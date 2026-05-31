using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class FPD_LayersAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static FPD_LayersAttribute()
	{
		Il2CppClassPointerStore<FPD_LayersAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FPD_LayersAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPD_LayersAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPD_LayersAttribute>.NativeClassPtr, 100663307);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19868, XrefRangeEnd = 19869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPD_LayersAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPD_LayersAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FPD_LayersAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
