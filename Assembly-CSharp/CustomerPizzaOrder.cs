using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class CustomerPizzaOrder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_orderId;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayId;

	private static readonly System.IntPtr NativeFieldInfoPtr_customerName;

	private static readonly System.IntPtr NativeFieldInfoPtr_orderTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_pizzaItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_pizzaPrices;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_remainingTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxWaitTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTutorial;

	private static readonly System.IntPtr NativeFieldInfoPtr_neverExpires;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresShadyIngredient;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredShadyIngredientType;

	private static readonly System.IntPtr NativeFieldInfoPtr_excludeFromBulkCancel;

	private static readonly System.IntPtr NativeFieldInfoPtr_serverPizzaData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateOrderId_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDisplayId_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateTotal_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormattedTime_Public_String_0;

	public unsafe string orderId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string displayId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string customerName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customerName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customerName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppSystem.DateTime orderTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderTime)) = dateTime;
		}
	}

	public unsafe Dictionary<string, int> pizzaItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, float> pizzaPrices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaPrices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaPrices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe float totalAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalAmount)) = num;
		}
	}

	public unsafe CustomerOrderStatus status
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status);
			return *(CustomerOrderStatus*)num;
		}
		set
		{
			*(CustomerOrderStatus*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status)) = customerOrderStatus;
		}
	}

	public unsafe float remainingTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingTime)) = num;
		}
	}

	public unsafe float maxWaitTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWaitTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWaitTime)) = num;
		}
	}

	public unsafe bool isTutorial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTutorial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTutorial)) = flag;
		}
	}

	public unsafe bool neverExpires
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neverExpires);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neverExpires)) = flag;
		}
	}

	public unsafe bool requiresShadyIngredient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresShadyIngredient);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresShadyIngredient)) = flag;
		}
	}

	public unsafe IngredientType requiredShadyIngredientType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredShadyIngredientType);
			return *(IngredientType*)num;
		}
		set
		{
			*(IngredientType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredShadyIngredientType)) = ingredientType;
		}
	}

	public unsafe bool excludeFromBulkCancel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromBulkCancel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromBulkCancel)) = flag;
		}
	}

	public unsafe string serverPizzaData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serverPizzaData);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serverPizzaData)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static CustomerPizzaOrder()
	{
		Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CustomerPizzaOrder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr);
		NativeFieldInfoPtr_orderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "orderId");
		NativeFieldInfoPtr_displayId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "displayId");
		NativeFieldInfoPtr_customerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "customerName");
		NativeFieldInfoPtr_orderTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "orderTime");
		NativeFieldInfoPtr_pizzaItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "pizzaItems");
		NativeFieldInfoPtr_pizzaPrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "pizzaPrices");
		NativeFieldInfoPtr_totalAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "totalAmount");
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "status");
		NativeFieldInfoPtr_remainingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "remainingTime");
		NativeFieldInfoPtr_maxWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "maxWaitTime");
		NativeFieldInfoPtr_isTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "isTutorial");
		NativeFieldInfoPtr_neverExpires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "neverExpires");
		NativeFieldInfoPtr_requiresShadyIngredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "requiresShadyIngredient");
		NativeFieldInfoPtr_requiredShadyIngredientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "requiredShadyIngredientType");
		NativeFieldInfoPtr_excludeFromBulkCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "excludeFromBulkCancel");
		NativeFieldInfoPtr_serverPizzaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, "serverPizzaData");
		NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, 100664130);
		NativeMethodInfoPtr_GenerateOrderId_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, 100664131);
		NativeMethodInfoPtr_GenerateDisplayId_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, 100664132);
		NativeMethodInfoPtr_CalculateTotal_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, 100664133);
		NativeMethodInfoPtr_GetFormattedTime_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr, 100664134);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 35163, RefRangeEnd = 35165, XrefRangeStart = 35126, XrefRangeEnd = 35163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CustomerPizzaOrder(string customer, float waitTime = 120f)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerPizzaOrder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(customer);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &waitTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35165, XrefRangeEnd = 35167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GenerateOrderId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateOrderId_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35167, XrefRangeEnd = 35182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GenerateDisplayId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateDisplayId_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35182, XrefRangeEnd = 35204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateTotal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateTotal_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35204, XrefRangeEnd = 35220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetFormattedTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormattedTime_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public CustomerPizzaOrder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
