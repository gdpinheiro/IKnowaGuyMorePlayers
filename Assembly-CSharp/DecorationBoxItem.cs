using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class DecorationBoxItem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_decoration;

	private static readonly System.IntPtr NativeFieldInfoPtr_quantity;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecorationSO_Int32_0;

	public unsafe DecorationSO decoration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoration);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecorationSO>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoration)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decorationSO));
		}
	}

	public unsafe int quantity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quantity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quantity)) = num;
		}
	}

	static DecorationBoxItem()
	{
		Il2CppClassPointerStore<DecorationBoxItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DecorationBoxItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationBoxItem>.NativeClassPtr);
		NativeFieldInfoPtr_decoration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationBoxItem>.NativeClassPtr, "decoration");
		NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationBoxItem>.NativeClassPtr, "quantity");
		NativeMethodInfoPtr__ctor_Public_Void_DecorationSO_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationBoxItem>.NativeClassPtr, 100665669);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 23026, RefRangeEnd = 23029, XrefRangeStart = 23026, XrefRangeEnd = 23029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecorationBoxItem(DecorationSO decoration, int qty)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationBoxItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decoration);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &qty;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DecorationSO_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DecorationBoxItem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
