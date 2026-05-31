using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class BeverageOrderData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_beverageType;

	private static readonly System.IntPtr NativeFieldInfoPtr_quantity;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBeverageType_Public_BeverageType_0;

	public unsafe string beverageType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_beverageType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_beverageType)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	static BeverageOrderData()
	{
		Il2CppClassPointerStore<BeverageOrderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BeverageOrderData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeverageOrderData>.NativeClassPtr);
		NativeFieldInfoPtr_beverageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeverageOrderData>.NativeClassPtr, "beverageType");
		NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeverageOrderData>.NativeClassPtr, "quantity");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeverageOrderData>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_GetBeverageType_Public_BeverageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeverageOrderData>.NativeClassPtr, 100663433);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BeverageOrderData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeverageOrderData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22941, RefRangeEnd = 22942, XrefRangeStart = 22928, XrefRangeEnd = 22941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BeverageType GetBeverageType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBeverageType_Public_BeverageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(BeverageType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public BeverageOrderData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
