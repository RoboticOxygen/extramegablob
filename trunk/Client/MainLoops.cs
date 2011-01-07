﻿using System;
using System.Collections;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ExtraMegaBlob.References;
using Mogre;
using MogreFramework;
using SkyX;
#region disable annoying warnings
#pragma warning disable 162 //CS0162: Unreachable code detected
#pragma warning disable 168 //CS0168: The variable 'XYZ' is declared but never used
#pragma warning disable 169 //CS0169: Field 'XYZ' is never used
#pragma warning disable 414 //CS0414: 'XYZ' is assigned but its value is never used
#pragma warning disable 649 //CS0649: Field 'XYZ' is never assigned to, and will always have its default value XX
#endregion
namespace ExtraMegaBlob.Client
{
    public partial class Simulation
    {
        public void main()
        {
            try
            {
                log(Program.header);

                conf = new Config();

                OgreWindow.Instance.textures = new Textures(ThingPath.path_cache);
                OgreWindow.Instance.skeletons = new Skeletons(ThingPath.path_cache);
                OgreWindow.Instance.meshes = new Meshes(ThingPath.path_cache);

                netClient = new ClientNetwork();
                netClient.onLogMessage += new ClientNetwork.LogDelegate(netClient_onLogMessage);
                netClient.onReceiveEvent += new ClientNetwork.onReceiveEventDelegate(netClient_onReceiveEvent);
                netClient.onConnectCompleted += new ClientNetwork.onConnectCompletedDelegate(netClient_onConnectCompleted);
                netClient.onDisconnected += new ClientNetwork.onDisconnectedDelegate(netClient_onDisconnected);


                ClientPluginManager = new ClientPluginManager();
                ClientPluginManager.onLogMessage += new LogDelegate(roomManager_onLogMessage);
                ClientPluginManager.onChat += new LogDelegate(ClientPluginManager_onChat);
                ClientPluginManager.route_toserver += new ClientPluginManager.route_toserver_delegate(clientPluginManager_route_toserver);
                ClientPluginManager.onListChanged += new ClientPluginManager.pluginListChangedHandler(ClientPluginManager_onListChanged);



                cache = new CacheManager();
                cache.onLogMessage += new LogDelegate(cache_onLogMessage);
                cache.route_toserver += new CacheManager.route_toserverDelegate(cache_route_toserver);
                cache.pluginAdded += new CacheManager.pluginAddedDelegate(cache_pluginAdded);
                cache.pluginDeleted += new CacheManager.pluginDeletedDelegate(cache_pluginDeleted);
                cache.textureAdded += new CacheManager.textureAddedDelegate(cache_textureAdded);
                cache.textureDeleted += new CacheManager.textureDeletedDelegate(cache_textureDeleted);
                cache.meshAdded += new CacheManager.meshAddedDelegate(cache_meshAdded);
                cache.meshDeleted += new CacheManager.meshDeletedDelegate(cache_meshDeleted);
                cache.skeletonAdded += new CacheManager.skeletonAddedDelegate(cache_skeletonAdded);
                cache.skeletonDeleted += new CacheManager.skeletonDeletedDelegate(cache_skeletonDeleted);

                //LogManager lm = new LogManager();


                OgreWindow.Instance.SceneCreating += new OgreWindow.SceneEventHandler(SceneCreating);
                OgreWindow.Instance.InitializeOgre();
                LogManager.Singleton.DefaultLog.MessageLogged += new LogListener.MessageLoggedHandler(DefaultLog_MessageLogged);
                OgreWindow.Instance.mRoot.FrameStarted += new FrameListener.FrameStartedHandler(Root_FrameStarted);
                OgreWindow.Instance.Text = Program.header;
                OgreWindow.Instance.onSend += new OgreWindow.sendDelegate(Instance_onSend);
                OgreWindow.Instance.FormClosing += new FormClosingEventHandler(mainwindow_FormClosing);
                if (OgreWindow.Instance.mRoot == null)
                {
                    MessageBox.Show("OgreWindow: not initialized yet");
                }
                OgreWindow.Instance.Show();
                timer t = new timer(new TimeSpan(0, 0, 2));
                t.start();
                try
                {
                    int loops;
                    bool b;
                    new Thread(new ThreadStart(netConnect)).Start();
                    new Thread(new ThreadStart(checkPluginAddQueueLoop)).Start();
                    new Thread(new ThreadStart(checkNetUpdateFileQueueLoop)).Start();
                    cache.init();
                    #region Primary Loop
                    while (!OgreWindow.Instance.ShuttingDown)
                    {
                        if (object.Equals(null, OgreWindow.Instance.mRoot)) break;
                        b = true;
                        loops = 0;
                        while (DateTime.Now.Ticks > next_game_tick && loops < MAX_FRAMESKIP)
                        {
                            update();
                            next_game_tick += SKIP_TICKS;
                            loops++;
                        }
                        interpolation = (float)(DateTime.Now.Ticks + SKIP_TICKS - next_game_tick) / (float)(SKIP_TICKS);
                        ExtraMegaBlob.References.Math.clamp_hi(1f, ref interpolation);
                        if (!OgreWindow.Instance.pauserendering)
                        {
                            OgreWindow.Instance.renderingframe = true;
                            b = OgreWindow.Instance.mRoot.RenderOneFrame();
                            OgreWindow.Instance.renderingframe = false;
                        }
                        if (!b) break;
                        OgreWindow.Instance.doEvents();
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Main: " + ex.StackTrace.ToString() + Environment.NewLine + ex.Message);
                if (OgreException.IsThrown)
                    MessageBox.Show(OgreException.LastException.FullDescription,
                                    "An Ogre exception has occurred!");
            }
            quit();
        }
        protected SkyManager manager;
        private string TerrainMaterialName = "Terrain";
        Entities entities = new Entities();
        SceneNodes nodes = new SceneNodes();
        private void SceneCreating()
        {
            SceneManager sm = OgreWindow.Instance.mSceneMgr;
            Root root = OgreWindow.Instance.mRoot;
            Camera camera = OgreWindow.Instance.mCamera;

            OgreWindow.Instance.mSceneMgr.SetShadowUseInfiniteFarPlane(true);
            sm.AmbientLight = ColourValue.Black;
            

            
            //sm.ShadowTechnique = ShadowTechnique.SHADOWTYPE_STENCIL_ADDITIVE;
            //sm.ShadowTechnique = ShadowTechnique.SHADOWTYPE_STENCIL_MODULATIVE;

            sm.ShadowTechnique = ShadowTechnique.SHADOWTYPE_NONE;
            //sm.ShadowTechnique = ShadowTechnique.SHADOWTYPE_TEXTURE_ADDITIVE;
            //sm.ShadowTechnique = ShadowTechnique.SHADOWTYPE_TEXTURE_ADDITIVE_INTEGRATED;
            //sm.ShadowTechnique = ShadowTechnique.SHADOWTYPE_TEXTURE_MODULATIVE;
            //sm.ShadowTechnique = ShadowTechnique.SHADOWTYPE_TEXTURE_MODULATIVE_INTEGRATED;
            


            sm.ShadowTechnique = ShadowTechnique.SHADOWTYPE_NONE; //skyx breaks when shadows are enabled!

            camera.FarClipDistance = 30000;
            camera.NearClipDistance = .25f;

            //camera.SetPosition(20000, 500, 20000);
            //camera.SetDirection(1, 0, 0);



            manager = new SkyManager(sm, OgreWindow.Instance.mCamera);
            manager.Create();


            //manager.GPUManager.AddGroundPass(material.GetTechnique(0).CreatePass(), 5000, SceneBlendType.SBT_TRANSPARENT_COLOUR);

            // Add a basic cloud layer
            manager.CloudsManager.Add(new CloudLayer.LayerOptions());

            //Add frame evnet
            //root.FrameStarted += new FrameListener.FrameStartedHandler(FrameStarted);
            
            
            
            
            
            
            OgreWindow.Instance.SceneReady = true;
        }
        private void cache_skeletonDeleted(string pathRelSkeletonFile)
        {
            OgreWindow.Instance.pause();
            try { OgreWindow.Instance.skeletons.RemoveAt(pathRelSkeletonFile); }
            catch (Exception ex) { log(ex.ToString()); }
            OgreWindow.Instance.unpause();
        }
        private void cache_skeletonAdded(string pathRelSkeletonFile)
        {
            OgreWindow.Instance.pause();
            try { OgreWindow.Instance.skeletons.Add(pathRelSkeletonFile); }
            catch (Exception ex) { log(ex.ToString()); }
            OgreWindow.Instance.unpause();
        }
        private void DefaultLog_MessageLogged(string message, LogMessageLevel lml, bool maskDebug, string logName)
        {

            log(lml.ToString() + ": " + message);
        }
        private bool Root_FrameStarted(FrameEvent evt)
        {
            //SceneManager sm = OgreWindow.Instance.mSceneMgr;
            //Root root = OgreWindow.Instance.mRoot;
            //Camera cam = OgreWindow.Instance.mCamera;

            //// Check camera height
            //RaySceneQuery raySceneQuery = sm.CreateRayQuery(new Ray(cam.Position + new Mogre.Vector3(0, 1000000, 0), Mogre.Vector3.NEGATIVE_UNIT_Y));
            //RaySceneQueryResult qryResult = raySceneQuery.Execute();

            //RaySceneQueryResult.Iterator it = qryResult.Begin();
            //if (it != qryResult.End() && it.Value.worldFragment != null)
            //{
            //    if (cam.DerivedPosition.y < it.Value.worldFragment.singleIntersection.y + 30)
            //    {
            //        cam.SetPosition(cam.Position.x,
            //                            it.Value.worldFragment.singleIntersection.y + 30,
            //                            cam.Position.z);
            //    }

            //    it.MoveNext();
            //}
            
            manager.TimeMultiplier = 0.1f;
            manager.Update(evt.timeSinceLastFrame);

            try
            {
                ClientPluginManager.FrameStartedHooks(interpolation);
            }
            catch
            {
                log("[ main() ] FrameStarted exception while doing plugins' hooks");
            }
            return true;
        }
        protected void HandleInput()
        {
            //base.HandleInput(evt);

            // Show/Hide information

            OgreWindow win = OgreWindow.Instance;

            if (OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_F1))
            {
                showInformation = !showInformation;

            }

            if (OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_1) && !(OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_LSHIFT) || OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_RSHIFT)))
            {
                manager.TimeMultiplier = 1.0f;
            }
            if (OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_1) && (OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_LSHIFT) || OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_RSHIFT)))
            {
                manager.TimeMultiplier = -1.0f;
            }


        }
        private String GetConfigString()
        {
            AtmosphereManager atmo = manager.AtmosphereManager;
            int hour = (int)atmo.Time.x;

            int min = (int)((atmo.Time.x - hour) * 60);


            String timeStr = Mogre.StringConverter.ToString(hour) + ":" + Mogre.StringConverter.ToString(min);
            String str = "SkyX Plugin demo (Press F1 to show/hide information)";
            if (showInformation)
            {
                str += " - Simuation paused - \n";
            }
            else
            {
                str += "\n-------------------------------------------------------------\nTime: " + timeStr + "\\n";
            }

            if (showInformation)
            {
                str += "-------------------------------------------------------------\n";
                str += "Time: " + timeStr + " [1, Shift+1] (+/-).\n";
                str += "Rayleigh multiplier: " + Mogre.StringConverter.ToString(atmo.RayleighMultiplier) + " [2, Shift+2] (+/-).\n";
                str += "Mie multiplier: " + Mogre.StringConverter.ToString(atmo.MieMultiplier) + " [3, Shift+3] (+/-).\n";
                str += "Exposure: " + Mogre.StringConverter.ToString(atmo.Exposure) + " [4, Shift+4] (+/-).\n";
                str += "Inner radius: " + Mogre.StringConverter.ToString(atmo.InnerRadius) + " [5, Shift+5] (+/-).\n";
                str += "Outer radius: " + Mogre.StringConverter.ToString(atmo.OuterRadius) + " [6, Shift+6] (+/-).\n";
                str += "Number of samples: " + Mogre.StringConverter.ToString(atmo.NumberOfSamples) + " [7, Shift+7] (+/-).\n";
                str += "Height position: " + Mogre.StringConverter.ToString(atmo.HeightPosition) + " [8, Shift+8] (+/-).\n";
            }

            return str;
        }
        protected bool showInformation;
        private void update()
        {
            HandleInput();
            checkOgreException();
            try
            {
                ClientPluginManager.updateHooks();
                if (OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_ESCAPE))
                {
                    quit();
                }
            }
            catch { }
        }
        private void quit()
        {
            if (OgreWindow.Instance.ShuttingDown) return;
            OgreWindow.Instance.ShuttingDown = true;
            ClientPluginManager.shutdown();
            netClient.disconnect();
            saveScreenshot();
            OgreWindow.Instance.Close();
            OgreWindow.Instance.meshes.shutdown();
            OgreWindow.Instance.textures.shutdown();
            OgreWindow.Instance.skeletons.shutdown();
            OgreWindow.Instance.mRoot.Dispose();
            OgreWindow.Instance.mRoot = null;
            OgreWindow.Instance.mWindow = null;
            OgreWindow.Instance.mCamera = null;
            OgreWindow.Instance.mViewport = null;
            OgreWindow.Instance.mSceneMgr = null;
        }
        private CacheManager cache;
        private ClientPluginManager ClientPluginManager;
        private ClientNetwork netClient;
        private const bool DISABLE_NETWORK = false;
        private Config conf = null;
        private Entity ground_ent = null;
        private SceneNode ground_node = null;
        private void mainwindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            quit();
        }
        private timer saveScreenshotLimiter = new timer(new TimeSpan(0, 0, 0, 1));
        private void checkPluginAddQueueLoop()
        {
            Thread.CurrentThread.Name = "plugin add queue loop";
            while (!OgreWindow.Instance.ShuttingDown)
            {
                Thread.Sleep(100);
                for (int i = 0; i < pluginAddQueue.Count; i++)
                {
                    string pathRel = (string)pluginAddQueue[i];
                    ClientPluginManager.addPlugin(pathRel);
                    pluginAddQueue.RemoveAt(i);
                    break;
                }
            }
        }
        private void checkNetUpdateFileQueueLoop()
        {
            Thread.CurrentThread.Name = "file update queue loop";
            while (!OgreWindow.Instance.ShuttingDown)
            {
                Thread.Sleep(100);
                for (int i = 0; i < netUpdateFileQueue.Count; i++)
                {
                    Event msg = (Event)netUpdateFileQueue[i];
                    try
                    {
                        cache.updateFile(msg);
                    }
                    catch (Exception ex)
                    {
                        log(ex.ToString());
                    }
                    netUpdateFileQueue.RemoveAt(i);
                    break;
                }
            }
        }
        private void saveScreenshot()
        {
            if (saveScreenshotLimiter.elapsed)
            {
                saveScreenshotLimiter.start();
                try
                {
                    OgreWindow.Instance.saveFrame(SaveFrameFile);
                }
                catch { }
            }
        }
        private string SaveFrameFile
        {
            get
            {
                for (int i = 0; i > -1; i++)
                {
                    string part1 = Path.GetDirectoryName(Application.ExecutablePath) + "\\Screenshots\\frame";
                    string part2 = i.ToString("D3");
                    string part3 = ".jpg";
                    string cmp = part1 + part2 + part3;
                    if (!File.Exists(cmp))
                    {
                        return cmp;
                    }
                }
                return null;
            }
        }

        private void checkOgreException()
        {
            if (Mogre.OgreException.IsThrown)
            {
                string a = "";
                OgreException x = Mogre.OgreException.LastException;
                a += "Source: " + x.Source + "; Number: " + x.Number.ToString() + "; Description: " + x.Description;
                log("[ main() ] " + a);
                Mogre.OgreException.ClearLastException();
            }
        }
        private void ClientPluginManager_onListChanged(string[] plugins)
        {
            OgreWindow.Instance.setPluginsActive(plugins);
        }
        private void cache_meshDeleted(string pathRelMeshFile)
        {
            OgreWindow.Instance.pause();
            try { OgreWindow.Instance.meshes.RemoveAt(pathRelMeshFile); }
            catch (Exception ex) { log(ex.ToString()); }
            OgreWindow.Instance.unpause();
        }
        private void cache_meshAdded(string pathRelMeshFile)
        {
            OgreWindow.Instance.pause();
            try { OgreWindow.Instance.meshes.Add(pathRelMeshFile); }
            catch (Exception ex) { log(ex.ToString()); }
            OgreWindow.Instance.unpause();
        }
        private void cache_textureDeleted(string pathRelTextureFile)
        {
            OgreWindow.Instance.pause();
            try { OgreWindow.Instance.textures.RemoveAt(pathRelTextureFile); }
            catch (Exception ex) { log(ex.ToString()); }
            OgreWindow.Instance.unpause();
        }
        private void cache_textureAdded(string pathRelTextureFile)
        {
            OgreWindow.Instance.pause();
            try { OgreWindow.Instance.textures.Add(pathRelTextureFile); }
            catch (Exception ex) { log(ex.ToString()); }
            OgreWindow.Instance.unpause();
        }
        private void netClient_onDisconnected()
        {
            // ClientPluginManager.delAllPlugins();
        }
        private void cache_pluginDeleted(string pathRelPluginFile)
        {
            ClientPluginManager.delPlugin(pathRelPluginFile);
        }
        private void cache_pluginAdded(string pathRelPluginFile)
        {
            //ClientPluginManager.addPlugin(pathRelPluginFile);
            pluginAddQueue.Add(pathRelPluginFile);
        }
        private ArrayList pluginAddQueue = new ArrayList();
        private ArrayList netUpdateFileQueue = new ArrayList();
        private void netClient_onConnectCompleted(string host, string port)
        {
            log("Connected to: " + host + ":" + port);

            cache.sendReport();
        }
        private void cache_route_toserver(Event ev)
        {
            ClientPluginManager.sourceHub(ev, EventTransfer.CLIENTTOSERVER);
        }
        private void log(string what)
        {
            OgreWindow.Instance.log(what);
        }
        private void cache_onLogMessage(string msg)
        {
            log("cache: " + msg);
        }
        private void netConnect()
        {
            Thread.CurrentThread.Name = "net connect loop";
            if (DISABLE_NETWORK)
            {
                log("Network is DISABLED");
                return;
            }
            while (!OgreWindow.Instance.ShuttingDown)
            {

                if (!netClient.connected && OgreWindow.Instance.SceneReady)
                {
                    try
                    {
                        netClient.connect(conf.serverip_clientcontext, conf.serverport);
                    }
                    catch (Exception ex)
                    {
                        log(ex.Message);
                    }
                }
                Thread.Sleep(1000);
            }
        }
        private void Instance_onSend(string text)
        {
            Event e = new Event();
            e._IntendedRecipients = eventScope.SERVERALL;
            e._Keyword = KeyWord.EVENT_CHATMESSAGE;
            e._Source_FullyQualifiedName = "ClientMain";
            e._Memories = new Memories();
            e._Memories.Add(new Memory("text", KeyWord.NIL, text, null));
            ClientPluginManager.sourceHub(e, EventTransfer.CLIENTTOSERVER);
        }
        private void ClientPluginManager_onChat(string msg)
        {
            OgreWindow.Instance.addChatMessage(msg);
        }
        private void netClient_onReceiveEvent(Event msg)
        {
            ClientPluginManager.sourceHub(msg, EventTransfer.SERVERTOCLIENT);
            if (msg._Keyword == KeyWord.CACHE_CLIENTRENAMEFILE)
            {
                cache.renameFile(msg);
            }
            if (msg._Keyword == KeyWord.CACHE_CLIENTDELETEFILE)
            {
                cache.deleteFile(msg);
            }
            if (msg._Keyword == KeyWord.CACHE_CLIENTUPDATEFILE)
            {
                //cache.updateFile(msg);
                netUpdateFileQueue.Add(msg);
            }
        }
        private void clientPluginManager_route_toserver(Event msg)
        {
            if (!netClient.connected)
            {
                return;
            }
            netClient.sendEvent(msg);
        }
        private void netClient_onLogMessage(string msg)
        {
            OgreWindow.Instance.log("[netClient]: " + msg);
        }
        private void roomManager_onLogMessage(string msg)
        {
            OgreWindow.Instance.log(msg);
        }
        private int TICKS_PER_SECOND { get { return 100; } }
        private int SKIP_TICKS { get { return (10000000 / TICKS_PER_SECOND); } }
        private int MAX_FRAMESKIP { get { return 5; } }
        private long next_game_tick = DateTime.Now.Ticks;
        private float interpolation = 0f;

    }
}