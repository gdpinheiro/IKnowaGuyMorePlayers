using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Core.Save;

[System.Serializable]
public class CargoBoxSaveEntry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_posX;

	private static readonly System.IntPtr NativeFieldInfoPtr_posY;

	private static readonly System.IntPtr NativeFieldInfoPtr_posZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotY;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotW;

	private static readonly System.IntPtr NativeFieldInfoPtr_ingredientIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_machineIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_orderableIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMachineBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOrderableBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEmpty;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	static CargoBoxSaveEntry()
	{
		Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "CargoBoxSaveEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr);
		NativeFieldInfoPtr_posX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "posX");
		NativeFieldInfoPtr_posY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "posY");
		NativeFieldInfoPtr_posZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "posZ");
		NativeFieldInfoPtr_rotX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "rotX");
		NativeFieldInfoPtr_rotY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "rotY");
		NativeFieldInfoPtr_rotZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "rotZ");
		NativeFieldInfoPtr_rotW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "rotW");
		NativeFieldInfoPtr_ingredientIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "ingredientIndex");
		NativeFieldInfoPtr_machineIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "machineIndex");
		NativeFieldInfoPtr_orderableIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "orderableIndex");
		NativeFieldInfoPtr_isMachineBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "isMachineBox");
		NativeFieldInfoPtr_isOrderableBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "isOrderableBox");
		NativeFieldInfoPtr_isEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, "isEmpty");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr, 100676019);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CargoBoxSaveEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CargoBoxSaveEntry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CargoBoxSaveEntry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
