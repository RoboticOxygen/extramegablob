/*  This file is produced by the C++/CLI AutoWrapper utility.
        Copyright (c) 2006 by Argiris Kirtzidis  */

#include "MogreStableHeaders.h"

#include "MogreNode.h"
#include "MogreUserObjectBindings.h"
#include "MogreCamera.h"

namespace Mogre
{
	//################################################################
	//Node
	//################################################################
	
	//Nested Types
	//################################################################
	//IListener
	//################################################################
	
	//Nested Types
	//Private Declarations
	
	//Internal Declarations
	Ogre::Node::Listener* Node::Listener::_IListener_GetNativePtr()
	{
		return static_cast<Ogre::Node::Listener*>( static_cast<Node_Listener_Proxy*>(_native) );
	}
	
	
	//Public Declarations
	Node::Listener::Listener( ) : Wrapper( (CLRObject*)0 )
	{
		_createdByCLR = true;
		Type^ thisType = this->GetType();
		_isOverriden = true;  //it's abstract or interface so it must be overriden
		Node_Listener_Proxy* proxy = new Node_Listener_Proxy(this);
		proxy->_overriden = Implementation::SubclassingManager::Instance->GetOverridenMethodsArrayPointer(thisType, Listener::typeid, 4);
		_native = proxy;
	
	
		_native->_MapToCLRObject(this, System::Runtime::InteropServices::GCHandleType::Normal);
	}
	
	void Node::Listener::NodeUpdated( Mogre::Node^ param1 )
	{
		static_cast<Node_Listener_Proxy*>(_native)->Listener::nodeUpdated( param1 );
	}
	
	void Node::Listener::NodeDestroyed( Mogre::Node^ param1 )
	{
		static_cast<Node_Listener_Proxy*>(_native)->Listener::nodeDestroyed( param1 );
	}
	
	void Node::Listener::NodeAttached( Mogre::Node^ param1 )
	{
		static_cast<Node_Listener_Proxy*>(_native)->Listener::nodeAttached( param1 );
	}
	
	void Node::Listener::NodeDetached( Mogre::Node^ param1 )
	{
		static_cast<Node_Listener_Proxy*>(_native)->Listener::nodeDetached( param1 );
	}
	
	
	//Protected Declarations
	
	
	
	
	#define STLDECL_MANAGEDKEY String^
	#define STLDECL_MANAGEDVALUE Mogre::Node^
	#define STLDECL_NATIVEKEY Ogre::String
	#define STLDECL_NATIVEVALUE Ogre::Node*
	CPP_DECLARE_STLHASHMAP( Node::, ChildNodeMap, STLDECL_MANAGEDKEY, STLDECL_MANAGEDVALUE, STLDECL_NATIVEKEY, STLDECL_NATIVEVALUE )
	#undef STLDECL_MANAGEDKEY
	#undef STLDECL_MANAGEDVALUE
	#undef STLDECL_NATIVEKEY
	#undef STLDECL_NATIVEVALUE
	
	CPP_DECLARE_MAP_ITERATOR( Node::, ChildNodeIterator, Ogre::Node::ChildNodeIterator, Mogre::Node::ChildNodeMap, Mogre::Node^, Ogre::Node*, String^, Ogre::String,  )
	
	//Private Declarations
	
	//Internal Declarations
	
	//Public Declarations
	bool Node::InheritOrientation::get()
	{
		return static_cast<const Ogre::Node*>(_native)->getInheritOrientation( );
	}
	void Node::InheritOrientation::set( bool inherit )
	{
		static_cast<Ogre::Node*>(_native)->setInheritOrientation( inherit );
	}
	
	bool Node::InheritScale::get()
	{
		return static_cast<const Ogre::Node*>(_native)->getInheritScale( );
	}
	void Node::InheritScale::set( bool inherit )
	{
		static_cast<Ogre::Node*>(_native)->setInheritScale( inherit );
	}
	
