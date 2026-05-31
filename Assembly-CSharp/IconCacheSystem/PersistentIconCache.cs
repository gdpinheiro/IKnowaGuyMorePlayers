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

public static class PersistentIconCache : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("IconCacheSystem.PersistentIconCache+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__21_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__EnforceDiskCacheLimit_b__21_0_Internal_Int32_IconCacheEntry_IconCacheEntry_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Comparison<IconCacheEntry> __9__21_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<IconCacheEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__21_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__21_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100674943);
			NativeMethodInfoPtr__EnforceDiskCacheLimit_b__21_0_Internal_Int32_IconCacheEntry_IconCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100674944);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199562, XrefRangeEnd = 199564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _EnforceDiskCacheLimit_b__21_0(IconCacheEntry a, IconCacheEntry b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__EnforceDiskCacheLimit_b__21_0_Internal_Int32_IconCacheEntry_IconCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_CACHE_FOLDER_NAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_METADATA_FILE_NAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_MEMORY_CACHE_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DISK_CACHE_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_memoryCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_lruOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_lruNodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_metadata;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInitialized;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CacheFolderPath_Private_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MetadataFilePath_Private_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCachedIcon_Public_Static_Sprite_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveIcon_Public_Static_Void_String_Sprite_String_String_IconCameraAngle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCachedIcon_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearMemoryCache_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToMemoryCache_Private_Static_Void_String_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TouchCacheEntry_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveIcon_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnforceDiskCacheLimit_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAllCache_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCacheStats_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCacheKey_Public_Static_String_String_IconCameraAngle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_Static_String_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadMetadata_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveMetadata_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadIconFromDisk_Private_Static_Sprite_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIconFilePath_Private_Static_String_String_0;

	public unsafe static string CACHE_FOLDER_NAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CACHE_FOLDER_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CACHE_FOLDER_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string METADATA_FILE_NAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_METADATA_FILE_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_METADATA_FILE_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int MAX_MEMORY_CACHE_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_MEMORY_CACHE_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_MEMORY_CACHE_SIZE, (void*)(&num));
		}
	}

	public unsafe static int MAX_DISK_CACHE_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_DISK_CACHE_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_DISK_CACHE_SIZE, (void*)(&num));
		}
	}

	public unsafe static Dictionary<string, Sprite> memoryCache
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_memoryCache, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Sprite>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_memoryCache, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static LinkedList<string> lruOrder
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lruOrder, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LinkedList<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lruOrder, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)linkedList));
		}
	}

	public unsafe static Dictionary<string, LinkedListNode<string>> lruNodes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lruNodes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, LinkedListNode<string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lruNodes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static IconCacheMetadata metadata
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_metadata, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IconCacheMetadata>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_metadata, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iconCacheMetadata));
		}
	}

	public unsafe static bool isInitialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isInitialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isInitialized, (void*)(&flag));
		}
	}

	public unsafe static string CacheFolderPath
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 199574, RefRangeEnd = 199581, XrefRangeStart = 199564, XrefRangeEnd = 199574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CacheFolderPath_Private_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string MetadataFilePath
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199591, RefRangeEnd = 199593, XrefRangeStart = 199581, XrefRangeEnd = 199591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MetadataFilePath_Private_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static PersistentIconCache()
	{
		Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "IconCacheSystem", "PersistentIconCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr);
		NativeFieldInfoPtr_CACHE_FOLDER_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, "CACHE_FOLDER_NAME");
		NativeFieldInfoPtr_METADATA_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, "METADATA_FILE_NAME");
		NativeFieldInfoPtr_MAX_MEMORY_CACHE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, "MAX_MEMORY_CACHE_SIZE");
		NativeFieldInfoPtr_MAX_DISK_CACHE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, "MAX_DISK_CACHE_SIZE");
		NativeFieldInfoPtr_memoryCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, "memoryCache");
		NativeFieldInfoPtr_lruOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, "lruOrder");
		NativeFieldInfoPtr_lruNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, "lruNodes");
		NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, "metadata");
		NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, "isInitialized");
		NativeMethodInfoPtr_get_CacheFolderPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674922);
		NativeMethodInfoPtr_get_MetadataFilePath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674923);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674924);
		NativeMethodInfoPtr_GetCachedIcon_Public_Static_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674925);
		NativeMethodInfoPtr_SaveIcon_Public_Static_Void_String_Sprite_String_String_IconCameraAngle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674926);
		NativeMethodInfoPtr_HasCachedIcon_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674927);
		NativeMethodInfoPtr_ClearMemoryCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674928);
		NativeMethodInfoPtr_AddToMemoryCache_Private_Static_Void_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674929);
		NativeMethodInfoPtr_TouchCacheEntry_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674930);
		NativeMethodInfoPtr_RemoveIcon_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674931);
		NativeMethodInfoPtr_EnforceDiskCacheLimit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674932);
		NativeMethodInfoPtr_ClearAllCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674933);
		NativeMethodInfoPtr_GetCacheStats_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674934);
		NativeMethodInfoPtr_GenerateCacheKey_Public_Static_String_String_IconCameraAngle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674935);
		NativeMethodInfoPtr_GetPrefabGUID_Public_Static_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674936);
		NativeMethodInfoPtr_LoadMetadata_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674937);
		NativeMethodInfoPtr_SaveMetadata_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674938);
		NativeMethodInfoPtr_LoadIconFromDisk_Private_Static_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674939);
		NativeMethodInfoPtr_GetIconFilePath_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentIconCache>.NativeClassPtr, 100674940);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 199608, RefRangeEnd = 199614, XrefRangeStart = 199593, XrefRangeEnd = 199608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199651, RefRangeEnd = 199652, XrefRangeStart = 199614, XrefRangeEnd = 199651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GetCachedIcon(string hash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hash);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCachedIcon_Public_Static_Sprite_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199652, XrefRangeEnd = 199708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveIcon(string hash, Sprite sprite, string prefabPath, string prefabGUID, IconCameraAngle angle, float zoom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefabPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefabGUID);
		*(IconCameraAngle**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &zoom;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveIcon_Public_Static_Void_String_Sprite_String_String_IconCameraAngle_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199708, XrefRangeEnd = 199730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasCachedIcon(string hash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hash);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCachedIcon_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199776, RefRangeEnd = 199778, XrefRangeStart = 199730, XrefRangeEnd = 199776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearMemoryCache()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearMemoryCache_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199842, RefRangeEnd = 199843, XrefRangeStart = 199778, XrefRangeEnd = 199842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddToMemoryCache(string hash, Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToMemoryCache_Private_Static_Void_String_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199843, XrefRangeEnd = 199865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TouchCacheEntry(string hash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hash);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TouchCacheEntry_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199968, RefRangeEnd = 199969, XrefRangeStart = 199865, XrefRangeEnd = 199968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveIcon(string hashPrefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hashPrefix);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveIcon_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200057, RefRangeEnd = 200058, XrefRangeStart = 199969, XrefRangeEnd = 200057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnforceDiskCacheLimit()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnforceDiskCacheLimit_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200087, RefRangeEnd = 200088, XrefRangeStart = 200058, XrefRangeEnd = 200087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearAllCache()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAllCache_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200125, RefRangeEnd = 200126, XrefRangeStart = 200088, XrefRangeEnd = 200125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCacheStats()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCacheStats_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200126, XrefRangeEnd = 200134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GenerateCacheKey(string prefabGUID, IconCameraAngle angle, float zoom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabGUID);
		*(IconCameraAngle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &zoom;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCacheKey_Public_Static_String_String_IconCameraAngle_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200134, XrefRangeEnd = 200136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetPrefabGUID(GameObject obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrefabGUID_Public_Static_String_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200152, RefRangeEnd = 200153, XrefRangeStart = 200136, XrefRangeEnd = 200152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadMetadata()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadMetadata_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 200166, RefRangeEnd = 200172, XrefRangeStart = 200153, XrefRangeEnd = 200166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveMetadata()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveMetadata_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200196, RefRangeEnd = 200197, XrefRangeStart = 200172, XrefRangeEnd = 200196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite LoadIconFromDisk(string hash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hash);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadIconFromDisk_Private_Static_Sprite_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 200210, RefRangeEnd = 200214, XrefRangeStart = 200197, XrefRangeEnd = 200210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetIconFilePath(string hash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hash);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIconFilePath_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public PersistentIconCache(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
