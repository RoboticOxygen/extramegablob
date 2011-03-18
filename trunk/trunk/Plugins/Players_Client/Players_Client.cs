﻿using System;
using System.Collections.Generic;
using System.Text;
using MogreFramework;
using ExtraMegaBlob.References;
using Mogre;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Threading;
using MOIS;
using Mogre.PhysX;
namespace ExtraMegaBlob
{
    public class plugin : ExtraMegaBlob.References.ClientPlugin
    {
        private Hashtable materials
        {
            get
            {
                Hashtable h = new Hashtable();
                #region materials
                h["metal"] = "\\Players\\BumpyMetal.jpg";
                h["dirt"] = "\\terr_dirt-grass.jpg";
                #endregion
                return h;
            }
        }
        private Hashtable meshes
        {
            get
            {
                Hashtable h = new Hashtable();
                #region meshes
                h["drone"] = "\\Drone.mesh";
                #endregion
                return h;
            }
        }
        private Hashtable skeletons
        {
            get
            {
                Hashtable h = new Hashtable();
                #region skeletons
                h["droneskele"] = "\\Drone.skeleton";
                #endregion
                return h;
            }
        }
        private SceneNodes nodes = new SceneNodes();
        private ActorNodes actors = new ActorNodes();
        private Entities entities = new Entities();
        private Lights lights = new Lights();
        //private CapsuleControllerDesc ccd = new CapsuleControllerDesc();
        private BoxControllerDesc bcd = new BoxControllerDesc();
        private BoxController control = null;
        private void resourceWaitThread()
        {
            while (true)
            {
                Thread.Sleep(1000);

                foreach (DictionaryEntry de in materials)
                {
                    if (!TextureManager.Singleton.ResourceExists((string)de.Value)) goto waitmore;
                }
                foreach (DictionaryEntry de in skeletons)
                {
                    if (!SkeletonManager.Singleton.ResourceExists((string)de.Value)) goto waitmore;
                }
                foreach (DictionaryEntry de in meshes)
                {
                    if (!MeshManager.Singleton.ResourceExists((string)de.Value)) goto waitmore;
                }
                if (!OgreWindow.Instance.mSceneMgr.HasSceneNode("mushroom")) goto waitmore;
                if (!OgreWindow.Instance.SceneReady) goto waitmore;


                break;
            waitmore:
                continue;
            }
            init();
        }
        private void init()
        {
            log("starting up! ");
            OgreWindow.Instance.pause();
            try
            {
                Hashtable mats = materials;
                foreach (DictionaryEntry mat in mats)
                {
                    ((MaterialPtr)MaterialManager.Singleton.Create((string)mat.Key, ResourceGroupManager.DEFAULT_RESOURCE_GROUP_NAME)).GetTechnique(0).GetPass(0).CreateTextureUnitState((string)mat.Value);
                }

                MeshManager.Singleton.CreatePlane("ground",
                    ResourceGroupManager.DEFAULT_RESOURCE_GROUP_NAME,
                    new Plane(Mogre.Vector3.UNIT_Y, 0),
                    1500, 1500, 20, 20, true, 1, 5, 5, Mogre.Vector3.UNIT_Z);
                // Create a ground plane
                entities.Add(OgreWindow.Instance.mSceneMgr.CreateEntity("GroundEntity", "ground"));
                entities["GroundEntity"].CastShadows = false;
                entities["GroundEntity"].SetMaterialName("dirt");
                nodes.Add(OgreWindow.Instance.mSceneMgr.RootSceneNode.CreateChildSceneNode("ground"));
                nodes["ground"].AttachObject(entities["GroundEntity"]);
                nodes["ground"].Position = new Mogre.Vector3(0f, 0f, 0f) + Location().toMogre;
                #region ground physics
                // the actor properties control the mass, position and orientation
                // if you leave the body set to null it will become a static actor and wont move
                ActorDesc actorDesc2 = new ActorDesc();
                actorDesc2.Density = 4;
                actorDesc2.Body = null;
                actorDesc2.GlobalPosition = nodes["ground"].Position;
                actorDesc2.GlobalOrientation = nodes["ground"].Orientation.ToRotationMatrix();


                PhysXHelpers.StaticMeshData meshdata = new PhysXHelpers.StaticMeshData(entities["GroundEntity"].GetMesh());
                actorDesc2.Shapes.Add(PhysXHelpers.CreateTriangleMesh(meshdata));
                Actor actor2 = null;
                try { actor2 = OgreWindow.Instance.scene.CreateActor(actorDesc2); }
                catch (System.AccessViolationException ex) { log(ex.ToString()); }
                if (actor2 != null)
                {
                    // create our special actor node to tie together the scene node and actor that we can update its position later
                    ActorNode actorNode2 = new ActorNode(nodes["ground"], actor2);
                    actors.Add(actorNode2);
                }
                #endregion


                OgreWindow.Instance.skeletons["\\Drone.skeleton"].Load();
                OgreWindow.Instance.meshes["\\Drone.mesh"].Load();
                OgreWindow.Instance.meshes["\\Drone.mesh"].SkeletonName = "\\Drone.skeleton";

                entities.Add(OgreWindow.Instance.mSceneMgr.CreateEntity("drone", "\\Drone.mesh"));

                entities["drone"].CastShadows = true;
                walkState = entities["drone"].GetAnimationState("walk");
                walkState.Enabled = true;
                walkState.Loop = true;
                entities["drone"].SetMaterialName("metal");
                nodes.Add(OgreWindow.Instance.mSceneMgr.RootSceneNode.CreateChildSceneNode("drone"));
                nodes["drone"].AttachObject(entities["drone"]);
                nodes["drone"].Position = new Mogre.Vector3(0f, 40f, 0f) + Location().toMogre;
                nodes["drone"].Scale(new Mogre.Vector3(.3f));

                nodes.Add(nodes["drone"].CreateChildSceneNode("orbit0"));
                nodes.Add(nodes["orbit0"].CreateChildSceneNode("orbit"));
                nodes["orbit"].Position = new Mogre.Vector3(0f, 0f, 0f);
                nodes["orbit"].AttachObject(OgreWindow.Instance.mCamera);
                nodes["drone"].SetFixedYawAxis(true);

                #region player physics
                bcd = new BoxControllerDesc();
                control = OgreWindow.Instance.physics.ControllerManager.CreateController(OgreWindow.Instance.scene, bcd); //System.NullReferenceException
                #endregion

                nodes.Add(OgreWindow.Instance.mSceneMgr.RootSceneNode.CreateChildSceneNode("suspensionY"));

                OgreWindow.g_m.MouseMoved += new MouseListener.MouseMovedHandler(mouseMoved);
                middlemousetimer.reset();
                middlemousetimer.start();

                this.btnLimiter_F.reset();
                this.btnLimiter_F.start();
                ready = true;
                new Thread(new ThreadStart(controlThread)).Start();
                new Thread(new ThreadStart(positionUpdaterThread)).Start();

                localY = nodes["drone"]._getDerivedOrientation() * Mogre.Vector3.UNIT_Y;
                localZ = nodes["drone"]._getDerivedOrientation() * Mogre.Vector3.UNIT_Z;
                localX = nodes["drone"]._getDerivedOrientation() * Mogre.Vector3.UNIT_X;
            }
            catch (Exception ex)
            {
                log(ex.ToString());
            }
            OgreWindow.Instance.unpause();
            log("done starting up! ");
        }
        private void positionUpdaterThread()
        {
            while (ready)
            {
                if (MoveScale_Camera_forwardback != 0 || MoveScale_Camera_leftright != 0 || MoveScale_Camera_updown != 0)
                {
                    TranslateVector_Camera.z -= MoveScale_Camera_forwardback;
                    TranslateVector_Camera.x -= MoveScale_Camera_leftright;
                    TranslateVector_Camera.y += MoveScale_Camera_updown;
                    Mogre.Vector3 loc1 = control.Actor.GlobalPosition;
                    Mogre.Vector3 loc = control.Actor.GlobalOrientationQuaternion * TranslateVector_Camera;
                    //control.Actor.MoveGlobalPosition(loc + loc1);
                    setPos(loc + loc1);

                    if (LocationBeaconInterval.elapsed)
                    {
                        sendLocationBeacon();
                        LocationBeaconInterval.start();
                    }


                    TranslateVector_Camera = new Mogre.Vector3();
                }
                Thread.Sleep(1);
            }
        }
        private Mogre.Vector3 localY = new Mogre.Vector3();
        private Mogre.Vector3 localZ = new Mogre.Vector3();
        private Mogre.Vector3 localX = new Mogre.Vector3();
        private void preventMousePick(string name)
        {
            Memories mems = new Memories();
            mems.Add(new Memory("Name", KeyWord.NIL, name, null));
            Event ev = new Event();
            ev._Keyword = KeyWord.PREVENTMOUSEPICK;
            ev._Memories = mems;
            ev._IntendedRecipients = EventTransfer.CLIENTTOCLIENT;
            base.outboxMessage(this, ev);
        }
        private AnimationState walkState = null;
        public override void startup()
        {
            new Thread(new ThreadStart(resourceWaitThread)).Start();
        }
        public override void shutdown()
        {
            ready = false;
            log("shutting down!");
            actors.shutdown();
            nodes.shutdown();
            entities.shutdown();
            lights.shutdown();
            log("done shutting down!");
        }
        public override ExtraMegaBlob.References.Vector3 Location()
        {
            //return new ExtraMegaBlob.References.Vector3(0f, -168.6846f, -1101.067f);
            return new ExtraMegaBlob.References.Vector3(0f, 0f, 0f);
        }
        public override float Radius()
        {
            return 90;
        }
        public override string Name()
        {
            return "Players_Client";
        }
        public override string[] AllowedInputNames()
        {
            return new string[] { "Movement_Client", "Players_Server" };
        }
        public override string[] AllowedOutputNames()
        {
            return new string[] { "Players_Server" };
        }
        public override void inbox(ExtraMegaBlob.References.Event ev)
        {
            if (!ready) return;
            switch (ev._Keyword)
            {
                case KeyWord.PLAYER_RESET:
                    chat("resetting player");

                    Quaternion q = new Quaternion(
                        float.Parse(ev._Memories[KeyWord.DATA_QUATERNION_W].Value),
                        float.Parse(ev._Memories[KeyWord.DATA_QUATERNION_X].Value),
                        float.Parse(ev._Memories[KeyWord.DATA_QUATERNION_Y].Value),
                        float.Parse(ev._Memories[KeyWord.DATA_QUATERNION_Z].Value));

                    Mogre.Vector3 v = new Mogre.Vector3(
                        float.Parse(ev._Memories[KeyWord.DATA_VECTOR3_X].Value),
                        float.Parse(ev._Memories[KeyWord.DATA_VECTOR3_Y].Value),
                        float.Parse(ev._Memories[KeyWord.DATA_VECTOR3_Z].Value));

                    resetPlayer(v, q);

                    break;
                case KeyWord.TONGITS_FREEZEPLR:
                    tongfreeze = true;
                    break;
                case KeyWord.TONGITS_UNFREEZEPLR:
                    tongfreeze = false;
                    break;
                default:
                    break;
            }
        }
        private bool tongfreeze = false;
        private Mogre.Vector3 getOrbitalPosition(Mogre.Vector3 focalPoint, Quaternion direction, float distanceToFocalPoint)
        {
            Mogre.Vector3 eyePos, xAxis, yAxis, zAxis;
            Quaternion m_Orientation = direction;

            Mogre.Matrix3 m_ViewMatrix;

            // Get the rotation matrix from the quaternion
            m_ViewMatrix = m_Orientation.ToRotationMatrix();

            // Get the axis we need them for the camera position calculation (the axes span a new coord frame)
            xAxis = new Mogre.Vector3(m_ViewMatrix[0, 0], m_ViewMatrix[0, 1], m_ViewMatrix[0, 2]);
            yAxis = new Mogre.Vector3(m_ViewMatrix[1, 0], m_ViewMatrix[1, 1], m_ViewMatrix[1, 2]);
            zAxis = new Mogre.Vector3(m_ViewMatrix[2, 0], m_ViewMatrix[2, 1], m_ViewMatrix[2, 2]);


            eyePos = focalPoint + zAxis * distanceToFocalPoint;

            // Transform our vector in the orbital space. Here we rotate and flip it.
            m_ViewMatrix[0, 3] = -xAxis.DotProduct(eyePos);
            m_ViewMatrix[1, 3] = -yAxis.DotProduct(eyePos);
            m_ViewMatrix[2, 3] = -zAxis.DotProduct(eyePos);

            Mogre.Vector3 m_CamPos = new Mogre.Vector3();

            // So extract the cam position for the sake of completeness
            m_CamPos.x = m_ViewMatrix[0, 3];
            m_CamPos.y = m_ViewMatrix[1, 3];
            m_CamPos.z = m_ViewMatrix[2, 3];

            return m_CamPos;
        }
        private Quaternion addQuats(Quaternion q1, Quaternion q2)
        {
            float x = q1.x + q2.x;
            float y = q1.y + q2.y;
            float z = q1.z + q2.z;
            float w = q1.w + q2.w;
            Quaternion q = new Quaternion(w, x, y, z);
            chat(q.Normalise().ToString());
            return q;
        }
        //private Quaternion addQuats2(Quaternion q1, Quaternion q2)
        //{
        //    q1.FromAxes(q2.to
        //    float x = q1.x + q2.x;
        //    float y = q1.y + q2.y;
        //    float z = q1.z + q2.z;
        //    float w = q1.w + q2.w;
        //    return new Quaternion(w, x, y, z).ya;
        //}
        // private float 
        private float normalizeAngleRadian(float angle)
        {
            if (angle < 0 || angle > (float)System.Math.PI * 2) return System.Math.Abs(((float)System.Math.PI * 2) - System.Math.Abs(angle));
            else return angle;
        }
        private Quaternion orient2 = new Quaternion();

