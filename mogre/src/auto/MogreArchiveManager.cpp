/*  This file is produced by the C++/CLI AutoWrapper utility.
        Copyright (c) 2006 by Argiris Kirtzidis  */

#include "MogreStableHeaders.h"

#include "MogreArchiveManager.h"
#include "MogreArchive.h"

namespace Mogre
{
	//################################################################
	//ArchiveManager
	//################################################################
	
	//Nested Types
	CPP_DECLARE_MAP_ITERATOR_NOCONSTRUCTOR( ArchiveManager::, ArchiveMapIterator, Ogre::ArchiveManager::ArchiveMapIterator, Mogre::ArchiveManager::ArchiveMap, Mogre::Archive^, Ogre::Archive*, String^, Ogre::String )
	
	//Private Declarations
	
	//Internal Declarations
	
	//Public Declarations
	ArchiveManager::ArchiveManager( )
	{
		_createdByCLR = true;
		_native = new Ogre::ArchiveManager();
	}
	
	Mogre::Archive^ ArchiveManager::Load( String^ filename, String^ archiveType )
	{
		DECLARE_NATIVE_STRING( o_filename, filename )
		DECLARE_NATIVE_STRING( o_archiveType, archiveType )
	
		return static_cast<Ogre::ArchiveManager*>(_native)->load( o_filename, o_archiveType );
	}
	
	void ArchiveManager::Unload( Mogre::Archive^ arch )
	{
		static_cast<Ogre::ArchiveManager*>(_native)->unload( arch );
	}
	
	void ArchiveManager::Unload( String^ filename )
	{
		DECLARE_NATIVE_STRING( o_filename, filename )
	
		static_cast<Ogre::ArchiveManager*>(_native)->unload( o_filename );
	}
	
	Mogre::ArchiveManager::ArchiveMapIterator^ ArchiveManager::GetArchiveIterator( )
	{
		return static_cast<Ogre::ArchiveManager*>(_native)->getArchiveIterator( );
	}
	
	
	//Protected Declarations
	
	
	

}
