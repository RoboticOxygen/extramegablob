/*  This file is produced by the C++/CLI AutoWrapper utility.
        Copyright (c) 2006 by Argiris Kirtzidis  */

#include "MogreStableHeaders.h"

#include "MogreResourceGroupManager.h"
#include "MogreResource.h"
#include "MogreCommon.h"
#include "MogreResourceManager.h"
#include "MogreDataStream.h"
#include "MogreStringVector.h"
#include "MogreArchive.h"
#include "MogreSceneManager.h"

namespace Mogre
{
	//################################################################
	//ResourceGroupListener
	//################################################################
	
	//Nested Types
	//Private Declarations
	
	//Internal Declarations
	
	//Public Declarations
	void ResourceGroupListener_Director::resourceGroupScriptingStarted( const Ogre::String& groupName, size_t scriptCount )
	{
		if (doCallForResourceGroupScriptingStarted)
		{
			_receiver->ResourceGroupScriptingStarted( TO_CLR_STRING( groupName ), scriptCount );
		}
	}
	
	void ResourceGroupListener_Director::scriptParseStarted( const Ogre::String& scriptName, bool& skipThisScript )
	{
		if (doCallForScriptParseStarted)
		{
			_receiver->ScriptParseStarted( TO_CLR_STRING( scriptName ), skipThisScript );
		}
	}
	
	void ResourceGroupListener_Director::scriptParseEnded( const Ogre::String& scriptName, bool skipped )
	{
		if (doCallForScriptParseEnded)
		{
			_receiver->ScriptParseEnded( TO_CLR_STRING( scriptName ), skipped );
		}
	}
	
	void ResourceGroupListener_Director::resourceGroupScriptingEnded( const Ogre::String& groupName )
	{
		if (doCallForResourceGroupScriptingEnded)
		{
			_receiver->ResourceGroupScriptingEnded( TO_CLR_STRING( groupName ) );
		}
	}
	
	void ResourceGroupListener_Director::resourceGroupPrepareStarted( const Ogre::String& groupName, size_t resourceCount )
	{
		if (doCallForResourceGroupPrepareStarted)
		{
			_receiver->ResourceGroupPrepareStarted( TO_CLR_STRING( groupName ), resourceCount );
		}
	}
	
	void ResourceGroupListener_Director::resourcePrepareStarted( const Ogre::ResourcePtr& resource )
	{
		if (doCallForResourcePrepareStarted)
		{
			_receiver->ResourcePrepareStarted( resource );
		}
	}
	
	void ResourceGroupListener_Director::resourcePrepareEnded( )
	{
		if (doCallForResourcePrepareEnded)
		{
			_receiver->ResourcePrepareEnded( );
		}
	}
	
	void ResourceGroupListener_Director::worldGeometryPrepareStageStarted( const Ogre::String& description )
	{
		if (doCallForWorldGeometryPrepareStageStarted)
		{
			_receiver->WorldGeometryPrepareStageStarted( TO_CLR_STRING( description ) );
		}
	}
	
	void ResourceGroupListener_Director::worldGeometryPrepareStageEnded( )
	{
		if (doCallForWorldGeometryPrepareStageEnded)
		{
			_receiver->WorldGeometryPrepareStageEnded( );
		}
	}
	
	void ResourceGroupListener_Director::resourceGroupPrepareEnded( const Ogre::String& groupName )
	{
		if (doCallForResourceGroupPrepareEnded)
		{
			_receiver->ResourceGroupPrepareEnded( TO_CLR_STRING( groupName ) );
		}
	}
	
	void ResourceGroupListener_Director::resourceGroupLoadStarted( const Ogre::String& groupName, size_t resourceCount )
	{
		if (doCallForResourceGroupLoadStarted)
		{
			_receiver->ResourceGroupLoadStarted( TO_CLR_STRING( groupName ), resourceCount );
		}
	}
	
	void ResourceGroupListener_Director::resourceLoadStarted( const Ogre::ResourcePtr& resource )
	{
		if (doCallForResourceLoadStarted)
		{
			_receiver->ResourceLoadStarted( resource );
		}
	}
	