        private bool mouseMoved(MouseEvent arg)
        {
            float RotateScale_CameraPitch = .001f;//mouse sensitivity
            float RotateScale_PlayerTurn = .005f;//mouse sensitivity
            MouseState_NativePtr s = arg.state;
            if (arg.state.buttons == 2)
            {
                //chat("____________________________________________________________");
                nodes["orbit0"].Pitch(s.Y.rel * RotateScale_CameraPitch);
                if (!tongfreeze)
                    if (s.X.rel != 0f)
                    {
                        nodes["drone"].Yaw(-s.X.rel * RotateScale_PlayerTurn);
                        setOrient(nodes["drone"]._getDerivedOrientation());

                        
                        //Mogre.Quaternion orient1 = control.Actor.GlobalOrientationQuaternion;
                        //Mogre.Vector3 rkAxis = new Mogre.Vector3();
                        //Degree rfAngle = new Degree();
                        //orient1.ToRotationMatrix().ToAxisAngle(out rkAxis, out rfAngle);
                        //orient2 = new Quaternion(new Radian(new Degree(rfAngle.ValueDegrees + (-s.X.rel * RotateScale_PlayerTurn))), new Mogre.Vector3(0, 1, 0));
                        ////control.Actor.GlobalOrientationQuaternion = orient2;
                        ////setOrient(orient2);
                        //spin(rfAngle.ValueDegrees + (-s.X.rel * RotateScale_PlayerTurn));
                    }
                updateCam();
            }

            float mouseZ = (float)OgreWindow.g_m.MouseState.Z.rel * .1f;
            //chat(mouseZ.ToString());
            if (mouseZ > 0)
            {
                middleMouseState = middleMouseStates.scrollup;
                middlemousetimer.reset();
                middlemousetimer.start();
            }
            else if (mouseZ < 0)
            {
                middleMouseState = middleMouseStates.scrolldown;
                middlemousetimer.reset();
                middlemousetimer.start();
            }

            return true;
        }
        private void updateCam()
        {
            SceneNode camnode = nodes["orbit"];
            SceneNode node = nodes["drone"];
            Mogre.Vector3 focalPoint = new Mogre.Vector3(0f, 0f, 0f);
            Quaternion direction = node.Orientation;
            direction.Normalise();

            //Mogre.Vector3 m_CamPos = getOrbitalPosition(focalPoint, direction);
            //OgreWindow.Instance.cameraNode.LookAt(focalPoint, Node.TransformSpace.TS_PARENT);
            //OgreWindow.Instance.cameraNode.Position = m_CamPos + focalPoint;


            Mogre.Vector3 m_CamPos = getOrbitalPosition(focalPoint, direction, 50f);
            camnode.Position = m_CamPos;
            camnode.LookAt(node.Position, Node.TransformSpace.TS_WORLD);

        }
        private timer middlemousetimer = new timer(mmbClutch);
        private enum middleMouseStates
        {
            scrollup,
            scrolldown,
            idle
        }
        private middleMouseStates middleMouseState = middleMouseStates.idle;
        private float MoveScale_Camera_forwardback = 0f;
        private float MoveScale_Camera_leftright = 0f;
        private float MoveScale_Camera_updown = 0f;
        private Mogre.Vector3 TranslateVector_Camera = new Mogre.Vector3();
        private const float speedcap_forwardback = .55f;
        private const float speedcap_leftright = .55f;
        private const float speedcap_updown = 5.5f;
        private const float incr_forwardback = .05f;
        private const float incr_leftright = .05f;
        private const float incr_updown = .01f;
        private const float brakes_updown = incr_updown * 2;
        private const float brakes_forwardback = incr_forwardback * 2;
        private const float brakes_leftright = incr_leftright * 2;
        private static TimeSpan mmbClutch = new TimeSpan(0, 0, 0, 0, 100);

