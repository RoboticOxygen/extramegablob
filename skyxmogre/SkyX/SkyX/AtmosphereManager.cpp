/*
--------------------------------------------------------------------------------
This source file is part of SkyX.
Visit ---

Copyright (C) 2009 Xavier Vergu�n Gonz�lez <xavierverguin@hotmail.com>
                                           <xavyiy@gmail.com>

This program is free software; you can redistribute it and/or modify it under
the terms of the GNU Lesser General Public License as published by the Free Software
Foundation; either version 2 of the License, or (at your option) any later
version.

This program is distributed in the hope that it will be useful, but WITHOUT
ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License along with
this program; if not, write to the Free Software Foundation, Inc., 59 Temple
Place - Suite 330, Boston, MA 02111-1307, USA, or go to
http://www.gnu.org/copyleft/lesser.txt.
--------------------------------------------------------------------------------
*/

#include "AtmosphereManager.h"

#include "SkyX.h"

#include "GPUManager.h"

namespace SkyX
{
	AtmosphereManager::AtmosphereManager(SkyX *s)
		: mSkyX(s)
		, mOptions(Options())
	{
	}

	AtmosphereManager::~AtmosphereManager()
	{
	}

	void AtmosphereManager::_update(const Options& NewOptions, const bool& ForceToUpdateAll)
	{
		GPUManager *mGPUManager = mSkyX->getGPUManager();

		if (NewOptions.Time != mOptions.Time || 
			NewOptions.EastPosition != mOptions.EastPosition ||
			ForceToUpdateAll)
		{
			mOptions.Time = NewOptions.Time;
			mOptions.EastPosition = NewOptions.EastPosition;

			if (mSkyX->isStarfieldEnabled())
			{
				mGPUManager->setGpuProgramParameter(GPUManager::GPUP_FRAGMENT, "uTime", mSkyX->_getTimeOffset()*0.5f, false);
			}

			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uLightDir", -getSunDirection());
			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_FRAGMENT, "uLightDir", -getSunDirection(), false);

			mSkyX->getMoonManager()->update();
		}

		if (NewOptions.InnerRadius != mOptions.InnerRadius || 
			NewOptions.OuterRadius != mOptions.OuterRadius ||
			ForceToUpdateAll)
		{
			mOptions.InnerRadius = NewOptions.InnerRadius;
			mOptions.OuterRadius = NewOptions.OuterRadius;

			float Scale = 1.0f / (mOptions.OuterRadius - mOptions.InnerRadius),
				  ScaleDepth = (mOptions.OuterRadius - mOptions.InnerRadius) / 2.0f,
				  ScaleOverScaleDepth = Scale / ScaleDepth;

			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uInnerRadius", mOptions.InnerRadius);
			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uCameraPos", Ogre::Vector3(0, mOptions.InnerRadius + (mOptions.OuterRadius-mOptions.InnerRadius)*mOptions.HeightPosition, 0));

			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uScale", Scale);
			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uScaleDepth", ScaleDepth);
			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uScaleOverScaleDepth", ScaleOverScaleDepth);
		}

		if (NewOptions.HeightPosition != mOptions.HeightPosition ||
			ForceToUpdateAll)
		{
			mOptions.HeightPosition = NewOptions.HeightPosition;

			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uCameraPos", Ogre::Vector3(0, mOptions.InnerRadius + (mOptions.OuterRadius-mOptions.InnerRadius)*mOptions.HeightPosition, 0));
		}

		if (NewOptions.RayleighMultiplier != mOptions.RayleighMultiplier ||
			NewOptions.SunIntensity       != mOptions.SunIntensity       ||
			ForceToUpdateAll)
		{
			mOptions.RayleighMultiplier = NewOptions.RayleighMultiplier;

			float Kr4PI  = mOptions.RayleighMultiplier * 4.0f * Ogre::Math::PI,
				  KrESun = mOptions.RayleighMultiplier * mOptions.SunIntensity;

            mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uKr4PI", Kr4PI);
			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uKrESun", KrESun);
		}

