using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

public static class FSceneIcons : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetGizmoIconEnabled_Public_Static_Void_MonoBehaviour_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGizmoIconEnabled_Public_Static_Void_Type_Boolean_0;

	static FSceneIcons()
	{
		Il2CppClassPointerStore<FSceneIcons>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FSceneIcons");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FSceneIcons>.NativeClassPtr);
		NativeMethodInfoPtr_SetGizmoIconEnabled_Public_Static_Void_MonoBehaviour_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSceneIcons>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_SetGizmoIconEnabled_Public_Static_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSceneIcons>.NativeClassPtr, 100663304);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19860, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGizmoIconEnabled(MonoBehaviour beh, bool on)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beh);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGizmoIconEnabled_Public_Static_Void_MonoBehaviour_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17126)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 17126, XrefRangeStart = 0, XrefRangeEnd = 17126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGizmoIconEnabled(Il2CppSystem.Type type, bool on)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGizmoIconEnabled_Public_Static_Void_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FSceneIcons(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
