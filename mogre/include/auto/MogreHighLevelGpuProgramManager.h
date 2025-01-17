/*  This file is produced by the C++/CLI AutoWrapper utility.
        Copyright (c) 2006 by Argiris Kirtzidis  */

#pragma once

#include "OgreHighLevelGpuProgramManager.h"
#include "MogreResourceManager.h"
#include "MogrePrerequisites.h"
#include "MogreGpuProgram.h"

namespace Mogre
{
	//################################################################
	//HighLevelGpuProgramManager
	//################################################################
	
	public ref class HighLevelGpuProgramManager : public ResourceManager
	{
		//Nested Types
		public: ref class FactoryMap;
	
		//Private Declarations
	private protected:
		static HighLevelGpuProgramManager^ _singleton;
	
		//Internal Declarations
	public protected:
		HighLevelGpuProgramManager( Ogre::HighLevelGpuProgramManager* obj ) : ResourceManager(obj)
		{
		}
	
	
		//Public Declarations
	public:
		HighLevelGpuProgramManager( );
	
		static property HighLevelGpuProgramManager^ Singleton
		{
			HighLevelGpuProgramManager^ get()
			{
				Ogre::HighLevelGpuProgramManager* ptr = Ogre::HighLevelGpuProgramManager::getSingletonPtr();
				if (_singleton == CLR_NULL || _singleton->_native != ptr)
				{
					if (_singleton != CLR_NULL)
					{
						_singleton->_native = 0;
						_singleton = nullptr;
					}
					if ( ptr ) _singleton = gcnew HighLevelGpuProgramManager( ptr );
				}
				return _singleton;
			}
		}
	
		bool IsLanguageSupported( String^ lang );
	
		Mogre::HighLevelGpuProgramPtr^ CreateProgram( String^ name, String^ groupName, String^ language, Mogre::GpuProgramType gptype );
	
	
		//Protected Declarations
	protected public:
	
	};
	

}
