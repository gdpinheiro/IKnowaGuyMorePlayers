using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation;

[System.Serializable]
public class RagdollChainBone : Il2CppSystem.Object
{
	public enum EColliderType
	{
		Capsule,
		Sphere,
		Box,
		Mesh,
		Other
	}

	public enum ECapsuleDirection
	{
		X,
		Y,
		Z
	}

	[System.Serializable]
	public class ColliderSetup : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ColliderType;

		private static readonly System.IntPtr NativeFieldInfoPtr_ColliderCenter;

		private static readonly System.IntPtr NativeFieldInfoPtr_ColliderSizeMultiply;

		private static readonly System.IntPtr NativeFieldInfoPtr_CapsuleDirection;

		private static readonly System.IntPtr NativeFieldInfoPtr_ColliderRadius;

		private static readonly System.IntPtr NativeFieldInfoPtr_ColliderLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_ColliderBoxSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_ColliderMesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_OtherReference;

		private static readonly System.IntPtr NativeFieldInfoPtr_RotationCorrection;

		private static readonly System.IntPtr NativeFieldInfoPtr_ColliderExtraTransform;

		private static readonly System.IntPtr NativeFieldInfoPtr_GameCollider;

		private static readonly System.IntPtr NativeFieldInfoPtr_GameColliderOnSource;