	Mogre::Quaternion Node::InitialOrientation::get()
	{
		return static_cast<const Ogre::Node*>(_native)->getInitialOrientation( );
	}
	
	Mogre::Vector3 Node::InitialPosition::get()
	{
		return static_cast<const Ogre::Node*>(_native)->getInitialPosition( );
	}
	
	Mogre::Vector3 Node::InitialScale::get()
	{
		return static_cast<const Ogre::Node*>(_native)->getInitialScale( );
	}
	
	Mogre::Matrix3^ Node::LocalAxes::get()
	{
		return static_cast<const Ogre::Node*>(_native)->getLocalAxes( );
	}
	
	String^ Node::Name::get()
	{
		return TO_CLR_STRING( static_cast<const Ogre::Node*>(_native)->getName( ) );
	}
	
	Mogre::Quaternion Node::Orientation::get()
	{
		return static_cast<const Ogre::Node*>(_native)->getOrientation( );
	}
	void Node::Orientation::set( Mogre::Quaternion q )
	{
		static_cast<Ogre::Node*>(_native)->setOrientation( q );
	}
	
	Mogre::Node^ Node::Parent::get()
	{
		return static_cast<const Ogre::Node*>(_native)->getParent( );
	}
	
	Mogre::Vector3 Node::Position::get()
	{
		return static_cast<const Ogre::Node*>(_native)->getPosition( );
	}
	void Node::Position::set( Mogre::Vector3 pos )
	{
		static_cast<Ogre::Node*>(_native)->setPosition( pos );
	}
	
	Mogre::UserObjectBindings^ Node::UserObjectBindings::get()
	{
		return static_cast<Ogre::Node*>(_native)->getUserObjectBindings( );
	}
	
	void Node::_Init_CLRObject( )
	{
		static_cast<Ogre::Node*>(_native)->_Init_CLRObject( );
	}
	
	void Node::SetOrientation( Mogre::Real w, Mogre::Real x, Mogre::Real y, Mogre::Real z )
	{
		static_cast<Ogre::Node*>(_native)->setOrientation( w, x, y, z );
	}
	
	void Node::ResetOrientation( )
	{
		static_cast<Ogre::Node*>(_native)->resetOrientation( );
	}
	
	void Node::SetPosition( Mogre::Real x, Mogre::Real y, Mogre::Real z )
	{
		static_cast<Ogre::Node*>(_native)->setPosition( x, y, z );
	}
	
	void Node::SetScale( Mogre::Vector3 scale )
	{
		static_cast<Ogre::Node*>(_native)->setScale( scale );
	}
	
	void Node::SetScale( Mogre::Real x, Mogre::Real y, Mogre::Real z )
	{
		static_cast<Ogre::Node*>(_native)->setScale( x, y, z );
	}
	
	Mogre::Vector3 Node::GetScale( )
	{
		return static_cast<const Ogre::Node*>(_native)->getScale( );
	}
	
	void Node::Scale( Mogre::Vector3 scale )
	{
		static_cast<Ogre::Node*>(_native)->scale( scale );
	}
	
	void Node::Scale( Mogre::Real x, Mogre::Real y, Mogre::Real z )
	{
		static_cast<Ogre::Node*>(_native)->scale( x, y, z );
	}
	
	void Node::Translate( Mogre::Vector3 d, Mogre::Node::TransformSpace relativeTo )
	{
		static_cast<Ogre::Node*>(_native)->translate( d, (Ogre::Node::TransformSpace)relativeTo );
	}
	void Node::Translate( Mogre::Vector3 d )
	{
		static_cast<Ogre::Node*>(_native)->translate( d );
	}
	
	void Node::Translate( Mogre::Real x, Mogre::Real y, Mogre::Real z, Mogre::Node::TransformSpace relativeTo )
	{
		static_cast<Ogre::Node*>(_native)->translate( x, y, z, (Ogre::Node::TransformSpace)relativeTo );
	}
	void Node::Translate( Mogre::Real x, Mogre::Real y, Mogre::Real z )
	{
		static_cast<Ogre::Node*>(_native)->translate( x, y, z );
	}
	
