using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class ContrabandListing : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_listingId;

	private static readonly System.IntPtr NativeFieldInfoPtr_priceModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_deliverySpeed;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeliveryDelay_Public_Static_Single_DeliverySpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeliverySpeedMultiplier_Public_Static_Single_DeliverySpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSuccessRate_Public_Static_Single_DeliverySpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeliveryTimeRange_Public_Static_String_DeliverySpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string listingId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listingId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listingId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float priceModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priceModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priceModifier)) = num;
		}
	}

	public unsafe DeliverySpeed deliverySpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliverySpeed);
			return *(DeliverySpeed*)num;
		}
		set
		{
			*(DeliverySpeed*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliverySpeed)) = deliverySpeed;
		}
	}

	static ContrabandListing()
	{
		Il2CppClassPointerStore<ContrabandListing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ContrabandListing");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContrabandListing>.NativeClassPtr);
		NativeFieldInfoPtr_listingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandListing>.NativeClassPtr, "listingId");
		NativeFieldInfoPtr_priceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandListing>.NativeClassPtr, "priceModifier");
		NativeFieldInfoPtr_deliverySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandListing>.NativeClassPtr, "deliverySpeed");
		NativeMethodInfoPtr_GetDeliveryDelay_Public_Static_Single_DeliverySpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContrabandListing>.NativeClassPtr, 100671321);
		NativeMethodInfoPtr_GetDeliverySpeedMultiplier_Public_Static_Single_DeliverySpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContrabandListing>.NativeClassPtr, 100671322);
		NativeMethodInfoPtr_GetSuccessRate_Public_Static_Single_DeliverySpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContrabandListing>.NativeClassPtr, 100671323);
		NativeMethodInfoPtr_GetDeliveryTimeRange_Public_Static_String_DeliverySpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContrabandListing>.NativeClassPtr, 100671324);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContrabandListing>.NativeClassPtr, 100671325);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131909, RefRangeEnd = 131910, XrefRangeStart = 131909, XrefRangeEnd = 131909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetDeliveryDelay(DeliverySpeed speed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeliveryDelay_Public_Static_Single_DeliverySpeed_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float GetDeliverySpeedMultiplier(DeliverySpeed speed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeliverySpeedMultiplier_Public_Static_Single_DeliverySpeed_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131910, RefRangeEnd = 131911, XrefRangeStart = 131910, XrefRangeEnd = 131910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetSuccessRate(DeliverySpeed speed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSuccessRate_Public_Static_Single_DeliverySpeed_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131915, RefRangeEnd = 131916, XrefRangeStart = 131911, XrefRangeEnd = 131915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDeliveryTimeRange(DeliverySpeed speed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeliveryTimeRange_Public_Static_String_DeliverySpeed_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ContrabandListing()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContrabandListing>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ContrabandListing(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
