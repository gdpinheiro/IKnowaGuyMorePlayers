using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class MachineSO : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_machineNameKey;

	private static readonly IntPtr NativeFieldInfoPtr_machineDescriptionKey;

	private static readonly IntPtr NativeFieldInfoPtr_machineType;

	private static readonly IntPtr NativeFieldInfoPtr_machineIcon;

	private static readonly IntPtr NativeFieldInfoPtr_machinePrefab;

	private static readonly IntPtr NativeFieldInfoPtr_price;

	private static readonly IntPtr NativeFieldInfoPtr_isAvailable;

	private static readonly IntPtr NativeFieldInfoPtr_maxQuantity;

	private static readonly IntPtr NativeFieldInfoPtr_requiredLevel;

	private static readonly IntPtr NativeFieldInfoPtr_allowFloorPlacement;

	private static readonly IntPtr NativeFieldInfoPtr_allowWallPlacement;

	private static readonly IntPtr NativeFieldInfoPtr_placementRotationOffset;

	private static readonly IntPtr NativeFieldInfoPtr_previewDistanceOffset;

	private static readonly IntPtr NativeFieldInfoPtr_deliveryTime;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string machineNameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineNameKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineNameKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string machineDescriptionKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineDescriptionKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineDescriptionKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe MachineType machineType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineType);
			return *(MachineType*)num;
		}
		set
		{
			*(MachineType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineType)) = machineType;
		}
	}

	public unsafe Sprite machineIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe GameObject machinePrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machinePrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machinePrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price)) = num;
		}
	}

	public unsafe bool isAvailable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAvailable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAvailable)) = flag;
		}
	}

	public unsafe int maxQuantity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxQuantity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxQuantity)) = num;
		}
	}

	public unsafe int requiredLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredLevel)) = num;
		}
	}

	public unsafe bool allowFloorPlacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowFloorPlacement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowFloorPlacement)) = flag;
		}
	}

	public unsafe bool allowWallPlacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowWallPlacement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowWallPlacement)) = flag;
		}
	}

	public unsafe float placementRotationOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementRotationOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementRotationOffset)) = num;
		}
	}

	public unsafe float previewDistanceOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previewDistanceOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previewDistanceOffset)) = num;
		}
	}

	public unsafe float deliveryTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveryTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveryTime)) = num;
		}
	}

	static MachineSO()
	{
		Il2CppClassPointerStore<MachineSO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MachineSO");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MachineSO>.NativeClassPtr);
		NativeFieldInfoPtr_machineNameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "machineNameKey");
		NativeFieldInfoPtr_machineDescriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "machineDescriptionKey");
		NativeFieldInfoPtr_machineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "machineType");
		NativeFieldInfoPtr_machineIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "machineIcon");
		NativeFieldInfoPtr_machinePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "machinePrefab");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "price");
		NativeFieldInfoPtr_isAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "isAvailable");
		NativeFieldInfoPtr_maxQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "maxQuantity");
		NativeFieldInfoPtr_requiredLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "requiredLevel");
		NativeFieldInfoPtr_allowFloorPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "allowFloorPlacement");
		NativeFieldInfoPtr_allowWallPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "allowWallPlacement");
		NativeFieldInfoPtr_placementRotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "placementRotationOffset");
		NativeFieldInfoPtr_previewDistanceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "previewDistanceOffset");
		NativeFieldInfoPtr_deliveryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, "deliveryTime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineSO>.NativeClassPtr, 100667212);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 79741, RefRangeEnd = 79742, XrefRangeStart = 79732, XrefRangeEnd = 79741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MachineSO()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MachineSO>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MachineSO(IntPtr pointer)
		: base(pointer)
	{
	}
}
