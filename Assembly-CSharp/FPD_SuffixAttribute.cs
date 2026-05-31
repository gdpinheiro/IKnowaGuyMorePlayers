using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class FPD_SuffixAttribute : PropertyAttribute
{
	public enum SuffixMode
	{
		From0to100,
		PercentageUnclamped,
		FromMinToMax,
		FromMinToMaxRounded
	}

	private static readonly IntPtr NativeFieldInfoPtr_Min;

	private static readonly IntPtr NativeFieldInfoPtr_Max;

	private static readonly IntPtr NativeFieldInfoPtr_Mode;

	private static readonly IntPtr NativeFieldInfoPtr_Suffix;

	private static readonly IntPtr NativeFieldInfoPtr_editableValue;

	private static readonly IntPtr NativeFieldInfoPtr_widerField;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SuffixMode_String_Boolean_Int32_0;

	public unsafe float Min
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Min);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Min)) = num;
		}
	}

	public unsafe float Max
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Max);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Max)) = num;
		}
	}

	public unsafe SuffixMode Mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mode);
			return *(SuffixMode*)num;
		}
		set
		{
			*(SuffixMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mode)) = suffixMode;
		}
	}

	public unsafe string Suffix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Suffix);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Suffix)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool editableValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editableValue);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editableValue)) = flag;
		}
	}

	public unsafe int widerField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_widerField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_widerField)) = num;
		}
	}

	static FPD_SuffixAttribute()
	{
		Il2CppClassPointerStore<FPD_SuffixAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FPD_SuffixAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPD_SuffixAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SuffixAttribute>.NativeClassPtr, "Min");
		NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SuffixAttribute>.NativeClassPtr, "Max");
		NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SuffixAttribute>.NativeClassPtr, "Mode");
		NativeFieldInfoPtr_Suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SuffixAttribute>.NativeClassPtr, "Suffix");
		NativeFieldInfoPtr_editableValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SuffixAttribute>.NativeClassPtr, "editableValue");
		NativeFieldInfoPtr_widerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_SuffixAttribute>.NativeClassPtr, "widerField");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SuffixMode_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPD_SuffixAttribute>.NativeClassPtr, 100663313);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19881, XrefRangeEnd = 19883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPD_SuffixAttribute(float min, float max, SuffixMode mode = SuffixMode.From0to100, string suffix = "%", bool editable = true, int wider = 0)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPD_SuffixAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = (nint)(&min);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &max;
		*(SuffixMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(suffix);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &editable;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &wider;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SuffixMode_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FPD_SuffixAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
