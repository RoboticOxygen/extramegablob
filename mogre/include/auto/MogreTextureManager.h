/*  This file is produced by the C++/CLI AutoWrapper utility.
        Copyright (c) 2006 by Argiris Kirtzidis  */

#pragma once

#include "OgreTextureManager.h"
#include "MogreResourceManager.h"
#include "MogrePrerequisites.h"
#include "MogreCommon.h"
#include "MogreTexture.h"
#include "MogrePixelFormat.h"

namespace Mogre
{
	//################################################################
	//TextureManager
	//################################################################
	
	public ref class TextureManager : public ResourceManager
	{
		//Nested Types
	
		//Private Declarations
	private protected:
		static TextureManager^ _singleton;
	
		//Internal Declarations
	public protected:
		TextureManager( Ogre::TextureManager* obj ) : ResourceManager(obj)
		{
		}
	
	
		//Public Declarations
	public:
	
		static property TextureManager^ Singleton
		{
			TextureManager^ get()
			{
				Ogre::TextureManager* ptr = Ogre::TextureManager::getSingletonPtr();
				if (_singleton == CLR_NULL || _singleton->_native != ptr)
				{
					if (_singleton != CLR_NULL)
					{
						_singleton->_native = 0;
						_singleton = nullptr;
					}
					if ( ptr ) _singleton = gcnew TextureManager( ptr );
				}
				return _singleton;
			}
		}
	
		property size_t DefaultNumMipmaps
		{
		public:
			size_t get();
		public:
			void set(size_t num);
		}
	
		property Mogre::ushort PreferredFloatBitDepth
		{
		public:
			Mogre::ushort get();
		}
	
		property Mogre::ushort PreferredIntegerBitDepth
		{
		public:
			Mogre::ushort get();
		}
	
		Pair<Mogre::ResourcePtr^, bool> CreateOrRetrieve( String^ name, String^ group, bool isManual, Mogre::IManualResourceLoader^ loader, Mogre::Const_NameValuePairList^ createParams, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma, bool isAlpha, Mogre::PixelFormat desiredFormat, bool hwGammaCorrection );
		Pair<Mogre::ResourcePtr^, bool> CreateOrRetrieve( String^ name, String^ group, bool isManual, Mogre::IManualResourceLoader^ loader, Mogre::Const_NameValuePairList^ createParams, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma, bool isAlpha, Mogre::PixelFormat desiredFormat );
		Pair<Mogre::ResourcePtr^, bool> CreateOrRetrieve( String^ name, String^ group, bool isManual, Mogre::IManualResourceLoader^ loader, Mogre::Const_NameValuePairList^ createParams, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma, bool isAlpha );
		Pair<Mogre::ResourcePtr^, bool> CreateOrRetrieve( String^ name, String^ group, bool isManual, Mogre::IManualResourceLoader^ loader, Mogre::Const_NameValuePairList^ createParams, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma );
		Pair<Mogre::ResourcePtr^, bool> CreateOrRetrieve( String^ name, String^ group, bool isManual, Mogre::IManualResourceLoader^ loader, Mogre::Const_NameValuePairList^ createParams, Mogre::TextureType texType, int numMipmaps );
		Pair<Mogre::ResourcePtr^, bool> CreateOrRetrieve( String^ name, String^ group, bool isManual, Mogre::IManualResourceLoader^ loader, Mogre::Const_NameValuePairList^ createParams, Mogre::TextureType texType );
		Pair<Mogre::ResourcePtr^, bool> CreateOrRetrieve( String^ name, String^ group, bool isManual, Mogre::IManualResourceLoader^ loader, Mogre::Const_NameValuePairList^ createParams );
		Pair<Mogre::ResourcePtr^, bool> CreateOrRetrieve( String^ name, String^ group, bool isManual, Mogre::IManualResourceLoader^ loader );
		Pair<Mogre::ResourcePtr^, bool> CreateOrRetrieve( String^ name, String^ group, bool isManual );
		Pair<Mogre::ResourcePtr^, bool> CreateOrRetrieve( String^ name, String^ group );
	
		Mogre::TexturePtr^ Prepare( String^ name, String^ group, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma, bool isAlpha, Mogre::PixelFormat desiredFormat, bool hwGammaCorrection );
		Mogre::TexturePtr^ Prepare( String^ name, String^ group, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma, bool isAlpha, Mogre::PixelFormat desiredFormat );
		Mogre::TexturePtr^ Prepare( String^ name, String^ group, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma, bool isAlpha );
		Mogre::TexturePtr^ Prepare( String^ name, String^ group, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma );
		Mogre::TexturePtr^ Prepare( String^ name, String^ group, Mogre::TextureType texType, int numMipmaps );
		Mogre::TexturePtr^ Prepare( String^ name, String^ group, Mogre::TextureType texType );
		Mogre::TexturePtr^ Prepare( String^ name, String^ group );
	
		Mogre::TexturePtr^ Load( String^ name, String^ group, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma, bool isAlpha, Mogre::PixelFormat desiredFormat, bool hwGammaCorrection );
		Mogre::TexturePtr^ Load( String^ name, String^ group, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma, bool isAlpha, Mogre::PixelFormat desiredFormat );
		Mogre::TexturePtr^ Load( String^ name, String^ group, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma, bool isAlpha );
		Mogre::TexturePtr^ Load( String^ name, String^ group, Mogre::TextureType texType, int numMipmaps, Mogre::Real gamma );
		Mogre::TexturePtr^ Load( String^ name, String^ group, Mogre::TextureType texType, int numMipmaps );
		Mogre::TexturePtr^ Load( String^ name, String^ group, Mogre::TextureType texType );
		Mogre::TexturePtr^ Load( String^ name, String^ group );
	
		Mogre::TexturePtr^ LoadImage( String^ name, String^ group, Mogre::Image^ img, Mogre::TextureType texType, int iNumMipmaps, Mogre::Real gamma, bool isAlpha, Mogre::PixelFormat desiredFormat, bool hwGammaCorrection );
		Mogre::TexturePtr^ LoadImage( String^ name, String^ group, Mogre::Image^ img, Mogre::TextureType texType, int iNumMipmaps, Mogre::Real gamma, bool isAlpha, Mogre::PixelFormat desiredFormat );
		Mogre::TexturePtr^ LoadImage( String^ name, String^ group, Mogre::Image^ img, Mogre::TextureType texType, int iNumMipmaps, Mogre::Real gamma, bool isAlpha );
		Mogre::TexturePtr^ LoadImage( String^ name, String^ group, Mogre::Image^ img, Mogre::TextureType texType, int iNumMipmaps, Mogre::Real gamma );
		Mogre::TexturePtr^ LoadImage( String^ name, String^ group, Mogre::Image^ img, Mogre::TextureType texType, int iNumMipmaps );
		Mogre::TexturePtr^ LoadImage( String^ name, String^ group, Mogre::Image^ img, Mogre::TextureType texType );
		Mogre::TexturePtr^ LoadImage( String^ name, String^ group, Mogre::Image^ img );
	
		Mogre::TexturePtr^ LoadRawData( String^ name, String^ group, Mogre::DataStreamPtr^ stream, Mogre::ushort uWidth, Mogre::ushort uHeight, Mogre::PixelFormat format, Mogre::TextureType texType, int iNumMipmaps, Mogre::Real gamma, bool hwGammaCorrection );
		Mogre::TexturePtr^ LoadRawData( String^ name, String^ group, Mogre::DataStreamPtr^ stream, Mogre::ushort uWidth, Mogre::ushort uHeight, Mogre::PixelFormat format, Mogre::TextureType texType, int iNumMipmaps, Mogre::Real gamma );
		Mogre::TexturePtr^ LoadRawData( String^ name, String^ group, Mogre::DataStreamPtr^ stream, Mogre::ushort uWidth, Mogre::ushort uHeight, Mogre::PixelFormat format, Mogre::TextureType texType, int iNumMipmaps );
		Mogre::TexturePtr^ LoadRawData( String^ name, String^ group, Mogre::DataStreamPtr^ stream, Mogre::ushort uWidth, Mogre::ushort uHeight, Mogre::PixelFormat format, Mogre::TextureType texType );
		Mogre::TexturePtr^ LoadRawData( String^ name, String^ group, Mogre::DataStreamPtr^ stream, Mogre::ushort uWidth, Mogre::ushort uHeight, Mogre::PixelFormat format );
	
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, Mogre::uint depth, int num_mips, Mogre::PixelFormat format, int usage, Mogre::IManualResourceLoader^ loader, bool hwGammaCorrection, Mogre::uint fsaa, String^ fsaaHint );
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, Mogre::uint depth, int num_mips, Mogre::PixelFormat format, int usage, Mogre::IManualResourceLoader^ loader, bool hwGammaCorrection, Mogre::uint fsaa );
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, Mogre::uint depth, int num_mips, Mogre::PixelFormat format, int usage, Mogre::IManualResourceLoader^ loader, bool hwGammaCorrection );
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, Mogre::uint depth, int num_mips, Mogre::PixelFormat format, int usage, Mogre::IManualResourceLoader^ loader );
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, Mogre::uint depth, int num_mips, Mogre::PixelFormat format, int usage );
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, Mogre::uint depth, int num_mips, Mogre::PixelFormat format );
	
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, int num_mips, Mogre::PixelFormat format, int usage, Mogre::IManualResourceLoader^ loader, bool hwGammaCorrection, Mogre::uint fsaa, String^ fsaaHint );
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, int num_mips, Mogre::PixelFormat format, int usage, Mogre::IManualResourceLoader^ loader, bool hwGammaCorrection, Mogre::uint fsaa );
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, int num_mips, Mogre::PixelFormat format, int usage, Mogre::IManualResourceLoader^ loader, bool hwGammaCorrection );
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, int num_mips, Mogre::PixelFormat format, int usage, Mogre::IManualResourceLoader^ loader );
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, int num_mips, Mogre::PixelFormat format, int usage );
		Mogre::TexturePtr^ CreateManual( String^ name, String^ group, Mogre::TextureType texType, Mogre::uint width, Mogre::uint height, int num_mips, Mogre::PixelFormat format );
	
		void SetPreferredIntegerBitDepth( Mogre::ushort bits, bool reloadTextures );
		void SetPreferredIntegerBitDepth( Mogre::ushort bits );
	
		void SetPreferredFloatBitDepth( Mogre::ushort bits, bool reloadTextures );
		void SetPreferredFloatBitDepth( Mogre::ushort bits );
	
		void SetPreferredBitDepths( Mogre::ushort integerBits, Mogre::ushort floatBits, bool reloadTextures );
		void SetPreferredBitDepths( Mogre::ushort integerBits, Mogre::ushort floatBits );
	
		bool IsFormatSupported( Mogre::TextureType ttype, Mogre::PixelFormat format, int usage );
	
		bool IsEquivalentFormatSupported( Mogre::TextureType ttype, Mogre::PixelFormat format, int usage );
	
		Mogre::PixelFormat GetNativeFormat( Mogre::TextureType ttype, Mogre::PixelFormat format, int usage );
	
		bool IsHardwareFilteringSupported( Mogre::TextureType ttype, Mogre::PixelFormat format, int usage, bool preciseFormatOnly );
		bool IsHardwareFilteringSupported( Mogre::TextureType ttype, Mogre::PixelFormat format, int usage );
	
	
		//Protected Declarations
	protected public:
	
	};
	

}
