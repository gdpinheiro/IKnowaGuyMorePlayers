using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class FPD_HeaderAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr_HeaderText;

	private static readonly IntPtr NativeFieldInfoPtr_UpperPadding;

	private static readonly IntPtr NativeFieldInfoPtr_BottomPadding;

	private static readonly IntPtr NativeFieldInfoPtr_Height;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0;

	public unsafe string HeaderText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeaderText);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeaderText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float UpperPadding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpperPadding);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpperPadding)) = num;
		}
	}

	public unsafe float BottomPadding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BottomPadding);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BottomPadding)) = num;
		}
	}

	public unsafe float Height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Height);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Height)) = num;
		}
	}

	static FPD_HeaderAttribute()
	{
		Il2CppClassPointerStore<FPD_HeaderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FPD_HeaderAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPD_HeaderAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_HeaderAttribute>.NativeClassPtr, "HeaderText");
		NativeFieldInfoPtr_UpperPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_HeaderAttribute>.NativeClassPtr, "UpperPadding");
		NativeFieldInfoPtr_BottomPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_HeaderAttribute>.NativeClassPtr, "BottomPadding");
		NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPD_HeaderAttribute>.NativeClassPtr, "Height");
		NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPD_HeaderAttribute>.NativeClassPtr, 100663306);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19866, XrefRangeEnd = 19868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPD_HeaderAttribute(string headerText, float upperPadding = 6f, float bottomPadding = 4f, int addHeight = 2)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPD_HeaderAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(headerText);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &upperPadding;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &bottomPadding;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &addHeight;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FPD_HeaderAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
