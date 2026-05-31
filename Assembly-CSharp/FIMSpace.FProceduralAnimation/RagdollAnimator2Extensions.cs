using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation;

public static class RagdollAnimator2Extensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__copyingFrom;

	private static readonly System.IntPtr NativeFieldInfoPtr__copyingFromBone;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsArm_Public_Static_Boolean_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRight_Public_Static_Boolean_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLeft_Public_Static_Boolean_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLeg_Public_Static_Boolean_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSameMainType_Public_Static_Boolean_ERagdollChainType_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAxisValue_Public_Static_Vector3_EJointAxis_Vector3_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAxisValue_Public_Static_Vector3_EJointAxis_Vector3_Single_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIndexColor_Public_Static_Color_RagdollHandler_Int32_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PasteMainSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PasteColliderSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CopyingFrom_Public_Static_get_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CopyingFromBone_Public_Static_get_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCopyingSource_Public_Static_Void_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCopyingSource_Public_Static_Void_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PasteColliderSettingsOfOtherChainSymmetrical_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_RagdollHandler_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PasteExtraSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PastePhysicsSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PastePhysics_Mass_OfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PastePhysicsSettingsOfOtherChainSymmetrical_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyColliderSettingsToAllBonesInChain_Public_Static_Void_RagdollChainBone_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PasteColliderSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PasteColliderSizeSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PasteColliderSettingsOfOtherBoneSymmetrical_Public_Static_Void_RagdollChainBone_RagdollChainBone_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PasteExtraSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PastePhysicsSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPhysicsSettingsToAllBonesInChain_Public_Static_Void_RagdollChainBone_RagdollBonesChain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PastePhysicsSettingsOfOtherBoneSymmetrical_Public_Static_Void_RagdollChainBone_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Private_Static_Void_String_Boolean_0;

	public unsafe static RagdollBonesChain _copyingFrom
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__copyingFrom, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__copyingFrom, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollBonesChain));
		}
	}

	public unsafe static RagdollChainBone _copyingFromBone
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__copyingFromBone, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__copyingFromBone, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollChainBone));
		}
	}

	public unsafe static RagdollBonesChain CopyingFrom
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232796, XrefRangeEnd = 232798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CopyingFrom_Public_Static_get_RagdollBonesChain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr) : null;
		}
	}

	public unsafe static RagdollChainBone CopyingFromBone
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232798, XrefRangeEnd = 232800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CopyingFromBone_Public_Static_get_RagdollChainBone_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
		}
	}

	static RagdollAnimator2Extensions()
	{
		Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RagdollAnimator2Extensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr);
		NativeFieldInfoPtr__copyingFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, "_copyingFrom");
		NativeFieldInfoPtr__copyingFromBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, "_copyingFromBone");
		NativeMethodInfoPtr_IsArm_Public_Static_Boolean_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677207);
		NativeMethodInfoPtr_IsRight_Public_Static_Boolean_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677208);
		NativeMethodInfoPtr_IsLeft_Public_Static_Boolean_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677209);
		NativeMethodInfoPtr_IsLeg_Public_Static_Boolean_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677210);
		NativeMethodInfoPtr_IsSameMainType_Public_Static_Boolean_ERagdollChainType_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677211);
		NativeMethodInfoPtr_SetAxisValue_Public_Static_Vector3_EJointAxis_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677212);
		NativeMethodInfoPtr_SetAxisValue_Public_Static_Vector3_EJointAxis_Vector3_Single_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677213);
		NativeMethodInfoPtr_GetIndexColor_Public_Static_Color_RagdollHandler_Int32_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677214);
		NativeMethodInfoPtr_PasteMainSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677215);
		NativeMethodInfoPtr_PasteColliderSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677216);
		NativeMethodInfoPtr_get_CopyingFrom_Public_Static_get_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677217);
		NativeMethodInfoPtr_get_CopyingFromBone_Public_Static_get_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677218);
		NativeMethodInfoPtr_SetCopyingSource_Public_Static_Void_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677219);
		NativeMethodInfoPtr_SetCopyingSource_Public_Static_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677220);
		NativeMethodInfoPtr_PasteColliderSettingsOfOtherChainSymmetrical_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_RagdollHandler_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677221);
		NativeMethodInfoPtr_PasteExtraSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677222);
		NativeMethodInfoPtr_PastePhysicsSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677223);
		NativeMethodInfoPtr_PastePhysics_Mass_OfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677224);
		NativeMethodInfoPtr_PastePhysicsSettingsOfOtherChainSymmetrical_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677225);
		NativeMethodInfoPtr_ApplyColliderSettingsToAllBonesInChain_Public_Static_Void_RagdollChainBone_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677226);
		NativeMethodInfoPtr_PasteColliderSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677227);
		NativeMethodInfoPtr_PasteColliderSizeSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677228);
		NativeMethodInfoPtr_PasteColliderSettingsOfOtherBoneSymmetrical_Public_Static_Void_RagdollChainBone_RagdollChainBone_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677229);
		NativeMethodInfoPtr_PasteExtraSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677230);
		NativeMethodInfoPtr_PastePhysicsSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677231);
		NativeMethodInfoPtr_ApplyPhysicsSettingsToAllBonesInChain_Public_Static_Void_RagdollChainBone_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677232);
		NativeMethodInfoPtr_PastePhysicsSettingsOfOtherBoneSymmetrical_Public_Static_Void_RagdollChainBone_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677233);
		NativeMethodInfoPtr_Log_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimator2Extensions>.NativeClassPtr, 100677234);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 232724, RefRangeEnd = 232740, XrefRangeStart = 232724, XrefRangeEnd = 232724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsArm(this ERagdollChainType chain)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsArm_Public_Static_Boolean_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool IsRight(this ERagdollChainType chain)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRight_Public_Static_Boolean_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool IsLeft(this ERagdollChainType chain)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLeft_Public_Static_Boolean_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 232740, RefRangeEnd = 232763, XrefRangeStart = 232740, XrefRangeEnd = 232740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsLeg(this ERagdollChainType chain)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&chain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLeg_Public_Static_Boolean_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 232763, RefRangeEnd = 232764, XrefRangeStart = 232763, XrefRangeEnd = 232763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSameMainType(this ERagdollChainType chain, ERagdollChainType oChain)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&chain);
		*(ERagdollChainType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oChain;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSameMainType_Public_Static_Boolean_ERagdollChainType_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Vector3 SetAxisValue(this EJointAxis axis, Vector3 target, float value, bool inverse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&axis);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inverse;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAxisValue_Public_Static_Vector3_EJointAxis_Vector3_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232764, XrefRangeEnd = 232768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 SetAxisValue(this EJointAxis axis, Vector3 target, float value, Vector3 customValue, bool inverse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&axis);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &customValue;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &inverse;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAxisValue_Public_Static_Vector3_EJointAxis_Vector3_Single_Vector3_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232768, XrefRangeEnd = 232771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetIndexColor(this RagdollHandler handler, int index, float hueOffset = 0f, float alpha = 1f, float sat = 0.85f, float val = 0.85f, float stepMultiplier = 0.3f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hueOffset;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sat;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepMultiplier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIndexColor_Public_Static_Color_RagdollHandler_Int32_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void PasteMainSettingsOfOtherChain(this RagdollBonesChain pasteTo, RagdollBonesChain copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PasteMainSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 232795, RefRangeEnd = 232796, XrefRangeStart = 232771, XrefRangeEnd = 232795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PasteColliderSettingsOfOtherChain(this RagdollBonesChain pasteTo, RagdollBonesChain copyFrom, bool allowDisplayDialog = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowDisplayDialog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PasteColliderSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232800, XrefRangeEnd = 232804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCopyingSource(RagdollBonesChain copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCopyingSource_Public_Static_Void_RagdollBonesChain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232804, XrefRangeEnd = 232808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCopyingSource(RagdollChainBone copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCopyingSource_Public_Static_Void_RagdollChainBone_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232808, XrefRangeEnd = 232821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PasteColliderSettingsOfOtherChainSymmetrical(this RagdollBonesChain pasteTo, RagdollBonesChain copyFrom, RagdollHandler handler, bool allowDisplayDialog = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowDisplayDialog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PasteColliderSettingsOfOtherChainSymmetrical_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_RagdollHandler_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 232828, RefRangeEnd = 232829, XrefRangeStart = 232821, XrefRangeEnd = 232828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PasteExtraSettingsOfOtherChain(this RagdollBonesChain pasteTo, RagdollBonesChain copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PasteExtraSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 232837, RefRangeEnd = 232838, XrefRangeStart = 232829, XrefRangeEnd = 232837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PastePhysicsSettingsOfOtherChain(this RagdollBonesChain pasteTo, RagdollBonesChain copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PastePhysicsSettingsOfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232838, XrefRangeEnd = 232845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PastePhysics_Mass_OfOtherChain(this RagdollBonesChain pasteTo, RagdollBonesChain copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PastePhysics_Mass_OfOtherChain_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232845, XrefRangeEnd = 232852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PastePhysicsSettingsOfOtherChainSymmetrical(this RagdollBonesChain pasteTo, RagdollBonesChain copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PastePhysicsSettingsOfOtherChainSymmetrical_Public_Static_Void_RagdollBonesChain_RagdollBonesChain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232852, XrefRangeEnd = 232858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyColliderSettingsToAllBonesInChain(this RagdollChainBone settingsOf, RagdollBonesChain applyToChain)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settingsOf);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)applyToChain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyColliderSettingsToAllBonesInChain_Public_Static_Void_RagdollChainBone_RagdollBonesChain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232902, RefRangeEnd = 232904, XrefRangeStart = 232858, XrefRangeEnd = 232902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PasteColliderSettingsOfOtherBone(this RagdollChainBone pasteTo, RagdollChainBone copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PasteColliderSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232904, XrefRangeEnd = 232936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PasteColliderSizeSettingsOfOtherBone(this RagdollChainBone pasteTo, RagdollChainBone copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PasteColliderSizeSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 232985, RefRangeEnd = 232986, XrefRangeStart = 232936, XrefRangeEnd = 232985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PasteColliderSettingsOfOtherBoneSymmetrical(this RagdollChainBone pasteTo, RagdollChainBone copyFrom, RagdollHandler handler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PasteColliderSettingsOfOtherBoneSymmetrical_Public_Static_Void_RagdollChainBone_RagdollChainBone_RagdollHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void PasteExtraSettingsOfOtherBone(this RagdollChainBone pasteTo, RagdollChainBone copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PasteExtraSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232987, RefRangeEnd = 232989, XrefRangeStart = 232986, XrefRangeEnd = 232987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PastePhysicsSettingsOfOtherBone(this RagdollChainBone pasteTo, RagdollChainBone copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PastePhysicsSettingsOfOtherBone_Public_Static_Void_RagdollChainBone_RagdollChainBone_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232989, XrefRangeEnd = 232995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyPhysicsSettingsToAllBonesInChain(this RagdollChainBone settingsOf, RagdollBonesChain applyToChain)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settingsOf);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)applyToChain);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyPhysicsSettingsToAllBonesInChain_Public_Static_Void_RagdollChainBone_RagdollBonesChain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void PastePhysicsSettingsOfOtherBoneSymmetrical(this RagdollChainBone pasteTo, RagdollChainBone copyFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pasteTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PastePhysicsSettingsOfOtherBoneSymmetrical_Public_Static_Void_RagdollChainBone_RagdollChainBone_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233002, RefRangeEnd = 233003, XrefRangeStart = 232995, XrefRangeEnd = 233002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log(string info, bool popup = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &popup;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Private_Static_Void_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RagdollAnimator2Extensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
