using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public static class CrackTextureGenerator : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCrackTexture_Public_Static_Texture2D_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCrackValue_Private_Static_Single_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hash_Private_Static_Single_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Frac_Private_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateMultiLayerCrackTexture_Public_Static_Texture2D_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDamageStageTextures_Public_Static_Il2CppReferenceArray_1_Texture2D_Int32_0;

	static CrackTextureGenerator()
	{
		Il2CppClassPointerStore<CrackTextureGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CrackTextureGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrackTextureGenerator>.NativeClassPtr);
		NativeMethodInfoPtr_GenerateCrackTexture_Public_Static_Texture2D_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrackTextureGenerator>.NativeClassPtr, 100666682);
		NativeMethodInfoPtr_GenerateCrackValue_Private_Static_Single_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrackTextureGenerator>.NativeClassPtr, 100666683);
		NativeMethodInfoPtr_Hash_Private_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrackTextureGenerator>.NativeClassPtr, 100666684);
		NativeMethodInfoPtr_Frac_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrackTextureGenerator>.NativeClassPtr, 100666685);
		NativeMethodInfoPtr_GenerateMultiLayerCrackTexture_Public_Static_Texture2D_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrackTextureGenerator>.NativeClassPtr, 100666686);
		NativeMethodInfoPtr_GenerateDamageStageTextures_Public_Static_Il2CppReferenceArray_1_Texture2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrackTextureGenerator>.NativeClassPtr, 100666687);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73229, XrefRangeEnd = 73244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D GenerateCrackTexture(int size = 512, float scale = 4f, float edgeSharpness = 5f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&size);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &edgeSharpness;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCrackTexture_Public_Static_Texture2D_Int32_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 73254, RefRangeEnd = 73263, XrefRangeStart = 73244, XrefRangeEnd = 73254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GenerateCrackValue(Vector2 p, float edgeSharpness)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&p);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &edgeSharpness;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCrackValue_Private_Static_Single_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73263, XrefRangeEnd = 73265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Hash(Vector2 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hash_Private_Static_Single_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73265, XrefRangeEnd = 73266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Frac(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Frac_Private_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73266, XrefRangeEnd = 73287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D GenerateMultiLayerCrackTexture(int size = 512, int layers = 4)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&size);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateMultiLayerCrackTexture_Public_Static_Texture2D_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73287, XrefRangeEnd = 73315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Texture2D> GenerateDamageStageTextures(int size = 256)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateDamageStageTextures_Public_Static_Il2CppReferenceArray_1_Texture2D_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr) : null;
	}

	public CrackTextureGenerator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