        private void setPos(Mogre.Vector3 pos)
        {
            if (!tongfreeze)
                control.Actor.MoveGlobalPosition(pos);
        }
        private void setOrient(Quaternion orient)
        {
            if (!tongfreeze)
                control.Actor.GlobalOrientationQuaternion = orient;
        }
        private void spin(Degree deg)
        {
            Mogre.Quaternion orient1 = control.Actor.GlobalOrientationQuaternion;

            Mogre.Vector3 rkAxis = new Mogre.Vector3();
            Degree rfAngle = new Degree();
            orient1.ToRotationMatrix().ToAxisAngle(out rkAxis, out rfAngle);
            Mogre.Quaternion orient2 = new Quaternion(new Radian(deg), new Mogre.Vector3(0, 1, 0));
            //control.Actor.GlobalOrientationQuaternion = orient2;
            //setOrient(orient2);
            setOrient(orient2);
        }
        private void resetCam()
        {
            updateCam();
            //nodes["orbit0"].Orientation = new Quaternion(-0.4837169f, -0.5147877f, 0.4847109f, -0.5158446f);
            //updateCam();
        }
        private timer LocationBeaconInterval = new timer(new TimeSpan(0, 0, 1));//1 second player world location updates
        private timer btnLimiter_F = new timer(new TimeSpan(0, 0, 1));//1 second player world location updates
        private void sendLocationBeacon()
        {
            Memories mems = new Memories();
            Mogre.Vector3 imAt = control.Actor.GlobalPosition;
            mems.Add(new Memory("", KeyWord.CARTESIAN_X, imAt.x.ToString(), null));
            mems.Add(new Memory("", KeyWord.CARTESIAN_Y, imAt.y.ToString(), null));
            mems.Add(new Memory("", KeyWord.CARTESIAN_Z, imAt.z.ToString(), null));
            Event ev = new Event();
            ev._Keyword = KeyWord.CARTESIAN_SECRETPLAYERLOCATION;
            ev._Memories = mems;
            ev._IntendedRecipients = EventTransfer.CLIENTTOSERVER;
            base.outboxMessage(this, ev);
            // log("Location: X=" + imAt.x.ToString() + " Y=" + imAt.y.ToString() + " Z=" + imAt.z.ToString());
        }