		if (NewOptions.MieMultiplier != mOptions.MieMultiplier ||
			NewOptions.SunIntensity  != mOptions.SunIntensity  ||
			ForceToUpdateAll)
		{
			mOptions.MieMultiplier = NewOptions.MieMultiplier;

			float Km4PI  = mOptions.MieMultiplier * 4.0f * Ogre::Math::PI,
				  KmESun = mOptions.MieMultiplier * mOptions.SunIntensity;

            mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uKm4PI", Km4PI);
			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uKmESun", KmESun, false);
		}

		if (NewOptions.NumberOfSamples != mOptions.NumberOfSamples ||
			ForceToUpdateAll)
		{
			mOptions.NumberOfSamples = NewOptions.NumberOfSamples;

			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uNumberOfSamples", mOptions.NumberOfSamples);
			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uSamples", static_cast<Ogre::Real>(mOptions.NumberOfSamples));
		}

		if (NewOptions.WaveLength != mOptions.WaveLength ||
			ForceToUpdateAll)
		{
			mOptions.WaveLength = NewOptions.WaveLength;

			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_VERTEX, "uInvWaveLength", 
				Ogre::Vector3(1.0f / Ogre::Math::Pow(mOptions.WaveLength.x, 4.0f),
				              1.0f / Ogre::Math::Pow(mOptions.WaveLength.y, 4.0f),
				              1.0f / Ogre::Math::Pow(mOptions.WaveLength.z, 4.0f)));
		}

		if (NewOptions.G != mOptions.G ||
			ForceToUpdateAll)
		{
			mOptions.G = NewOptions.G;

			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_FRAGMENT, "uG", mOptions.G, false);
			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_FRAGMENT, "uG2", mOptions.G*mOptions.G, false);
		}

		if ((NewOptions.Exposure != mOptions.Exposure ||
			ForceToUpdateAll) && 
			(mSkyX->getLightingMode() == SkyX::LM_LDR))
		{
			mOptions.Exposure = NewOptions.Exposure;

			mGPUManager->setGpuProgramParameter(GPUManager::GPUP_FRAGMENT, "uExposure", mOptions.Exposure);
		}

		mSkyX->getCloudsManager()->_updateInternal();
	}

	const float AtmosphereManager::_scale(const float& cos, const float& uScaleDepth) const
	{
		float x = 1.0 - cos;
		return uScaleDepth * Ogre::Math::Exp(-0.00287 + x*(0.459 + x*(3.83 + x*(-6.80 + x*5.25))));
	}

	const Ogre::Vector3 AtmosphereManager::getColorAt(const Ogre::Vector3& Direction) const
	{
		if (Direction.y<0)
		{
			return Ogre::Vector3(0,0,0);
		}
		
		// Parameters
		double Scale = 1.0f / (mOptions.OuterRadius - mOptions.InnerRadius),
			   ScaleDepth = (mOptions.OuterRadius - mOptions.InnerRadius) / 2.0f,
		       ScaleOverScaleDepth = Scale / ScaleDepth,
			   Kr4PI  = mOptions.RayleighMultiplier * 4.0f * Ogre::Math::PI,
			   KrESun = mOptions.RayleighMultiplier * mOptions.SunIntensity,
			   Km4PI  = mOptions.MieMultiplier * 4.0f * Ogre::Math::PI,
			   KmESun = mOptions.MieMultiplier * mOptions.SunIntensity;

		// --- Start vertex program simulation ---
		Ogre::Vector3
			uLightDir = -getSunDirection(),
			v3Pos = Direction,
			uCameraPos = Ogre::Vector3(0, mOptions.InnerRadius + (mOptions.OuterRadius-mOptions.InnerRadius)*mOptions.HeightPosition, 0),
			uInvWaveLength = Ogre::Vector3(
			                    1.0f / Ogre::Math::Pow(mOptions.WaveLength.x, 4.0f),
			                    1.0f / Ogre::Math::Pow(mOptions.WaveLength.y, 4.0f),
		   	                    1.0f / Ogre::Math::Pow(mOptions.WaveLength.z, 4.0f));

		// Get the ray from the camera to the vertex, and it's length (far point)
		v3Pos.y += mOptions.InnerRadius;
		Ogre::Vector3 v3Ray = v3Pos - uCameraPos;
		double fFar = v3Ray.length();
		v3Ray /= fFar;

		// Calculate the ray's starting position, then calculate its scattering offset
		Ogre::Vector3 v3Start = uCameraPos;
		double fHeight = uCameraPos.y,
		       fStartAngle = v3Ray.dotProduct(v3Start) / fHeight,
		       fDepth = Ogre::Math::Exp(ScaleOverScaleDepth * (mOptions.InnerRadius - uCameraPos.y)),
		       fStartOffset = fDepth * _scale(fStartAngle, ScaleDepth);

		// Init loop variables
		double fSampleLength = fFar /(double)mOptions.NumberOfSamples,
		       fScaledLength = fSampleLength * Scale,
			   fHeight_, fDepth_, fLightAngle, fCameraAngle, fScatter;
		Ogre::Vector3 v3SampleRay = v3Ray * fSampleLength,
		              v3SamplePoint = v3Start + v3SampleRay * 0.5f,
					  color, v3Attenuate;

        // Loop the ray
		for (int i = 0; i < mOptions.NumberOfSamples; i++)
		{
			fHeight_ = v3SamplePoint.length();
			fDepth_ = Ogre::Math::Exp(ScaleOverScaleDepth * (mOptions.InnerRadius-fHeight_));

			fLightAngle = uLightDir.dotProduct(v3SamplePoint) / fHeight_;
			fCameraAngle = v3Ray.dotProduct(v3SamplePoint) / fHeight_;

			fScatter = (fStartOffset + fDepth*(_scale(fLightAngle, ScaleDepth) - _scale(fCameraAngle, ScaleDepth)));

			v3Attenuate = Ogre::Vector3(
				Ogre::Math::Exp(-fScatter * (uInvWaveLength.x * Kr4PI + Km4PI)),
				Ogre::Math::Exp(-fScatter * (uInvWaveLength.y * Kr4PI + Km4PI)),
				Ogre::Math::Exp(-fScatter * (uInvWaveLength.z * Kr4PI + Km4PI)));

			// Accumulate color
			v3Attenuate *= (fDepth_ * fScaledLength);
			color += v3Attenuate;

			// Next sample point
			v3SamplePoint += v3SampleRay;
		}

		// Outputs
		Ogre::Vector3 oRayleighColor = color * (uInvWaveLength * KrESun),
		              oMieColor      = color * KmESun,
		              oDirection     = uCameraPos - v3Pos;

		// --- End vertex program simulation ---
		// --- Start fragment program simulation ---

		double cos = uLightDir.dotProduct(oDirection) / oDirection.length(),
		       cos2 = cos*cos,
		       rayleighPhase = 0.75 * (1.0 + 0.5*cos2),
			   g2 = mOptions.G*mOptions.G,
		       miePhase = 1.5f * ((1.0f - g2) / (2.0f + g2)) * 
			            (1.0f + cos2) / Ogre::Math::Pow(1.0f + g2 - 2.0f * mOptions.G * cos, 1.5f);

		Ogre::Vector3 oColor;

		if (mSkyX->getLightingMode() == SkyX::LM_LDR)
		{
			oColor = Ogre::Vector3(
				1 - Ogre::Math::Exp(-mOptions.Exposure * (rayleighPhase * oRayleighColor.x + miePhase * oMieColor.x)),
				1 - Ogre::Math::Exp(-mOptions.Exposure * (rayleighPhase * oRayleighColor.y + miePhase * oMieColor.y)),
				1 - Ogre::Math::Exp(-mOptions.Exposure * (rayleighPhase * oRayleighColor.z + miePhase * oMieColor.z)));
		}
		else
		{
			oColor = rayleighPhase * oRayleighColor + miePhase * oMieColor;
		}

		// For night rendering
		oColor += Ogre::Math::Clamp<Ogre::Real>(((1 - std::max(oColor.x, std::max(oColor.y, oColor.z))*10)), 0, 1) 
			* (Ogre::Vector3(0.05, 0.05, 0.1)
			* (2-0.75f*Ogre::Math::Clamp<Ogre::Real>(-uLightDir.y, 0, 1)) * Ogre::Math::Pow(1-Direction.y, 3));

		// --- End fragment program simulation ---

		// Output color
		return oColor;
	}

	const Ogre::Vector3 AtmosphereManager::getSunDirection() const
	{
		// 24h day: 
		// 0______A(Sunrise)_______B(Sunset)______24
		//                     

		float y,
			X = mOptions.Time.x,
			A = mOptions.Time.y,
			B = mOptions.Time.z,
			AB  = A+24-B,
			AB_ = B-A,
			XB  = X+24-B;

		if (X<A || X>B)
		{
			if (X<A)
			{
                y = -XB / AB;
			}
			else
			{
				y = -(X-B) / AB;
			}
            
			if (y > -0.5f)
			{
				y *= 2;
			}
			else
			{
				y = -(1 + y)*2;
			}
		}
		else
		{
			y = (X-A)/(B-A);

			if (y < 0.5f)
			{
				y *= 2;
			}
			else
			{
				y = (1 - y)*2;
			}
		}

		Ogre::Vector2 East = mOptions.EastPosition.normalisedCopy();

		if (X > A && X < B)
		{
			if (X > (A + AB_/2))
			{
				East = -East;
			}
		}
		else
		{
			if (X<A)
			{
				if (XB < (24-AB_)/2)
				{
					East = -East;
				}
			}
			else
			{
				if ((X-B) < (24-AB_)/2)
				{
					East = -East;
				}
			}
		}

		float ydeg = (Ogre::Math::PI/2)*y,
		      sn = Ogre::Math::Sin(ydeg),
		      cs = Ogre::Math::Cos(ydeg);

		Ogre::Vector3 SPos = Ogre::Vector3(East.x*cs, sn, East.y*cs);

		return -SPos;
	}

	const Ogre::Vector3 AtmosphereManager::getSunPosition() const
	{
		return mSkyX->getCamera()->getDerivedPosition() - getSunDirection()*mSkyX->getMeshManager()->getSkydomeRadius();
	}
}
EXPORT const Ogre::Vector3& AtmosphereManager_GetSunPosition(SkyX::AtmosphereManager* ptr)
{
	return ptr->getSunPosition();
}

EXPORT const Ogre::Vector3& AtmosphereManager_GetTime(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().Time;
}

EXPORT const Ogre::Vector2& AtmosphereManager_GetEastPosition(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().EastPosition;
}

EXPORT float AtmosphereManager_GetInnerRadius(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().InnerRadius;
}

EXPORT float AtmosphereManager_GetOuterRadius(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().OuterRadius;
}

EXPORT float AtmosphereManager_GetHeightPosition(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().HeightPosition;
}

EXPORT float AtmosphereManager_GetRayleighMultiplier(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().RayleighMultiplier;
}

EXPORT float AtmosphereManager_GetMieMultiplier(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().MieMultiplier;
}

EXPORT float AtmosphereManager_GetSunIntensity(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().SunIntensity;
}

EXPORT const Ogre::Vector3& AtmosphereManager_GetWaveLength(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().WaveLength;
}

EXPORT float AtmosphereManager_GetG(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().G;
}

EXPORT float AtmosphereManager_GetExposure(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().Exposure;
}


EXPORT int AtmosphereManager_GetNumberOfSamples(SkyX::AtmosphereManager* ptr)
{
	return ptr->getOptions().NumberOfSamples;
}
