using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation;

public class RagdollAnimator2BoneIndicator : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__ParentHandler_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__RagdollBoneProcessor_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__BoneSettings_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__AttachableObject_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__BodyBoneID_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__ParentChain_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsAnimatorBone_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsAnimatorBoneReference_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_ParentHandler_Public_get_RagdollHandler_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ParentHandler_Private_set_Void_RagdollHandler_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ParentRagdollProcessor_Public_get_RagdollHandler_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ParentRagdollAnimator_Public_get_RagdollAnimator2_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RagdollBoneProcessor_Public_get_RagdollBoneProcessor_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_RagdollBoneProcessor_Private_set_Void_RagdollBoneProcessor_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DummyBoneRigidbody_Public_get_Rigidbody_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PhysicalBone_Public_get_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SourceBone_Public_get_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_BoneSettings_Public_get_RagdollChainBone_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_BoneSettings_Private_set_Void_RagdollChainBone_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_AttachableObject_Public_get_RA2AttachableObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_AttachableObject_Private_set_Void_RA2AttachableObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_BodyBoneID_Public_get_ERagdollBoneID_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_BodyBoneID_Private_set_Void_ERagdollBoneID_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ParentChain_Public_get_RagdollBonesChain_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ParentChain_Private_set_Void_RagdollBonesChain_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ChainType_Public_get_ERagdollChainType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsAnimatorBone_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsAnimatorBone_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsAnimatorBoneReference_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsAnimatorBoneReference_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_MarkAsAnimatorBone_Internal_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_RagdollAnimator2BoneIndicator_RagdollHandler_RagdollBoneProcessor_RagdollBonesChain_Boolean_RA2AttachableObject_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RagdollHandler _ParentHandler_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentHandler_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollHandler>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentHandler_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollHandler));
		}
	}

	public unsafe RagdollBoneProcessor _RagdollBoneProcessor_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RagdollBoneProcessor_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollBoneProcessor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RagdollBoneProcessor_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollBoneProcessor));
		}
	}

	public unsafe RagdollChainBone _BoneSettings_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BoneSettings_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BoneSettings_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollChainBone));
		}
	}

	public unsafe RA2AttachableObject _AttachableObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AttachableObject_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RA2AttachableObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AttachableObject_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rA2AttachableObject));
		}
	}

	public unsafe ERagdollBoneID _BodyBoneID_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BodyBoneID_k__BackingField);
			return *(ERagdollBoneID*)num;
		}
		set
		{
			*(ERagdollBoneID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BodyBoneID_k__BackingField)) = eRagdollBoneID;
		}
	}

	public unsafe RagdollBonesChain _ParentChain_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentChain_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentChain_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollBonesChain));
		}
	}

	public unsafe bool _IsAnimatorBone_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsAnimatorBone_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsAnimatorBone_k__BackingField)) = flag;
		}
	}

	public unsafe bool _IsAnimatorBoneReference_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsAnimatorBoneReference_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsAnimatorBoneReference_k__BackingField)) = flag;
		}
	}

	public unsafe RagdollHandler ParentHandler
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 43540, RefRangeEnd = 43551, XrefRangeStart = 43540, XrefRangeEnd = 43551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentHandler_Public_get_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollHandler>(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 193815, RefRangeEnd = 193823, XrefRangeStart = 193815, XrefRangeEnd = 193823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ParentHandler_Private_set_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe RagdollHandler ParentRagdollProcessor
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 43540, RefRangeEnd = 43551, XrefRangeStart = 43540, XrefRangeEnd = 43551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentRagdollProcessor_Public_get_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollHandler>(intPtr) : null;
		}
	}

	public unsafe RagdollAnimator2 ParentRagdollAnimator
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232703, XrefRangeEnd = 232705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentRagdollAnimator_Public_get_RagdollAnimator2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollAnimator2>(intPtr) : null;
		}
	}

	public unsafe RagdollBoneProcessor RagdollBoneProcessor
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43141, RefRangeEnd = 43144, XrefRangeStart = 43141, XrefRangeEnd = 43144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RagdollBoneProcessor_Public_get_RagdollBoneProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollBoneProcessor>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RagdollBoneProcessor_Private_set_Void_RagdollBoneProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Rigidbody DummyBoneRigidbody
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232705, RefRangeEnd = 232706, XrefRangeStart = 232705, XrefRangeEnd = 232705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DummyBoneRigidbody_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}
	}

	public unsafe Transform PhysicalBone
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PhysicalBone_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
	}

	public unsafe Transform SourceBone
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SourceBone_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
	}

	public unsafe RagdollChainBone BoneSettings
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 43149, RefRangeEnd = 43165, XrefRangeStart = 43149, XrefRangeEnd = 43165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BoneSettings_Public_get_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 232707, RefRangeEnd = 232714, XrefRangeStart = 232706, XrefRangeEnd = 232707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BoneSettings_Private_set_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe RA2AttachableObject AttachableObject
	{
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 57380, RefRangeEnd = 57408, XrefRangeStart = 57380, XrefRangeEnd = 57408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AttachableObject_Public_get_RA2AttachableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RA2AttachableObject>(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232715, RefRangeEnd = 232717, XrefRangeStart = 232714, XrefRangeEnd = 232715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AttachableObject_Private_set_Void_RA2AttachableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ERagdollBoneID BodyBoneID
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BodyBoneID_Public_get_ERagdollBoneID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ERagdollBoneID*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BodyBoneID_Private_set_Void_ERagdollBoneID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe RagdollBonesChain ParentChain
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentChain_Public_get_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ParentChain_Private_set_Void_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ERagdollChainType ChainType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ChainType_Public_get_ERagdollChainType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ERagdollChainType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsAnimatorBone
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209323, RefRangeEnd = 209324, XrefRangeStart = 209323, XrefRangeEnd = 209324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsAnimatorBone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsAnimatorBone_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool IsAnimatorBoneReference
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsAnimatorBoneReference_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsAnimatorBoneReference_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static RagdollAnimator2BoneIndicator()
	{
		Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RagdollAnimator2BoneIndicator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr);
		NativeFieldInfoPtr__ParentHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, "<ParentHandler>k__BackingField");
		NativeFieldInfoPtr__RagdollBoneProcessor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, "<RagdollBoneProcessor>k__BackingField");
		NativeFieldInfoPtr__BoneSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, "<BoneSettings>k__BackingField");
		NativeFieldInfoPtr__AttachableObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, "<AttachableObject>k__BackingField");
		NativeFieldInfoPtr__BodyBoneID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, "<BodyBoneID>k__BackingField");
		NativeFieldInfoPtr__ParentChain_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, "<ParentChain>k__BackingField");
		NativeFieldInfoPtr__IsAnimatorBone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, "<IsAnimatorBone>k__BackingField");
		NativeFieldInfoPtr__IsAnimatorBoneReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, "<IsAnimatorBoneReference>k__BackingField");
		NativeMethodInfoPtr_get_ParentHandler_Public_get_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677182);
		NativeMethodInfoPtr_set_ParentHandler_Private_set_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677183);
		NativeMethodInfoPtr_get_ParentRagdollProcessor_Public_get_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677184);
		NativeMethodInfoPtr_get_ParentRagdollAnimator_Public_get_RagdollAnimator2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677185);
		NativeMethodInfoPtr_get_RagdollBoneProcessor_Public_get_RagdollBoneProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677186);
		NativeMethodInfoPtr_set_RagdollBoneProcessor_Private_set_Void_RagdollBoneProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677187);
		NativeMethodInfoPtr_get_DummyBoneRigidbody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677188);
		NativeMethodInfoPtr_get_PhysicalBone_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677189);
		NativeMethodInfoPtr_get_SourceBone_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677190);
		NativeMethodInfoPtr_get_BoneSettings_Public_get_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677191);
		NativeMethodInfoPtr_set_BoneSettings_Private_set_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677192);
		NativeMethodInfoPtr_get_AttachableObject_Public_get_RA2AttachableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677193);
		NativeMethodInfoPtr_set_AttachableObject_Private_set_Void_RA2AttachableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677194);
		NativeMethodInfoPtr_get_BodyBoneID_Public_get_ERagdollBoneID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677195);
		NativeMethodInfoPtr_set_BodyBoneID_Private_set_Void_ERagdollBoneID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677196);
		NativeMethodInfoPtr_get_ParentChain_Public_get_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677197);
		NativeMethodInfoPtr_set_ParentChain_Private_set_Void_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677198);
		NativeMethodInfoPtr_get_ChainType_Public_get_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677199);
		NativeMethodInfoPtr_get_IsAnimatorBone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677200);
		NativeMethodInfoPtr_set_IsAnimatorBone_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677201);
		NativeMethodInfoPtr_get_IsAnimatorBoneReference_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677202);
		NativeMethodInfoPtr_set_IsAnimatorBoneReference_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677203);
		NativeMethodInfoPtr_MarkAsAnimatorBone_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677204);
		NativeMethodInfoPtr_Initialize_Public_Virtual_New_RagdollAnimator2BoneIndicator_RagdollHandler_RagdollBoneProcessor_RagdollBonesChain_Boolean_RA2AttachableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677205);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr, 100677206);
	}

	[CallerCount(0)]
	public unsafe void MarkAsAnimatorBone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkAsAnimatorBone_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232717, XrefRangeEnd = 232723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual RagdollAnimator2BoneIndicator Initialize(RagdollHandler handler, RagdollBoneProcessor boneProcessor, RagdollBonesChain parentChain, bool isAnimatorBone = false, RA2AttachableObject attachable = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneProcessor);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentChain);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &isAnimatorBone;
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attachable);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_New_RagdollAnimator2BoneIndicator_RagdollHandler_RagdollBoneProcessor_RagdollBonesChain_Boolean_RA2AttachableObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RagdollAnimator2BoneIndicator>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232723, XrefRangeEnd = 232724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollAnimator2BoneIndicator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollAnimator2BoneIndicator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RagdollAnimator2BoneIndicator(IntPtr pointer)
		: base(pointer)
	{
	}
}