	void ResourceGroupListener_Director::resourceLoadEnded( )
	{
		if (doCallForResourceLoadEnded)
		{
			_receiver->ResourceLoadEnded( );
		}
	}
	
	void ResourceGroupListener_Director::worldGeometryStageStarted( const Ogre::String& description )
	{
		if (doCallForWorldGeometryStageStarted)
		{
			_receiver->WorldGeometryStageStarted( TO_CLR_STRING( description ) );
		}
	}
	
	void ResourceGroupListener_Director::worldGeometryStageEnded( )
	{
		if (doCallForWorldGeometryStageEnded)
		{
			_receiver->WorldGeometryStageEnded( );
		}
	}
	
	void ResourceGroupListener_Director::resourceGroupLoadEnded( const Ogre::String& groupName )
	{
		if (doCallForResourceGroupLoadEnded)
		{
			_receiver->ResourceGroupLoadEnded( TO_CLR_STRING( groupName ) );
		}
	}
	
	
	//Protected Declarations
	
	
	
	//################################################################
	//IResourceLoadingListener
	//################################################################
	
	//Nested Types
	//Private Declarations
	
	//Internal Declarations
	Ogre::ResourceLoadingListener* ResourceLoadingListener::_IResourceLoadingListener_GetNativePtr()
	{
		return static_cast<Ogre::ResourceLoadingListener*>( static_cast<ResourceLoadingListener_Proxy*>(_native) );
	}
	
	
	//Public Declarations
	ResourceLoadingListener::ResourceLoadingListener() : Wrapper( (CLRObject*)0 )
	{
		_createdByCLR = true;
		Type^ thisType = this->GetType();
		_isOverriden = true;  //it's abstract or interface so it must be overriden
		ResourceLoadingListener_Proxy* proxy = new ResourceLoadingListener_Proxy(this);
		proxy->_overriden = Implementation::SubclassingManager::Instance->GetOverridenMethodsArrayPointer(thisType, ResourceLoadingListener::typeid, 0);
		_native = proxy;
	
	
		_native->_MapToCLRObject(this, System::Runtime::InteropServices::GCHandleType::Normal);
	}
	
	
	
	
	
	//Protected Declarations
	
	
	
	
	//################################################################
	//ResourceGroupManager
	//################################################################
	
	//Nested Types
	//################################################################
	//ResourceDeclaration_NativePtr
	//################################################################
	
	//Nested Types
	//Private Declarations
	
	//Internal Declarations
	
	//Public Declarations
	
	String^ ResourceGroupManager::ResourceDeclaration_NativePtr::resourceName::get()
	{
		return TO_CLR_STRING( _native->resourceName );
	}
	void ResourceGroupManager::ResourceDeclaration_NativePtr::resourceName::set( String^ value )
	{
		DECLARE_NATIVE_STRING( o_value, value )
	
		_native->resourceName = o_value;
	}
	
	String^ ResourceGroupManager::ResourceDeclaration_NativePtr::resourceType::get()
	{
		return TO_CLR_STRING( _native->resourceType );
	}
	void ResourceGroupManager::ResourceDeclaration_NativePtr::resourceType::set( String^ value )
	{
		DECLARE_NATIVE_STRING( o_value, value )
	
		_native->resourceType = o_value;
	}
	
	Mogre::IManualResourceLoader^ ResourceGroupManager::ResourceDeclaration_NativePtr::loader::get()
	{
		return _native->loader;
	}
	void ResourceGroupManager::ResourceDeclaration_NativePtr::loader::set( Mogre::IManualResourceLoader^ value )
	{
		_native->loader = value;
	}
	
	Mogre::NameValuePairList^ ResourceGroupManager::ResourceDeclaration_NativePtr::parameters::get()
	{
		return Mogre::NameValuePairList::ByValue( _native->parameters );
	}
	void ResourceGroupManager::ResourceDeclaration_NativePtr::parameters::set( Mogre::NameValuePairList^ value )
	{
		_native->parameters = value;
	}
	
	
	Mogre::ResourceGroupManager::ResourceDeclaration_NativePtr ResourceGroupManager::ResourceDeclaration_NativePtr::Create()
	{
		ResourceDeclaration_NativePtr ptr;
		ptr._native = new Ogre::ResourceGroupManager::ResourceDeclaration();
		return ptr;
	}
	
	
	//Protected Declarations
	
	
	
