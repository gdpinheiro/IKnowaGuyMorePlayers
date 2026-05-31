using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public static class SunGradientPresets : Il2CppSystem.Object
{
	public enum PresetType
	{
		Realistic,
		Stylized,
		Warm,
		Cool,
		Fantasy,
		Dramatic,
		Soft,
		Vibrant
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreset_Public_Static_Gradient_PresetType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRealisticGradient_Public_Static_Gradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStylizedGradient_Public_Static_Gradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWarmGradient_Public_Static_Gradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCoolGradient_Public_Static_Gradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFantasyGradient_Public_Static_Gradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDramaticGradient_Public_Static_Gradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSoftGradient_Public_Static_Gradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVibrantGradient_Public_Static_Gradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPresetDescription_Public_Static_String_PresetType_0;

	static SunGradientPresets()
	{
		Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SunGradientPresets");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr);
		NativeMethodInfoPtr_GetPreset_Public_Static_Gradient_PresetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr, 100664500);
		NativeMethodInfoPtr_GetRealisticGradient_Public_Static_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr, 100664501);
		NativeMethodInfoPtr_GetStylizedGradient_Public_Static_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr, 100664502);
		NativeMethodInfoPtr_GetWarmGradient_Public_Static_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr, 100664503);
		NativeMethodInfoPtr_GetCoolGradient_Public_Static_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr, 100664504);
		NativeMethodInfoPtr_GetFantasyGradient_Public_Static_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr, 100664505);
		NativeMethodInfoPtr_GetDramaticGradient_Public_Static_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr, 100664506);
		NativeMethodInfoPtr_GetSoftGradient_Public_Static_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr, 100664507);
		NativeMethodInfoPtr_GetVibrantGradient_Public_Static_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr, 100664508);
		NativeMethodInfoPtr_GetPresetDescription_Public_Static_String_PresetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunGradientPresets>.NativeClassPtr, 100664509);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43618, RefRangeEnd = 43619, XrefRangeStart = 43610, XrefRangeEnd = 43618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Gradient GetPreset(PresetType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreset_Public_Static_Gradient_PresetType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Gradient>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43639, RefRangeEnd = 43640, XrefRangeStart = 43619, XrefRangeEnd = 43639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Gradient GetRealisticGradient()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRealisticGradient_Public_Static_Gradient_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Gradient>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43659, RefRangeEnd = 43660, XrefRangeStart = 43640, XrefRangeEnd = 43659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Gradient GetStylizedGradient()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStylizedGradient_Public_Static_Gradient_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Gradient>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43678, RefRangeEnd = 43679, XrefRangeStart = 43660, XrefRangeEnd = 43678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Gradient GetWarmGradient()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWarmGradient_Public_Static_Gradient_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Gradient>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43697, RefRangeEnd = 43698, XrefRangeStart = 43679, XrefRangeEnd = 43697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Gradient GetCoolGradient()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCoolGradient_Public_Static_Gradient_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Gradient>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43718, RefRangeEnd = 43719, XrefRangeStart = 43698, XrefRangeEnd = 43718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Gradient GetFantasyGradient()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFantasyGradient_Public_Static_Gradient_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Gradient>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43737, RefRangeEnd = 43738, XrefRangeStart = 43719, XrefRangeEnd = 43737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Gradient GetDramaticGradient()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDramaticGradient_Public_Static_Gradient_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Gradient>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43756, RefRangeEnd = 43757, XrefRangeStart = 43738, XrefRangeEnd = 43756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Gradient GetSoftGradient()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSoftGradient_Public_Static_Gradient_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Gradient>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43776, RefRangeEnd = 43777, XrefRangeStart = 43757, XrefRangeEnd = 43776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Gradient GetVibrantGradient()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVibrantGradient_Public_Static_Gradient_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Gradient>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43777, XrefRangeEnd = 43787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetPresetDescription(PresetType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPresetDescription_Public_Static_String_PresetType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public SunGradientPresets(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
