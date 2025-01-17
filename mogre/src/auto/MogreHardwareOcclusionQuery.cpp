/*  This file is produced by the C++/CLI AutoWrapper utility.
        Copyright (c) 2006 by Argiris Kirtzidis  */

#include "MogreStableHeaders.h"

#include "MogreHardwareOcclusionQuery.h"

namespace Mogre
{
	//################################################################
	//HardwareOcclusionQuery
	//################################################################
	
	//Nested Types
	//Private Declarations
	
	//Internal Declarations
	
	//Public Declarations
	bool HardwareOcclusionQuery::IsStillOutstanding::get()
	{
		return static_cast<Ogre::HardwareOcclusionQuery*>(_native)->isStillOutstanding( );
	}
	
	unsigned int HardwareOcclusionQuery::LastQuerysPixelcount::get()
	{
		return static_cast<const Ogre::HardwareOcclusionQuery*>(_native)->getLastQuerysPixelcount( );
	}
	
	void HardwareOcclusionQuery::_Init_CLRObject( )
	{
		static_cast<Ogre::HardwareOcclusionQuery*>(_native)->_Init_CLRObject( );
	}
	
	void HardwareOcclusionQuery::BeginOcclusionQuery( )
	{
		static_cast<Ogre::HardwareOcclusionQuery*>(_native)->beginOcclusionQuery( );
	}
	
	void HardwareOcclusionQuery::EndOcclusionQuery( )
	{
		static_cast<Ogre::HardwareOcclusionQuery*>(_native)->endOcclusionQuery( );
	}
	
	bool HardwareOcclusionQuery::PullOcclusionQuery( [Out] unsigned int% NumOfFragments )
	{
		pin_ptr<unsigned int> p_NumOfFragments = &NumOfFragments;
	
		return static_cast<Ogre::HardwareOcclusionQuery*>(_native)->pullOcclusionQuery( p_NumOfFragments );
	}
	
	
	//Protected Declarations
	
	
	__declspec(dllexport) void _Init_CLRObject_HardwareOcclusionQuery(CLRObject* pClrObj)
	{
		*pClrObj = gcnew Mogre::HardwareOcclusionQuery(pClrObj);
	}
	

}
