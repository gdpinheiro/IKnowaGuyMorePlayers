using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public class DeliverySlot : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isOccupied;

	private static readonly System.IntPtr NativeFieldInfoPtr_emptyColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_occupiedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_gizmoSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnCargoRemoved;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedCargo;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedCargoBox;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnCargoRemoved_Public_add_Void_Action_1_DeliverySlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnCargoRemoved_Public_rem_Void_Action_1_DeliverySlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SpawnedCargo_Public_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnCargo_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleCargoPickedUp_Private_Void_CargoBox_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSlot_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool isOccupied
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOccupied);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOccupied)) = flag;
		}
	}

	public unsafe Color emptyColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emptyColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emptyColor)) = color;
		}
	}

	public unsafe Color occupiedColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupiedColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupiedColor)) = color;
		}
	}

	public unsafe float gizmoSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoSize)) = num;
		}
	}

	public unsafe Il2CppSystem.Action<DeliverySlot> OnCargoRemoved
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCargoRemoved);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<DeliverySlot>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCargoRemoved)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe GameObject spawnedCargo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedCargo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedCargo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe CargoBox spawnedCargoBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedCargoBox);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CargoBox>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedCargoBox)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cargoBox));
		}
	}

	public unsafe bool IsOccupied
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe GameObject SpawnedCargo
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59674, RefRangeEnd = 59675, XrefRangeStart = 59674, XrefRangeEnd = 59674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SpawnedCargo_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
	}

	static DeliverySlot()
	{
		Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DeliverySlot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr);
		NativeFieldInfoPtr_isOccupied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, "isOccupied");
		NativeFieldInfoPtr_emptyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, "emptyColor");
		NativeFieldInfoPtr_occupiedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, "occupiedColor");
		NativeFieldInfoPtr_gizmoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, "gizmoSize");
		NativeFieldInfoPtr_OnCargoRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, "OnCargoRemoved");
		NativeFieldInfoPtr_spawnedCargo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, "spawnedCargo");
		NativeFieldInfoPtr_spawnedCargoBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, "spawnedCargoBox");
		NativeMethodInfoPtr_add_OnCargoRemoved_Public_add_Void_Action_1_DeliverySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, 100665480);
		NativeMethodInfoPtr_remove_OnCargoRemoved_Public_rem_Void_Action_1_DeliverySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, 100665481);
		NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, 100665482);
		NativeMethodInfoPtr_get_SpawnedCargo_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, 100665483);
		NativeMethodInfoPtr_SpawnCargo_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, 100665484);
		NativeMethodInfoPtr_HandleCargoPickedUp_Private_Void_CargoBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, 100665485);
		NativeMethodInfoPtr_ClearSlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, 100665486);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, 100665487);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr, 100665488);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59667, RefRangeEnd = 59668, XrefRangeStart = 59662, XrefRangeEnd = 59667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnCargoRemoved(Il2CppSystem.Action<DeliverySlot> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnCargoRemoved_Public_add_Void_Action_1_DeliverySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59673, RefRangeEnd = 59674, XrefRangeStart = 59668, XrefRangeEnd = 59673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnCargoRemoved(Il2CppSystem.Action<DeliverySlot> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnCargoRemoved_Public_rem_Void_Action_1_DeliverySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59722, RefRangeEnd = 59723, XrefRangeStart = 59675, XrefRangeEnd = 59722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnCargo(GameObject cargoBox)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cargoBox);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnCargo_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59723, XrefRangeEnd = 59736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleCargoPickedUp(CargoBox cargoBox)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cargoBox);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleCargoPickedUp_Private_Void_CargoBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 59749, RefRangeEnd = 59751, XrefRangeStart = 59736, XrefRangeEnd = 59749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearSlot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59751, XrefRangeEnd = 59762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59762, XrefRangeEnd = 59763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DeliverySlot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliverySlot>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DeliverySlot(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
