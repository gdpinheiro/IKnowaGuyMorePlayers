using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Core.Save;

[System.Serializable]
public class HeldItemsSaveEntry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_itemType;

	private static readonly System.IntPtr NativeFieldInfoPtr_registryIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_stackCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_photoFileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_cargoBoxState;

	private static readonly System.IntPtr NativeFieldInfoPtr_pizzaState;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string itemType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemType)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int registryIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_registryIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_registryIndex)) = num;
		}
	}

	public unsafe int stackCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackCount)) = num;
		}
	}

	public unsafe string photoFileName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_photoFileName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_photoFileName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe CargoBoxSaveEntry cargoBoxState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cargoBoxState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CargoBoxSaveEntry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cargoBoxState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cargoBoxSaveEntry));
		}
	}

	public unsafe PizzaSaveEntry pizzaState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PizzaSaveEntry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pizzaSaveEntry));
		}
	}

	static HeldItemsSaveEntry()
	{
		Il2CppClassPointerStore<HeldItemsSaveEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "HeldItemsSaveEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeldItemsSaveEntry>.NativeClassPtr);
		NativeFieldInfoPtr_itemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeldItemsSaveEntry>.NativeClassPtr, "itemType");
		NativeFieldInfoPtr_registryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeldItemsSaveEntry>.NativeClassPtr, "registryIndex");
		NativeFieldInfoPtr_stackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeldItemsSaveEntry>.NativeClassPtr, "stackCount");
		NativeFieldInfoPtr_photoFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeldItemsSaveEntry>.NativeClassPtr, "photoFileName");
		NativeFieldInfoPtr_cargoBoxState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeldItemsSaveEntry>.NativeClassPtr, "cargoBoxState");
		NativeFieldInfoPtr_pizzaState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeldItemsSaveEntry>.NativeClassPtr, "pizzaState");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeldItemsSaveEntry>.NativeClassPtr, 100676027);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeldItemsSaveEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeldItemsSaveEntry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HeldItemsSaveEntry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