	void Node::Translate( Mogre::Matrix3^ axes, Mogre::Vector3 move, Mogre::Node::TransformSpace relativeTo )
	{
		pin_ptr<Ogre::Matrix3> p_axes = interior_ptr<Ogre::Matrix3>(&axes->m00);
	
		static_cast<Ogre::Node*>(_native)->translate( *p_axes, move, (Ogre::Node::TransformSpace)relativeTo );
	}
	void Node::Translate( Mogre::Matrix3^ axes, Mogre::Vector3 move )
	{
		pin_ptr<Ogre::Matrix3> p_axes = interior_ptr<Ogre::Matrix3>(&axes->m00);
	
		static_cast<Ogre::Node*>(_native)->translate( *p_axes, move );
	}
	
	void Node::Translate( Mogre::Matrix3^ axes, Mogre::Real x, Mogre::Real y, Mogre::Real z, Mogre::Node::TransformSpace relativeTo )
	{
		pin_ptr<Ogre::Matrix3> p_axes = interior_ptr<Ogre::Matrix3>(&axes->m00);
	
		static_cast<Ogre::Node*>(_native)->translate( *p_axes, x, y, z, (Ogre::Node::TransformSpace)relativeTo );
	}
	void Node::Translate( Mogre::Matrix3^ axes, Mogre::Real x, Mogre::Real y, Mogre::Real z )
	{
		pin_ptr<Ogre::Matrix3> p_axes = interior_ptr<Ogre::Matrix3>(&axes->m00);
	
		static_cast<Ogre::Node*>(_native)->translate( *p_axes, x, y, z );
	}
	
	void Node::Roll( Mogre::Radian angle, Mogre::Node::TransformSpace relativeTo )
	{
		static_cast<Ogre::Node*>(_native)->roll( angle, (Ogre::Node::TransformSpace)relativeTo );
	}
	void Node::Roll( Mogre::Radian angle )
	{
		static_cast<Ogre::Node*>(_native)->roll( angle );
	}
	
	void Node::Pitch( Mogre::Radian angle, Mogre::Node::TransformSpace relativeTo )
	{
		static_cast<Ogre::Node*>(_native)->pitch( angle, (Ogre::Node::TransformSpace)relativeTo );
	}
	void Node::Pitch( Mogre::Radian angle )
	{
		static_cast<Ogre::Node*>(_native)->pitch( angle );
	}
	
	void Node::Yaw( Mogre::Radian angle, Mogre::Node::TransformSpace relativeTo )
	{
		static_cast<Ogre::Node*>(_native)->yaw( angle, (Ogre::Node::TransformSpace)relativeTo );
	}
	void Node::Yaw( Mogre::Radian angle )
	{
		static_cast<Ogre::Node*>(_native)->yaw( angle );
	}
	
	void Node::Rotate( Mogre::Vector3 axis, Mogre::Radian angle, Mogre::Node::TransformSpace relativeTo )
	{
		static_cast<Ogre::Node*>(_native)->rotate( axis, angle, (Ogre::Node::TransformSpace)relativeTo );
	}
	void Node::Rotate( Mogre::Vector3 axis, Mogre::Radian angle )
	{
		static_cast<Ogre::Node*>(_native)->rotate( axis, angle );
	}
	
	void Node::Rotate( Mogre::Quaternion q, Mogre::Node::TransformSpace relativeTo )
	{
		static_cast<Ogre::Node*>(_native)->rotate( q, (Ogre::Node::TransformSpace)relativeTo );
	}
	void Node::Rotate( Mogre::Quaternion q )
	{
		static_cast<Ogre::Node*>(_native)->rotate( q );
	}
	