	#undef CPP_STLLIST_DEFINE_REMOVE_AND_UNIQUE
	#define CPP_STLLIST_DEFINE_REMOVE_AND_UNIQUE(PREFIX,CLASS_NAME,M,N)
	
	#define STLDECL_MANAGEDTYPE Mogre::ResourceGroupManager::ResourceDeclaration_NativePtr
	#define STLDECL_NATIVETYPE Ogre::ResourceGroupManager::ResourceDeclaration
	CPP_DECLARE_STLLIST( ResourceGroupManager::, ResourceDeclarationList, STLDECL_MANAGEDTYPE, STLDECL_NATIVETYPE )
	#undef STLDECL_MANAGEDTYPE
	#undef STLDECL_NATIVETYPE
	
	#undef CPP_STLLIST_DEFINE_REMOVE_AND_UNIQUE
	#define CPP_STLLIST_DEFINE_REMOVE_AND_UNIQUE(PREFIX,CLASS_NAME,M,N)    CPP_STLLIST_REMOVE_AND_UNIQUE_DEFINITIONS(PREFIX,CLASS_NAME,M,N)
	
	#define STLDECL_MANAGEDKEY String^
	#define STLDECL_MANAGEDVALUE Mogre::ResourceManager^
	#define STLDECL_NATIVEKEY Ogre::String
	#define STLDECL_NATIVEVALUE Ogre::ResourceManager*
	CPP_DECLARE_STLMAP( ResourceGroupManager::, ResourceManagerMap, STLDECL_MANAGEDKEY, STLDECL_MANAGEDVALUE, STLDECL_NATIVEKEY, STLDECL_NATIVEVALUE )
	#undef STLDECL_MANAGEDKEY
	#undef STLDECL_MANAGEDVALUE
	#undef STLDECL_NATIVEKEY
	#undef STLDECL_NATIVEVALUE
	
	CPP_DECLARE_MAP_ITERATOR( ResourceGroupManager::, ResourceManagerIterator, Ogre::ResourceGroupManager::ResourceManagerIterator, Mogre::ResourceGroupManager::ResourceManagerMap, Mogre::ResourceManager^, Ogre::ResourceManager*, String^, Ogre::String,  )
	
	//Private Declarations
	
	//Internal Declarations
	
	//Public Declarations
	ResourceGroupManager::ResourceGroupManager( )
	{
		_createdByCLR = true;
		_native = new Ogre::ResourceGroupManager();
	}
	
	String^ ResourceGroupManager::DEFAULT_RESOURCE_GROUP_NAME::get()
	{
		return TO_CLR_STRING( Ogre::ResourceGroupManager::DEFAULT_RESOURCE_GROUP_NAME );
	}
	void ResourceGroupManager::DEFAULT_RESOURCE_GROUP_NAME::set( String^ value )
	{
		DECLARE_NATIVE_STRING( o_value, value )
	
		Ogre::ResourceGroupManager::DEFAULT_RESOURCE_GROUP_NAME = o_value;
	}
	
	String^ ResourceGroupManager::INTERNAL_RESOURCE_GROUP_NAME::get()
	{
		return TO_CLR_STRING( Ogre::ResourceGroupManager::INTERNAL_RESOURCE_GROUP_NAME );
	}
	void ResourceGroupManager::INTERNAL_RESOURCE_GROUP_NAME::set( String^ value )
	{
		DECLARE_NATIVE_STRING( o_value, value )
	
		Ogre::ResourceGroupManager::INTERNAL_RESOURCE_GROUP_NAME = o_value;
	}
	
	String^ ResourceGroupManager::AUTODETECT_RESOURCE_GROUP_NAME::get()
	{
		return TO_CLR_STRING( Ogre::ResourceGroupManager::AUTODETECT_RESOURCE_GROUP_NAME );
	}
	void ResourceGroupManager::AUTODETECT_RESOURCE_GROUP_NAME::set( String^ value )
	{
		DECLARE_NATIVE_STRING( o_value, value )
	
		Ogre::ResourceGroupManager::AUTODETECT_RESOURCE_GROUP_NAME = o_value;
	}
	
