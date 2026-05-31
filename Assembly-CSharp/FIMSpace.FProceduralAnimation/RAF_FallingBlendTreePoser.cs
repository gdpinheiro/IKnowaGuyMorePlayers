using System;
using System.Runtime.CompilerServices;
using FIMSpace.FGenerating;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation;

public class RAF_FallingBlendTreePoser : RagdollAnimatorFeatureUpdate
{
	private static readonly IntPtr NativeFieldInfoPtr_fallingModeDuration;

	private static readonly IntPtr NativeFieldInfoPtr_stuckDetectTimer;

	private static readonly IntPtr NativeFieldInfoPtr_unstuckPerformTimer;

	private static readonly IntPtr NativeFieldInfoPtr_unstuckVeloPushTimer;

	private static readonly IntPtr NativeFieldInfoPtr_unstuckStage;

	private static readonly IntPtr NativeFieldInfoPtr_groundAngle;

	private static readonly IntPtr NativeFieldInfoPtr_safeUpRaycastOffset;

	private static readonly IntPtr NativeFieldInfoPtr_lastAppliedImpact;

	private static readonly IntPtr NativeFieldInfoPtr_velocityMagnitude;

	private static readonly IntPtr NativeFieldInfoPtr_lastHit;

	private static readonly IntPtr NativeFieldInfoPtr__hash_FallX;

	private static readonly IntPtr NativeFieldInfoPtr__hash_FallZ;

	private static readonly IntPtr NativeFieldInfoPtr__hash_FallG;

	private static readonly IntPtr NativeFieldInfoPtr__additiveLayer;

	private static readonly IntPtr NativeFieldInfoPtr_smoothDampDuration;

	private static readonly IntPtr NativeFieldInfoPtr_sd_FallX;

	private static readonly IntPtr NativeFieldInfoPtr_sd_FallZ;

	private static readonly IntPtr NativeFieldInfoPtr_sd_FallG;

	private static readonly IntPtr NativeFieldInfoPtr_sd_layer;

	private static readonly IntPtr NativeFieldInfoPtr_localVelocity;

	private static readonly IntPtr NativeFieldInfoPtr_backLay;

	private static readonly IntPtr NativeFieldInfoPtr_sideLay;

	private static readonly IntPtr NativeFieldInfoPtr_groundMaskV;

	private static readonly IntPtr NativeFieldInfoPtr_transitionSpeedV;

	private static readonly IntPtr NativeFieldInfoPtr_unstuckSensitivityV;

	private static readonly IntPtr NativeFieldInfoPtr_additiveLayerMaxVelocityV;

	private static readonly IntPtr NativeFieldInfoPtr_averageBodyVelocityV;

	private static readonly IntPtr NativeFieldInfoPtr_nearToGroundHeightV;

	private static readonly IntPtr NativeFieldInfoPtr_coreChain;

	private static readonly IntPtr NativeMethodInfoPtr_get_UseUpdate_Public_Virtual_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Mecanim_Public_get_Animator_0;

