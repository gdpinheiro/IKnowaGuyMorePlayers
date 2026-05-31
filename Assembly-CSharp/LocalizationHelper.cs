using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

public static class LocalizationHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TABLE_NAME;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalized_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalized_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedOrDefault_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsReady_Public_Static_Boolean_0;

	public unsafe static string TABLE_NAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TABLE_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TABLE_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static LocalizationHelper()
	{
		Il2CppClassPointerStore<LocalizationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LocalizationHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationHelper>.NativeClassPtr);
		NativeFieldInfoPtr_TABLE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationHelper>.NativeClassPtr, "TABLE_NAME");
		NativeMethodInfoPtr_GetLocalized_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationHelper>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_GetLocalized_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationHelper>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_GetLocalizedOrDefault_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationHelper>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_IsReady_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationHelper>.NativeClassPtr, 100663558);
	}

	[CallerCount(609)]
	[CachedScanResults(RefRangeStart = 23310, RefRangeEnd = 23919, XrefRangeStart = 23294, XrefRangeEnd = 23310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocalized(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalized_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(79)]
	[CachedScanResults(RefRangeStart = 23927, RefRangeEnd = 24006, XrefRangeStart = 23919, XrefRangeEnd = 23927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocalized(string key, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalized_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 24009, RefRangeEnd = 24017, XrefRangeStart = 24006, XrefRangeEnd = 24009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocalizedOrDefault(string key, string defaultText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultText);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedOrDefault_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 24027, RefRangeEnd = 24029, XrefRangeStart = 24017, XrefRangeEnd = 24027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsReady()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsReady_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public static string GetLocalized(string key, params Il2CppSystem.Object[] args)
	{
		return GetLocalized(key, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public LocalizationHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
