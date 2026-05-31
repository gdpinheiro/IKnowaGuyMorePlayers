using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class DayNightCycleController : MonoBehaviour
{
	public enum ColorPresetMode
	{
		BuiltIn,
		Custom,
		Manual
	}

	private static readonly IntPtr NativeFieldInfoPtr_mainLight;

	private static readonly IntPtr NativeFieldInfoPtr_autoFindLight;

	private static readonly IntPtr NativeFieldInfoPtr_lightRotationY;

	private static readonly IntPtr NativeFieldInfoPtr_sunriseHour;

	private static readonly IntPtr NativeFieldInfoPtr_sunsetHour;

	private static readonly IntPtr NativeFieldInfoPtr_transitionDuration;

	private static readonly IntPtr NativeFieldInfoPtr_sunMaxIntensity;

	private static readonly IntPtr NativeFieldInfoPtr_sunIntensityCurve;

	private static readonly IntPtr NativeFieldInfoPtr_moonMaxIntensity;

	private static readonly IntPtr NativeFieldInfoPtr_moonIntensityCurve;

	private static readonly IntPtr NativeFieldInfoPtr_moonLightColor;

	private static readonly IntPtr NativeFieldInfoPtr_controlIntensity;

	private static readonly IntPtr NativeFieldInfoPtr_controlColor;

	private static readonly IntPtr NativeFieldInfoPtr_controlAmbientColor;

	private static readonly IntPtr NativeFieldInfoPtr_dayAmbientColor;

	private static readonly IntPtr NativeFieldInfoPtr_nightAmbientColor;

	private static readonly IntPtr NativeFieldInfoPtr_ambientTransitionCurve;

	private static readonly IntPtr NativeFieldInfoPtr_skyboxMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_controlSkybox;

	private static readonly IntPtr NativeFieldInfoPtr_daySkyTop;

	private static readonly IntPtr NativeFieldInfoPtr_daySkyBottom;

	private static readonly IntPtr NativeFieldInfoPtr_dayHorizonColor;

	private static readonly IntPtr NativeFieldInfoPtr_dayCloudEdge;

	private static readonly IntPtr NativeFieldInfoPtr_dayCloudMain;

	private static readonly IntPtr NativeFieldInfoPtr_nightSkyTop;

	private static readonly IntPtr NativeFieldInfoPtr_nightSkyBottom;

	private static readonly IntPtr NativeFieldInfoPtr_nightHorizonColor;

	private static readonly IntPtr NativeFieldInfoPtr_nightCloudEdge;

	private static readonly IntPtr NativeFieldInfoPtr_nightCloudMain;

	private static readonly IntPtr NativeFieldInfoPtr_sunSkyColor;

	private static readonly IntPtr NativeFieldInfoPtr_skyMoonColor;

	private static readonly IntPtr NativeFieldInfoPtr_starsSkyColor;

	private static readonly IntPtr NativeFieldInfoPtr_colorPresetMode;

	private static readonly IntPtr NativeFieldInfoPtr_builtInPreset;

	private static readonly IntPtr NativeFieldInfoPtr_customGradientPreset;

	private static readonly IntPtr NativeFieldInfoPtr_dayNightColorGradient;

	private static readonly IntPtr NativeFieldInfoPtr_dayAmbientSources;

	private static readonly IntPtr NativeFieldInfoPtr_daySourceMaxVolumes;

	private static readonly IntPtr NativeFieldInfoPtr_nightAmbientSources;

	private static readonly IntPtr NativeFieldInfoPtr_nightSourceMaxVolumes;

	private static readonly IntPtr NativeFieldInfoPtr_audioTransitionSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_showGizmos;

	private static readonly IntPtr NativeFieldInfoPtr_gizmoRadius;

	private static readonly IntPtr NativeFieldInfoPtr_debugRotationX;

	private static readonly IntPtr NativeFieldInfoPtr_isCurrentlySun;

	private static readonly IntPtr NativeFieldInfoPtr_timeManager;

	private static readonly IntPtr NativeFieldInfoPtr_ambientAudioMuted;

	private static readonly IntPtr NativeFieldInfoPtr_dayLength;

	private static readonly IntPtr NativeFieldInfoPtr_nightLength;

	private static readonly IntPtr NativeFieldInfoPtr_halfTransition;

	private static readonly IntPtr NativeFieldInfoPtr_UpdateInterval;

	private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastUpdate;

	private static readonly IntPtr NativeFieldInfoPtr__DayTopColor;

	private static readonly IntPtr NativeFieldInfoPtr__NightTopColor;

	private static readonly IntPtr NativeFieldInfoPtr__DayBottomColor;

	private static readonly IntPtr NativeFieldInfoPtr__NightBottomColor;

	private static readonly IntPtr NativeFieldInfoPtr__HorizonColorDay;

	private static readonly IntPtr NativeFieldInfoPtr__HorizonColorNight;

	private static readonly IntPtr NativeFieldInfoPtr__CloudColorDayEdge;

	private static readonly IntPtr NativeFieldInfoPtr__CloudColorNightEdge;

	private static readonly IntPtr NativeFieldInfoPtr__CloudColorDayMain;

	private static readonly IntPtr NativeFieldInfoPtr__CloudColorNightMain;

	private static readonly IntPtr NativeFieldInfoPtr__SunColorID;

	private static readonly IntPtr NativeFieldInfoPtr__MoonColorID;

	private static readonly IntPtr NativeFieldInfoPtr__StarsSkyColorID;

	private static readonly IntPtr NativeFieldInfoPtr_lastNightBlend;

	private static readonly IntPtr NativeFieldInfoPtr_lastDayFadeValue;

	private static readonly IntPtr NativeFieldInfoPtr_lastNightFadeValue;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsTimeLoading_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CacheTiming_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ComputePhase_Private_Void_Single_byref_Boolean_byref_Single_byref_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateLight_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateEnvironment_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateAmbientColor_Private_Void_Single_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalculateNightBlend_Private_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplySkyboxColors_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_CacheAmbientAudioVolumes_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateAmbientAudio_Private_Void_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetAmbientAudioMuted_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsDaytime_Public_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetBuiltInPreset_Public_Void_PresetType_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeGradient_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Light mainLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light));
		}
	}

	public unsafe bool autoFindLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoFindLight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoFindLight)) = flag;
		}
	}

	public unsafe float lightRotationY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightRotationY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightRotationY)) = num;
		}
	}

	public unsafe float sunriseHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunriseHour);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunriseHour)) = num;
		}
	}

	public unsafe float sunsetHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunsetHour);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunsetHour)) = num;
		}
	}

	public unsafe float transitionDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionDuration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionDuration)) = num;
		}
	}

	public unsafe float sunMaxIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunMaxIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunMaxIntensity)) = num;
		}
	}

	public unsafe AnimationCurve sunIntensityCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunIntensityCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunIntensityCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float moonMaxIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moonMaxIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moonMaxIntensity)) = num;
		}
	}

	public unsafe AnimationCurve moonIntensityCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moonIntensityCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moonIntensityCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Color moonLightColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moonLightColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moonLightColor)) = color;
		}
	}

	public unsafe bool controlIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlIntensity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlIntensity)) = flag;
		}
	}

	public unsafe bool controlColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlColor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlColor)) = flag;
		}
	}

	public unsafe bool controlAmbientColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlAmbientColor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlAmbientColor)) = flag;
		}
	}

	public unsafe Color dayAmbientColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayAmbientColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayAmbientColor)) = color;
		}
	}

	public unsafe Color nightAmbientColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightAmbientColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightAmbientColor)) = color;
		}
	}

	public unsafe AnimationCurve ambientTransitionCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientTransitionCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientTransitionCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Material skyboxMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyboxMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyboxMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe bool controlSkybox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlSkybox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlSkybox)) = flag;
		}
	}

	public unsafe Color daySkyTop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daySkyTop);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daySkyTop)) = color;
		}
	}

	public unsafe Color daySkyBottom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daySkyBottom);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daySkyBottom)) = color;
		}
	}

	public unsafe Color dayHorizonColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayHorizonColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayHorizonColor)) = color;
		}
	}

	public unsafe Color dayCloudEdge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayCloudEdge);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayCloudEdge)) = color;
		}
	}

	public unsafe Color dayCloudMain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayCloudMain);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayCloudMain)) = color;
		}
	}

	public unsafe Color nightSkyTop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightSkyTop);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightSkyTop)) = color;
		}
	}

	public unsafe Color nightSkyBottom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightSkyBottom);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightSkyBottom)) = color;
		}
	}

	public unsafe Color nightHorizonColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightHorizonColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightHorizonColor)) = color;
		}
	}

	public unsafe Color nightCloudEdge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightCloudEdge);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightCloudEdge)) = color;
		}
	}

	public unsafe Color nightCloudMain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightCloudMain);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightCloudMain)) = color;
		}
	}

	public unsafe Color sunSkyColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunSkyColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunSkyColor)) = color;
		}
	}

	public unsafe Color skyMoonColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyMoonColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyMoonColor)) = color;
		}
	}

	public unsafe Color starsSkyColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starsSkyColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starsSkyColor)) = color;
		}
	}

	public unsafe ColorPresetMode colorPresetMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorPresetMode);
			return *(ColorPresetMode*)num;
		}
		set
		{
			*(ColorPresetMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorPresetMode)) = colorPresetMode;
		}
	}

	public unsafe SunGradientPresets.PresetType builtInPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builtInPreset);
			return *(SunGradientPresets.PresetType*)num;
		}
		set
		{
			*(SunGradientPresets.PresetType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builtInPreset)) = presetType;
		}
	}

	public unsafe SunGradientPreset customGradientPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customGradientPreset);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SunGradientPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customGradientPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sunGradientPreset));
		}
	}

	public unsafe Gradient dayNightColorGradient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayNightColorGradient);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Gradient>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayNightColorGradient)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gradient));
		}
	}

	public unsafe List<AudioSource> dayAmbientSources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayAmbientSources);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AudioSource>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayAmbientSources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> daySourceMaxVolumes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daySourceMaxVolumes);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daySourceMaxVolumes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AudioSource> nightAmbientSources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightAmbientSources);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AudioSource>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightAmbientSources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> nightSourceMaxVolumes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightSourceMaxVolumes);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightSourceMaxVolumes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float audioTransitionSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioTransitionSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioTransitionSpeed)) = num;
		}
	}

	public unsafe bool showGizmos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showGizmos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showGizmos)) = flag;
		}
	}

	public unsafe float gizmoRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoRadius)) = num;
		}
	}

	public unsafe float debugRotationX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRotationX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRotationX)) = num;
		}
	}

	public unsafe bool isCurrentlySun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCurrentlySun);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCurrentlySun)) = flag;
		}
	}

	public unsafe TimeManager timeManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TimeManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeManager));
		}
	}

	public unsafe bool ambientAudioMuted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientAudioMuted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientAudioMuted)) = flag;
		}
	}

	public unsafe float dayLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayLength)) = num;
		}
	}

	public unsafe float nightLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightLength)) = num;
		}
	}

	public unsafe float halfTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfTransition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfTransition)) = num;
		}
	}

	public unsafe static float UpdateInterval
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpdateInterval, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpdateInterval, (void*)(&num));
		}
	}

	public unsafe float timeSinceLastUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSinceLastUpdate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSinceLastUpdate)) = num;
		}
	}

	public unsafe static int _DayTopColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DayTopColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DayTopColor, (void*)(&num));
		}
	}

	public unsafe static int _NightTopColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__NightTopColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__NightTopColor, (void*)(&num));
		}
	}

	public unsafe static int _DayBottomColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DayBottomColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DayBottomColor, (void*)(&num));
		}
	}

	public unsafe static int _NightBottomColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__NightBottomColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__NightBottomColor, (void*)(&num));
		}
	}

	public unsafe static int _HorizonColorDay
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__HorizonColorDay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__HorizonColorDay, (void*)(&num));
		}
	}

	public unsafe static int _HorizonColorNight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__HorizonColorNight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__HorizonColorNight, (void*)(&num));
		}
	}

	public unsafe static int _CloudColorDayEdge
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CloudColorDayEdge, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CloudColorDayEdge, (void*)(&num));
		}
	}

	public unsafe static int _CloudColorNightEdge
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CloudColorNightEdge, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CloudColorNightEdge, (void*)(&num));
		}
	}

	public unsafe static int _CloudColorDayMain
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CloudColorDayMain, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CloudColorDayMain, (void*)(&num));
		}
	}

	public unsafe static int _CloudColorNightMain
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CloudColorNightMain, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CloudColorNightMain, (void*)(&num));
		}
	}

	public unsafe static int _SunColorID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SunColorID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SunColorID, (void*)(&num));
		}
	}

	public unsafe static int _MoonColorID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__MoonColorID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__MoonColorID, (void*)(&num));
		}
	}

	public unsafe static int _StarsSkyColorID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StarsSkyColorID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StarsSkyColorID, (void*)(&num));
		}
	}

	public unsafe float lastNightBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastNightBlend);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastNightBlend)) = num;
		}
	}

	public unsafe float lastDayFadeValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDayFadeValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDayFadeValue)) = num;
		}
	}

	public unsafe float lastNightFadeValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastNightFadeValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastNightFadeValue)) = num;
		}
	}

	static DayNightCycleController()
	{
		Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DayNightCycleController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr);
		NativeFieldInfoPtr_mainLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "mainLight");
		NativeFieldInfoPtr_autoFindLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "autoFindLight");
		NativeFieldInfoPtr_lightRotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "lightRotationY");
		NativeFieldInfoPtr_sunriseHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "sunriseHour");
		NativeFieldInfoPtr_sunsetHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "sunsetHour");
		NativeFieldInfoPtr_transitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "transitionDuration");
		NativeFieldInfoPtr_sunMaxIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "sunMaxIntensity");
		NativeFieldInfoPtr_sunIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "sunIntensityCurve");
		NativeFieldInfoPtr_moonMaxIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "moonMaxIntensity");
		NativeFieldInfoPtr_moonIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "moonIntensityCurve");
		NativeFieldInfoPtr_moonLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "moonLightColor");
		NativeFieldInfoPtr_controlIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "controlIntensity");
		NativeFieldInfoPtr_controlColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "controlColor");
		NativeFieldInfoPtr_controlAmbientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "controlAmbientColor");
		NativeFieldInfoPtr_dayAmbientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "dayAmbientColor");
		NativeFieldInfoPtr_nightAmbientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "nightAmbientColor");
		NativeFieldInfoPtr_ambientTransitionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "ambientTransitionCurve");
		NativeFieldInfoPtr_skyboxMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "skyboxMaterial");
		NativeFieldInfoPtr_controlSkybox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "controlSkybox");
		NativeFieldInfoPtr_daySkyTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "daySkyTop");
		NativeFieldInfoPtr_daySkyBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "daySkyBottom");
		NativeFieldInfoPtr_dayHorizonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "dayHorizonColor");
		NativeFieldInfoPtr_dayCloudEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "dayCloudEdge");
		NativeFieldInfoPtr_dayCloudMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "dayCloudMain");
		NativeFieldInfoPtr_nightSkyTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "nightSkyTop");
		NativeFieldInfoPtr_nightSkyBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "nightSkyBottom");
		NativeFieldInfoPtr_nightHorizonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "nightHorizonColor");
		NativeFieldInfoPtr_nightCloudEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "nightCloudEdge");
		NativeFieldInfoPtr_nightCloudMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "nightCloudMain");
		NativeFieldInfoPtr_sunSkyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "sunSkyColor");
		NativeFieldInfoPtr_skyMoonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "skyMoonColor");
		NativeFieldInfoPtr_starsSkyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "starsSkyColor");
		NativeFieldInfoPtr_colorPresetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "colorPresetMode");
		NativeFieldInfoPtr_builtInPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "builtInPreset");
		NativeFieldInfoPtr_customGradientPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "customGradientPreset");
		NativeFieldInfoPtr_dayNightColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "dayNightColorGradient");
		NativeFieldInfoPtr_dayAmbientSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "dayAmbientSources");
		NativeFieldInfoPtr_daySourceMaxVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "daySourceMaxVolumes");
		NativeFieldInfoPtr_nightAmbientSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "nightAmbientSources");
		NativeFieldInfoPtr_nightSourceMaxVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "nightSourceMaxVolumes");
		NativeFieldInfoPtr_audioTransitionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "audioTransitionSpeed");
		NativeFieldInfoPtr_showGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "showGizmos");
		NativeFieldInfoPtr_gizmoRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "gizmoRadius");
		NativeFieldInfoPtr_debugRotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "debugRotationX");
		NativeFieldInfoPtr_isCurrentlySun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "isCurrentlySun");
		NativeFieldInfoPtr_timeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "timeManager");
		NativeFieldInfoPtr_ambientAudioMuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "ambientAudioMuted");
		NativeFieldInfoPtr_dayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "dayLength");
		NativeFieldInfoPtr_nightLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "nightLength");
		NativeFieldInfoPtr_halfTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "halfTransition");
		NativeFieldInfoPtr_UpdateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "UpdateInterval");
		NativeFieldInfoPtr_timeSinceLastUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "timeSinceLastUpdate");
		NativeFieldInfoPtr__DayTopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_DayTopColor");
		NativeFieldInfoPtr__NightTopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_NightTopColor");
		NativeFieldInfoPtr__DayBottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_DayBottomColor");
		NativeFieldInfoPtr__NightBottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_NightBottomColor");
		NativeFieldInfoPtr__HorizonColorDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_HorizonColorDay");
		NativeFieldInfoPtr__HorizonColorNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_HorizonColorNight");
		NativeFieldInfoPtr__CloudColorDayEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_CloudColorDayEdge");
		NativeFieldInfoPtr__CloudColorNightEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_CloudColorNightEdge");
		NativeFieldInfoPtr__CloudColorDayMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_CloudColorDayMain");
		NativeFieldInfoPtr__CloudColorNightMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_CloudColorNightMain");
		NativeFieldInfoPtr__SunColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_SunColorID");
		NativeFieldInfoPtr__MoonColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_MoonColorID");
		NativeFieldInfoPtr__StarsSkyColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "_StarsSkyColorID");
		NativeFieldInfoPtr_lastNightBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "lastNightBlend");
		NativeFieldInfoPtr_lastDayFadeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "lastDayFadeValue");
		NativeFieldInfoPtr_lastNightFadeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, "lastNightFadeValue");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_IsTimeLoading_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_CacheTiming_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr_ComputePhase_Private_Void_Single_byref_Boolean_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_UpdateLight_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_UpdateEnvironment_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_UpdateAmbientColor_Private_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_CalculateNightBlend_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_ApplySkyboxColors_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663845);
		NativeMethodInfoPtr_CacheAmbientAudioVolumes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663846);
		NativeMethodInfoPtr_UpdateAmbientAudio_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663847);
		NativeMethodInfoPtr_SetAmbientAudioMuted_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663848);
		NativeMethodInfoPtr_IsDaytime_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663849);
		NativeMethodInfoPtr_SetBuiltInPreset_Public_Void_PresetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663850);
		NativeMethodInfoPtr_InitializeGradient_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663851);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr, 100663852);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29539, XrefRangeEnd = 29573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29573, XrefRangeEnd = 29591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29591, XrefRangeEnd = 29607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29613, RefRangeEnd = 29615, XrefRangeStart = 29607, XrefRangeEnd = 29613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTimeLoading()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTimeLoading_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void CacheTiming()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheTiming_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29615, RefRangeEnd = 29616, XrefRangeStart = 29615, XrefRangeEnd = 29615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputePhase(float currentTime, out bool isSunMode, out float fade, out float progress)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&currentTime);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref isSunMode);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref fade);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref progress);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputePhase_Private_Void_Single_byref_Boolean_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29629, RefRangeEnd = 29631, XrefRangeStart = 29616, XrefRangeEnd = 29629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLight(float currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&currentTime);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLight_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29648, RefRangeEnd = 29650, XrefRangeStart = 29631, XrefRangeEnd = 29648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateEnvironment(float currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&currentTime);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateEnvironment_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29657, RefRangeEnd = 29658, XrefRangeStart = 29650, XrefRangeEnd = 29657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAmbientColor(float currentTime, bool isDaytime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&currentTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isDaytime;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAmbientColor_Private_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float CalculateNightBlend(float currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&currentTime);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateNightBlend_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29706, RefRangeEnd = 29707, XrefRangeStart = 29658, XrefRangeEnd = 29706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplySkyboxColors(float nightBlend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&nightBlend);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplySkyboxColors_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29746, RefRangeEnd = 29747, XrefRangeStart = 29707, XrefRangeEnd = 29746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheAmbientAudioVolumes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheAmbientAudioVolumes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29786, RefRangeEnd = 29787, XrefRangeStart = 29747, XrefRangeEnd = 29786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAmbientAudio(float sunFade, float moonFade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&sunFade);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &moonFade;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAmbientAudio_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29787, RefRangeEnd = 29789, XrefRangeStart = 29787, XrefRangeEnd = 29787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAmbientAudioMuted(bool muted)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&muted);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAmbientAudioMuted_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsDaytime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDaytime_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29789, XrefRangeEnd = 29790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBuiltInPreset(SunGradientPresets.PresetType preset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&preset);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBuiltInPreset_Public_Void_PresetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29812, RefRangeEnd = 29814, XrefRangeStart = 29790, XrefRangeEnd = 29812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeGradient()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeGradient_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29814, XrefRangeEnd = 29845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DayNightCycleController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DayNightCycleController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DayNightCycleController(IntPtr pointer)
		: base(pointer)
	{
	}
}
