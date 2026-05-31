using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class FPD_PropertiesFoldoutAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr_HowManyNextPropertiesToContain;

	private static readonly IntPtr NativeFieldInfoPtr_foldout;

	private static readonly IntPtr NativeFieldInfoPtr_title;

	private static readonly IntPtr NativeFieldInfoPtr_indent;

	private static readonly IntPtr NativeFieldInfoPtr_frameStyleID;

	private static readonly IntPtr NativeFieldInfoPtr_frameStyle;

	private static readonly IntPtr NativeFieldInfoPtr_extraSpacing;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_String_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Int32_String_Int32_Int32_0;

	public unsafe int HowManyNextPropertiesToContain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HowManyNextPropertiesToContain);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HowManyNextPropertiesToContain)) = num;
		}
	}

	public unsafe bool foldout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foldout);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foldout)) = flag;
		}
	}

	public unsafe string title
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_title);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_title)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int indent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indent);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indent)) = num;
		}
	}

	public unsafe int frameStyleID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameStyleID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameStyleID)) = num;
		}
	}

	public unsafe string frameStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameStyle);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameStyle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int extraSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraSpacing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraSpacing)) = num;
		}
	}

	static FPD_PropertiesFoldoutAttribute()
	{
		Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FPD_PropertiesFoldoutAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_HowManyNextPropertiesToContain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr, "HowManyNextPropertiesToContain");
		NativeFieldInfoPtr_foldout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr, "foldout");
		NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr, "title");
		NativeFieldInfoPtr_indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr, "indent");
		NativeFieldInfoPtr_frameStyleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr, "frameStyleID");
		NativeFieldInfoPtr_frameStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr, "frameStyle");
		NativeFieldInfoPtr_extraSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr, "extraSpacing");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr, 100663310);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19869, XrefRangeEnd = 19872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPD_PropertiesFoldoutAttribute(int howManyNextPropsInside, bool defaultFoldout = false, string title = "", int extraSpacing = 0, int indent = 1)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&howManyNextPropsInside);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &defaultFoldout;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &extraSpacing;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &indent;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19872, XrefRangeEnd = 19875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPD_PropertiesFoldoutAttribute(string frameStyle, int howManyNextPropsInside, bool defaultFoldout = false, string title = "", int extraSpacing = 0, int indent = 1)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(frameStyle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &howManyNextPropsInside;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &defaultFoldout;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &extraSpacing;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &indent;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19875, XrefRangeEnd = 19877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPD_PropertiesFoldoutAttribute(int howManyNextPropsInside, bool defaultFoldout, int frameStyleID, string title = "", int extraSpacing = 0, int indent = 1)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPD_PropertiesFoldoutAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = (nint)(&howManyNextPropsInside);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &defaultFoldout;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &frameStyleID;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &extraSpacing;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &indent;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Int32_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FPD_PropertiesFoldoutAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
