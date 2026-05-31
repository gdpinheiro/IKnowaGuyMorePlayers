using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class FPD_SingleLineTwoPropsAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr_PropName;

	private static readonly IntPtr NativeFieldInfoPtr_LabelWidth;

	private static readonly IntPtr NativeFieldInfoPtr_SecLabelWidth;

	private static readonly IntPtr NativeFieldInfoPtr_MiddlePadding;

	private static readonly IntPtr NativeFieldInfoPtr_UpPadding;

	private static readonly IntPtr NativeFieldInfoPtr_AddSecondPropWidth;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_Int32_Int32_0;

	public unsafe string PropName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PropName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PropName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int LabelWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LabelWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LabelWidth)) = num;
		}
	}

	public unsafe int SecLabelWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SecLabelWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SecLabelWidth)) = num;
		}
	}

	public unsafe int MiddlePadding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiddlePadding);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiddlePadding)) = num;
		}
	}

	public unsafe int UpPadding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpPadding);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpPadding)) = num;
		}
	}

	public unsafe int AddSecondPropWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSecondPropWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSecondPropWidth)) = num;
		}
	}

	static FPD_SingleLineTwoPropsAttribute()
	{
		Il2CppClassPointerStore<FPD_SingleLineTwoPropsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FPD_SingleLineTwoPropsAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPD_SingleLineTwoPropsAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_PropName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SingleLineTwoPropsAttribute>.NativeClassPtr, "PropName");
		NativeFieldInfoPtr_LabelWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SingleLineTwoPropsAttribute>.NativeClassPtr, "LabelWidth");
		NativeFieldInfoPtr_SecLabelWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SingleLineTwoPropsAttribute>.NativeClassPtr, "SecLabelWidth");
		NativeFieldInfoPtr_MiddlePadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SingleLineTwoPropsAttribute>.NativeClassPtr, "MiddlePadding");
		NativeFieldInfoPtr_UpPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SingleLineTwoPropsAttribute>.NativeClassPtr, "UpPadding");
		NativeFieldInfoPtr_AddSecondPropWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SingleLineTwoPropsAttribute>.NativeClassPtr, "AddSecondPropWidth");
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPD_SingleLineTwoPropsAttribute>.NativeClassPtr, 100663312);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19879, XrefRangeEnd = 19881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPD_SingleLineTwoPropsAttribute(string propName, int labelWidth = 0, int secondPropLabelWidth = 0, int middlePadding = 10, int addSecondPropWidth = 0, int upPadding = 0)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPD_SingleLineTwoPropsAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &labelWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &secondPropLabelWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &middlePadding;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &addSecondPropWidth;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &upPadding;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FPD_SingleLineTwoPropsAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
