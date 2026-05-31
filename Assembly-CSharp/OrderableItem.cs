using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class OrderableItem : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_orderableSO;

	private static readonly IntPtr NativeMethodInfoPtr_GetOrderableSO_Public_OrderableSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetOrderableIndex_Public_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe OrderableSO orderableSO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableSO);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<OrderableSO>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableSO)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)orderableSO));
		}
	}

	static OrderableItem()
	{
		Il2CppClassPointerStore<OrderableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OrderableItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderableItem>.NativeClassPtr);
		NativeFieldInfoPtr_orderableSO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderableItem>.NativeClassPtr, "orderableSO");
		NativeMethodInfoPtr_GetOrderableSO_Public_OrderableSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderableItem>.NativeClassPtr, 100665630);
		NativeMethodInfoPtr_GetOrderableIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderableItem>.NativeClassPtr, 100665631);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderableItem>.NativeClassPtr, 100665632);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 43540, RefRangeEnd = 43551, XrefRangeStart = 43540, XrefRangeEnd = 43551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OrderableSO GetOrderableSO()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrderableSO_Public_OrderableSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<OrderableSO>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 61940, RefRangeEnd = 61942, XrefRangeStart = 61931, XrefRangeEnd = 61940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetOrderableIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrderableIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(158)]
	[CachedScanResults(RefRangeStart = 42846, RefRangeEnd = 43004, XrefRangeStart = 42846, XrefRangeEnd = 43004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OrderableItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderableItem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OrderableItem(IntPtr pointer)
		: base(pointer)
	{
	}
}
