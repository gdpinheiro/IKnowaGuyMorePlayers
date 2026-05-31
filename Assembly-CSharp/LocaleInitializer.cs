using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class LocaleInitializer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetInvariantCulture_Private_Static_Void_0;

	static LocaleInitializer()
	{
		Il2CppClassPointerStore<LocaleInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LocaleInitializer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocaleInitializer>.NativeClassPtr);
		NativeMethodInfoPtr_SetInvariantCulture_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleInitializer>.NativeClassPtr, 100663554);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23280, XrefRangeEnd = 23294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetInvariantCulture()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInvariantCulture_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LocaleInitializer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
