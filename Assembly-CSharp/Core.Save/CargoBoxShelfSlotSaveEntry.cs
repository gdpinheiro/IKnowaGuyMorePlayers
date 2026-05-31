using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Core.Save;

[System.Serializable]
public class CargoBoxShelfSlotSaveEntry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ingredientIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_machineIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_orderableIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_decorationIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMachineBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOrderableBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDecorationBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEmpty;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe int orderableIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableIndex)) = num;
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

	public unsafe bool isMachineBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMachineBox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMachineBox)) = flag;
		}
	}

	public unsafe bool isOrderableBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOrderableBox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOrderableBox)) = flag;
		}
	}

	public unsafe bool isDecorationBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDecorationBox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDecorationBox)) = flag;
		}
	}

	public unsafe bool isEmpty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEmpty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEmpty)) = flag;
		}
	}

	static CargoBoxShelfSlotSaveEntry()
	{
		Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "CargoBoxShelfSlotSaveEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr);
		NativeFieldInfoPtr_ingredientIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr, "ingredientIndex");
		NativeFieldInfoPtr_machineIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr, "machineIndex");
		NativeFieldInfoPtr_orderableIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr, "orderableIndex");
		NativeFieldInfoPtr_decorationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr, "decorationIndex");
		NativeFieldInfoPtr_isMachineBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr, "isMachineBox");
		NativeFieldInfoPtr_isOrderableBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr, "isOrderableBox");
		NativeFieldInfoPtr_isDecorationBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr, "isDecorationBox");
		NativeFieldInfoPtr_isEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr, "isEmpty");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr, 100675997);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215272, RefRangeEnd = 215273, XrefRangeStart = 215271, XrefRangeEnd = 215272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CargoBoxShelfSlotSaveEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CargoBoxShelfSlotSaveEntry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CargoBoxShelfSlotSaveEntry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
