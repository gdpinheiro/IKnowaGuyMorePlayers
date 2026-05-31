using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation;

public class RagdollBoneProcessor : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__BoneSetup_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_joint;

	private static readonly System.IntPtr NativeFieldInfoPtr_stransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_rigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_initLocalPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_initLocalRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_calibrationLocalRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_jointAxisConversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialAxisCorrection;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastAppliedPosition_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__animatorLocalRotation_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_animatorRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_animatorPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr__LastMatchingRigidodyOrigin_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__updateLoopRelevantVelocity_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCaptureTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__PreviousFixedPosition_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__FixedPositionDelta_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_IndicatorComponent;

	private static readonly System.IntPtr NativeFieldInfoPtr__storedHardMatch_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_averageTranslation;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastFixedFramePosition;

	private static readonly System.IntPtr NativeFieldInfoPtr__translationCalculatedAtFixedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_averageAngularity;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastFixedFrameRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr__angularCalculatedAtFixedTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BoneSetup_Public_get_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BoneSetup_Private_set_Void_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dtransform_Private_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lastAppliedPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lastAppliedPosition_Private_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_animatorLocalRotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_animatorLocalRotation_Private_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AnimatorRotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AnimatorPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LastMatchingRigidodyOrigin_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LastMatchingRigidodyOrigin_Private_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_updateLoopRelevantVelocity_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_updateLoopRelevantVelocity_Private_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PreviousFixedPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_PreviousFixedPosition_Private_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FixedPositionDelta_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_FixedPositionDelta_Private_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurableJoint_Transform_Rigidbody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetPoseParameters_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitWithJoint_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaptureAnimatorPose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaptureAnimationVelocity_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalibrateRotation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Calibrate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreCalibrationPose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreCalibrationPose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SyncKinematicRigidbodyWithAnimatorPose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFixedPositionDelta_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnimationJointMatchingUpdate_Internal_Void_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAlternativeTensor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyJointRotation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyLocalRotationToAnimatorBone_Internal_Void_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyLocalRotationToAnimatorBoneFinal_Public_Void_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPhysicalRotationToTheBone_Internal_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPositionToAnimatorBone_Internal_Void_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPhysicalPositionToTheBone_Internal_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HardMatchBonePosition_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_storedHardMatch_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_storedHardMatch_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreHardMatchFactor_Internal_Void_RagdollBonesChain_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateHardMatchFactor_Private_Single_RagdollBonesChain_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnimationRotationHardMatchingStandUpdate_Internal_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnimationRotationHardMatchingFallUpdate_Internal_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTranslationData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AverageTranslationDataRequest_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AverageTranslationDataRequestRaw_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAngularData_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AverageAngularityDataRequest_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AverageAngularityDataRequestRaw_Public_Single_0;

	public unsafe RagdollChainBone _BoneSetup_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BoneSetup_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BoneSetup_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollChainBone));
		}
	}

	public unsafe ConfigurableJoint joint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configurableJoint));
		}
	}

	public unsafe Transform stransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stransform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Rigidbody rigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigidbody)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody));
		}
	}

	public unsafe Vector3 initLocalPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalPos)) = vector;
		}
	}

	public unsafe Quaternion initLocalRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalRot);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalRot)) = quaternion;
		}
	}

	public unsafe Quaternion calibrationLocalRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calibrationLocalRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calibrationLocalRotation)) = quaternion;
		}
	}

	public unsafe Quaternion jointAxisConversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jointAxisConversion);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jointAxisConversion)) = quaternion;
		}
	}

	public unsafe Quaternion initialAxisCorrection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialAxisCorrection);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialAxisCorrection)) = quaternion;
		}
	}

	public unsafe Vector3 _lastAppliedPosition_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastAppliedPosition_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastAppliedPosition_k__BackingField)) = vector;
		}
	}

	public unsafe Quaternion _animatorLocalRotation_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__animatorLocalRotation_k__BackingField);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__animatorLocalRotation_k__BackingField)) = quaternion;
		}
	}

	public unsafe Quaternion animatorRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorRotation)) = quaternion;
		}
	}

	public unsafe Vector3 animatorPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorPosition)) = vector;
		}
	}

	public unsafe Vector3 _LastMatchingRigidodyOrigin_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LastMatchingRigidodyOrigin_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LastMatchingRigidodyOrigin_k__BackingField)) = vector;
		}
	}

	public unsafe Vector3 _updateLoopRelevantVelocity_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__updateLoopRelevantVelocity_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__updateLoopRelevantVelocity_k__BackingField)) = vector;
		}
	}

	public unsafe float lastCaptureTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCaptureTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCaptureTime)) = num;
		}
	}

	public unsafe Vector3 _PreviousFixedPosition_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PreviousFixedPosition_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PreviousFixedPosition_k__BackingField)) = vector;
		}
	}

	public unsafe Vector3 _FixedPositionDelta_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FixedPositionDelta_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FixedPositionDelta_k__BackingField)) = vector;
		}
	}

	public unsafe RagdollAnimator2BoneIndicator IndicatorComponent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IndicatorComponent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollAnimator2BoneIndicator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IndicatorComponent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollAnimator2BoneIndicator));
		}
	}

	public unsafe float _storedHardMatch_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storedHardMatch_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storedHardMatch_k__BackingField)) = num;
		}
	}

	public unsafe Vector3 averageTranslation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageTranslation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageTranslation)) = vector;
		}
	}

	public unsafe Vector3 _lastFixedFramePosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastFixedFramePosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastFixedFramePosition)) = vector;
		}
	}

	public unsafe float _translationCalculatedAtFixedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__translationCalculatedAtFixedTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__translationCalculatedAtFixedTime)) = num;
		}
	}

	public unsafe float averageAngularity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageAngularity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageAngularity)) = num;
		}
	}

	public unsafe Quaternion _lastFixedFrameRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastFixedFrameRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastFixedFrameRotation)) = quaternion;
		}
	}

	public unsafe float _angularCalculatedAtFixedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__angularCalculatedAtFixedTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__angularCalculatedAtFixedTime)) = num;
		}
	}

	public unsafe RagdollChainBone BoneSetup
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 224328, RefRangeEnd = 224338, XrefRangeStart = 224328, XrefRangeEnd = 224338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BoneSetup_Public_get_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224339, RefRangeEnd = 224340, XrefRangeStart = 224339, XrefRangeEnd = 224340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BoneSetup_Private_set_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Transform dtransform
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dtransform_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
	}

	public unsafe Vector3 lastAppliedPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastAppliedPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lastAppliedPosition_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Quaternion animatorLocalRotation
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81461, RefRangeEnd = 81462, XrefRangeStart = 81461, XrefRangeEnd = 81462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_animatorLocalRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_animatorLocalRotation_Private_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Quaternion AnimatorRotation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AnimatorRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Vector3 AnimatorPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AnimatorPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Vector3 LastMatchingRigidodyOrigin
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastMatchingRigidodyOrigin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LastMatchingRigidodyOrigin_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Vector3 updateLoopRelevantVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_updateLoopRelevantVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_updateLoopRelevantVelocity_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Vector3 PreviousFixedPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PreviousFixedPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PreviousFixedPosition_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Vector3 FixedPositionDelta
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FixedPositionDelta_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FixedPositionDelta_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float storedHardMatch
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_storedHardMatch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_storedHardMatch_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static RagdollBoneProcessor()
	{
		Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RagdollBoneProcessor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr);
		NativeFieldInfoPtr__BoneSetup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "<BoneSetup>k__BackingField");
		NativeFieldInfoPtr_joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "joint");
		NativeFieldInfoPtr_stransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "stransform");
		NativeFieldInfoPtr_rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "rigidbody");
		NativeFieldInfoPtr_initLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "initLocalPos");
		NativeFieldInfoPtr_initLocalRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "initLocalRot");
		NativeFieldInfoPtr_calibrationLocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "calibrationLocalRotation");
		NativeFieldInfoPtr_jointAxisConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "jointAxisConversion");
		NativeFieldInfoPtr_initialAxisCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "initialAxisCorrection");
		NativeFieldInfoPtr__lastAppliedPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "<lastAppliedPosition>k__BackingField");
		NativeFieldInfoPtr__animatorLocalRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "<animatorLocalRotation>k__BackingField");
		NativeFieldInfoPtr_animatorRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "animatorRotation");
		NativeFieldInfoPtr_animatorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "animatorPosition");
		NativeFieldInfoPtr__LastMatchingRigidodyOrigin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "<LastMatchingRigidodyOrigin>k__BackingField");
		NativeFieldInfoPtr__updateLoopRelevantVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "<updateLoopRelevantVelocity>k__BackingField");
		NativeFieldInfoPtr_lastCaptureTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "lastCaptureTime");
		NativeFieldInfoPtr__PreviousFixedPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "<PreviousFixedPosition>k__BackingField");
		NativeFieldInfoPtr__FixedPositionDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "<FixedPositionDelta>k__BackingField");
		NativeFieldInfoPtr_IndicatorComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "IndicatorComponent");
		NativeFieldInfoPtr__storedHardMatch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "<storedHardMatch>k__BackingField");
		NativeFieldInfoPtr_averageTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "averageTranslation");
		NativeFieldInfoPtr__lastFixedFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "_lastFixedFramePosition");
		NativeFieldInfoPtr__translationCalculatedAtFixedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "_translationCalculatedAtFixedTime");
		NativeFieldInfoPtr_averageAngularity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "averageAngularity");
		NativeFieldInfoPtr__lastFixedFrameRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "_lastFixedFrameRotation");
		NativeFieldInfoPtr__angularCalculatedAtFixedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, "_angularCalculatedAtFixedTime");
		NativeMethodInfoPtr_get_BoneSetup_Public_get_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677237);
		NativeMethodInfoPtr_set_BoneSetup_Private_set_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677238);
		NativeMethodInfoPtr_get_dtransform_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677239);
		NativeMethodInfoPtr_get_lastAppliedPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677240);
		NativeMethodInfoPtr_set_lastAppliedPosition_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677241);
		NativeMethodInfoPtr_get_animatorLocalRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677242);
		NativeMethodInfoPtr_set_animatorLocalRotation_Private_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677243);
		NativeMethodInfoPtr_get_AnimatorRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677244);
		NativeMethodInfoPtr_get_AnimatorPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677245);
		NativeMethodInfoPtr_get_LastMatchingRigidodyOrigin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677246);
		NativeMethodInfoPtr_set_LastMatchingRigidodyOrigin_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677247);
		NativeMethodInfoPtr_get_updateLoopRelevantVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677248);
		NativeMethodInfoPtr_set_updateLoopRelevantVelocity_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677249);
		NativeMethodInfoPtr_get_PreviousFixedPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677250);
		NativeMethodInfoPtr_set_PreviousFixedPosition_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677251);
		NativeMethodInfoPtr_get_FixedPositionDelta_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677252);
		NativeMethodInfoPtr_set_FixedPositionDelta_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677253);
		NativeMethodInfoPtr__ctor_Public_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677254);
		NativeMethodInfoPtr__ctor_Public_Void_ConfigurableJoint_Transform_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677255);
		NativeMethodInfoPtr_ResetPoseParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677256);
		NativeMethodInfoPtr_InitWithJoint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677257);
		NativeMethodInfoPtr_CaptureAnimatorPose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677258);
		NativeMethodInfoPtr_CaptureAnimationVelocity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677259);
		NativeMethodInfoPtr_CalibrateRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677260);
		NativeMethodInfoPtr_Calibrate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677261);
		NativeMethodInfoPtr_StoreCalibrationPose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677262);
		NativeMethodInfoPtr_RestoreCalibrationPose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677263);
		NativeMethodInfoPtr_SyncKinematicRigidbodyWithAnimatorPose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677264);
		NativeMethodInfoPtr_UpdateFixedPositionDelta_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677265);
		NativeMethodInfoPtr_AnimationJointMatchingUpdate_Internal_Void_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677266);
		NativeMethodInfoPtr_ApplyAlternativeTensor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677267);
		NativeMethodInfoPtr_ApplyJointRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677268);
		NativeMethodInfoPtr_ApplyLocalRotationToAnimatorBone_Internal_Void_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677269);
		NativeMethodInfoPtr_ApplyLocalRotationToAnimatorBoneFinal_Public_Void_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677270);
		NativeMethodInfoPtr_ApplyPhysicalRotationToTheBone_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677271);
		NativeMethodInfoPtr_ApplyPositionToAnimatorBone_Internal_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677272);
		NativeMethodInfoPtr_ApplyPhysicalPositionToTheBone_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677273);
		NativeMethodInfoPtr_HardMatchBonePosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677274);
		NativeMethodInfoPtr_get_storedHardMatch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677275);
		NativeMethodInfoPtr_set_storedHardMatch_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677276);
		NativeMethodInfoPtr_StoreHardMatchFactor_Internal_Void_RagdollBonesChain_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677277);
		NativeMethodInfoPtr_CalculateHardMatchFactor_Private_Single_RagdollBonesChain_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677278);
		NativeMethodInfoPtr_AnimationRotationHardMatchingStandUpdate_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677279);
		NativeMethodInfoPtr_AnimationRotationHardMatchingFallUpdate_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677280);
		NativeMethodInfoPtr_UpdateTranslationData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677281);
		NativeMethodInfoPtr_AverageTranslationDataRequest_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677282);
		NativeMethodInfoPtr_AverageTranslationDataRequestRaw_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677283);
		NativeMethodInfoPtr_UpdateAngularData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677284);
		NativeMethodInfoPtr_AverageAngularityDataRequest_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677285);
		NativeMethodInfoPtr_AverageAngularityDataRequestRaw_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr, 100677286);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233019, RefRangeEnd = 233021, XrefRangeStart = 233003, XrefRangeEnd = 233019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollBoneProcessor(RagdollChainBone settings)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233036, RefRangeEnd = 233037, XrefRangeStart = 233021, XrefRangeEnd = 233036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollBoneProcessor(ConfigurableJoint configurableJoint, Transform sourceTransform, Rigidbody rig)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollBoneProcessor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configurableJoint);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rig);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ConfigurableJoint_Transform_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 233054, RefRangeEnd = 233061, XrefRangeStart = 233037, XrefRangeEnd = 233054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetPoseParameters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetPoseParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233074, RefRangeEnd = 233076, XrefRangeStart = 233061, XrefRangeEnd = 233074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitWithJoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitWithJoint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233082, RefRangeEnd = 233085, XrefRangeStart = 233076, XrefRangeEnd = 233082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CaptureAnimatorPose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaptureAnimatorPose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233085, XrefRangeEnd = 233089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CaptureAnimationVelocity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaptureAnimationVelocity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 233090, RefRangeEnd = 233094, XrefRangeStart = 233089, XrefRangeEnd = 233090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalibrateRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalibrateRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233096, RefRangeEnd = 233099, XrefRangeStart = 233094, XrefRangeEnd = 233096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Calibrate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Calibrate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233099, RefRangeEnd = 233101, XrefRangeStart = 233099, XrefRangeEnd = 233099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreCalibrationPose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreCalibrationPose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233101, RefRangeEnd = 233103, XrefRangeStart = 233101, XrefRangeEnd = 233101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreCalibrationPose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreCalibrationPose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233103, XrefRangeEnd = 233113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SyncKinematicRigidbodyWithAnimatorPose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncKinematicRigidbodyWithAnimatorPose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233116, RefRangeEnd = 233117, XrefRangeStart = 233113, XrefRangeEnd = 233116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFixedPositionDelta()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFixedPositionDelta_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233119, RefRangeEnd = 233120, XrefRangeStart = 233117, XrefRangeEnd = 233119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnimationJointMatchingUpdate(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnimationJointMatchingUpdate_Internal_Void_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233121, RefRangeEnd = 233122, XrefRangeStart = 233120, XrefRangeEnd = 233121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyAlternativeTensor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyAlternativeTensor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233128, RefRangeEnd = 233130, XrefRangeStart = 233122, XrefRangeEnd = 233128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyJointRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyJointRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233130, XrefRangeEnd = 233133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyLocalRotationToAnimatorBone(Quaternion localRotation, float blend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&localRotation);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &blend;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyLocalRotationToAnimatorBone_Internal_Void_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233133, XrefRangeEnd = 233136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyLocalRotationToAnimatorBoneFinal(Quaternion localRotation, float blend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&localRotation);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &blend;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyLocalRotationToAnimatorBoneFinal_Public_Void_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233143, RefRangeEnd = 233144, XrefRangeStart = 233136, XrefRangeEnd = 233143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyPhysicalRotationToTheBone(float blend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&blend);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyPhysicalRotationToTheBone_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233144, XrefRangeEnd = 233149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyPositionToAnimatorBone(Vector3 localPosition, float blend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&localPosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &blend;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyPositionToAnimatorBone_Internal_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233155, RefRangeEnd = 233158, XrefRangeStart = 233149, XrefRangeEnd = 233155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyPhysicalPositionToTheBone(float blend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&blend);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyPhysicalPositionToTheBone_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233161, RefRangeEnd = 233164, XrefRangeStart = 233158, XrefRangeEnd = 233161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HardMatchBonePosition(float power)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&power);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HardMatchBonePosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233168, RefRangeEnd = 233170, XrefRangeStart = 233164, XrefRangeEnd = 233168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreHardMatchFactor(RagdollBonesChain chain, float hardMatchMultiplier = 0f, float overallMultiplier = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hardMatchMultiplier;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &overallMultiplier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreHardMatchFactor_Internal_Void_RagdollBonesChain_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233170, XrefRangeEnd = 233171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateHardMatchFactor(RagdollBonesChain chain, float hardMatchMultiplier = 0f, float overallMultiplier = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hardMatchMultiplier;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &overallMultiplier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateHardMatchFactor_Private_Single_RagdollBonesChain_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233173, RefRangeEnd = 233174, XrefRangeStart = 233171, XrefRangeEnd = 233173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnimationRotationHardMatchingStandUpdate(float hardMatch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hardMatch);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnimationRotationHardMatchingStandUpdate_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233178, RefRangeEnd = 233179, XrefRangeStart = 233174, XrefRangeEnd = 233178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnimationRotationHardMatchingFallUpdate(float hardMatch = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hardMatch);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnimationRotationHardMatchingFallUpdate_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233179, XrefRangeEnd = 233183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTranslationData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTranslationData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233194, RefRangeEnd = 233197, XrefRangeStart = 233183, XrefRangeEnd = 233194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 AverageTranslationDataRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AverageTranslationDataRequest_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector3 AverageTranslationDataRequestRaw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AverageTranslationDataRequestRaw_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233205, RefRangeEnd = 233206, XrefRangeStart = 233197, XrefRangeEnd = 233205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAngularData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAngularData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233212, RefRangeEnd = 233213, XrefRangeStart = 233206, XrefRangeEnd = 233212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float AverageAngularityDataRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AverageAngularityDataRequest_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float AverageAngularityDataRequestRaw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AverageAngularityDataRequestRaw_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public RagdollBoneProcessor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