	private static readonly IntPtr NativeMethodInfoPtr_PrepareHashesAndLayer_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FallX_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_FallX_Protected_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FallZ_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_FallZ_Protected_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FallG_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_FallG_Protected_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SetFallX_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SetFallZ_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SetFallG_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_GetAdditiveLayerWeight_Private_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SmoothSetAdditiveLayer_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SetAdditiveLayerWeight_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_DoExtraRaycasts_Private_Void_byref_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_VelocityLimiter_Private_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnstuckHelperPush_Private_Void_Int32_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float fallingModeDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallingModeDuration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallingModeDuration)) = num;
		}
	}

	public unsafe float stuckDetectTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stuckDetectTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stuckDetectTimer)) = num;
		}
	}

	public unsafe float unstuckPerformTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unstuckPerformTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unstuckPerformTimer)) = num;
		}
	}

	public unsafe float unstuckVeloPushTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unstuckVeloPushTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unstuckVeloPushTimer)) = num;
		}
	}

	public unsafe int unstuckStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unstuckStage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unstuckStage)) = num;
		}
	}

	public unsafe float groundAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundAngle)) = num;
		}
	}

	public unsafe Vector3 safeUpRaycastOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_safeUpRaycastOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_safeUpRaycastOffset)) = vector;
		}
	}

	public unsafe Vector3 lastAppliedImpact
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastAppliedImpact);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastAppliedImpact)) = vector;
		}
	}

	public unsafe float velocityMagnitude
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocityMagnitude);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocityMagnitude)) = num;
		}
	}

	public unsafe RaycastHit lastHit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastHit);
			return *(RaycastHit*)num;
		}
		set
		{
			*(RaycastHit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastHit)) = raycastHit;
		}
	}

	public unsafe int _hash_FallX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hash_FallX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hash_FallX)) = num;
		}
	}

	public unsafe int _hash_FallZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hash_FallZ);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hash_FallZ)) = num;
		}
	}

	public unsafe int _hash_FallG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hash_FallG);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hash_FallG)) = num;
		}
	}

	public unsafe int _additiveLayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additiveLayer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additiveLayer)) = num;
		}
	}

	public unsafe float smoothDampDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothDampDuration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothDampDuration)) = num;
		}
	}

	public unsafe float sd_FallX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sd_FallX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sd_FallX)) = num;
		}
	}

	public unsafe float sd_FallZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sd_FallZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sd_FallZ)) = num;
		}
	}

	public unsafe float sd_FallG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sd_FallG);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sd_FallG)) = num;
		}
	}

	public unsafe float sd_layer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sd_layer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sd_layer)) = num;
		}
	}

	public unsafe Vector3 localVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localVelocity)) = vector;
		}
	}

	public unsafe ERagdollGetUpType backLay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backLay);
			return *(ERagdollGetUpType*)num;
		}
		set
		{
			*(ERagdollGetUpType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backLay)) = eRagdollGetUpType;
		}
	}

	public unsafe ERagdollGetUpType sideLay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideLay);
			return *(ERagdollGetUpType*)num;
		}
		set
		{
			*(ERagdollGetUpType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideLay)) = eRagdollGetUpType;
		}
	}

	public unsafe FUniversalVariable groundMaskV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundMaskV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundMaskV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable transitionSpeedV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionSpeedV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionSpeedV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable unstuckSensitivityV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unstuckSensitivityV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unstuckSensitivityV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable additiveLayerMaxVelocityV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additiveLayerMaxVelocityV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additiveLayerMaxVelocityV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable averageBodyVelocityV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageBodyVelocityV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageBodyVelocityV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable nearToGroundHeightV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearToGroundHeightV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearToGroundHeightV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe RagdollBonesChain coreChain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coreChain);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coreChain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollBonesChain));
		}
	}

	public unsafe override bool UseUpdate
	{
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 26835, RefRangeEnd = 26870, XrefRangeStart = 26835, XrefRangeEnd = 26870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_UseUpdate_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Animator Mecanim
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237678, XrefRangeEnd = 237679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Mecanim_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr) : null;
		}
	}

	public unsafe float FallX
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237705, XrefRangeEnd = 237708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FallX_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237708, XrefRangeEnd = 237711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FallX_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float FallZ
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237711, XrefRangeEnd = 237714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FallZ_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237714, XrefRangeEnd = 237717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FallZ_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float FallG
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237717, XrefRangeEnd = 237720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FallG_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237720, XrefRangeEnd = 237723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FallG_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float SetFallX
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 237730, RefRangeEnd = 237745, XrefRangeStart = 237723, XrefRangeEnd = 237730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SetFallX_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float SetFallZ
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 237752, RefRangeEnd = 237766, XrefRangeStart = 237745, XrefRangeEnd = 237752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SetFallZ_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float SetFallG
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237773, RefRangeEnd = 237777, XrefRangeStart = 237766, XrefRangeEnd = 237773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SetFallG_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float GetAdditiveLayerWeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237777, XrefRangeEnd = 237780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GetAdditiveLayerWeight_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float SmoothSetAdditiveLayer
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237787, RefRangeEnd = 237791, XrefRangeStart = 237780, XrefRangeEnd = 237787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SmoothSetAdditiveLayer_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float SetAdditiveLayerWeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237791, XrefRangeEnd = 237794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SetAdditiveLayerWeight_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static RAF_FallingBlendTreePoser()
	{
		Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RAF_FallingBlendTreePoser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr);
		NativeFieldInfoPtr_fallingModeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "fallingModeDuration");
		NativeFieldInfoPtr_stuckDetectTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "stuckDetectTimer");
		NativeFieldInfoPtr_unstuckPerformTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "unstuckPerformTimer");
		NativeFieldInfoPtr_unstuckVeloPushTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "unstuckVeloPushTimer");
		NativeFieldInfoPtr_unstuckStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "unstuckStage");
		NativeFieldInfoPtr_groundAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "groundAngle");
		NativeFieldInfoPtr_safeUpRaycastOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "safeUpRaycastOffset");
		NativeFieldInfoPtr_lastAppliedImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "lastAppliedImpact");
		NativeFieldInfoPtr_velocityMagnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "velocityMagnitude");
		NativeFieldInfoPtr_lastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "lastHit");
		NativeFieldInfoPtr__hash_FallX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "_hash_FallX");
		NativeFieldInfoPtr__hash_FallZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "_hash_FallZ");
		NativeFieldInfoPtr__hash_FallG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "_hash_FallG");
		NativeFieldInfoPtr__additiveLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "_additiveLayer");
		NativeFieldInfoPtr_smoothDampDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "smoothDampDuration");
		NativeFieldInfoPtr_sd_FallX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "sd_FallX");
		NativeFieldInfoPtr_sd_FallZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "sd_FallZ");
		NativeFieldInfoPtr_sd_FallG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "sd_FallG");
		NativeFieldInfoPtr_sd_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "sd_layer");
		NativeFieldInfoPtr_localVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "localVelocity");
		NativeFieldInfoPtr_backLay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "backLay");
		NativeFieldInfoPtr_sideLay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "sideLay");
		NativeFieldInfoPtr_groundMaskV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "groundMaskV");
		NativeFieldInfoPtr_transitionSpeedV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "transitionSpeedV");
		NativeFieldInfoPtr_unstuckSensitivityV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "unstuckSensitivityV");
		NativeFieldInfoPtr_additiveLayerMaxVelocityV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "additiveLayerMaxVelocityV");
		NativeFieldInfoPtr_averageBodyVelocityV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "averageBodyVelocityV");
		NativeFieldInfoPtr_nearToGroundHeightV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "nearToGroundHeightV");
		NativeFieldInfoPtr_coreChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, "coreChain");
		NativeMethodInfoPtr_get_UseUpdate_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677610);
		NativeMethodInfoPtr_get_Mecanim_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677611);
		NativeMethodInfoPtr_PrepareHashesAndLayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677612);
		NativeMethodInfoPtr_get_FallX_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677613);
		NativeMethodInfoPtr_set_FallX_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677614);
		NativeMethodInfoPtr_get_FallZ_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677615);
		NativeMethodInfoPtr_set_FallZ_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677616);
		NativeMethodInfoPtr_get_FallG_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677617);
		NativeMethodInfoPtr_set_FallG_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677618);
		NativeMethodInfoPtr_set_SetFallX_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677619);
		NativeMethodInfoPtr_set_SetFallZ_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677620);
		NativeMethodInfoPtr_set_SetFallG_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677621);
		NativeMethodInfoPtr_get_GetAdditiveLayerWeight_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677622);
		NativeMethodInfoPtr_set_SmoothSetAdditiveLayer_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677623);
		NativeMethodInfoPtr_set_SetAdditiveLayerWeight_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677624);
		NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677625);
		NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677626);
		NativeMethodInfoPtr_DoExtraRaycasts_Private_Void_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677627);
		NativeMethodInfoPtr_VelocityLimiter_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677628);
		NativeMethodInfoPtr_UnstuckHelperPush_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677629);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr, 100677630);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237704, RefRangeEnd = 237705, XrefRangeStart = 237679, XrefRangeEnd = 237704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareHashesAndLayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareHashesAndLayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237794, XrefRangeEnd = 237846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool OnInit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237846, XrefRangeEnd = 238027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238063, RefRangeEnd = 238065, XrefRangeStart = 238027, XrefRangeEnd = 238063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoExtraRaycasts(ref float groundAngle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref groundAngle);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoExtraRaycasts_Private_Void_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238065, XrefRangeEnd = 238066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float VelocityLimiter(float magnitude)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&magnitude);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VelocityLimiter_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 238070, RefRangeEnd = 238073, XrefRangeStart = 238066, XrefRangeEnd = 238070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnstuckHelperPush(int stage, float powerMul = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&stage);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &powerMul;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnstuckHelperPush_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238073, XrefRangeEnd = 238078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RAF_FallingBlendTreePoser()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RAF_FallingBlendTreePoser>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RAF_FallingBlendTreePoser(IntPtr pointer)
		: base(pointer)
	{
	}
}