	Mogre::Node^ Node::CreateChild( Mogre::Vector3 translate, Mogre::Quaternion rotate )
	{
		return static_cast<Ogre::Node*>(_native)->createChild( translate, rotate );
	}
	Mogre::Node^ Node::CreateChild( Mogre::Vector3 translate )
	{
		return static_cast<Ogre::Node*>(_native)->createChild( translate );
	}
	Mogre::Node^ Node::CreateChild( )
	{
		return static_cast<Ogre::Node*>(_native)->createChild( );
	}
	
	Mogre::Node^ Node::CreateChild( String^ name, Mogre::Vector3 translate, Mogre::Quaternion rotate )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		return static_cast<Ogre::Node*>(_native)->createChild( o_name, translate, rotate );
	}
	Mogre::Node^ Node::CreateChild( String^ name, Mogre::Vector3 translate )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		return static_cast<Ogre::Node*>(_native)->createChild( o_name, translate );
	}
	Mogre::Node^ Node::CreateChild( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		return static_cast<Ogre::Node*>(_native)->createChild( o_name );
	}
	
	void Node::AddChild( Mogre::Node^ child )
	{
		static_cast<Ogre::Node*>(_native)->addChild( child );
	}
	
	unsigned short Node::NumChildren( )
	{
		return static_cast<const Ogre::Node*>(_native)->numChildren( );
	}
	
	Mogre::Node^ Node::GetChild( unsigned short index )
	{
		return static_cast<const Ogre::Node*>(_native)->getChild( index );
	}
	
	Mogre::Node^ Node::GetChild( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		return static_cast<const Ogre::Node*>(_native)->getChild( o_name );
	}
	
	Mogre::Node::ChildNodeIterator^ Node::GetChildIterator( )
	{
		return static_cast<Ogre::Node*>(_native)->getChildIterator( );
	}
	
	Mogre::Node^ Node::RemoveChild( unsigned short index )
	{
		return static_cast<Ogre::Node*>(_native)->removeChild( index );
	}
	
	Mogre::Node^ Node::RemoveChild( Mogre::Node^ child )
	{
		return static_cast<Ogre::Node*>(_native)->removeChild( child );
	}
	
	Mogre::Node^ Node::RemoveChild( String^ name )
	{
		DECLARE_NATIVE_STRING( o_name, name )
	
		return static_cast<Ogre::Node*>(_native)->removeChild( o_name );
	}
	
	void Node::RemoveAllChildren( )
	{
		static_cast<Ogre::Node*>(_native)->removeAllChildren( );
	}
	
	void Node::_setDerivedPosition( Mogre::Vector3 pos )
	{
		static_cast<Ogre::Node*>(_native)->_setDerivedPosition( pos );
	}
	
	void Node::_setDerivedOrientation( Mogre::Quaternion q )
	{
		static_cast<Ogre::Node*>(_native)->_setDerivedOrientation( q );
	}
	
	Mogre::Quaternion Node::_getDerivedOrientation( )
	{
		return static_cast<const Ogre::Node*>(_native)->_getDerivedOrientation( );
	}
	
	Mogre::Vector3 Node::_getDerivedPosition( )
	{
		return static_cast<const Ogre::Node*>(_native)->_getDerivedPosition( );
	}
	
	Mogre::Vector3 Node::_getDerivedScale( )
	{
		return static_cast<const Ogre::Node*>(_native)->_getDerivedScale( );
	}
	
	Mogre::Matrix4^ Node::_getFullTransform( )
	{
		return static_cast<const Ogre::Node*>(_native)->_getFullTransform( );
	}
	
	void Node::_update( bool updateChildren, bool parentHasChanged )
	{
		static_cast<Ogre::Node*>(_native)->_update( updateChildren, parentHasChanged );
	}
	
	void Node::SetListener( Mogre::Node::IListener^ listener )
	{
		static_cast<Ogre::Node*>(_native)->setListener( listener );
	}
	
	Mogre::Node::IListener^ Node::GetListener( )
	{
		return static_cast<const Ogre::Node*>(_native)->getListener( );
	}
	
	void Node::SetInitialState( )
	{
		static_cast<Ogre::Node*>(_native)->setInitialState( );
	}
	
	void Node::ResetToInitialState( )
	{
		static_cast<Ogre::Node*>(_native)->resetToInitialState( );
	}
	
	Mogre::Vector3 Node::ConvertWorldToLocalPosition( Mogre::Vector3 worldPos )
	{
		return static_cast<Ogre::Node*>(_native)->convertWorldToLocalPosition( worldPos );
	}
	
	Mogre::Vector3 Node::ConvertLocalToWorldPosition( Mogre::Vector3 localPos )
	{
		return static_cast<Ogre::Node*>(_native)->convertLocalToWorldPosition( localPos );
	}
	
	Mogre::Quaternion Node::ConvertWorldToLocalOrientation( Mogre::Quaternion worldOrientation )
	{
		return static_cast<Ogre::Node*>(_native)->convertWorldToLocalOrientation( worldOrientation );
	}
	
	Mogre::Quaternion Node::ConvertLocalToWorldOrientation( Mogre::Quaternion localOrientation )
	{
		return static_cast<Ogre::Node*>(_native)->convertLocalToWorldOrientation( localOrientation );
	}
	
	Mogre::Real Node::GetSquaredViewDepth( Mogre::Camera^ cam )
	{
		return static_cast<const Ogre::Node*>(_native)->getSquaredViewDepth( cam );
	}
	
	void Node::NeedUpdate( bool forceParentUpdate )
	{
		static_cast<Ogre::Node*>(_native)->needUpdate( forceParentUpdate );
	}
	void Node::NeedUpdate( )
	{
		static_cast<Ogre::Node*>(_native)->needUpdate( );
	}
	
	void Node::RequestUpdate( Mogre::Node^ child, bool forceParentUpdate )
	{
		static_cast<Ogre::Node*>(_native)->requestUpdate( child, forceParentUpdate );
	}
	void Node::RequestUpdate( Mogre::Node^ child )
	{
		static_cast<Ogre::Node*>(_native)->requestUpdate( child );
	}
	
	void Node::CancelUpdate( Mogre::Node^ child )
	{
		static_cast<Ogre::Node*>(_native)->cancelUpdate( child );
	}
	
	void Node::QueueNeedUpdate( Mogre::Node^ n )
	{
		Ogre::Node::queueNeedUpdate( n );
	}
	
	void Node::ProcessQueuedUpdates( )
	{
		Ogre::Node::processQueuedUpdates( );
	}
	
	
	//Protected Declarations
	
	
	__declspec(dllexport) void _Init_CLRObject_Node(CLRObject* pClrObj)
	{
		*pClrObj = gcnew Mogre::Node(pClrObj);
	}
	
	//################################################################
	//Node_Listener_Proxy
	//################################################################
	
	
	
	void Node_Listener_Proxy::nodeUpdated( const Ogre::Node* param1 )
	{
		if (_overriden[ 0 ])
		{
			_managed->NodeUpdated( param1 );
		}
		else
			Listener::nodeUpdated( param1 );
	}
	
	void Node_Listener_Proxy::nodeDestroyed( const Ogre::Node* param1 )
	{
		if (_overriden[ 1 ])
		{
			_managed->NodeDestroyed( param1 );
		}
		else
			Listener::nodeDestroyed( param1 );
	}
	
	void Node_Listener_Proxy::nodeAttached( const Ogre::Node* param1 )
	{
		if (_overriden[ 2 ])
		{
			_managed->NodeAttached( param1 );
		}
		else
			Listener::nodeAttached( param1 );
	}
	
	void Node_Listener_Proxy::nodeDetached( const Ogre::Node* param1 )
	{
		if (_overriden[ 3 ])
		{
			_managed->NodeDetached( param1 );
		}
		else
			Listener::nodeDetached( param1 );
	}

}
