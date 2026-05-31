using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation;

[System.Serializable]
public class RagdollBonesChain : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__prentHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChainName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChainType;

	private static readonly System.IntPtr NativeFieldInfoPtr_BoneSetups;

	private static readonly System.IntPtr NativeFieldInfoPtr__RuntimeBoneProcessors_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ConnectionBone_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ChainBonesLength_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChainThicknessMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChainScaleMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_MassMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_MusclesForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_AxisLimitRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnlimitedRotations;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedMassScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedMassOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_Detach;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChainBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_AlternativeTensors;

	private static readonly System.IntPtr NativeFieldInfoPtr_AlternativeTensorsOnFall;

	private static readonly System.IntPtr NativeFieldInfoPtr_tensorsSwitched;

	private static readonly System.IntPtr NativeFieldInfoPtr_HardMatchMultiply;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlaymodeInitialized_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ParentConnectionBones_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_blendOnCollisionCulldown;

	private static readonly System.IntPtr NativeFieldInfoPtr_blendOnCollisionMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_playmodeDetached;

	private static readonly System.IntPtr NativeFieldInfoPtr__DummyParentObject_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoAdjustColliders_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoAdjustColliders_Limb_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoAdjustColliders_Core_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustColliderSettingsBasingOnTheStartEndPosition_Public_Vector3_RagdollChainBone_Int32_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustColliderDirectionParams_Private_Void_RagdollChainBone_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisValue_Private_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAxisValue_Private_Vector3_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChainAverageRadius_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyColliderSettingTo_Public_Static_Void_Collider_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyProvidesContacts_Private_Static_Void_Collider_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoAdjustPhysics_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoAdjustJointsAxes_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustJointAxesBasingOnTheStartEndPosition_Private_Void_RagdollChainBone_Int32_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoAdjustJointsLimits_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChainTypePercentageMass_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBoneMassPercentage_Public_Single_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChainTypePercentageMassReal_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBoneMassPercentageReal_Public_Single_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureCollisionIgnoreBetweenChildBones_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfShouldIgnoreByBounds_Public_Void_RagdollChainBone_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaleCollider_Private_Void_Collider_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureCollisionIgnoreBetweenBonesUsingBounds_Public_Void_List_1_RagdollBonesChain_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBoneAndItsChildren_Public_Void_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRuntimeBoneProcessing_Public_Void_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectAllConnectedBones_Public_List_1_RagdollChainBone_RagdollChainBone_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectAllFillBones_Public_List_1_InBetweenBone_List_1_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchPhysics_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParentHandler_Public_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentHandler_Public_get_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LastBone_Public_get_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RuntimeBoneProcessors_Public_get_List_1_RagdollBoneProcessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RuntimeBoneProcessors_Private_set_Void_List_1_RagdollBoneProcessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConnectionBone_Public_get_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ConnectionBone_Private_set_Void_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ChainBonesLength_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ChainBonesLength_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScaleMultiplier_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetThicknessMultiplier_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlaymodeInitialized_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_PlaymodeInitialized_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompletePlaymodeInitialization_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentConnectionBones_Public_get_List_1_InBetweenBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ParentConnectionBones_Private_set_Void_List_1_InBetweenBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_ERagdollBoneID_EColliderType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_Boolean_EColliderType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_Transform_EColliderType_ERagdollBoneID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_GatherChildBones_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBone_Public_RagdollChainBone_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBone_Public_RagdollChainBone_ERagdollBoneID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIndex_Public_Int32_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParent_Public_RagdollChainBone_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsAnimatorBoneTransform_Public_Boolean_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsAnimatorBoneTransform_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsDummyBoneTransform_Public_Boolean_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLength_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DummyParentObject_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DummyParentObject_Private_set_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDummyLimb_Public_Transform_RagdollHandler_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAverageStepSizeOfTheChain_Internal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshRagdollComponents_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshJointsParentingDefault_Public_Void_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshBonesParentBoneVariable_Public_Void_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetachBones_Public_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshJointsParentingWithInBetweenBones_Public_Void_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSymmetryChainByType_Public_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSymmetryTo_Public_RagdollChainBone_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSymmetryChainTo_Public_Static_RagdollBonesChain_RagdollHandler_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSymmetryTo_Public_Boolean_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTypeRelatedWith_Public_Boolean_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Calibrate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalibrateJustRotation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPhysicalRotationsToTheSkeleton_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBlend_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPhysicalPositionToTheSkeleton_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaptureAnimator_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureJointsAnchors_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ForceOverrideAllBonesBlendFor_Public_Void_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ResetOverrideBlends_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryIdentifyBoneIDs_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreCalibrationPose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreCalibrationPose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IgnoreCollisionsWith_Public_Void_Collider_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DefineConnectionBone_Internal_Void_RagdollHandler_0;

	public unsafe RagdollHandler _prentHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prentHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prentHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollHandler));
		}
	}

	public unsafe string ChainName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChainName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChainName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ERagdollChainType ChainType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChainType);
			return *(ERagdollChainType*)num;
		}
		set
		{
			*(ERagdollChainType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChainType)) = eRagdollChainType;
		}
	}

	public unsafe List<RagdollChainBone> BoneSetups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BoneSetups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RagdollChainBone>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BoneSetups)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RagdollBoneProcessor> _RuntimeBoneProcessors_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RuntimeBoneProcessors_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RagdollBoneProcessor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RuntimeBoneProcessors_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe RagdollChainBone _ConnectionBone_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConnectionBone_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConnectionBone_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollChainBone));
		}
	}

	public unsafe float _ChainBonesLength_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ChainBonesLength_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ChainBonesLength_k__BackingField)) = num;
		}
	}

	public unsafe float ChainThicknessMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChainThicknessMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChainThicknessMultiplier)) = num;
		}
	}

	public unsafe float ChainScaleMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChainScaleMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChainScaleMultiplier)) = num;
		}
	}

	public unsafe float MassMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MassMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MassMultiplier)) = num;
		}
	}

	public unsafe float MusclesForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MusclesForce);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MusclesForce)) = num;
		}
	}

	public unsafe float AxisLimitRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AxisLimitRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AxisLimitRange)) = num;
		}
	}

	public unsafe bool UnlimitedRotations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnlimitedRotations);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnlimitedRotations)) = flag;
		}
	}

	public unsafe float ConnectedMassScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectedMassScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectedMassScale)) = num;
		}
	}

	public unsafe bool ConnectedMassOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectedMassOverride);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectedMassOverride)) = flag;
		}
	}

	public unsafe bool Detach
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Detach);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Detach)) = flag;
		}
	}

	public unsafe float ChainBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChainBlend);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChainBlend)) = num;
		}
	}

	public unsafe float OverrideBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideBlend);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideBlend)) = num;
		}
	}

	public unsafe bool AlternativeTensors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlternativeTensors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlternativeTensors)) = flag;
		}
	}

	public unsafe bool AlternativeTensorsOnFall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlternativeTensorsOnFall);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlternativeTensorsOnFall)) = flag;
		}
	}

	public unsafe bool tensorsSwitched
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tensorsSwitched);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tensorsSwitched)) = flag;
		}
	}

	public unsafe float HardMatchMultiply
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HardMatchMultiply);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HardMatchMultiply)) = num;
		}
	}

	public unsafe bool _PlaymodeInitialized_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlaymodeInitialized_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlaymodeInitialized_k__BackingField)) = flag;
		}
	}

	public unsafe List<RagdollChainBone.InBetweenBone> _ParentConnectionBones_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentConnectionBones_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RagdollChainBone.InBetweenBone>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentConnectionBones_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float blendOnCollisionCulldown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendOnCollisionCulldown);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendOnCollisionCulldown)) = num;
		}
	}

	public unsafe float blendOnCollisionMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendOnCollisionMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendOnCollisionMin)) = num;
		}
	}

	public unsafe bool playmodeDetached
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playmodeDetached);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playmodeDetached)) = flag;
		}
	}

	public unsafe Transform _DummyParentObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DummyParentObject_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DummyParentObject_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe RagdollHandler ParentHandler
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 224328, RefRangeEnd = 224338, XrefRangeStart = 224328, XrefRangeEnd = 224338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentHandler_Public_get_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollHandler>(intPtr) : null;
		}
	}

	public unsafe RagdollChainBone LastBone
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239749, XrefRangeEnd = 239754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastBone_Public_get_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
		}
	}

	public unsafe List<RagdollBoneProcessor> RuntimeBoneProcessors
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 43149, RefRangeEnd = 43165, XrefRangeStart = 43149, XrefRangeEnd = 43165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RuntimeBoneProcessors_Public_get_List_1_RagdollBoneProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RagdollBoneProcessor>>(intPtr) : null;
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 232707, RefRangeEnd = 232714, XrefRangeStart = 232707, XrefRangeEnd = 232714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RuntimeBoneProcessors_Private_set_Void_List_1_RagdollBoneProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe RagdollChainBone ConnectionBone
	{
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 57380, RefRangeEnd = 57408, XrefRangeStart = 57380, XrefRangeEnd = 57408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConnectionBone_Public_get_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232715, RefRangeEnd = 232717, XrefRangeStart = 232715, XrefRangeEnd = 232717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ConnectionBone_Private_set_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float ChainBonesLength
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81457, RefRangeEnd = 81458, XrefRangeStart = 81457, XrefRangeEnd = 81458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ChainBonesLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ChainBonesLength_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool PlaymodeInitialized
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlaymodeInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PlaymodeInitialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<RagdollChainBone.InBetweenBone> ParentConnectionBones
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentConnectionBones_Public_get_List_1_InBetweenBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RagdollChainBone.InBetweenBone>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ParentConnectionBones_Private_set_Void_List_1_InBetweenBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Transform DummyParentObject
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 91977, RefRangeEnd = 91984, XrefRangeStart = 91977, XrefRangeEnd = 91984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DummyParentObject_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DummyParentObject_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static RagdollBonesChain()
	{
		Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RagdollBonesChain");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr);
		NativeFieldInfoPtr__prentHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "_prentHandler");
		NativeFieldInfoPtr_ChainName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "ChainName");
		NativeFieldInfoPtr_ChainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "ChainType");
		NativeFieldInfoPtr_BoneSetups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "BoneSetups");
		NativeFieldInfoPtr__RuntimeBoneProcessors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "<RuntimeBoneProcessors>k__BackingField");
		NativeFieldInfoPtr__ConnectionBone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "<ConnectionBone>k__BackingField");
		NativeFieldInfoPtr__ChainBonesLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "<ChainBonesLength>k__BackingField");
		NativeFieldInfoPtr_ChainThicknessMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "ChainThicknessMultiplier");
		NativeFieldInfoPtr_ChainScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "ChainScaleMultiplier");
		NativeFieldInfoPtr_MassMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "MassMultiplier");
		NativeFieldInfoPtr_MusclesForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "MusclesForce");
		NativeFieldInfoPtr_AxisLimitRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "AxisLimitRange");
		NativeFieldInfoPtr_UnlimitedRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "UnlimitedRotations");
		NativeFieldInfoPtr_ConnectedMassScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "ConnectedMassScale");
		NativeFieldInfoPtr_ConnectedMassOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "ConnectedMassOverride");
		NativeFieldInfoPtr_Detach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "Detach");
		NativeFieldInfoPtr_ChainBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "ChainBlend");
		NativeFieldInfoPtr_OverrideBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "OverrideBlend");
		NativeFieldInfoPtr_AlternativeTensors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "AlternativeTensors");
		NativeFieldInfoPtr_AlternativeTensorsOnFall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "AlternativeTensorsOnFall");
		NativeFieldInfoPtr_tensorsSwitched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "tensorsSwitched");
		NativeFieldInfoPtr_HardMatchMultiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "HardMatchMultiply");
		NativeFieldInfoPtr__PlaymodeInitialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "<PlaymodeInitialized>k__BackingField");
		NativeFieldInfoPtr__ParentConnectionBones_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "<ParentConnectionBones>k__BackingField");
		NativeFieldInfoPtr_blendOnCollisionCulldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "blendOnCollisionCulldown");
		NativeFieldInfoPtr_blendOnCollisionMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "blendOnCollisionMin");
		NativeFieldInfoPtr_playmodeDetached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "playmodeDetached");
		NativeFieldInfoPtr__DummyParentObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, "<DummyParentObject>k__BackingField");
		NativeMethodInfoPtr_AutoAdjustColliders_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677701);
		NativeMethodInfoPtr_AutoAdjustColliders_Limb_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677702);
		NativeMethodInfoPtr_AutoAdjustColliders_Core_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677703);
		NativeMethodInfoPtr_AdjustColliderSettingsBasingOnTheStartEndPosition_Public_Vector3_RagdollChainBone_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677704);
		NativeMethodInfoPtr_AdjustColliderDirectionParams_Private_Void_RagdollChainBone_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677705);
		NativeMethodInfoPtr_GetAxisValue_Private_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677706);
		NativeMethodInfoPtr_SetAxisValue_Private_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677707);
		NativeMethodInfoPtr_GetChainAverageRadius_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677708);
		NativeMethodInfoPtr_CopyColliderSettingTo_Public_Static_Void_Collider_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677709);
		NativeMethodInfoPtr_CopyProvidesContacts_Private_Static_Void_Collider_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677710);
		NativeMethodInfoPtr_AutoAdjustPhysics_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677711);
		NativeMethodInfoPtr_AutoAdjustJointsAxes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677712);
		NativeMethodInfoPtr_AdjustJointAxesBasingOnTheStartEndPosition_Private_Void_RagdollChainBone_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677713);
		NativeMethodInfoPtr_AutoAdjustJointsLimits_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677714);
		NativeMethodInfoPtr_GetChainTypePercentageMass_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677715);
		NativeMethodInfoPtr_GetBoneMassPercentage_Public_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677716);
		NativeMethodInfoPtr_GetChainTypePercentageMassReal_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677717);
		NativeMethodInfoPtr_GetBoneMassPercentageReal_Public_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677718);
		NativeMethodInfoPtr_EnsureCollisionIgnoreBetweenChildBones_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677719);
		NativeMethodInfoPtr_CheckIfShouldIgnoreByBounds_Public_Void_RagdollChainBone_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677720);
		NativeMethodInfoPtr_ScaleCollider_Private_Void_Collider_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677721);
		NativeMethodInfoPtr_EnsureCollisionIgnoreBetweenBonesUsingBounds_Public_Void_List_1_RagdollBonesChain_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677722);
		NativeMethodInfoPtr_RemoveBoneAndItsChildren_Public_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677723);
		NativeMethodInfoPtr_RemoveRuntimeBoneProcessing_Public_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677724);
		NativeMethodInfoPtr_CollectAllConnectedBones_Public_List_1_RagdollChainBone_RagdollChainBone_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677725);
		NativeMethodInfoPtr_CollectAllFillBones_Public_List_1_InBetweenBone_List_1_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677726);
		NativeMethodInfoPtr_SwitchPhysics_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677727);
		NativeMethodInfoPtr_SetParentHandler_Public_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677728);
		NativeMethodInfoPtr_get_ParentHandler_Public_get_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677729);
		NativeMethodInfoPtr_get_LastBone_Public_get_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677730);
		NativeMethodInfoPtr_get_RuntimeBoneProcessors_Public_get_List_1_RagdollBoneProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677731);
		NativeMethodInfoPtr_set_RuntimeBoneProcessors_Private_set_Void_List_1_RagdollBoneProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677732);
		NativeMethodInfoPtr_get_ConnectionBone_Public_get_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677733);
		NativeMethodInfoPtr_set_ConnectionBone_Private_set_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677734);
		NativeMethodInfoPtr_get_ChainBonesLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677735);
		NativeMethodInfoPtr_set_ChainBonesLength_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677736);
		NativeMethodInfoPtr_GetScaleMultiplier_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677737);
		NativeMethodInfoPtr_GetThicknessMultiplier_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677738);
		NativeMethodInfoPtr_get_PlaymodeInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677739);
		NativeMethodInfoPtr_set_PlaymodeInitialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677740);
		NativeMethodInfoPtr_CompletePlaymodeInitialization_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677741);
		NativeMethodInfoPtr_get_ParentConnectionBones_Public_get_List_1_InBetweenBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677742);
		NativeMethodInfoPtr_set_ParentConnectionBones_Private_set_Void_List_1_InBetweenBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677743);
		NativeMethodInfoPtr__ctor_Public_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677744);
		NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677745);
		NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_ERagdollBoneID_EColliderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677746);
		NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_Boolean_EColliderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677747);
		NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_Transform_EColliderType_ERagdollBoneID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677748);
		NativeMethodInfoPtr_Setup_GatherChildBones_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677749);
		NativeMethodInfoPtr_GetBone_Public_RagdollChainBone_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677750);
		NativeMethodInfoPtr_GetBone_Public_RagdollChainBone_ERagdollBoneID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677751);
		NativeMethodInfoPtr_GetIndex_Public_Int32_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677752);
		NativeMethodInfoPtr_GetParent_Public_RagdollChainBone_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677753);
		NativeMethodInfoPtr_ContainsAnimatorBoneTransform_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677754);
		NativeMethodInfoPtr_ContainsAnimatorBoneTransform_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677755);
		NativeMethodInfoPtr_ContainsDummyBoneTransform_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677756);
		NativeMethodInfoPtr_CalculateLength_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677757);
		NativeMethodInfoPtr_get_DummyParentObject_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677758);
		NativeMethodInfoPtr_set_DummyParentObject_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677759);
		NativeMethodInfoPtr_GenerateDummyLimb_Public_Transform_RagdollHandler_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677760);
		NativeMethodInfoPtr_GetAverageStepSizeOfTheChain_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677761);
		NativeMethodInfoPtr_RefreshRagdollComponents_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677762);
		NativeMethodInfoPtr_RefreshJointsParentingDefault_Public_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677763);
		NativeMethodInfoPtr_RefreshBonesParentBoneVariable_Public_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677764);
		NativeMethodInfoPtr_DetachBones_Public_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677765);
		NativeMethodInfoPtr_RefreshJointsParentingWithInBetweenBones_Public_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677766);
		NativeMethodInfoPtr_GetSymmetryChainByType_Public_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677767);
		NativeMethodInfoPtr_GetSymmetryTo_Public_RagdollChainBone_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677768);
		NativeMethodInfoPtr_FindSymmetryChainTo_Public_Static_RagdollBonesChain_RagdollHandler_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677769);
		NativeMethodInfoPtr_HasSymmetryTo_Public_Boolean_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677770);
		NativeMethodInfoPtr_IsTypeRelatedWith_Public_Boolean_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677771);
		NativeMethodInfoPtr_Calibrate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677772);
		NativeMethodInfoPtr_CalibrateJustRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677773);
		NativeMethodInfoPtr_ApplyPhysicalRotationsToTheSkeleton_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677774);
		NativeMethodInfoPtr_GetBlend_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677775);
		NativeMethodInfoPtr_ApplyPhysicalPositionToTheSkeleton_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677776);
		NativeMethodInfoPtr_CaptureAnimator_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677777);
		NativeMethodInfoPtr_ConfigureJointsAnchors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677778);
		NativeMethodInfoPtr_User_ForceOverrideAllBonesBlendFor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677779);
		NativeMethodInfoPtr_User_ResetOverrideBlends_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677780);
		NativeMethodInfoPtr_TryIdentifyBoneIDs_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677781);
		NativeMethodInfoPtr_StoreCalibrationPose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677782);
		NativeMethodInfoPtr_RestoreCalibrationPose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677783);
		NativeMethodInfoPtr_IgnoreCollisionsWith_Public_Void_Collider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677784);
		NativeMethodInfoPtr_DefineConnectionBone_Internal_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr, 100677785);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238922, RefRangeEnd = 238923, XrefRangeStart = 238920, XrefRangeEnd = 238922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoAdjustColliders(bool isHumanoid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isHumanoid);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoAdjustColliders_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238971, RefRangeEnd = 238972, XrefRangeStart = 238923, XrefRangeEnd = 238971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoAdjustColliders_Limb()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoAdjustColliders_Limb_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239128, RefRangeEnd = 239129, XrefRangeStart = 238972, XrefRangeEnd = 239128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoAdjustColliders_Core(bool isHumanoid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isHumanoid);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoAdjustColliders_Core_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 239184, RefRangeEnd = 239188, XrefRangeStart = 239129, XrefRangeEnd = 239184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 AdjustColliderSettingsBasingOnTheStartEndPosition(RagdollChainBone bone, int boneIndex, Vector3 startPosition, Vector3 targetEndPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boneIndex;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startPosition;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetEndPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustColliderSettingsBasingOnTheStartEndPosition_Public_Vector3_RagdollChainBone_Int32_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239206, RefRangeEnd = 239207, XrefRangeStart = 239188, XrefRangeEnd = 239206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdjustColliderDirectionParams(RagdollChainBone bone, Vector3 colliderDir, float diffLocalMagn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colliderDir;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &diffLocalMagn;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustColliderDirectionParams_Private_Void_RagdollChainBone_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float GetAxisValue(Vector3 axis, Vector3 getFrom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&axis);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &getFrom;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxisValue_Private_Single_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector3 SetAxisValue(Vector3 axis, Vector3 baseValue, Vector3 selectFrom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&axis);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseValue;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &selectFrom;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAxisValue_Private_Vector3_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239207, XrefRangeEnd = 239210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChainAverageRadius(int boneIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&boneIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChainAverageRadius_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 239260, RefRangeEnd = 239263, XrefRangeStart = 239210, XrefRangeEnd = 239260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyColliderSettingTo(Collider copyFrom, Collider pasteTo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyColliderSettingTo_Public_Static_Void_Collider_Collider_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239263, XrefRangeEnd = 239266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyProvidesContacts(Collider to, Collider from)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)to);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyProvidesContacts_Private_Static_Void_Collider_Collider_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239275, RefRangeEnd = 239276, XrefRangeStart = 239266, XrefRangeEnd = 239275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoAdjustPhysics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoAdjustPhysics_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239323, RefRangeEnd = 239324, XrefRangeStart = 239276, XrefRangeEnd = 239323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoAdjustJointsAxes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoAdjustJointsAxes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239338, RefRangeEnd = 239339, XrefRangeStart = 239324, XrefRangeEnd = 239338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdjustJointAxesBasingOnTheStartEndPosition(RagdollChainBone bone, int boneIndex, Vector3 startPosition, Vector3 targetEndPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boneIndex;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startPosition;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetEndPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustJointAxesBasingOnTheStartEndPosition_Private_Void_RagdollChainBone_Int32_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239360, RefRangeEnd = 239361, XrefRangeStart = 239339, XrefRangeEnd = 239360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AutoAdjustJointsLimits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoAdjustJointsLimits_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239363, RefRangeEnd = 239364, XrefRangeStart = 239361, XrefRangeEnd = 239363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChainTypePercentageMass()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChainTypePercentageMass_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 239372, RefRangeEnd = 239375, XrefRangeStart = 239364, XrefRangeEnd = 239372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBoneMassPercentage(int index, float totalLimbMul)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &totalLimbMul;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBoneMassPercentage_Public_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239375, XrefRangeEnd = 239377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChainTypePercentageMassReal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChainTypePercentageMassReal_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239377, XrefRangeEnd = 239387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBoneMassPercentageReal(int index, float totalLimbMul)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &totalLimbMul;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBoneMassPercentageReal_Public_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239400, RefRangeEnd = 239401, XrefRangeStart = 239387, XrefRangeEnd = 239400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureCollisionIgnoreBetweenChildBones()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureCollisionIgnoreBetweenChildBones_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239401, XrefRangeEnd = 239416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckIfShouldIgnoreByBounds(RagdollChainBone otherBone, float boundsSize = 1.1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherBone);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundsSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfShouldIgnoreByBounds_Public_Void_RagdollChainBone_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 239424, RefRangeEnd = 239428, XrefRangeStart = 239416, XrefRangeEnd = 239424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScaleCollider(Collider c, float scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleCollider_Private_Void_Collider_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239577, RefRangeEnd = 239578, XrefRangeStart = 239428, XrefRangeEnd = 239577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureCollisionIgnoreBetweenBonesUsingBounds(List<RagdollBonesChain> chains, float scaleUpFactor = 1.2f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chains);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleUpFactor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureCollisionIgnoreBetweenBonesUsingBounds_Public_Void_List_1_RagdollBonesChain_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239633, RefRangeEnd = 239634, XrefRangeStart = 239578, XrefRangeEnd = 239633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveBoneAndItsChildren(RagdollChainBone parentBone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBoneAndItsChildren_Public_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239641, RefRangeEnd = 239642, XrefRangeStart = 239634, XrefRangeEnd = 239641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveRuntimeBoneProcessing(RagdollChainBone ragdollChainBone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollChainBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRuntimeBoneProcessing_Public_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 239694, RefRangeEnd = 239697, XrefRangeStart = 239642, XrefRangeEnd = 239694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<RagdollChainBone> CollectAllConnectedBones(RagdollChainBone bone, bool includeSelf = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeSelf;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectAllConnectedBones_Public_List_1_RagdollChainBone_RagdollChainBone_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RagdollChainBone>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 239731, RefRangeEnd = 239733, XrefRangeStart = 239697, XrefRangeEnd = 239731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<RagdollChainBone.InBetweenBone> CollectAllFillBones(List<RagdollChainBone> bones)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bones);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectAllFillBones_Public_List_1_InBetweenBone_List_1_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RagdollChainBone.InBetweenBone>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239748, RefRangeEnd = 239749, XrefRangeStart = 239733, XrefRangeEnd = 239748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchPhysics(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchPhysics_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224339, RefRangeEnd = 224340, XrefRangeStart = 224339, XrefRangeEnd = 224340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetParentHandler(RagdollHandler handler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParentHandler_Public_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239754, RefRangeEnd = 239755, XrefRangeStart = 239754, XrefRangeEnd = 239754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetScaleMultiplier()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScaleMultiplier_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239755, RefRangeEnd = 239756, XrefRangeStart = 239755, XrefRangeEnd = 239755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetThicknessMultiplier()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThicknessMultiplier_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239796, RefRangeEnd = 239797, XrefRangeStart = 239756, XrefRangeEnd = 239796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompletePlaymodeInitialization()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompletePlaymodeInitialization_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239810, RefRangeEnd = 239811, XrefRangeStart = 239797, XrefRangeEnd = 239810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollBonesChain(RagdollHandler ragdollHandler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollBonesChain>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 239827, RefRangeEnd = 239829, XrefRangeStart = 239811, XrefRangeEnd = 239827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollChainBone AddNewBone(Transform sceneBone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sceneBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 239834, RefRangeEnd = 239850, XrefRangeStart = 239829, XrefRangeEnd = 239834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollChainBone AddNewBone(ERagdollBoneID boneID, RagdollChainBone.EColliderType colliderType = RagdollChainBone.EColliderType.Capsule)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&boneID);
		*(RagdollChainBone.EColliderType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colliderType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_ERagdollBoneID_EColliderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239850, XrefRangeEnd = 239863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollChainBone AddNewBone(bool assignSuggestion = true, RagdollChainBone.EColliderType colliderType = RagdollChainBone.EColliderType.Capsule)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&assignSuggestion);
		*(RagdollChainBone.EColliderType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colliderType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_Boolean_EColliderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239879, RefRangeEnd = 239880, XrefRangeStart = 239863, XrefRangeEnd = 239879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollChainBone AddNewBone(Transform sourceBone, RagdollChainBone.EColliderType colliderType, ERagdollBoneID boneID = ERagdollBoneID.Unknown)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceBone);
		*(RagdollChainBone.EColliderType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colliderType;
		*(ERagdollBoneID**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &boneID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewBone_Public_RagdollChainBone_Transform_EColliderType_ERagdollBoneID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239880, XrefRangeEnd = 239902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup_GatherChildBones()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_GatherChildBones_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 239910, RefRangeEnd = 239922, XrefRangeStart = 239902, XrefRangeEnd = 239910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollChainBone GetBone(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBone_Public_RagdollChainBone_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239922, XrefRangeEnd = 239933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollChainBone GetBone(ERagdollBoneID id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBone_Public_RagdollChainBone_ERagdollBoneID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 239938, RefRangeEnd = 239944, XrefRangeStart = 239933, XrefRangeEnd = 239938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetIndex(RagdollChainBone bone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIndex_Public_Int32_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239944, XrefRangeEnd = 239951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollChainBone GetParent(RagdollChainBone bone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParent_Public_RagdollChainBone_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 239965, RefRangeEnd = 239969, XrefRangeStart = 239951, XrefRangeEnd = 239965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsAnimatorBoneTransform(Transform checkBone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)checkBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsAnimatorBoneTransform_Public_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239981, RefRangeEnd = 239982, XrefRangeStart = 239969, XrefRangeEnd = 239981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsAnimatorBoneTransform(string boneName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(boneName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsAnimatorBoneTransform_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 239996, RefRangeEnd = 239998, XrefRangeStart = 239982, XrefRangeEnd = 239996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsDummyBoneTransform(Transform checkBone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)checkBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsDummyBoneTransform_Public_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240017, RefRangeEnd = 240018, XrefRangeStart = 239998, XrefRangeEnd = 240017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateLength()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateLength_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240184, RefRangeEnd = 240185, XrefRangeStart = 240018, XrefRangeEnd = 240184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GenerateDummyLimb(RagdollHandler handler, bool generateLostParents = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateLostParents;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateDummyLimb_Public_Transform_RagdollHandler_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240185, XrefRangeEnd = 240206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAverageStepSizeOfTheChain()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAverageStepSizeOfTheChain_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240216, RefRangeEnd = 240217, XrefRangeStart = 240206, XrefRangeEnd = 240216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshRagdollComponents(bool addOnSource = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addOnSource);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshRagdollComponents_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 240240, RefRangeEnd = 240242, XrefRangeStart = 240217, XrefRangeEnd = 240240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshJointsParentingDefault(RagdollChainBone parentBone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshJointsParentingDefault_Public_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240257, RefRangeEnd = 240258, XrefRangeStart = 240242, XrefRangeEnd = 240257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshBonesParentBoneVariable(RagdollChainBone parentBone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshBonesParentBoneVariable_Public_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240299, RefRangeEnd = 240300, XrefRangeStart = 240258, XrefRangeEnd = 240299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DetachBones(RagdollHandler handler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetachBones_Public_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240300, XrefRangeEnd = 240334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshJointsParentingWithInBetweenBones(RagdollChainBone parentBone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshJointsParentingWithInBetweenBones_Public_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240334, XrefRangeEnd = 240335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollBonesChain GetSymmetryChainByType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSymmetryChainByType_Public_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240335, XrefRangeEnd = 240344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollChainBone GetSymmetryTo(RagdollChainBone bone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSymmetryTo_Public_RagdollChainBone_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 240384, RefRangeEnd = 240386, XrefRangeStart = 240344, XrefRangeEnd = 240384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RagdollBonesChain FindSymmetryChainTo(RagdollHandler handler, RagdollBonesChain chain)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSymmetryChainTo_Public_Static_RagdollBonesChain_RagdollHandler_RagdollBonesChain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240386, XrefRangeEnd = 240396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasSymmetryTo(RagdollChainBone bone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSymmetryTo_Public_Boolean_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240396, XrefRangeEnd = 240400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTypeRelatedWith(RagdollBonesChain ragdollBonesChain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollBonesChain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTypeRelatedWith_Public_Boolean_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240415, RefRangeEnd = 240416, XrefRangeStart = 240400, XrefRangeEnd = 240415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Calibrate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Calibrate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240431, RefRangeEnd = 240432, XrefRangeStart = 240416, XrefRangeEnd = 240431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalibrateJustRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalibrateJustRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240448, RefRangeEnd = 240449, XrefRangeStart = 240432, XrefRangeEnd = 240448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyPhysicalRotationsToTheSkeleton(float finalBlend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&finalBlend);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyPhysicalRotationsToTheSkeleton_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240449, RefRangeEnd = 240450, XrefRangeStart = 240449, XrefRangeEnd = 240449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBlend(float baseBlend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&baseBlend);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBlend_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240466, RefRangeEnd = 240467, XrefRangeStart = 240450, XrefRangeEnd = 240466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyPhysicalPositionToTheSkeleton(float finalBlend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&finalBlend);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyPhysicalPositionToTheSkeleton_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240482, RefRangeEnd = 240483, XrefRangeStart = 240467, XrefRangeEnd = 240482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CaptureAnimator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaptureAnimator_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 240498, RefRangeEnd = 240500, XrefRangeStart = 240483, XrefRangeEnd = 240498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureJointsAnchors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureJointsAnchors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240500, XrefRangeEnd = 240528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void User_ForceOverrideAllBonesBlendFor(float duration, float transitionTime = 0.1f, float targetOverrideBlend = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&duration);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transitionTime;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetOverrideBlend;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ForceOverrideAllBonesBlendFor_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240543, RefRangeEnd = 240544, XrefRangeStart = 240528, XrefRangeEnd = 240543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void User_ResetOverrideBlends()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ResetOverrideBlends_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240544, XrefRangeEnd = 240559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryIdentifyBoneIDs(bool changeOnlyUnknowns = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&changeOnlyUnknowns);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryIdentifyBoneIDs_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240574, RefRangeEnd = 240575, XrefRangeStart = 240559, XrefRangeEnd = 240574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreCalibrationPose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreCalibrationPose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240590, RefRangeEnd = 240591, XrefRangeStart = 240575, XrefRangeEnd = 240590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreCalibrationPose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreCalibrationPose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 240620, RefRangeEnd = 240623, XrefRangeStart = 240591, XrefRangeEnd = 240620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IgnoreCollisionsWith(Collider coll, bool ignore)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)coll);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignore;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IgnoreCollisionsWith_Public_Void_Collider_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 240626, RefRangeEnd = 240627, XrefRangeStart = 240623, XrefRangeEnd = 240626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DefineConnectionBone(RagdollHandler ragdollHandler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DefineConnectionBone_Internal_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RagdollBonesChain(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