		private static readonly System.IntPtr NativeFieldInfoPtr_BoundedIgnoreScale;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_RotationCorrectionQ_Public_get_Quaternion_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_UsingExtraTransform_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetScaleModded_Public_Vector3_RagdollBonesChain_RagdollChainBone_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ScaleUsingThickness_Public_Vector3_Vector3_Single_RagdollBonesChain_RagdollChainBone_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAverageScale_Public_Single_RagdollChainBone_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetColliderSizeAxes_Public_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCollider_Public_Collider_RagdollChainBone_Boolean_Int32_RagdollBonesChain_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ProceedIgnore_Private_Void_Collider_Collider_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IgnoreCollisionWith_Public_Void_Collider_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IgnoreCollisionWith_Public_Void_ColliderSetup_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DisposeWrongCollider_Private_Void_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Editor_GetHandleSize_Public_Single_RagdollChainBone_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DisposeRuntimeObjects_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLocalSize_Public_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSize_Public_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CopySettingsFromColliderComponent_Public_Void_Collider_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CopySettingsFromOtherSetup_Public_Void_ColliderSetup_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe EColliderType ColliderType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderType);
				return *(EColliderType*)num;
			}
			set
			{
				*(EColliderType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderType)) = eColliderType;
			}
		}

		public unsafe Vector3 ColliderCenter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderCenter);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderCenter)) = vector;
			}
		}

		public unsafe float ColliderSizeMultiply
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderSizeMultiply);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderSizeMultiply)) = num;
			}
		}

		public unsafe ECapsuleDirection CapsuleDirection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapsuleDirection);
				return *(ECapsuleDirection*)num;
			}
			set
			{
				*(ECapsuleDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapsuleDirection)) = eCapsuleDirection;
			}
		}

		public unsafe float ColliderRadius
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderRadius);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderRadius)) = num;
			}
		}

		public unsafe float ColliderLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderLength);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderLength)) = num;
			}
		}

		public unsafe Vector3 ColliderBoxSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderBoxSize);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderBoxSize)) = vector;
			}
		}

		public unsafe Mesh ColliderMesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderMesh);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
			}
		}

		public unsafe Collider OtherReference
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OtherReference);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OtherReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collider));
			}
		}

		public unsafe Vector3 RotationCorrection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationCorrection);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationCorrection)) = vector;
			}
		}

		public unsafe Transform ColliderExtraTransform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderExtraTransform);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColliderExtraTransform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Collider GameCollider
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameCollider);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameCollider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collider));
			}
		}

		public unsafe Collider GameColliderOnSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameColliderOnSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameColliderOnSource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collider));
			}
		}

		public unsafe float BoundedIgnoreScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BoundedIgnoreScale);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BoundedIgnoreScale)) = num;
			}
		}

		public unsafe Quaternion RotationCorrectionQ
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240638, XrefRangeEnd = 240639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RotationCorrectionQ_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe bool UsingExtraTransform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 240641, RefRangeEnd = 240643, XrefRangeStart = 240639, XrefRangeEnd = 240641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UsingExtraTransform_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static ColliderSetup()
		{
			Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "ColliderSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr);
			NativeFieldInfoPtr_ColliderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "ColliderType");
			NativeFieldInfoPtr_ColliderCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "ColliderCenter");
			NativeFieldInfoPtr_ColliderSizeMultiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "ColliderSizeMultiply");
			NativeFieldInfoPtr_CapsuleDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "CapsuleDirection");
			NativeFieldInfoPtr_ColliderRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "ColliderRadius");
			NativeFieldInfoPtr_ColliderLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "ColliderLength");
			NativeFieldInfoPtr_ColliderBoxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "ColliderBoxSize");
			NativeFieldInfoPtr_ColliderMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "ColliderMesh");
			NativeFieldInfoPtr_OtherReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "OtherReference");
			NativeFieldInfoPtr_RotationCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "RotationCorrection");
			NativeFieldInfoPtr_ColliderExtraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "ColliderExtraTransform");
			NativeFieldInfoPtr_GameCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "GameCollider");
			NativeFieldInfoPtr_GameColliderOnSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "GameColliderOnSource");
			NativeFieldInfoPtr_BoundedIgnoreScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, "BoundedIgnoreScale");
			NativeMethodInfoPtr_get_RotationCorrectionQ_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677883);
			NativeMethodInfoPtr_get_UsingExtraTransform_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677884);
			NativeMethodInfoPtr_GetScaleModded_Public_Vector3_RagdollBonesChain_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677885);
			NativeMethodInfoPtr_ScaleUsingThickness_Public_Vector3_Vector3_Single_RagdollBonesChain_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677886);
			NativeMethodInfoPtr_GetAverageScale_Public_Single_RagdollChainBone_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677887);
			NativeMethodInfoPtr_GetColliderSizeAxes_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677888);
			NativeMethodInfoPtr_RefreshCollider_Public_Collider_RagdollChainBone_Boolean_Int32_RagdollBonesChain_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677889);
			NativeMethodInfoPtr_ProceedIgnore_Private_Void_Collider_Collider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677890);
			NativeMethodInfoPtr_IgnoreCollisionWith_Public_Void_Collider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677891);
			NativeMethodInfoPtr_IgnoreCollisionWith_Public_Void_ColliderSetup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677892);
			NativeMethodInfoPtr_DisposeWrongCollider_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677893);
			NativeMethodInfoPtr_Editor_GetHandleSize_Public_Single_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677894);
			NativeMethodInfoPtr_DisposeRuntimeObjects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677895);
			NativeMethodInfoPtr_CalculateLocalSize_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677896);
			NativeMethodInfoPtr_CalculateSize_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677897);
			NativeMethodInfoPtr_CopySettingsFromColliderComponent_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677898);
			NativeMethodInfoPtr_CopySettingsFromOtherSetup_Public_Void_ColliderSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677899);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr, 100677900);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240643, XrefRangeEnd = 240649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetScaleModded(RagdollBonesChain chain, RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScaleModded_Public_Vector3_RagdollBonesChain_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240671, RefRangeEnd = 240673, XrefRangeStart = 240649, XrefRangeEnd = 240671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScaleUsingThickness(Vector3 scale, float thickness, RagdollBonesChain chain, RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&scale);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &thickness;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleUsingThickness_Public_Vector3_Vector3_Single_RagdollBonesChain_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240673, XrefRangeEnd = 240685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageScale(RagdollChainBone bone, float chainMultiply = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chainMultiply;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAverageScale_Public_Single_RagdollChainBone_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe Vector3 GetColliderSizeAxes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColliderSizeAxes_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240830, RefRangeEnd = 240831, XrefRangeStart = 240685, XrefRangeEnd = 240830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider RefreshCollider(RagdollChainBone bone, bool fallMode, int colliderIndex, RagdollBonesChain chain, bool onSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallMode;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &colliderIndex;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
			*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &onSource;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshCollider_Public_Collider_RagdollChainBone_Boolean_Int32_RagdollBonesChain_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr) : null;
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 240838, RefRangeEnd = 240841, XrefRangeStart = 240831, XrefRangeEnd = 240838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProceedIgnore(Collider a, Collider b, bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignore;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProceedIgnore_Private_Void_Collider_Collider_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 240854, RefRangeEnd = 240860, XrefRangeStart = 240841, XrefRangeEnd = 240854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IgnoreCollisionWith(Collider coll, bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)coll);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignore;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IgnoreCollisionWith_Public_Void_Collider_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 240873, RefRangeEnd = 240876, XrefRangeStart = 240860, XrefRangeEnd = 240873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IgnoreCollisionWith(ColliderSetup oColl, bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)oColl);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignore;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IgnoreCollisionWith_Public_Void_ColliderSetup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 240888, RefRangeEnd = 240893, XrefRangeStart = 240876, XrefRangeEnd = 240888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeWrongCollider(Il2CppSystem.Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetType);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeWrongCollider_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240893, XrefRangeEnd = 240902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Editor_GetHandleSize(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Editor_GetHandleSize_Public_Single_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240911, RefRangeEnd = 240912, XrefRangeStart = 240902, XrefRangeEnd = 240911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeRuntimeObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeRuntimeObjects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240912, XrefRangeEnd = 240917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 CalculateLocalSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateLocalSize_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240928, RefRangeEnd = 240929, XrefRangeStart = 240917, XrefRangeEnd = 240928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 CalculateSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSize_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240937, RefRangeEnd = 240938, XrefRangeStart = 240929, XrefRangeEnd = 240937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopySettingsFromColliderComponent(Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collider);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopySettingsFromColliderComponent_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240940, RefRangeEnd = 240941, XrefRangeStart = 240938, XrefRangeEnd = 240940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopySettingsFromOtherSetup(ColliderSetup copyFrom)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopySettingsFromOtherSetup_Public_Void_ColliderSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240948, RefRangeEnd = 240950, XrefRangeStart = 240941, XrefRangeEnd = 240948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColliderSetup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColliderSetup>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ColliderSetup(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class InBetweenBone : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_SourceBone;

		private static readonly System.IntPtr NativeFieldInfoPtr_DummyBone;

		private static readonly System.IntPtr NativeFieldInfoPtr_initLocalRotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_animatorLocalRotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_rigidbody;

		private static readonly System.IntPtr NativeFieldInfoPtr_FixedJoint;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_InitLocalRotation_Public_get_Quaternion_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AssignParent_Internal_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Calibrate_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CaptureAnimator_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SyncWithAnimator_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRigidbody_Internal_Rigidbody_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyPhysicalComponents_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Transform SourceBone
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceBone);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceBone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform DummyBone
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DummyBone);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DummyBone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Quaternion initLocalRotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalRotation);
				return *(Quaternion*)num;
			}
			set
			{
				*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalRotation)) = quaternion;
			}
		}

		public unsafe Quaternion animatorLocalRotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorLocalRotation);
				return *(Quaternion*)num;
			}
			set
			{
				*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorLocalRotation)) = quaternion;
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

		public unsafe FixedJoint FixedJoint
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedJoint);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FixedJoint>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedJoint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fixedJoint));
			}
		}

		public unsafe Quaternion InitLocalRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InitLocalRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static InBetweenBone()
		{
			Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "InBetweenBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr);
			NativeFieldInfoPtr_SourceBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, "SourceBone");
			NativeFieldInfoPtr_DummyBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, "DummyBone");
			NativeFieldInfoPtr_initLocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, "initLocalRotation");
			NativeFieldInfoPtr_animatorLocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, "animatorLocalRotation");
			NativeFieldInfoPtr_rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, "rigidbody");
			NativeFieldInfoPtr_FixedJoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, "FixedJoint");
			NativeMethodInfoPtr_get_InitLocalRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, 100677901);
			NativeMethodInfoPtr_Initialize_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, 100677902);
			NativeMethodInfoPtr_AssignParent_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, 100677903);
			NativeMethodInfoPtr_Calibrate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, 100677904);
			NativeMethodInfoPtr_CaptureAnimator_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, 100677905);
			NativeMethodInfoPtr_SyncWithAnimator_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, 100677906);
			NativeMethodInfoPtr_GenerateRigidbody_Internal_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, 100677907);
			NativeMethodInfoPtr_DestroyPhysicalComponents_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, 100677908);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr, 100677909);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240950, XrefRangeEnd = 240951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 240958, RefRangeEnd = 240962, XrefRangeStart = 240951, XrefRangeEnd = 240958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignParent(Transform setParentIfNoParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)setParentIfNoParent);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignParent_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240962, XrefRangeEnd = 240963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Calibrate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Calibrate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240964, RefRangeEnd = 240965, XrefRangeStart = 240963, XrefRangeEnd = 240964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CaptureAnimator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaptureAnimator_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240965, XrefRangeEnd = 240966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncWithAnimator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncWithAnimator_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240977, RefRangeEnd = 240978, XrefRangeStart = 240966, XrefRangeEnd = 240977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rigidbody GenerateRigidbody()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRigidbody_Internal_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240987, RefRangeEnd = 240988, XrefRangeStart = 240978, XrefRangeEnd = 240987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyPhysicalComponents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyPhysicalComponents_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InBetweenBone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InBetweenBone>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public InBetweenBone(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct ReferencePoseCoordinates
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_LocalSpacePosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_LocalSpaceRotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_RootSpacePosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_RootSpaceRotation;

		[FieldOffset(0)]
		public Vector3 LocalSpacePosition;

		[FieldOffset(12)]
		public Quaternion LocalSpaceRotation;

		[FieldOffset(28)]
		public Vector3 RootSpacePosition;

		[FieldOffset(40)]
		public Quaternion RootSpaceRotation;

		static ReferencePoseCoordinates()
		{
			Il2CppClassPointerStore<ReferencePoseCoordinates>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "ReferencePoseCoordinates");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferencePoseCoordinates>.NativeClassPtr);
			NativeFieldInfoPtr_LocalSpacePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferencePoseCoordinates>.NativeClassPtr, "LocalSpacePosition");
			NativeFieldInfoPtr_LocalSpaceRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferencePoseCoordinates>.NativeClassPtr, "LocalSpaceRotation");
			NativeFieldInfoPtr_RootSpacePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferencePoseCoordinates>.NativeClassPtr, "RootSpacePosition");
			NativeFieldInfoPtr_RootSpaceRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferencePoseCoordinates>.NativeClassPtr, "RootSpaceRotation");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReferencePoseCoordinates>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollChainBone+<>c__DisplayClass129_0")]
	public sealed class __c__DisplayClass129_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pMaterial;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ApplyPhysicMaterial_b__0_Internal_Void_Collider_0;

		public unsafe PhysicsMaterial pMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pMaterial);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PhysicsMaterial>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)physicsMaterial));
			}
		}

		static __c__DisplayClass129_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass129_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<>c__DisplayClass129_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass129_0>.NativeClassPtr);
			NativeFieldInfoPtr_pMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass129_0>.NativeClassPtr, "pMaterial");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass129_0>.NativeClassPtr, 100677910);
			NativeMethodInfoPtr__ApplyPhysicMaterial_b__0_Internal_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass129_0>.NativeClassPtr, 100677911);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass129_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass129_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240988, XrefRangeEnd = 240990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ApplyPhysicMaterial_b__0(Collider c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ApplyPhysicMaterial_b__0_Internal_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass129_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollChainBone+<>c__DisplayClass138_0")]
	public sealed class __c__DisplayClass138_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_chain;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RefreshDynamicPhysicalParameters_b__0_Internal_Void_0;

		public unsafe RagdollBonesChain chain
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chain);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollBonesChain));
			}
		}

		public unsafe RagdollChainBone __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollChainBone));
			}
		}

		static __c__DisplayClass138_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass138_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<>c__DisplayClass138_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass138_0>.NativeClassPtr);
			NativeFieldInfoPtr_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass138_0>.NativeClassPtr, "chain");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass138_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass138_0>.NativeClassPtr, 100677912);
			NativeMethodInfoPtr__RefreshDynamicPhysicalParameters_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass138_0>.NativeClassPtr, 100677913);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass138_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass138_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240990, XrefRangeEnd = 240991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RefreshDynamicPhysicalParameters_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RefreshDynamicPhysicalParameters_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass138_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollChainBone+<IEForceOverrideBlend>d__160")]
	public sealed class _IEForceOverrideBlend_d__160 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_parentHandler;

		private static readonly System.IntPtr NativeFieldInfoPtr_targetOverrideBlend;

		private static readonly System.IntPtr NativeFieldInfoPtr_transitionTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_duration;

		private static readonly System.IntPtr NativeFieldInfoPtr__elapsed_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__startBlend_5__3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe RagdollChainBone __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollChainBone));
			}
		}

		public unsafe RagdollHandler parentHandler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentHandler);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollHandler>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollHandler));
			}
		}

		public unsafe float targetOverrideBlend
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetOverrideBlend);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetOverrideBlend)) = num;
			}
		}

		public unsafe float transitionTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionTime)) = num;
			}
		}

		public unsafe float duration
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration)) = num;
			}
		}

		public unsafe float _elapsed_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elapsed_5__2);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elapsed_5__2)) = num;
			}
		}

		public unsafe float _startBlend_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startBlend_5__3);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startBlend_5__3)) = num;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 24312, RefRangeEnd = 24460, XrefRangeStart = 24312, XrefRangeEnd = 24460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 24312, RefRangeEnd = 24460, XrefRangeStart = 24312, XrefRangeEnd = 24460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _IEForceOverrideBlend_d__160()
		{
			Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<IEForceOverrideBlend>d__160");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_parentHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, "parentHandler");
			NativeFieldInfoPtr_targetOverrideBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, "targetOverrideBlend");
			NativeFieldInfoPtr_transitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, "transitionTime");
			NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, "duration");
			NativeFieldInfoPtr__elapsed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, "<elapsed>5__2");
			NativeFieldInfoPtr__startBlend_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, "<startBlend>5__3");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, 100677914);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, 100677915);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, 100677916);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, 100677917);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, 100677918);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr, 100677919);
		}

		[CallerCount(195)]
		[CachedScanResults(RefRangeStart = 24030, RefRangeEnd = 24225, XrefRangeStart = 24030, XrefRangeEnd = 24225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _IEForceOverrideBlend_d__160(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_IEForceOverrideBlend_d__160>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(17126)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 17126, XrefRangeStart = 0, XrefRangeEnd = 17126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240991, XrefRangeEnd = 240996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240996, XrefRangeEnd = 241001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _IEForceOverrideBlend_d__160(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetOrGenerate_Private_T_Transform_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetOrGenerate_Private_T_Transform_0, Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_SourceBone;

	private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalDummyBone;

	private static readonly System.IntPtr NativeFieldInfoPtr_DetachParent;

	private static readonly System.IntPtr NativeFieldInfoPtr__ParentChain_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ParentBone_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__BoneProcessor_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAnchor;

	private static readonly System.IntPtr NativeFieldInfoPtr_SourceBoneDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_BypassKinematicControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_BoundedIgnoreScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_WasDismembered;

	private static readonly System.IntPtr NativeFieldInfoPtr_ParentDismembered;

	private static readonly System.IntPtr NativeFieldInfoPtr__InitialConnectedBody_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__InitialJointAnchor_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlaymodeInitialized_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__GameRigidbody_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Joint_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_BoneID;

	private static readonly System.IntPtr NativeFieldInfoPtr_colliders;

	private static readonly System.IntPtr NativeFieldInfoPtr_MassMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_MusclesBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_TargetMainAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_InverseMainAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainAxisLowLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainAxisHighLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_TargetSecondaryAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_InverseSecondaryAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryAxisAngleLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_ThirdAxisAngleLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseIndividualParameters;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideInterpolation;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideDetectionMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideDragValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideAngularDrag;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideSpringPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideSpringDamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_HardMatchingMultiply;

	private static readonly System.IntPtr NativeFieldInfoPtr_HardMatchOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionMassOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisableCollisionEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceLimitsAllTheTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceKinematicOnStanding;

	private static readonly System.IntPtr NativeFieldInfoPtr__wasForceKinematicOnStanding;

	private static readonly System.IntPtr NativeFieldInfoPtr_AllowConfigurablePosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_LinearSpringLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_LinearSpringDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_BoneBlendMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalForward;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToBase;

	private static readonly System.IntPtr NativeFieldInfoPtr__InBetweenBones_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TargetConnectedMassScale_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_StoredReferencePose;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr__forceBlendCoro;

	private static readonly System.IntPtr NativeFieldInfoPtr__forceBlendStartOverr;

	private static readonly System.IntPtr NativeFieldInfoPtr_wasPhysicsDisabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_kinematicOnDisabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_MotionInfluenceMultiplier;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentChain_Public_get_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ParentChain_Private_set_Void_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentBone_Public_get_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ParentBone_Private_set_Void_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BoneProcessor_Public_get_RagdollBoneProcessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BoneProcessor_Private_set_Void_RagdollBoneProcessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Posing_Public_get_RagdollBoneProcessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InitialConnectedBody_Public_get_Rigidbody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_InitialConnectedBody_Internal_set_Void_Rigidbody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InitialJointAnchor_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_InitialJointAnchor_Private_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlaymodeInitialized_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_PlaymodeInitialized_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDummyBone_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaymodeInitialize_Public_Void_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GameRigidbody_Public_get_Rigidbody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_GameRigidbody_Private_set_Void_Rigidbody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MainBoneCollider_Public_get_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Joint_Public_get_ConfigurableJoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Joint_Private_set_Void_ConfigurableJoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyToAllColliders_Public_Void_Action_1_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Colliders_Public_get_List_1_ColliderSetup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BaseColliderSetup_Public_get_ColliderSetup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchOffJointAnimationMatching_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddColliderSetup_Public_ColliderSetup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveColliderSetup_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColliderSetup_Public_ColliderSetup_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMatrix_Public_Matrix4x4_Vector3_Vector3_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainAxis_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMainAxisByVector_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSecondaryAxisByVector_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainAxisLowLimit_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainAxisHighLimit_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSecondaryAxis_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSecondaryAxisAngleLimit_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetThirdAxisAngleLimit_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetThirdAxis_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMass_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoAutoMassSettings_Public_Void_RagdollHandler_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRigidbodyDrag_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRigidbodyAngularDrag_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainAxisLimitContactDistance_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainAxisLimitBounciness_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainAxisLimitSpring_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainAxisLimitDamper_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOtherAxesLimitSpring_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOtherAxesLimitDamper_Public_Single_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreHelperReferenceValues_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InBetweenBones_Public_get_List_1_InBetweenBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_InBetweenBones_Private_set_Void_List_1_InBetweenBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInBetweenBones_Public_Void_List_1_InBetweenBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshRigidbody_Public_Rigidbody_RagdollHandler_RagdollBonesChain_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshRigidbodyOptimizationParameters_Public_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSolversCount_Private_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshRigidbodyInterpolation_Protected_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UsingExtraTransform_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPhysicMaterial_Public_Void_PhysicsMaterial_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCollider_Public_Void_RagdollBonesChain_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrGenerate_Private_T_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshJoint_Public_ConfigurableJoint_RagdollBonesChain_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshJointLimitSwitch_Public_Void_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetConnectedMassScale_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetConnectedMassScale_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshDynamicPhysicalParameters_Public_Void_RagdollBonesChain_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchIsKinematic_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureJointAnchors_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Joint_UpdateAngleLimits_Private_Void_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Joint_UpdateAngularSpringLimits_Private_Void_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Joint_SetMotionLock_Public_Void_ConfigurableJointMotion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Joint_SetAngularMotionLock_Public_Void_ConfigurableJointMotion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Joint_SetPositionLimit_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetJointMatchingParameters_Public_Void_Single_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetJointMatchingParametersPosition_Public_Void_Single_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetZeroDrive_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetJointMatchingMaximumForce_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryIdentifyBoneID_Public_Void_RagdollBonesChain_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryDoAutoSettings_Public_Void_RagdollHandler_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ForceOverrideBlendFor_Public_Void_RagdollHandler_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ForceStopOverrideBlend_Public_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IEForceOverrideBlend_Private_IEnumerator_RagdollHandler_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyInBetweenBones_Internal_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IgnoreCollisionsWith_Public_Void_RagdollChainBone_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IgnoreCollisionsWith_Public_Void_Collider_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetJointFreeMotion_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchPhysics_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfShouldIgnoreByBounds_Public_Void_RagdollChainBone_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreCalibrationPose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreCalibrationPose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParentBone_Internal_Void_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Transform SourceBone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceBone);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceBone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform PhysicalDummyBone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhysicalDummyBone);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhysicalDummyBone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform DetachParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DetachParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DetachParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe RagdollBonesChain _ParentChain_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentChain_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentChain_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollBonesChain));
		}
	}

	public unsafe RagdollChainBone _ParentBone_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentBone_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentBone_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollChainBone));
		}
	}

	public unsafe RagdollBoneProcessor _BoneProcessor_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BoneProcessor_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBoneProcessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BoneProcessor_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollBoneProcessor));
		}
	}

	public unsafe bool IsAnchor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAnchor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAnchor)) = flag;
		}
	}

	public unsafe int SourceBoneDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceBoneDepth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceBoneDepth)) = num;
		}
	}

	public unsafe bool BypassKinematicControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BypassKinematicControl);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BypassKinematicControl)) = flag;
		}
	}

	public unsafe float BoundedIgnoreScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BoundedIgnoreScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BoundedIgnoreScale)) = num;
		}
	}

	public unsafe bool WasDismembered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasDismembered);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasDismembered)) = flag;
		}
	}

	public unsafe bool ParentDismembered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParentDismembered);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParentDismembered)) = flag;
		}
	}

	public unsafe Rigidbody _InitialConnectedBody_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InitialConnectedBody_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InitialConnectedBody_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody));
		}
	}

	public unsafe Vector3 _InitialJointAnchor_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InitialJointAnchor_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InitialJointAnchor_k__BackingField)) = vector;
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

	public unsafe Rigidbody _GameRigidbody_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GameRigidbody_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GameRigidbody_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody));
		}
	}

	public unsafe ConfigurableJoint _Joint_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Joint_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Joint_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configurableJoint));
		}
	}

	public unsafe ERagdollBoneID BoneID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BoneID);
			return *(ERagdollBoneID*)num;
		}
		set
		{
			*(ERagdollBoneID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BoneID)) = eRagdollBoneID;
		}
	}

	public unsafe List<ColliderSetup> colliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ColliderSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe float ForceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceMultiplier)) = num;
		}
	}

	public unsafe float MusclesBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MusclesBoost);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MusclesBoost)) = num;
		}
	}

	public unsafe EJointAxis MainAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainAxis);
			return *(EJointAxis*)num;
		}
		set
		{
			*(EJointAxis*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainAxis)) = eJointAxis;
		}
	}

	public unsafe Vector3 TargetMainAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetMainAxis);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetMainAxis)) = vector;
		}
	}

	public unsafe bool InverseMainAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InverseMainAxis);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InverseMainAxis)) = flag;
		}
	}

	public unsafe float MainAxisLowLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainAxisLowLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainAxisLowLimit)) = num;
		}
	}

	public unsafe float MainAxisHighLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainAxisHighLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainAxisHighLimit)) = num;
		}
	}

	public unsafe EJointAxis SecondaryAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SecondaryAxis);
			return *(EJointAxis*)num;
		}
		set
		{
			*(EJointAxis*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SecondaryAxis)) = eJointAxis;
		}
	}

	public unsafe Vector3 TargetSecondaryAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetSecondaryAxis);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetSecondaryAxis)) = vector;
		}
	}

	public unsafe bool InverseSecondaryAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InverseSecondaryAxis);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InverseSecondaryAxis)) = flag;
		}
	}

	public unsafe float SecondaryAxisAngleLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SecondaryAxisAngleLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SecondaryAxisAngleLimit)) = num;
		}
	}

	public unsafe float ThirdAxisAngleLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ThirdAxisAngleLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ThirdAxisAngleLimit)) = num;
		}
	}

	public unsafe PhysicsMaterial OverrideMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PhysicsMaterial>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)physicsMaterial));
		}
	}

	public unsafe bool UseIndividualParameters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseIndividualParameters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseIndividualParameters)) = flag;
		}
	}

	public unsafe RigidbodyInterpolation OverrideInterpolation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideInterpolation);
			return *(RigidbodyInterpolation*)num;
		}
		set
		{
			*(RigidbodyInterpolation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideInterpolation)) = rigidbodyInterpolation;
		}
	}

	public unsafe CollisionDetectionMode OverrideDetectionMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideDetectionMode);
			return *(CollisionDetectionMode*)num;
		}
		set
		{
			*(CollisionDetectionMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideDetectionMode)) = collisionDetectionMode;
		}
	}

	public unsafe float OverrideDragValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideDragValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideDragValue)) = num;
		}
	}

	public unsafe float OverrideAngularDrag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideAngularDrag);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideAngularDrag)) = num;
		}
	}

	public unsafe float OverrideSpringPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideSpringPower);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideSpringPower)) = num;
		}
	}

	public unsafe float OverrideSpringDamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideSpringDamp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideSpringDamp)) = num;
		}
	}

	public unsafe float HardMatchingMultiply
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HardMatchingMultiply);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HardMatchingMultiply)) = num;
		}
	}

	public unsafe float HardMatchOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HardMatchOverride);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HardMatchOverride)) = num;
		}
	}

	public unsafe float ConnectionMassOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionMassOverride);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectionMassOverride)) = num;
		}
	}

	public unsafe bool DisableCollisionEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableCollisionEvents);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableCollisionEvents)) = flag;
		}
	}

	public unsafe bool ForceLimitsAllTheTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceLimitsAllTheTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceLimitsAllTheTime)) = flag;
		}
	}

	public unsafe bool ForceKinematicOnStanding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceKinematicOnStanding);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceKinematicOnStanding)) = flag;
		}
	}

	public unsafe bool _wasForceKinematicOnStanding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wasForceKinematicOnStanding);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wasForceKinematicOnStanding)) = flag;
		}
	}

	public unsafe bool AllowConfigurablePosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowConfigurablePosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowConfigurablePosition)) = flag;
		}
	}

	public unsafe float LinearSpringLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LinearSpringLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LinearSpringLimit)) = num;
		}
	}

	public unsafe float LinearSpringDamping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LinearSpringDamping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LinearSpringDamping)) = num;
		}
	}

	public unsafe float BoneBlendMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BoneBlendMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BoneBlendMultiplier)) = num;
		}
	}

	public unsafe Vector3 LocalRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalRight);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalRight)) = vector;
		}
	}

	public unsafe Vector3 LocalUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalUp);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalUp)) = vector;
		}
	}

	public unsafe Vector3 LocalForward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalForward);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalForward)) = vector;
		}
	}

	public unsafe Vector3 ToBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToBase);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToBase)) = vector;
		}
	}

	public unsafe List<InBetweenBone> _InBetweenBones_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InBetweenBones_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InBetweenBone>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InBetweenBones_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float _TargetConnectedMassScale_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetConnectedMassScale_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetConnectedMassScale_k__BackingField)) = num;
		}
	}

	public unsafe ReferencePoseCoordinates StoredReferencePose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StoredReferencePose);
			return *(ReferencePoseCoordinates*)num;
		}
		set
		{
			*(ReferencePoseCoordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StoredReferencePose)) = referencePoseCoordinates;
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

	public unsafe Coroutine _forceBlendCoro
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forceBlendCoro);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Coroutine>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forceBlendCoro)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)coroutine));
		}
	}

	public unsafe float _forceBlendStartOverr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forceBlendStartOverr);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forceBlendStartOverr)) = num;
		}
	}

	public unsafe bool wasPhysicsDisabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasPhysicsDisabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasPhysicsDisabled)) = flag;
		}
	}

	public unsafe bool kinematicOnDisabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kinematicOnDisabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kinematicOnDisabled)) = flag;
		}
	}

	public unsafe float MotionInfluenceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MotionInfluenceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MotionInfluenceMultiplier)) = num;
		}
	}

	public unsafe RagdollBonesChain ParentChain
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43141, RefRangeEnd = 43144, XrefRangeStart = 43141, XrefRangeEnd = 43144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentChain_Public_get_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ParentChain_Private_set_Void_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe RagdollChainBone ParentBone
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 43149, RefRangeEnd = 43165, XrefRangeStart = 43149, XrefRangeEnd = 43165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentBone_Public_get_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 232707, RefRangeEnd = 232714, XrefRangeStart = 232707, XrefRangeEnd = 232714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ParentBone_Private_set_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe RagdollBoneProcessor BoneProcessor
	{
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 57380, RefRangeEnd = 57408, XrefRangeStart = 57380, XrefRangeEnd = 57408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BoneProcessor_Public_get_RagdollBoneProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBoneProcessor>(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232715, RefRangeEnd = 232717, XrefRangeStart = 232715, XrefRangeEnd = 232717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BoneProcessor_Private_set_Void_RagdollBoneProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe RagdollBoneProcessor Posing
	{
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 57380, RefRangeEnd = 57408, XrefRangeStart = 57380, XrefRangeEnd = 57408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Posing_Public_get_RagdollBoneProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBoneProcessor>(intPtr) : null;
		}
	}

	public unsafe Rigidbody InitialConnectedBody
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67291, RefRangeEnd = 67292, XrefRangeStart = 67291, XrefRangeEnd = 67292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InitialConnectedBody_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_InitialConnectedBody_Internal_set_Void_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Vector3 InitialJointAnchor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InitialJointAnchor_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_InitialJointAnchor_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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

	public unsafe Rigidbody GameRigidbody
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137115, RefRangeEnd = 137116, XrefRangeStart = 137115, XrefRangeEnd = 137116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GameRigidbody_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_GameRigidbody_Private_set_Void_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Collider MainBoneCollider
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 241021, RefRangeEnd = 241035, XrefRangeStart = 241018, XrefRangeEnd = 241021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MainBoneCollider_Public_get_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr) : null;
		}
	}

	public unsafe ConfigurableJoint Joint
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Joint_Public_get_ConfigurableJoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Joint_Private_set_Void_ConfigurableJoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<ColliderSetup> Colliders
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Colliders_Public_get_List_1_ColliderSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ColliderSetup>>(intPtr) : null;
		}
	}

	public unsafe ColliderSetup BaseColliderSetup
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 241058, RefRangeEnd = 241066, XrefRangeStart = 241054, XrefRangeEnd = 241058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BaseColliderSetup_Public_get_ColliderSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ColliderSetup>(intPtr) : null;
		}
	}

	public unsafe List<InBetweenBone> InBetweenBones
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InBetweenBones_Public_get_List_1_InBetweenBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InBetweenBone>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_InBetweenBones_Private_set_Void_List_1_InBetweenBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool UsingExtraTransform
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241208, XrefRangeEnd = 241225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UsingExtraTransform_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float TargetConnectedMassScale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetConnectedMassScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TargetConnectedMassScale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static RagdollChainBone()
	{
		Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RagdollChainBone");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr);
		NativeFieldInfoPtr_SourceBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "SourceBone");
		NativeFieldInfoPtr_PhysicalDummyBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "PhysicalDummyBone");
		NativeFieldInfoPtr_DetachParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "DetachParent");
		NativeFieldInfoPtr__ParentChain_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<ParentChain>k__BackingField");
		NativeFieldInfoPtr__ParentBone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<ParentBone>k__BackingField");
		NativeFieldInfoPtr__BoneProcessor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<BoneProcessor>k__BackingField");
		NativeFieldInfoPtr_IsAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "IsAnchor");
		NativeFieldInfoPtr_SourceBoneDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "SourceBoneDepth");
		NativeFieldInfoPtr_BypassKinematicControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "BypassKinematicControl");
		NativeFieldInfoPtr_BoundedIgnoreScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "BoundedIgnoreScale");
		NativeFieldInfoPtr_WasDismembered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "WasDismembered");
		NativeFieldInfoPtr_ParentDismembered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "ParentDismembered");
		NativeFieldInfoPtr__InitialConnectedBody_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<InitialConnectedBody>k__BackingField");
		NativeFieldInfoPtr__InitialJointAnchor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<InitialJointAnchor>k__BackingField");
		NativeFieldInfoPtr__PlaymodeInitialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<PlaymodeInitialized>k__BackingField");
		NativeFieldInfoPtr__GameRigidbody_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<GameRigidbody>k__BackingField");
		NativeFieldInfoPtr__Joint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<Joint>k__BackingField");
		NativeFieldInfoPtr_BoneID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "BoneID");
		NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "colliders");
		NativeFieldInfoPtr_MassMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "MassMultiplier");
		NativeFieldInfoPtr_ForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "ForceMultiplier");
		NativeFieldInfoPtr_MusclesBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "MusclesBoost");
		NativeFieldInfoPtr_MainAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "MainAxis");
		NativeFieldInfoPtr_TargetMainAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "TargetMainAxis");
		NativeFieldInfoPtr_InverseMainAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "InverseMainAxis");
		NativeFieldInfoPtr_MainAxisLowLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "MainAxisLowLimit");
		NativeFieldInfoPtr_MainAxisHighLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "MainAxisHighLimit");
		NativeFieldInfoPtr_SecondaryAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "SecondaryAxis");
		NativeFieldInfoPtr_TargetSecondaryAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "TargetSecondaryAxis");
		NativeFieldInfoPtr_InverseSecondaryAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "InverseSecondaryAxis");
		NativeFieldInfoPtr_SecondaryAxisAngleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "SecondaryAxisAngleLimit");
		NativeFieldInfoPtr_ThirdAxisAngleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "ThirdAxisAngleLimit");
		NativeFieldInfoPtr_OverrideMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "OverrideMaterial");
		NativeFieldInfoPtr_UseIndividualParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "UseIndividualParameters");
		NativeFieldInfoPtr_OverrideInterpolation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "OverrideInterpolation");
		NativeFieldInfoPtr_OverrideDetectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "OverrideDetectionMode");
		NativeFieldInfoPtr_OverrideDragValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "OverrideDragValue");
		NativeFieldInfoPtr_OverrideAngularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "OverrideAngularDrag");
		NativeFieldInfoPtr_OverrideSpringPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "OverrideSpringPower");
		NativeFieldInfoPtr_OverrideSpringDamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "OverrideSpringDamp");
		NativeFieldInfoPtr_HardMatchingMultiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "HardMatchingMultiply");
		NativeFieldInfoPtr_HardMatchOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "HardMatchOverride");
		NativeFieldInfoPtr_ConnectionMassOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "ConnectionMassOverride");
		NativeFieldInfoPtr_DisableCollisionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "DisableCollisionEvents");
		NativeFieldInfoPtr_ForceLimitsAllTheTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "ForceLimitsAllTheTime");
		NativeFieldInfoPtr_ForceKinematicOnStanding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "ForceKinematicOnStanding");
		NativeFieldInfoPtr__wasForceKinematicOnStanding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "_wasForceKinematicOnStanding");
		NativeFieldInfoPtr_AllowConfigurablePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "AllowConfigurablePosition");
		NativeFieldInfoPtr_LinearSpringLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "LinearSpringLimit");
		NativeFieldInfoPtr_LinearSpringDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "LinearSpringDamping");
		NativeFieldInfoPtr_BoneBlendMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "BoneBlendMultiplier");
		NativeFieldInfoPtr_LocalRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "LocalRight");
		NativeFieldInfoPtr_LocalUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "LocalUp");
		NativeFieldInfoPtr_LocalForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "LocalForward");
		NativeFieldInfoPtr_ToBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "ToBase");
		NativeFieldInfoPtr__InBetweenBones_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<InBetweenBones>k__BackingField");
		NativeFieldInfoPtr__TargetConnectedMassScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "<TargetConnectedMassScale>k__BackingField");
		NativeFieldInfoPtr_StoredReferencePose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "StoredReferencePose");
		NativeFieldInfoPtr_OverrideBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "OverrideBlend");
		NativeFieldInfoPtr__forceBlendCoro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "_forceBlendCoro");
		NativeFieldInfoPtr__forceBlendStartOverr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "_forceBlendStartOverr");
		NativeFieldInfoPtr_wasPhysicsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "wasPhysicsDisabled");
		NativeFieldInfoPtr_kinematicOnDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "kinematicOnDisabled");
		NativeFieldInfoPtr_MotionInfluenceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, "MotionInfluenceMultiplier");
		NativeMethodInfoPtr_get_ParentChain_Public_get_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677793);
		NativeMethodInfoPtr_set_ParentChain_Private_set_Void_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677794);
		NativeMethodInfoPtr_get_ParentBone_Public_get_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677795);
		NativeMethodInfoPtr_set_ParentBone_Private_set_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677796);
		NativeMethodInfoPtr_get_BoneProcessor_Public_get_RagdollBoneProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677797);
		NativeMethodInfoPtr_set_BoneProcessor_Private_set_Void_RagdollBoneProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677798);
		NativeMethodInfoPtr_get_Posing_Public_get_RagdollBoneProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677799);
		NativeMethodInfoPtr_get_InitialConnectedBody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677800);
		NativeMethodInfoPtr_set_InitialConnectedBody_Internal_set_Void_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677801);
		NativeMethodInfoPtr_get_InitialJointAnchor_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677802);
		NativeMethodInfoPtr_set_InitialJointAnchor_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677803);
		NativeMethodInfoPtr_get_PlaymodeInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677804);
		NativeMethodInfoPtr_set_PlaymodeInitialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677805);
		NativeMethodInfoPtr_GenerateDummyBone_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677806);
		NativeMethodInfoPtr_PlaymodeInitialize_Public_Void_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677807);
		NativeMethodInfoPtr_get_GameRigidbody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677808);
		NativeMethodInfoPtr_set_GameRigidbody_Private_set_Void_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677809);
		NativeMethodInfoPtr_get_MainBoneCollider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677810);
		NativeMethodInfoPtr_get_Joint_Public_get_ConfigurableJoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677811);
		NativeMethodInfoPtr_set_Joint_Private_set_Void_ConfigurableJoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677812);
		NativeMethodInfoPtr_ApplyToAllColliders_Public_Void_Action_1_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677813);
		NativeMethodInfoPtr_get_Colliders_Public_get_List_1_ColliderSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677814);
		NativeMethodInfoPtr_get_BaseColliderSetup_Public_get_ColliderSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677815);
		NativeMethodInfoPtr_SwitchOffJointAnimationMatching_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677816);
		NativeMethodInfoPtr_AddColliderSetup_Public_ColliderSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677817);
		NativeMethodInfoPtr_RemoveColliderSetup_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677818);
		NativeMethodInfoPtr_GetColliderSetup_Public_ColliderSetup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677819);
		NativeMethodInfoPtr_GetMatrix_Public_Matrix4x4_Vector3_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677820);
		NativeMethodInfoPtr_GetMainAxis_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677821);
		NativeMethodInfoPtr_SetMainAxisByVector_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677822);
		NativeMethodInfoPtr_SetSecondaryAxisByVector_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677823);
		NativeMethodInfoPtr_GetMainAxisLowLimit_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677824);
		NativeMethodInfoPtr_GetMainAxisHighLimit_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677825);
		NativeMethodInfoPtr_GetSecondaryAxis_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677826);
		NativeMethodInfoPtr_GetSecondaryAxisAngleLimit_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677827);
		NativeMethodInfoPtr_GetThirdAxisAngleLimit_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677828);
		NativeMethodInfoPtr_GetThirdAxis_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677829);
		NativeMethodInfoPtr_GetMass_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677830);
		NativeMethodInfoPtr_DoAutoMassSettings_Public_Void_RagdollHandler_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677831);
		NativeMethodInfoPtr_GetRigidbodyDrag_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677832);
		NativeMethodInfoPtr_GetRigidbodyAngularDrag_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677833);
		NativeMethodInfoPtr_GetMainAxisLimitContactDistance_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677834);
		NativeMethodInfoPtr_GetMainAxisLimitBounciness_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677835);
		NativeMethodInfoPtr_GetMainAxisLimitSpring_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677836);
		NativeMethodInfoPtr_GetMainAxisLimitDamper_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677837);
		NativeMethodInfoPtr_GetOtherAxesLimitSpring_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677838);
		NativeMethodInfoPtr_GetOtherAxesLimitDamper_Public_Single_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677839);
		NativeMethodInfoPtr_StoreHelperReferenceValues_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677840);
		NativeMethodInfoPtr_get_InBetweenBones_Public_get_List_1_InBetweenBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677841);
		NativeMethodInfoPtr_set_InBetweenBones_Private_set_Void_List_1_InBetweenBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677842);
		NativeMethodInfoPtr_SetInBetweenBones_Public_Void_List_1_InBetweenBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677843);
		NativeMethodInfoPtr_RefreshRigidbody_Public_Rigidbody_RagdollHandler_RagdollBonesChain_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677844);
		NativeMethodInfoPtr_RefreshRigidbodyOptimizationParameters_Public_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677845);
		NativeMethodInfoPtr_RefreshSolversCount_Private_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677846);
		NativeMethodInfoPtr_RefreshRigidbodyInterpolation_Protected_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677847);
		NativeMethodInfoPtr_get_UsingExtraTransform_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677848);
		NativeMethodInfoPtr_ApplyPhysicMaterial_Public_Void_PhysicsMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677849);
		NativeMethodInfoPtr_RefreshCollider_Public_Void_RagdollBonesChain_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677850);
		NativeMethodInfoPtr_GetOrGenerate_Private_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677851);
		NativeMethodInfoPtr_RefreshJoint_Public_ConfigurableJoint_RagdollBonesChain_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677852);
		NativeMethodInfoPtr_RefreshJointLimitSwitch_Public_Void_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677853);
		NativeMethodInfoPtr_get_TargetConnectedMassScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677854);
		NativeMethodInfoPtr_set_TargetConnectedMassScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677855);
		NativeMethodInfoPtr_RefreshDynamicPhysicalParameters_Public_Void_RagdollBonesChain_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677856);
		NativeMethodInfoPtr_SwitchIsKinematic_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677857);
		NativeMethodInfoPtr_ConfigureJointAnchors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677858);
		NativeMethodInfoPtr_Joint_UpdateAngleLimits_Private_Void_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677859);
		NativeMethodInfoPtr_Joint_UpdateAngularSpringLimits_Private_Void_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677860);
		NativeMethodInfoPtr_Joint_SetMotionLock_Public_Void_ConfigurableJointMotion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677861);
		NativeMethodInfoPtr_Joint_SetAngularMotionLock_Public_Void_ConfigurableJointMotion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677862);
		NativeMethodInfoPtr_Joint_SetPositionLimit_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677863);
		NativeMethodInfoPtr_SetJointMatchingParameters_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677864);
		NativeMethodInfoPtr_SetJointMatchingParametersPosition_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677865);
		NativeMethodInfoPtr_SetZeroDrive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677866);
		NativeMethodInfoPtr_SetJointMatchingMaximumForce_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677867);
		NativeMethodInfoPtr_TryIdentifyBoneID_Public_Void_RagdollBonesChain_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677868);
		NativeMethodInfoPtr_TryDoAutoSettings_Public_Void_RagdollHandler_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677869);
		NativeMethodInfoPtr_User_ForceOverrideBlendFor_Public_Void_RagdollHandler_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677870);
		NativeMethodInfoPtr_User_ForceStopOverrideBlend_Public_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677871);
		NativeMethodInfoPtr_IEForceOverrideBlend_Private_IEnumerator_RagdollHandler_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677872);
		NativeMethodInfoPtr_DestroyInBetweenBones_Internal_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677873);
		NativeMethodInfoPtr_IgnoreCollisionsWith_Public_Void_RagdollChainBone_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677874);
		NativeMethodInfoPtr_IgnoreCollisionsWith_Public_Void_Collider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677875);
		NativeMethodInfoPtr_SetJointFreeMotion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677876);
		NativeMethodInfoPtr_SwitchPhysics_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677877);
		NativeMethodInfoPtr_CheckIfShouldIgnoreByBounds_Public_Void_RagdollChainBone_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677878);
		NativeMethodInfoPtr_StoreCalibrationPose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677879);
		NativeMethodInfoPtr_RestoreCalibrationPose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677880);
		NativeMethodInfoPtr_SetParentBone_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677881);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr, 100677882);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241001, XrefRangeEnd = 241006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateDummyBone(Transform transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateDummyBone_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241006, XrefRangeEnd = 241018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaymodeInitialize(RagdollBonesChain parentChain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentChain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaymodeInitialize_Public_Void_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241053, RefRangeEnd = 241054, XrefRangeStart = 241035, XrefRangeEnd = 241053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyToAllColliders(Il2CppSystem.Action<Collider> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyToAllColliders_Public_Void_Action_1_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241071, RefRangeEnd = 241072, XrefRangeStart = 241066, XrefRangeEnd = 241071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchOffJointAnimationMatching()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchOffJointAnimationMatching_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 241086, RefRangeEnd = 241089, XrefRangeStart = 241072, XrefRangeEnd = 241086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ColliderSetup AddColliderSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddColliderSetup_Public_ColliderSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ColliderSetup>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241089, XrefRangeEnd = 241099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveColliderSetup(int indexToRemove)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&indexToRemove);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveColliderSetup_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241099, XrefRangeEnd = 241103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ColliderSetup GetColliderSetup(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColliderSetup_Public_ColliderSetup_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ColliderSetup>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241103, XrefRangeEnd = 241110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetMatrix(Vector3 centerOffset, Vector3 scale, Quaternion correctionRot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&centerOffset);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &correctionRot;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMatrix_Public_Matrix4x4_Vector3_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 241111, RefRangeEnd = 241116, XrefRangeStart = 241110, XrefRangeEnd = 241111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetMainAxis()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainAxis_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 241119, RefRangeEnd = 241124, XrefRangeStart = 241116, XrefRangeEnd = 241119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMainAxisByVector(Vector3 dir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMainAxisByVector_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241127, RefRangeEnd = 241129, XrefRangeStart = 241124, XrefRangeEnd = 241127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSecondaryAxisByVector(Vector3 dir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSecondaryAxisByVector_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float GetMainAxisLowLimit(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainAxisLowLimit_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetMainAxisHighLimit(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainAxisHighLimit_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 241130, RefRangeEnd = 241134, XrefRangeStart = 241129, XrefRangeEnd = 241130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetSecondaryAxis()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSecondaryAxis_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetSecondaryAxisAngleLimit(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSecondaryAxisAngleLimit_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetThirdAxisAngleLimit(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThirdAxisAngleLimit_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241134, XrefRangeEnd = 241136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetThirdAxis()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThirdAxis_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetMass(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMass_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241136, XrefRangeEnd = 241147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoAutoMassSettings(RagdollHandler handler, RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoAutoMassSettings_Public_Void_RagdollHandler_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float GetRigidbodyDrag(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRigidbodyDrag_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetRigidbodyAngularDrag(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRigidbodyAngularDrag_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetMainAxisLimitContactDistance(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainAxisLimitContactDistance_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetMainAxisLimitBounciness(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainAxisLimitBounciness_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetMainAxisLimitSpring(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainAxisLimitSpring_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetMainAxisLimitDamper(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainAxisLimitDamper_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetOtherAxesLimitSpring(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOtherAxesLimitSpring_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetOtherAxesLimitDamper(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOtherAxesLimitDamper_Public_Single_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241155, RefRangeEnd = 241156, XrefRangeStart = 241147, XrefRangeEnd = 241155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreHelperReferenceValues(Transform baseTransform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreHelperReferenceValues_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInBetweenBones(List<InBetweenBone> inBetweenBones)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBetweenBones);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInBetweenBones_Public_Void_List_1_InBetweenBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 241183, RefRangeEnd = 241186, XrefRangeStart = 241156, XrefRangeEnd = 241183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Rigidbody RefreshRigidbody(RagdollHandler handler, RagdollBonesChain chain, bool onSource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &onSource;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshRigidbody_Public_Rigidbody_RagdollHandler_RagdollBonesChain_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241192, RefRangeEnd = 241194, XrefRangeStart = 241186, XrefRangeEnd = 241192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshRigidbodyOptimizationParameters(RagdollHandler handler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshRigidbodyOptimizationParameters_Public_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 241202, RefRangeEnd = 241205, XrefRangeStart = 241194, XrefRangeEnd = 241202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshSolversCount(RagdollHandler handler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshSolversCount_Private_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241205, XrefRangeEnd = 241208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshRigidbodyInterpolation(RagdollHandler handler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshRigidbodyInterpolation_Protected_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241238, RefRangeEnd = 241240, XrefRangeStart = 241225, XrefRangeEnd = 241238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyPhysicMaterial(PhysicsMaterial pMaterial)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pMaterial);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyPhysicMaterial_Public_Void_PhysicsMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 241246, RefRangeEnd = 241253, XrefRangeStart = 241240, XrefRangeEnd = 241246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshCollider(RagdollBonesChain chain, bool fallMode, bool onSource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallMode;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &onSource;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshCollider_Public_Void_RagdollBonesChain_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 241261, RefRangeEnd = 241266, XrefRangeStart = 241253, XrefRangeEnd = 241261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetOrGenerate<T>(Transform from) where T : Component
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetOrGenerate_Private_T_Transform_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 241304, RefRangeEnd = 241310, XrefRangeStart = 241266, XrefRangeEnd = 241304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConfigurableJoint RefreshJoint(RagdollBonesChain chain, bool fallMode, bool onSource, bool playmodeRefresh, bool applyConnectedMassScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallMode;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &onSource;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &playmodeRefresh;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &applyConnectedMassScale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshJoint_Public_ConfigurableJoint_RagdollBonesChain_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 241325, RefRangeEnd = 241328, XrefRangeStart = 241310, XrefRangeEnd = 241325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshJointLimitSwitch(RagdollBonesChain parentChain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentChain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshJointLimitSwitch_Public_Void_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 241356, RefRangeEnd = 241361, XrefRangeStart = 241328, XrefRangeEnd = 241356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshDynamicPhysicalParameters(RagdollBonesChain chain, bool fallMode, bool applyConnectedMassScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallMode;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &applyConnectedMassScale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshDynamicPhysicalParameters_Public_Void_RagdollBonesChain_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241362, RefRangeEnd = 241363, XrefRangeStart = 241361, XrefRangeEnd = 241362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchIsKinematic(bool kinematic)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&kinematic);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchIsKinematic_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241382, RefRangeEnd = 241383, XrefRangeStart = 241363, XrefRangeEnd = 241382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureJointAnchors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureJointAnchors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241407, RefRangeEnd = 241408, XrefRangeStart = 241383, XrefRangeEnd = 241407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Joint_UpdateAngleLimits(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Joint_UpdateAngleLimits_Private_Void_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241408, XrefRangeEnd = 241420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Joint_UpdateAngularSpringLimits(RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Joint_UpdateAngularSpringLimits_Private_Void_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 241427, RefRangeEnd = 241432, XrefRangeStart = 241420, XrefRangeEnd = 241427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Joint_SetMotionLock(ConfigurableJointMotion mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Joint_SetMotionLock_Public_Void_ConfigurableJointMotion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 241439, RefRangeEnd = 241445, XrefRangeStart = 241432, XrefRangeEnd = 241439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Joint_SetAngularMotionLock(ConfigurableJointMotion mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Joint_SetAngularMotionLock_Public_Void_ConfigurableJointMotion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241445, XrefRangeEnd = 241452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Joint_SetPositionLimit(float limitValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&limitValue);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Joint_SetPositionLimit_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241463, RefRangeEnd = 241465, XrefRangeStart = 241452, XrefRangeEnd = 241463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetJointMatchingParameters(float spring, float dampingValue, bool useAcceleration = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&spring);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dampingValue;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useAcceleration;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetJointMatchingParameters_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241465, XrefRangeEnd = 241472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetJointMatchingParametersPosition(float spring, float dampingValue, bool useAcceleration = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&spring);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dampingValue;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useAcceleration;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetJointMatchingParametersPosition_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241472, XrefRangeEnd = 241482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetZeroDrive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetZeroDrive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241482, XrefRangeEnd = 241485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetJointMatchingMaximumForce(float maximumForce)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maximumForce);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetJointMatchingMaximumForce_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241528, RefRangeEnd = 241530, XrefRangeStart = 241485, XrefRangeEnd = 241528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryIdentifyBoneID(RagdollBonesChain chain, bool changeOnlyIfUnknown = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeOnlyIfUnknown;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryIdentifyBoneID_Public_Void_RagdollBonesChain_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241530, XrefRangeEnd = 241557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryDoAutoSettings(RagdollHandler handler, RagdollBonesChain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryDoAutoSettings_Public_Void_RagdollHandler_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241557, XrefRangeEnd = 241571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void User_ForceOverrideBlendFor(RagdollHandler parentHandler, float duration, float transitionTime = 0.1f, float targetOverrideBlend = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &transitionTime;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetOverrideBlend;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ForceOverrideBlendFor_Public_Void_RagdollHandler_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241571, XrefRangeEnd = 241572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void User_ForceStopOverrideBlend(RagdollHandler parentHandler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ForceStopOverrideBlend_Public_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241572, XrefRangeEnd = 241578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator IEForceOverrideBlend(RagdollHandler parentHandler, float duration, float transitionTime = 0.1f, float targetOverrideBlend = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &transitionTime;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetOverrideBlend;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IEForceOverrideBlend_Private_IEnumerator_RagdollHandler_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241578, XrefRangeEnd = 241604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyInBetweenBones(RagdollHandler parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyInBetweenBones_Internal_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 241629, RefRangeEnd = 241633, XrefRangeStart = 241604, XrefRangeEnd = 241629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IgnoreCollisionsWith(RagdollChainBone otherBone, bool ignore = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherBone);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignore;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IgnoreCollisionsWith_Public_Void_RagdollChainBone_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241633, XrefRangeEnd = 241648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IgnoreCollisionsWith(Collider coll, bool ignore = true)
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
	[CachedScanResults(RefRangeStart = 241654, RefRangeEnd = 241655, XrefRangeStart = 241648, XrefRangeEnd = 241654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetJointFreeMotion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetJointFreeMotion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241686, RefRangeEnd = 241687, XrefRangeStart = 241655, XrefRangeEnd = 241686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 241717, RefRangeEnd = 241718, XrefRangeStart = 241687, XrefRangeEnd = 241717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckIfShouldIgnoreByBounds(RagdollChainBone otherBone, float boundsSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherBone);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundsSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfShouldIgnoreByBounds_Public_Void_RagdollChainBone_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241718, XrefRangeEnd = 241720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreCalibrationPose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreCalibrationPose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241720, XrefRangeEnd = 241722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreCalibrationPose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreCalibrationPose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 232707, RefRangeEnd = 232714, XrefRangeStart = 232707, XrefRangeEnd = 232714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetParentBone(RagdollChainBone parentBone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParentBone_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241722, XrefRangeEnd = 241755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollChainBone()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollChainBone>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RagdollChainBone(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
