using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class PizzaOrderData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pizzaType;

	private static readonly System.IntPtr NativeFieldInfoPtr_quantity;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPizzaType_Public_PizzaType_0;

	public unsafe string pizzaType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaType)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	static PizzaOrderData()
	{
		Il2CppClassPointerStore<PizzaOrderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PizzaOrderData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PizzaOrderData>.NativeClassPtr);
		NativeFieldInfoPtr_pizzaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaOrderData>.NativeClassPtr, "pizzaType");
		NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaOrderData>.NativeClassPtr, "quantity");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PizzaOrderData>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_GetPizzaType_Public_PizzaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PizzaOrderData>.NativeClassPtr, 100663431);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22907, XrefRangeEnd = 22908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PizzaOrderData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PizzaOrderData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22927, RefRangeEnd = 22928, XrefRangeStart = 22908, XrefRangeEnd = 22927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PizzaType GetPizzaType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPizzaType_Public_PizzaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(PizzaType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public PizzaOrderData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
