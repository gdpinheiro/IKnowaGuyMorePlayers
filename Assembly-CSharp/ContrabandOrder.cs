using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class ContrabandOrder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_orderId;

	private static readonly System.IntPtr NativeFieldInfoPtr_contrabandId;

	private static readonly System.IntPtr NativeFieldInfoPtr_state;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemNetworkId;

	private static readonly System.IntPtr NativeFieldInfoPtr_cryptoPrice;

	private static readonly System.IntPtr NativeFieldInfoPtr_createdTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_listingId;

	private static readonly System.IntPtr NativeFieldInfoPtr_deliveryDelaySeconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_deliveryEndTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTutorialOrder;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe string contrabandId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contrabandId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contrabandId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ContrabandOrderState state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state);
			return *(ContrabandOrderState*)num;
		}
		set
		{
			*(ContrabandOrderState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state)) = contrabandOrderState;
		}
	}

	public unsafe ulong itemNetworkId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemNetworkId);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemNetworkId)) = num;
		}
	}

	public unsafe float cryptoPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cryptoPrice);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cryptoPrice)) = num;
		}
	}

	public unsafe float createdTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createdTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createdTime)) = num;
		}
	}

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

	public unsafe float deliveryDelaySeconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveryDelaySeconds);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveryDelaySeconds)) = num;
		}
	}

	public unsafe float deliveryEndTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveryEndTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveryEndTime)) = num;
		}
	}

	public unsafe bool isTutorialOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTutorialOrder);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTutorialOrder)) = flag;
		}
	}

	static ContrabandOrder()
	{
		Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ContrabandOrder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr);
		NativeFieldInfoPtr_orderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr, "orderId");
		NativeFieldInfoPtr_contrabandId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr, "contrabandId");
		NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr, "state");
		NativeFieldInfoPtr_itemNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr, "itemNetworkId");
		NativeFieldInfoPtr_cryptoPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr, "cryptoPrice");
		NativeFieldInfoPtr_createdTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr, "createdTime");
		NativeFieldInfoPtr_listingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr, "listingId");
		NativeFieldInfoPtr_deliveryDelaySeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr, "deliveryDelaySeconds");
		NativeFieldInfoPtr_deliveryEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr, "deliveryEndTime");
		NativeFieldInfoPtr_isTutorialOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr, "isTutorialOrder");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr, 100671228);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 130296, RefRangeEnd = 130300, XrefRangeStart = 130292, XrefRangeEnd = 130296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ContrabandOrder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContrabandOrder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ContrabandOrder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
