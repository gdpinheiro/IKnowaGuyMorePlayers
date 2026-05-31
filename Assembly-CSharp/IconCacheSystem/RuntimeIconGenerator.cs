using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace IconCacheSystem;

public static class RuntimeIconGenerator : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_iconSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_dynamicObjectTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedCamObj;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedRenderTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedKeyLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedFillLight;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateIcon_Public_Static_Sprite_GameObject_IconCameraAngle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCacheForObject_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDynamicObject_Private_Static_Boolean_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureResources_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateIconInternal_Private_Static_Sprite_GameObject_IconCameraAngle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateBounds_Private_Static_Bounds_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreOriginalLayers_Private_Static_Void_GameObject_Dictionary_2_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreOriginalLayers_Private_Static_Void_Dictionary_2_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraOffsetForAngle_Private_Static_Vector3_IconCameraAngle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCacheStats_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAllCache_Public_Static_Void_0;

	public unsafe static int iconSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_iconSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_iconSize, (void*)(&num));
		}
	}

	public unsafe static HashSet<string> dynamicObjectTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dynamicObjectTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dynamicObjectTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static GameObject cachedCamObj
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedCamObj, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedCamObj, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe static Camera cachedCamera
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedCamera, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedCamera, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera));
		}
	}

	public unsafe static RenderTexture cachedRenderTexture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedRenderTexture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedRenderTexture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderTexture));
		}
	}

	public unsafe static Light cachedKeyLight
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedKeyLight, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedKeyLight, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light));
		}
	}

	public unsafe static Light cachedFillLight
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedFillLight, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedFillLight, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light));
		}
	}

	static RuntimeIconGenerator()
	{
		Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "IconCacheSystem", "RuntimeIconGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr);
		NativeFieldInfoPtr_iconSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, "iconSize");
		NativeFieldInfoPtr_dynamicObjectTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, "dynamicObjectTypes");
		NativeFieldInfoPtr_cachedCamObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, "cachedCamObj");
		NativeFieldInfoPtr_cachedCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, "cachedCamera");
		NativeFieldInfoPtr_cachedRenderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, "cachedRenderTexture");
		NativeFieldInfoPtr_cachedKeyLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, "cachedKeyLight");
		NativeFieldInfoPtr_cachedFillLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, "cachedFillLight");
		NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674945);
		NativeMethodInfoPtr_GenerateIcon_Public_Static_Sprite_GameObject_IconCameraAngle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674946);
		NativeMethodInfoPtr_ClearCacheForObject_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674947);
		NativeMethodInfoPtr_IsDynamicObject_Private_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674948);
		NativeMethodInfoPtr_EnsureResources_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674949);
		NativeMethodInfoPtr_GenerateIconInternal_Private_Static_Sprite_GameObject_IconCameraAngle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674950);
		NativeMethodInfoPtr_CalculateBounds_Private_Static_Bounds_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674951);
		NativeMethodInfoPtr_StoreOriginalLayers_Private_Static_Void_GameObject_Dictionary_2_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674952);
		NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674953);
		NativeMethodInfoPtr_RestoreOriginalLayers_Private_Static_Void_Dictionary_2_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674954);
		NativeMethodInfoPtr_GetCameraOffsetForAngle_Private_Static_Vector3_IconCameraAngle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674955);
		NativeMethodInfoPtr_GetCacheStats_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674956);
		NativeMethodInfoPtr_ClearAllCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeIconGenerator>.NativeClassPtr, 100674957);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200214, XrefRangeEnd = 200218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200218, XrefRangeEnd = 200245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GenerateIcon(GameObject target, IconCameraAngle angle = IconCameraAngle.FrontRight, float zoomMultiplier = 1f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(IconCameraAngle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &zoomMultiplier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateIcon_Public_Static_Sprite_GameObject_IconCameraAngle_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200245, XrefRangeEnd = 200257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearCacheForObject(GameObject target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCacheForObject_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200276, RefRangeEnd = 200277, XrefRangeStart = 200257, XrefRangeEnd = 200276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDynamicObject(GameObject obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDynamicObject_Private_Static_Boolean_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200423, RefRangeEnd = 200424, XrefRangeStart = 200277, XrefRangeEnd = 200423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnsureResources()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureResources_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200424, XrefRangeEnd = 200583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GenerateIconInternal(GameObject target, IconCameraAngle angle, float zoomMultiplier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(IconCameraAngle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &zoomMultiplier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateIconInternal_Private_Static_Sprite_GameObject_IconCameraAngle_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200589, RefRangeEnd = 200590, XrefRangeStart = 200583, XrefRangeEnd = 200589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds CalculateBounds(GameObject obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateBounds_Private_Static_Bounds_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 200618, RefRangeEnd = 200620, XrefRangeStart = 200590, XrefRangeEnd = 200618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StoreOriginalLayers(GameObject obj, Dictionary<GameObject, int> layerDict)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layerDict);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreOriginalLayers_Private_Static_Void_GameObject_Dictionary_2_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 200645, RefRangeEnd = 200647, XrefRangeStart = 200620, XrefRangeEnd = 200645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayerRecursively(GameObject obj, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200668, RefRangeEnd = 200669, XrefRangeStart = 200647, XrefRangeEnd = 200668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RestoreOriginalLayers(Dictionary<GameObject, int> layerDict)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layerDict);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreOriginalLayers_Private_Static_Void_Dictionary_2_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Vector3 GetCameraOffsetForAngle(IconCameraAngle angle, float objectSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&angle);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &objectSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraOffsetForAngle_Private_Static_Vector3_IconCameraAngle_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200669, XrefRangeEnd = 200673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCacheStats()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCacheStats_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200673, XrefRangeEnd = 200677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearAllCache()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAllCache_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RuntimeIconGenerator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
