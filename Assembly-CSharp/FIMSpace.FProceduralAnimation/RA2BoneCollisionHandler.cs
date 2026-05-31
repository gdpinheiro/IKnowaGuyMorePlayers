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

public class RA2BoneCollisionHandler : RA2BoneCollisionHandlerBase
{
	public sealed class CollisionCapture : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Enters;

		private static readonly System.IntPtr NativeFieldInfoPtr_Entered;

		private static readonly System.IntPtr NativeFieldInfoPtr_Lastest;

		public unsafe int Enters
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enters);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Enters)) = num;
			}
		}

		public unsafe Transform Entered
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Entered);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Entered)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe UnityEngine.Collision Lastest
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Lastest);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Collision>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Lastest)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision));
			}
		}

		static CollisionCapture()
		{
			Il2CppClassPointerStore<CollisionCapture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, "CollisionCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollisionCapture>.NativeClassPtr);
			NativeFieldInfoPtr_Enters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionCapture>.NativeClassPtr, "Enters");
			NativeFieldInfoPtr_Entered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionCapture>.NativeClassPtr, "Entered");
			NativeFieldInfoPtr_Lastest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionCapture>.NativeClassPtr, "Lastest");
		}

		public CollisionCapture(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CollisionCapture()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollisionCapture>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__EnteredCollisions_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__EnteredSelfCollisions_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_CollectCollisions;

	private static readonly System.IntPtr NativeFieldInfoPtr__LatestEnterCollision_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__LatestEnterNonSelfCollision_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__LatestExitCollision_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EnteredCollisions_Public_get_Dictionary_2_Transform_CollisionCapture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EnteredCollisions_Private_set_Void_Dictionary_2_Transform_CollisionCapture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EnteredSelfCollisions_Public_get_Dictionary_2_Transform_CollisionCapture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EnteredSelfCollisions_Private_set_Void_Dictionary_2_Transform_CollisionCapture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LatestEnterCollision_Public_get_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LatestEnterCollision_Private_set_Void_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LatestEnterNonSelfCollision_Public_get_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LatestEnterNonSelfCollision_Private_set_Void_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSavingEnteredCollisionsList_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_RagdollAnimator2BoneIndicator_RagdollHandler_RagdollBoneProcessor_RagdollBonesChain_Boolean_RA2AttachableObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupCollisions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LatestExitCollision_Public_get_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LatestExitCollision_Private_set_Void_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionExit_Private_Void_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCollidingWith_Public_Virtual_Boolean_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollidesWithAnything_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstCollidingCollider_Public_Virtual_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<Transform, CollisionCapture> _EnteredCollisions_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnteredCollisions_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Transform, CollisionCapture>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnteredCollisions_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Transform, CollisionCapture> _EnteredSelfCollisions_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnteredSelfCollisions_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Transform, CollisionCapture>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnteredSelfCollisions_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe bool CollectCollisions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CollectCollisions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CollectCollisions)) = flag;
		}
	}

	public unsafe UnityEngine.Collision _LatestEnterCollision_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LatestEnterCollision_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Collision>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LatestEnterCollision_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision));
		}
	}

	public unsafe UnityEngine.Collision _LatestEnterNonSelfCollision_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LatestEnterNonSelfCollision_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Collision>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LatestEnterNonSelfCollision_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision));
		}
	}

	public unsafe UnityEngine.Collision _LatestExitCollision_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LatestExitCollision_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Collision>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LatestExitCollision_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision));
		}
	}

	public unsafe Dictionary<Transform, CollisionCapture> EnteredCollisions
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 207267, RefRangeEnd = 207284, XrefRangeStart = 207267, XrefRangeEnd = 207284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnteredCollisions_Public_get_Dictionary_2_Transform_CollisionCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Transform, CollisionCapture>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnteredCollisions_Private_set_Void_Dictionary_2_Transform_CollisionCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Dictionary<Transform, CollisionCapture> EnteredSelfCollisions
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137115, RefRangeEnd = 137116, XrefRangeStart = 137115, XrefRangeEnd = 137116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnteredSelfCollisions_Public_get_Dictionary_2_Transform_CollisionCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Transform, CollisionCapture>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnteredSelfCollisions_Private_set_Void_Dictionary_2_Transform_CollisionCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe UnityEngine.Collision LatestEnterCollision
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LatestEnterCollision_Public_get_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Collision>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LatestEnterCollision_Private_set_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe UnityEngine.Collision LatestEnterNonSelfCollision
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LatestEnterNonSelfCollision_Public_get_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Collision>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LatestEnterNonSelfCollision_Private_set_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe UnityEngine.Collision LatestExitCollision
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 91977, RefRangeEnd = 91984, XrefRangeStart = 91977, XrefRangeEnd = 91984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LatestExitCollision_Public_get_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Collision>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LatestExitCollision_Private_set_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static RA2BoneCollisionHandler()
	{
		Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RA2BoneCollisionHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr);
		NativeFieldInfoPtr__EnteredCollisions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, "<EnteredCollisions>k__BackingField");
		NativeFieldInfoPtr__EnteredSelfCollisions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, "<EnteredSelfCollisions>k__BackingField");
		NativeFieldInfoPtr_CollectCollisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, "CollectCollisions");
		NativeFieldInfoPtr__LatestEnterCollision_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, "<LatestEnterCollision>k__BackingField");
		NativeFieldInfoPtr__LatestEnterNonSelfCollision_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, "<LatestEnterNonSelfCollision>k__BackingField");
		NativeFieldInfoPtr__LatestExitCollision_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, "<LatestExitCollision>k__BackingField");
		NativeMethodInfoPtr_get_EnteredCollisions_Public_get_Dictionary_2_Transform_CollisionCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677138);
		NativeMethodInfoPtr_set_EnteredCollisions_Private_set_Void_Dictionary_2_Transform_CollisionCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677139);
		NativeMethodInfoPtr_get_EnteredSelfCollisions_Public_get_Dictionary_2_Transform_CollisionCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677140);
		NativeMethodInfoPtr_set_EnteredSelfCollisions_Private_set_Void_Dictionary_2_Transform_CollisionCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677141);
		NativeMethodInfoPtr_get_LatestEnterCollision_Public_get_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677142);
		NativeMethodInfoPtr_set_LatestEnterCollision_Private_set_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677143);
		NativeMethodInfoPtr_get_LatestEnterNonSelfCollision_Public_get_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677144);
		NativeMethodInfoPtr_set_LatestEnterNonSelfCollision_Private_set_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677145);
		NativeMethodInfoPtr_EnableSavingEnteredCollisionsList_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677146);
		NativeMethodInfoPtr_Initialize_Public_Virtual_RagdollAnimator2BoneIndicator_RagdollHandler_RagdollBoneProcessor_RagdollBonesChain_Boolean_RA2AttachableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677147);
		NativeMethodInfoPtr_CleanupCollisions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677148);
		NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677149);
		NativeMethodInfoPtr_get_LatestExitCollision_Public_get_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677150);
		NativeMethodInfoPtr_set_LatestExitCollision_Private_set_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677151);
		NativeMethodInfoPtr_OnCollisionExit_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677152);
		NativeMethodInfoPtr_IsCollidingWith_Public_Virtual_Boolean_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677153);
		NativeMethodInfoPtr_CollidesWithAnything_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677154);
		NativeMethodInfoPtr_GetFirstCollidingCollider_Public_Virtual_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677155);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr, 100677156);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232474, XrefRangeEnd = 232486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void EnableSavingEnteredCollisionsList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EnableSavingEnteredCollisionsList_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232486, XrefRangeEnd = 232494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override RagdollAnimator2BoneIndicator Initialize(RagdollHandler handler, RagdollBoneProcessor boneProcessor, RagdollBonesChain parentChain, bool isAnimatorBone = false, RA2AttachableObject attachable = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneProcessor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentChain);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isAnimatorBone;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attachable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_RagdollAnimator2BoneIndicator_RagdollHandler_RagdollBoneProcessor_RagdollBonesChain_Boolean_RA2AttachableObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollAnimator2BoneIndicator>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 232500, RefRangeEnd = 232501, XrefRangeStart = 232494, XrefRangeEnd = 232500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupCollisions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupCollisions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232501, XrefRangeEnd = 232539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCollisionEnter(UnityEngine.Collision collision)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232539, XrefRangeEnd = 232564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCollisionExit(UnityEngine.Collision collision)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCollisionExit_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232564, XrefRangeEnd = 232596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsCollidingWith(Collider collider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collider);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsCollidingWith_Public_Virtual_Boolean_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232596, XrefRangeEnd = 232599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool CollidesWithAnything()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CollidesWithAnything_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232599, XrefRangeEnd = 232607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Collider GetFirstCollidingCollider()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetFirstCollidingCollider_Public_Virtual_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232607, XrefRangeEnd = 232608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RA2BoneCollisionHandler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RA2BoneCollisionHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RA2BoneCollisionHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