        private void resetPlayer(Mogre.Vector3 loc, Quaternion orient)
        {
            setPos(loc);
            setOrient(orient);
        }
        private void controlThread()
        {
            while (ready)
            {
                try
                {


                    if (middlemousetimer.elapsed)
                    {
                        middleMouseState = middleMouseStates.idle;
                    }
                    if (OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_F))
                    {
                        if (btnLimiter_F.elapsed)
                        {
                            if (!tongfreeze)
                            {
                                resetPlayer(new Mogre.Vector3(-1.291305f, 35.18927f, 2.11423f), new Quaternion(0.2246418f, 0f, 0.9744414f, 0f));
                                resetCam();
                                sendLocationBeacon();
                            }
                            btnLimiter_F.start();
                        }
                    }
                    if (OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_W))
                    {



                        if (MoveScale_Camera_forwardback > -speedcap_forwardback)
                            MoveScale_Camera_forwardback -= incr_forwardback;
                    }
                    else if (OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_S))
                    {
                        if (MoveScale_Camera_forwardback < speedcap_forwardback)
                            MoveScale_Camera_forwardback += incr_forwardback;
                    }
                    else if (MoveScale_Camera_forwardback != 0f)
                    {
                        if (MoveScale_Camera_forwardback > 0f)
                            MoveScale_Camera_forwardback -= incr_forwardback;
                        else
                            MoveScale_Camera_forwardback += incr_forwardback;
                        if (MoveScale_Camera_forwardback < brakes_forwardback && MoveScale_Camera_forwardback > -brakes_forwardback)
                            MoveScale_Camera_forwardback = 0f;
                    }
                    else
                    {
                        MoveScale_Camera_forwardback = 0f;
                    }
                    if (OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_A))
                    {
                        if (MoveScale_Camera_leftright > -speedcap_leftright)
                            MoveScale_Camera_leftright -= incr_leftright;
                    }
                    else if (OgreWindow.g_kb.IsKeyDown(MOIS.KeyCode.KC_D))
                    {
                        if (MoveScale_Camera_leftright < speedcap_leftright)
                            MoveScale_Camera_leftright += incr_leftright;
                    }
                    else if (MoveScale_Camera_leftright != 0f)
                    {
                        if (MoveScale_Camera_leftright > 0f)
                            MoveScale_Camera_leftright -= incr_leftright;
                        else
                            MoveScale_Camera_leftright += incr_leftright;
                        if (MoveScale_Camera_leftright < brakes_leftright && MoveScale_Camera_leftright > -brakes_leftright)
                            MoveScale_Camera_leftright = 0f;
                    }
                    else
                    {
                        MoveScale_Camera_leftright = 0f;
                    }

