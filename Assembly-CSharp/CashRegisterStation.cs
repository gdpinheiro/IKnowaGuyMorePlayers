using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Netcode;

[System.Serializable]
public class CashRegisterStation : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_machine;

	private static readonly System.IntPtr NativeFieldInfoPtr_cashRegisterWaypoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineSlotWaypoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_tipJar;

	private static readonly System.IntPtr NativeFieldInfoPtr_customerAtCashRegister;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineSlots;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkCustomerAtCashRegisterId;

	private static readonly System.IntPtr NativeFieldInfoPtr_isUnlocked;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQueueLength_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCashRegisterAvailable_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CashRegisterMachine machine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CashRegisterMachine>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machine)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cashRegisterMachine));
		}
	}

	public unsafe NPCWaypoint cashRegisterWaypoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cashRegisterWaypoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NPCWaypoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cashRegisterWaypoint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nPCWaypoint));
		}
	}

	public unsafe List<NPCWaypoint> lineSlotWaypoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineSlotWaypoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NPCWaypoint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineSlotWaypoints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe TipJar tipJar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tipJar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TipJar>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tipJar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tipJar));
		}
	}

	public unsafe CustomerNPC customerAtCashRegister
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customerAtCashRegister);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomerNPC>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customerAtCashRegister)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customerNPC));
		}
	}

	public unsafe List<RestaurantSlot> lineSlots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineSlots);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RestaurantSlot>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineSlots)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe NetworkVariable<ulong> networkCustomerAtCashRegisterId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkCustomerAtCashRegisterId);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkVariable<ulong>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkCustomerAtCashRegisterId)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkVariable));
		}
	}

	public unsafe bool isUnlocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnlocked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnlocked)) = flag;
		}
	}

	static CashRegisterStation()
	{
		Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CashRegisterStation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr);
		NativeFieldInfoPtr_machine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr, "machine");
		NativeFieldInfoPtr_cashRegisterWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr, "cashRegisterWaypoint");
		NativeFieldInfoPtr_lineSlotWaypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr, "lineSlotWaypoints");
		NativeFieldInfoPtr_tipJar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr, "tipJar");
		NativeFieldInfoPtr_customerAtCashRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr, "customerAtCashRegister");
		NativeFieldInfoPtr_lineSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr, "lineSlots");
		NativeFieldInfoPtr_networkCustomerAtCashRegisterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr, "networkCustomerAtCashRegisterId");
		NativeFieldInfoPtr_isUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr, "isUnlocked");
		NativeMethodInfoPtr_GetQueueLength_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr, 100669940);
		NativeMethodInfoPtr_IsCashRegisterAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr, 100669941);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr, 100669942);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 111601, RefRangeEnd = 111604, XrefRangeStart = 111588, XrefRangeEnd = 111601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetQueueLength()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQueueLength_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111604, XrefRangeEnd = 111605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCashRegisterAvailable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCashRegisterAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111605, XrefRangeEnd = 111620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CashRegisterStation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashRegisterStation>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CashRegisterStation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