	size_t ResourceGroupManager::RESOURCE_SYSTEM_NUM_REFERENCE_COUNTS::get()
	{
		return Ogre::ResourceGroupManager::RESOURCE_SYSTEM_NUM_REFERENCE_COUNTS;
	}
	void ResourceGroupManager::RESOURCE_SYSTEM_NUM_REFERENCE_COUNTS::set( size_t value )
	{
		Ogre::ResourceGroupManager::RESOURCE_SYSTEM_NUM_REFERENCE_COUNTS = value;
	}
	
	Mogre::IResourceLoadingListener^ ResourceGroupManager::LoadingListener::get()
	{
		return static_cast<Ogre::ResourceGroupManager*>(_native)->getLoadingListener( );
	}
	void ResourceGroupManager::LoadingListener::set( Mogre::IResourceLoadingListener^ listener )
	{
		static_cast<Ogre::ResourceGroupManager*>(_native)->setLoadingListener( listener );
	}
	
	String^ ResourceGroupManager::WorldResourceGroupName::get()
	{
		return TO_CLR_STRING( static_cast<const Ogre::ResourceGroupManager*>(_native)->getWorldResourceGroupName( ) );
	}
	void ResourceGroupManager::WorldResourceGroupName::set( String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->setWorldResourceGroupName( o_groupName );
	}
	