                    if (middleMouseState == middleMouseStates.scrolldown)
                    {
                        if (MoveScale_Camera_updown > -speedcap_updown)
                            MoveScale_Camera_updown -= incr_updown;
                    }
                    else if (middleMouseState == middleMouseStates.scrollup)
                    {
                        if (MoveScale_Camera_updown < speedcap_updown)
                            MoveScale_Camera_updown += incr_updown;
                    }
                    else if (MoveScale_Camera_updown != 0f)
                    {
                        if (MoveScale_Camera_updown > 0f)
                            MoveScale_Camera_updown -= incr_updown;
                        else
                            MoveScale_Camera_updown += incr_updown;
                        if (MoveScale_Camera_updown < brakes_updown && MoveScale_Camera_updown > -brakes_updown)
                            MoveScale_Camera_updown = 0f;

                    }
                    else
                    {
                        MoveScale_Camera_updown = 0f;
                    }
                    //TranslateVector_Camera.z -= MoveScale_Camera_forwardback;
                    //TranslateVector_Camera.x -= MoveScale_Camera_leftright;
                    //TranslateVector_Camera.y += MoveScale_Camera_updown;

                    if (MoveScale_Camera_updown != 0f)
                    {
                        control.Actor.AddForce(new Mogre.Vector3(0f, MoveScale_Camera_updown, 0f));
                        chat(MoveScale_Camera_updown.ToString());
                    }



