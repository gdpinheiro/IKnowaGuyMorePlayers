using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

public static class BeverageTypeData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_BeverageType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_BeverageType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDispenseDuration_Public_Static_Single_BeverageType_0;

	static BeverageTypeData()
	{
		Il2CppClassPointerStore<BeverageTypeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BeverageTypeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeverageTypeData>.NativeClassPtr);
		NativeMethodInfoPtr_GetColor_Public_Static_Color_BeverageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeverageTypeData>.NativeClassPtr, 100666275);
		NativeMethodInfoPtr_GetName_Public_Static_String_BeverageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeverageTypeData>.NativeClassPtr, 100666276);
		NativeMethodInfoPtr_GetDispenseDuration_Public_Static_Single_BeverageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeverageTypeData>.NativeClassPtr, 100666277);
	}

	[CallerCount(0)]
	public unsafe static Color GetColor(BeverageType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Static_Color_BeverageType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 68407, RefRangeEnd = 68412, XrefRangeStart = 68402, XrefRangeEnd = 68407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(BeverageType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_BeverageType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float GetDispenseDuration(BeverageType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDispenseDuration_Public_Static_Single_BeverageType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public BeverageTypeData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