	void ResourceGroupManager::CreateResourceGroup( String^ name, bool inGlobalPool )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->createResourceGroup( o_name, inGlobalPool );
	}
	void ResourceGroupManager::CreateResourceGroup( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->createResourceGroup( o_name );
	}
	
	void ResourceGroupManager::InitialiseResourceGroup( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->initialiseResourceGroup( o_name );
	}
	
	void ResourceGroupManager::InitialiseAllResourceGroups( )
	{
		static_cast<Ogre::ResourceGroupManager*>(_native)->initialiseAllResourceGroups( );
	}
	
	void ResourceGroupManager::PrepareResourceGroup( String^ name, bool prepareMainResources, bool prepareWorldGeom )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->prepareResourceGroup( o_name, prepareMainResources, prepareWorldGeom );
	}
	void ResourceGroupManager::PrepareResourceGroup( String^ name, bool prepareMainResources )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->prepareResourceGroup( o_name, prepareMainResources );
	}
	void ResourceGroupManager::PrepareResourceGroup( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->prepareResourceGroup( o_name );
	}
	
	void ResourceGroupManager::LoadResourceGroup( String^ name, bool loadMainResources, bool loadWorldGeom )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->loadResourceGroup( o_name, loadMainResources, loadWorldGeom );
	}
	void ResourceGroupManager::LoadResourceGroup( String^ name, bool loadMainResources )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->loadResourceGroup( o_name, loadMainResources );
	}
	void ResourceGroupManager::LoadResourceGroup( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->loadResourceGroup( o_name );
	}
	
	void ResourceGroupManager::UnloadResourceGroup( String^ name, bool reloadableOnly )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->unloadResourceGroup( o_name, reloadableOnly );
	}
	void ResourceGroupManager::UnloadResourceGroup( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->unloadResourceGroup( o_name );
	}
	
	void ResourceGroupManager::UnloadUnreferencedResourcesInGroup( String^ name, bool reloadableOnly )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->unloadUnreferencedResourcesInGroup( o_name, reloadableOnly );
	}
	void ResourceGroupManager::UnloadUnreferencedResourcesInGroup( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->unloadUnreferencedResourcesInGroup( o_name );
	}
	
	void ResourceGroupManager::ClearResourceGroup( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->clearResourceGroup( o_name );
	}
	
	void ResourceGroupManager::DestroyResourceGroup( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->destroyResourceGroup( o_name );
	}
	
	bool ResourceGroupManager::IsResourceGroupInitialised( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->isResourceGroupInitialised( o_name );
	}
	
	bool ResourceGroupManager::IsResourceGroupLoaded( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->isResourceGroupLoaded( o_name );
	}
	
	bool ResourceGroupManager::ResourceGroupExists( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->resourceGroupExists( o_name );
	}
	
	void ResourceGroupManager::AddResourceLocation( String^ name, String^ locType, String^ resGroup, bool recursive )
	{
		DECLARE_NATIVE_STRING( o_name, name )
		DECLARE_NATIVE_STRING( o_locType, locType )
		DECLARE_NATIVE_STRING( o_resGroup, resGroup )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->addResourceLocation( o_name, o_locType, o_resGroup, recursive );
	}
	void ResourceGroupManager::AddResourceLocation( String^ name, String^ locType, String^ resGroup )
	{
		DECLARE_NATIVE_STRING( o_name, name )
		DECLARE_NATIVE_STRING( o_locType, locType )
		DECLARE_NATIVE_STRING( o_resGroup, resGroup )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->addResourceLocation( o_name, o_locType, o_resGroup );
	}
	void ResourceGroupManager::AddResourceLocation( String^ name, String^ locType )
	{
		DECLARE_NATIVE_STRING( o_name, name )
		DECLARE_NATIVE_STRING( o_locType, locType )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->addResourceLocation( o_name, o_locType );
	}
	
	void ResourceGroupManager::RemoveResourceLocation( String^ name, String^ resGroup )
	{
		DECLARE_NATIVE_STRING( o_name, name )
		DECLARE_NATIVE_STRING( o_resGroup, resGroup )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->removeResourceLocation( o_name, o_resGroup );
	}
	void ResourceGroupManager::RemoveResourceLocation( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->removeResourceLocation( o_name );
	}
	
	bool ResourceGroupManager::ResourceLocationExists( String^ name, String^ resGroup )
	{
		DECLARE_NATIVE_STRING( o_name, name )
		DECLARE_NATIVE_STRING( o_resGroup, resGroup )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->resourceLocationExists( o_name, o_resGroup );
	}
	bool ResourceGroupManager::ResourceLocationExists( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->resourceLocationExists( o_name );
	}
	
	void ResourceGroupManager::DeclareResource( String^ name, String^ resourceType, String^ groupName, Mogre::Const_NameValuePairList^ loadParameters )
	{
		DECLARE_NATIVE_STRING( o_name, name )
		DECLARE_NATIVE_STRING( o_resourceType, resourceType )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->declareResource( o_name, o_resourceType, o_groupName, loadParameters );
	}
	void ResourceGroupManager::DeclareResource( String^ name, String^ resourceType, String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_name, name )
		DECLARE_NATIVE_STRING( o_resourceType, resourceType )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->declareResource( o_name, o_resourceType, o_groupName );
	}
	void ResourceGroupManager::DeclareResource( String^ name, String^ resourceType )
	{
		DECLARE_NATIVE_STRING( o_name, name )
		DECLARE_NATIVE_STRING( o_resourceType, resourceType )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->declareResource( o_name, o_resourceType );
	}
	
	void ResourceGroupManager::DeclareResource( String^ name, String^ resourceType, String^ groupName, Mogre::IManualResourceLoader^ loader, Mogre::Const_NameValuePairList^ loadParameters )
	{
		DECLARE_NATIVE_STRING( o_name, name )
		DECLARE_NATIVE_STRING( o_resourceType, resourceType )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->declareResource( o_name, o_resourceType, o_groupName, loader, loadParameters );
	}
	void ResourceGroupManager::DeclareResource( String^ name, String^ resourceType, String^ groupName, Mogre::IManualResourceLoader^ loader )
	{
		DECLARE_NATIVE_STRING( o_name, name )
		DECLARE_NATIVE_STRING( o_resourceType, resourceType )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->declareResource( o_name, o_resourceType, o_groupName, loader );
	}
	
	void ResourceGroupManager::UndeclareResource( String^ name, String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_name, name )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->undeclareResource( o_name, o_groupName );
	}
	
	Mogre::DataStreamPtr^ ResourceGroupManager::OpenResource( String^ resourceName, String^ groupName, bool searchGroupsIfNotFound, Mogre::Resource^ resourceBeingLoaded )
	{
		DECLARE_NATIVE_STRING( o_resourceName, resourceName )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->openResource( o_resourceName, o_groupName, searchGroupsIfNotFound, resourceBeingLoaded );
	}
	Mogre::DataStreamPtr^ ResourceGroupManager::OpenResource( String^ resourceName, String^ groupName, bool searchGroupsIfNotFound )
	{
		DECLARE_NATIVE_STRING( o_resourceName, resourceName )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->openResource( o_resourceName, o_groupName, searchGroupsIfNotFound );
	}
	Mogre::DataStreamPtr^ ResourceGroupManager::OpenResource( String^ resourceName, String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_resourceName, resourceName )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->openResource( o_resourceName, o_groupName );
	}
	Mogre::DataStreamPtr^ ResourceGroupManager::OpenResource( String^ resourceName )
	{
		DECLARE_NATIVE_STRING( o_resourceName, resourceName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->openResource( o_resourceName );
	}
	
	Mogre::DataStreamListPtr^ ResourceGroupManager::OpenResources( String^ pattern, String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_pattern, pattern )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->openResources( o_pattern, o_groupName );
	}
	Mogre::DataStreamListPtr^ ResourceGroupManager::OpenResources( String^ pattern )
	{
		DECLARE_NATIVE_STRING( o_pattern, pattern )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->openResources( o_pattern );
	}
	
	Mogre::StringVectorPtr^ ResourceGroupManager::ListResourceNames( String^ groupName, bool dirs )
	{
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->listResourceNames( o_groupName, dirs );
	}
	Mogre::StringVectorPtr^ ResourceGroupManager::ListResourceNames( String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->listResourceNames( o_groupName );
	}
	
	Mogre::FileInfoListPtr^ ResourceGroupManager::ListResourceFileInfo( String^ groupName, bool dirs )
	{
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->listResourceFileInfo( o_groupName, dirs );
	}
	Mogre::FileInfoListPtr^ ResourceGroupManager::ListResourceFileInfo( String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->listResourceFileInfo( o_groupName );
	}
	
	Mogre::StringVectorPtr^ ResourceGroupManager::FindResourceNames( String^ groupName, String^ pattern, bool dirs )
	{
		DECLARE_NATIVE_STRING( o_groupName, groupName )
		DECLARE_NATIVE_STRING( o_pattern, pattern )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->findResourceNames( o_groupName, o_pattern, dirs );
	}
	Mogre::StringVectorPtr^ ResourceGroupManager::FindResourceNames( String^ groupName, String^ pattern )
	{
		DECLARE_NATIVE_STRING( o_groupName, groupName )
		DECLARE_NATIVE_STRING( o_pattern, pattern )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->findResourceNames( o_groupName, o_pattern );
	}
	
	bool ResourceGroupManager::ResourceExists( String^ group, String^ filename )
	{
		DECLARE_NATIVE_STRING( o_group, group )
		DECLARE_NATIVE_STRING( o_filename, filename )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->resourceExists( o_group, o_filename );
	}
	
	bool ResourceGroupManager::ResourceExistsInAnyGroup( String^ filename )
	{
		DECLARE_NATIVE_STRING( o_filename, filename )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->resourceExistsInAnyGroup( o_filename );
	}
	
	String^ ResourceGroupManager::FindGroupContainingResource( String^ filename )
	{
		DECLARE_NATIVE_STRING( o_filename, filename )
	
		return TO_CLR_STRING( static_cast<Ogre::ResourceGroupManager*>(_native)->findGroupContainingResource( o_filename ) );
	}
	
	Mogre::FileInfoListPtr^ ResourceGroupManager::FindResourceFileInfo( String^ group, String^ pattern, bool dirs )
	{
		DECLARE_NATIVE_STRING( o_group, group )
		DECLARE_NATIVE_STRING( o_pattern, pattern )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->findResourceFileInfo( o_group, o_pattern, dirs );
	}
	Mogre::FileInfoListPtr^ ResourceGroupManager::FindResourceFileInfo( String^ group, String^ pattern )
	{
		DECLARE_NATIVE_STRING( o_group, group )
		DECLARE_NATIVE_STRING( o_pattern, pattern )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->findResourceFileInfo( o_group, o_pattern );
	}
	
	time_t ResourceGroupManager::ResourceModifiedTime( String^ group, String^ filename )
	{
		DECLARE_NATIVE_STRING( o_group, group )
		DECLARE_NATIVE_STRING( o_filename, filename )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->resourceModifiedTime( o_group, o_filename );
	}
	
	Mogre::StringVectorPtr^ ResourceGroupManager::ListResourceLocations( String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->listResourceLocations( o_groupName );
	}
	
	Mogre::StringVectorPtr^ ResourceGroupManager::FindResourceLocation( String^ groupName, String^ pattern )
	{
		DECLARE_NATIVE_STRING( o_groupName, groupName )
		DECLARE_NATIVE_STRING( o_pattern, pattern )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->findResourceLocation( o_groupName, o_pattern );
	}
	
	Mogre::DataStreamPtr^ ResourceGroupManager::CreateResource( String^ filename, String^ groupName, bool overwrite, String^ locationPattern )
	{
		DECLARE_NATIVE_STRING( o_filename, filename )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
		DECLARE_NATIVE_STRING( o_locationPattern, locationPattern )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->createResource( o_filename, o_groupName, overwrite, o_locationPattern );
	}
	Mogre::DataStreamPtr^ ResourceGroupManager::CreateResource( String^ filename, String^ groupName, bool overwrite )
	{
		DECLARE_NATIVE_STRING( o_filename, filename )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->createResource( o_filename, o_groupName, overwrite );
	}
	Mogre::DataStreamPtr^ ResourceGroupManager::CreateResource( String^ filename, String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_filename, filename )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->createResource( o_filename, o_groupName );
	}
	Mogre::DataStreamPtr^ ResourceGroupManager::CreateResource( String^ filename )
	{
		DECLARE_NATIVE_STRING( o_filename, filename )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->createResource( o_filename );
	}
	
	void ResourceGroupManager::DeleteResource( String^ filename, String^ groupName, String^ locationPattern )
	{
		DECLARE_NATIVE_STRING( o_filename, filename )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
		DECLARE_NATIVE_STRING( o_locationPattern, locationPattern )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->deleteResource( o_filename, o_groupName, o_locationPattern );
	}
	void ResourceGroupManager::DeleteResource( String^ filename, String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_filename, filename )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->deleteResource( o_filename, o_groupName );
	}
	void ResourceGroupManager::DeleteResource( String^ filename )
	{
		DECLARE_NATIVE_STRING( o_filename, filename )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->deleteResource( o_filename );
	}
	
	void ResourceGroupManager::DeleteMatchingResources( String^ filePattern, String^ groupName, String^ locationPattern )
	{
		DECLARE_NATIVE_STRING( o_filePattern, filePattern )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
		DECLARE_NATIVE_STRING( o_locationPattern, locationPattern )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->deleteMatchingResources( o_filePattern, o_groupName, o_locationPattern );
	}
	void ResourceGroupManager::DeleteMatchingResources( String^ filePattern, String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_filePattern, filePattern )
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->deleteMatchingResources( o_filePattern, o_groupName );
	}
	void ResourceGroupManager::DeleteMatchingResources( String^ filePattern )
	{
		DECLARE_NATIVE_STRING( o_filePattern, filePattern )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->deleteMatchingResources( o_filePattern );
	}
	
	void ResourceGroupManager::LinkWorldGeometryToResourceGroup( String^ group, String^ worldGeometry, Mogre::SceneManager^ sceneManager )
	{
		DECLARE_NATIVE_STRING( o_group, group )
		DECLARE_NATIVE_STRING( o_worldGeometry, worldGeometry )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->linkWorldGeometryToResourceGroup( o_group, o_worldGeometry, sceneManager );
	}
	
	void ResourceGroupManager::UnlinkWorldGeometryFromResourceGroup( String^ group )
	{
		DECLARE_NATIVE_STRING( o_group, group )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->unlinkWorldGeometryFromResourceGroup( o_group );
	}
	
	bool ResourceGroupManager::IsResourceGroupInGlobalPool( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->isResourceGroupInGlobalPool( o_name );
	}
	
	void ResourceGroupManager::ShutdownAll( )
	{
		static_cast<Ogre::ResourceGroupManager*>(_native)->shutdownAll( );
	}
	
	void ResourceGroupManager::_registerResourceManager( String^ resourceType, Mogre::ResourceManager^ rm )
	{
		DECLARE_NATIVE_STRING( o_resourceType, resourceType )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->_registerResourceManager( o_resourceType, rm );
	}
	
	void ResourceGroupManager::_unregisterResourceManager( String^ resourceType )
	{
		DECLARE_NATIVE_STRING( o_resourceType, resourceType )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->_unregisterResourceManager( o_resourceType );
	}
	
	Mogre::ResourceGroupManager::ResourceManagerIterator^ ResourceGroupManager::GetResourceManagerIterator( )
	{
		return static_cast<Ogre::ResourceGroupManager*>(_native)->getResourceManagerIterator( );
	}
	
	Mogre::ResourceManager^ ResourceGroupManager::_getResourceManager( String^ resourceType )
	{
		DECLARE_NATIVE_STRING( o_resourceType, resourceType )
	
		return static_cast<Ogre::ResourceGroupManager*>(_native)->_getResourceManager( o_resourceType );
	}
	
	void ResourceGroupManager::_notifyResourceCreated( Mogre::ResourcePtr^ res )
	{
		static_cast<Ogre::ResourceGroupManager*>(_native)->_notifyResourceCreated( (Ogre::ResourcePtr&)res );
	}
	
	void ResourceGroupManager::_notifyResourceRemoved( Mogre::ResourcePtr^ res )
	{
		static_cast<Ogre::ResourceGroupManager*>(_native)->_notifyResourceRemoved( (Ogre::ResourcePtr&)res );
	}
	
	void ResourceGroupManager::_notifyResourceGroupChanged( String^ oldGroup, Mogre::Resource^ res )
	{
		DECLARE_NATIVE_STRING( o_oldGroup, oldGroup )
	
		static_cast<Ogre::ResourceGroupManager*>(_native)->_notifyResourceGroupChanged( o_oldGroup, res );
	}
	
	void ResourceGroupManager::_notifyAllResourcesRemoved( Mogre::ResourceManager^ manager )
	{
		static_cast<Ogre::ResourceGroupManager*>(_native)->_notifyAllResourcesRemoved( manager );
	}
	
	Mogre::StringVector^ ResourceGroupManager::GetResourceGroups( )
	{
		return Mogre::StringVector::ByValue( static_cast<Ogre::ResourceGroupManager*>(_native)->getResourceGroups( ) );
	}
	
	Mogre::ResourceGroupManager::ResourceDeclarationList^ ResourceGroupManager::GetResourceDeclarationList( String^ groupName )
	{
		DECLARE_NATIVE_STRING( o_groupName, groupName )
	
		return Mogre::ResourceGroupManager::ResourceDeclarationList::ByValue( static_cast<Ogre::ResourceGroupManager*>(_native)->getResourceDeclarationList( o_groupName ) );
	}
	
	
	//Protected Declarations
	
	
	
	//################################################################
	//ResourceLoadingListener_Proxy
	//################################################################
	
	
	
	Ogre::DataStreamPtr ResourceLoadingListener_Proxy::resourceLoading( const Ogre::String& name, const Ogre::String& group, Ogre::Resource* resource )
	{
		Mogre::DataStreamPtr^ mp_return = _managed->ResourceLoading( TO_CLR_STRING( name ), TO_CLR_STRING( group ), resource );
		return (Ogre::DataStreamPtr)mp_return;
	}
	
	void ResourceLoadingListener_Proxy::resourceStreamOpened( const Ogre::String& name, const Ogre::String& group, Ogre::Resource* resource, Ogre::DataStreamPtr& dataStream )
	{
		_managed->ResourceStreamOpened( TO_CLR_STRING( name ), TO_CLR_STRING( group ), resource, dataStream );
	}
	
	bool ResourceLoadingListener_Proxy::resourceCollision( Ogre::Resource* resource, Ogre::ResourceManager* resourceManager )
	{
		bool mp_return = _managed->ResourceCollision( resource, resourceManager );
		return mp_return;
	}

}