                    //control.Actor.AddForce(loc);



                    //actors["drone"].actor.AddLocalTorque(new Mogre.Vector3(0f, 1000f, 0f));
                    //actors["drone"].actor.AddLocalForce(loc);

                    // actors["drone"].actor.LinearVelocity = loc; //kinda works
                    //actors["drone"].actor.GlobalOrientation..Orientation.ToRotationMatrix();
                    // if (nodes["drone"].Orientation.Roll.ValueDegrees > 0)
                    //     actors["drone"].actor.AddLocalTorque(new Mogre.Vector3(0f, 1000f, 0f));

                }
                catch (Exception ex) { log(ex.ToString()); }

                Thread.Sleep(100);

            }
        }


        public override void updateHook()
        {
            if (t.elapsed)
            {
                t.reset();
                t.start();
            }
            if (ready)
            {


                walkState.AddTime(.01f);
                actors.UpdateAllActors(.1f);
                // actors.UpdateActor(.1f, "drone", control.Actor);

                if (control.Actor == null) return;
                if (!control.Actor.IsSleeping)
                {
                    // nodes["drone"].Position = control.Actor.GlobalPosition;
                    nodes["drone"].Position = control.Actor.GlobalPosition;
                    nodes["drone"].Orientation = control.Actor.GlobalOrientationQuaternion;
                    OgreWindow.Instance.setInfoLabelText(string.Format(" {0}f, {1}f, {2}f ", control.Actor.GlobalPosition.x, control.Actor.GlobalPosition.y, control.Actor.GlobalPosition.z));
                    OgreWindow.Instance.setInfoLabelText2(string.Format(" {0}f, {1}f, {2}f, {3}f ", control.Actor.GlobalOrientationQuaternion.w, control.Actor.GlobalOrientationQuaternion.x, control.Actor.GlobalOrientationQuaternion.y, control.Actor.GlobalOrientationQuaternion.z));
                    OgreWindow.Instance.setInfoLabelText3(string.Format(" {0}f, {1}f, {2}f, {3}f ", nodes["orbit0"]._getDerivedOrientation().w, nodes["orbit0"]._getDerivedOrientation().x, nodes["orbit0"]._getDerivedOrientation().y, nodes["orbit0"]._getDerivedOrientation().z));
                }


            }
        }
        timer scaleLimiter = new timer(new TimeSpan(0, 0, 1));

        private bool ready = false;
        public override void frameHook(float interpolation)
        {

            //if (MoveScale_Camera_updown != 0)
            //{
            //    float s = MoveScale_Camera_updown * (interpolation + 1);
            //    TranslateVector_Camera.y += s;
            //    MoveScale_Camera_updown -= s;
            //}
            //try
            //{
            //    ////Mogre.Vector3 translateTo = OgreWindow.Instance.cameraYawNode.Orientation * OgreWindow.Instance.cameraPitchNode.Orientation * TranslateVector_Camera;
            //    //if (TranslateVector_Camera.x != 0f || TranslateVector_Camera.y != 0f || TranslateVector_Camera.z != 0f)
            //    //{
            //    //    updateCam();

            //    //    Mogre.Vector3 loc = nodes["drone"]._getDerivedOrientation() * TranslateVector_Camera;

            //    //    //nodes["drone"].Translate(nodes["drone"]._getDerivedOrientation() * TranslateVector_Camera); //limited to x/z - works
            //    //    //actors["drone"].actor.AddLocalForce(loc);
            //    //    //if (actors["drone"].actor.IsSleeping) actors["drone"].actor.WakeUp(.1f);
            //    //    //actors["drone"].actor.LinearVelocity = loc; //kinda works

            //    //    // actors["drone"].actor.MoveGlobalPosition(actors["drone"].actor.GlobalPosition + loc);

            //    //}

            //    TranslateVector_Camera = new Mogre.Vector3();
            //}
            //catch
            //{
            //}
        }
        private Random ran = new Random((int)DateTime.Now.Ticks);


        ExtraMegaBlob.References.timer t = new ExtraMegaBlob.References.timer(new TimeSpan(0, 0, 0, 0, 1000));
    }
}