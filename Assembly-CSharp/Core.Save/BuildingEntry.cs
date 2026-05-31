using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Core.Save;

[System.Serializable]
public class BuildingEntry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_machineType;

	private static readonly System.IntPtr NativeFieldInfoPtr_posX;

	private static readonly System.IntPtr NativeFieldInfoPtr_posY;

	private static readonly System.IntPtr NativeFieldInfoPtr_posZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotY;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotW;

	private static readonly System.IntPtr NativeFieldInfoPtr_ingredientIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_ingredientAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_freezerAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_doughPressStock;

	private static readonly System.IntPtr NativeFieldInfoPtr_machineIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_decorationIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_pizzaRackSlots;

	private static readonly System.IntPtr NativeFieldInfoPtr_pizzaStationPizza;

	private static readonly System.IntPtr NativeFieldInfoPtr_cargoBoxShelfSlots;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int machineType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineType)) = num;
		}
	}

	public unsafe float posX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posX)) = num;
		}
	}

	public unsafe float posY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posY)) = num;
		}
	}

	public unsafe float posZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posZ)) = num;
		}
	}

	public unsafe float rotX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotX)) = num;
		}
	}

	public unsafe float rotY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotY)) = num;
		}
	}

	public unsafe float rotZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotZ)) = num;
		}
	}

	public unsafe float rotW
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotW);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotW)) = num;
		}
	}

	public unsafe int ingredientIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientIndex)) = num;
		}
	}

	public unsafe int ingredientAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientAmount)) = num;
		}
	}

	public unsafe int freezerAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freezerAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freezerAmount)) = num;
		}
	}

	public unsafe int doughPressStock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doughPressStock);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doughPressStock)) = num;
		}
	}

	public unsafe int machineIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineIndex)) = num;
		}
	}

	public unsafe int decorationIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorationIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorationIndex)) = num;
		}
	}

	public unsafe List<PizzaSaveEntry> pizzaRackSlots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaRackSlots);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PizzaSaveEntry>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaRackSlots)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe PizzaSaveEntry pizzaStationPizza
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaStationPizza);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PizzaSaveEntry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaStationPizza)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pizzaSaveEntry));
		}
	}

	public unsafe List<CargoBoxShelfSlotSaveEntry> cargoBoxShelfSlots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cargoBoxShelfSlots);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CargoBoxShelfSlotSaveEntry>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cargoBoxShelfSlots)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static BuildingEntry()
	{
		Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "BuildingEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr);
		NativeFieldInfoPtr_machineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "machineType");
		NativeFieldInfoPtr_posX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "posX");
		NativeFieldInfoPtr_posY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "posY");
		NativeFieldInfoPtr_posZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "posZ");
		NativeFieldInfoPtr_rotX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "rotX");
		NativeFieldInfoPtr_rotY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "rotY");
		NativeFieldInfoPtr_rotZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "rotZ");
		NativeFieldInfoPtr_rotW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "rotW");
		NativeFieldInfoPtr_ingredientIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "ingredientIndex");
		NativeFieldInfoPtr_ingredientAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "ingredientAmount");
		NativeFieldInfoPtr_freezerAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "freezerAmount");
		NativeFieldInfoPtr_doughPressStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "doughPressStock");
		NativeFieldInfoPtr_machineIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "machineIndex");
		NativeFieldInfoPtr_decorationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "decorationIndex");
		NativeFieldInfoPtr_pizzaRackSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "pizzaRackSlots");
		NativeFieldInfoPtr_pizzaStationPizza = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "pizzaStationPizza");
		NativeFieldInfoPtr_cargoBoxShelfSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, "cargoBoxShelfSlots");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr, 100675994);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215259, RefRangeEnd = 215260, XrefRangeStart = 215258, XrefRangeEnd = 215259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuildingEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingEntry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BuildingEntry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
