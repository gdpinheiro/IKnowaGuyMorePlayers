using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class FPD_ResourcesIconAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr_Path;

	private static readonly IntPtr NativeFieldInfoPtr_Spacing;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

	public unsafe string Path
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Path);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Path)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int Spacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Spacing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Spacing)) = num;
		}
	}

	static FPD_ResourcesIconAttribute()
	{
		Il2CppClassPointerStore<FPD_ResourcesIconAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FPD_ResourcesIconAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPD_ResourcesIconAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_ResourcesIconAttribute>.NativeClassPtr, "Path");
		NativeFieldInfoPtr_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_ResourcesIconAttribute>.NativeClassPtr, "Spacing");
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPD_ResourcesIconAttribute>.NativeClassPtr, 100663311);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19877, XrefRangeEnd = 19879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPD_ResourcesIconAttribute(string path, int spacing = 0)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPD_ResourcesIconAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &spacing;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FPD_ResourcesIconAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
