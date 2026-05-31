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
public class ClothingSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_slotStates;

	private static readonly System.IntPtr NativeFieldInfoPtr_takenInteractableEntryIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<int> slotStates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotStates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotStates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int takenInteractableEntryIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takenInteractableEntryIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takenInteractableEntryIndex)) = num;
		}
	}

	static ClothingSaveData()
	{
		Il2CppClassPointerStore<ClothingSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "ClothingSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_slotStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingSaveData>.NativeClassPtr, "slotStates");
		NativeFieldInfoPtr_takenInteractableEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingSaveData>.NativeClassPtr, "takenInteractableEntryIndex");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingSaveData>.NativeClassPtr, 100676011);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 215328, RefRangeEnd = 215330, XrefRangeStart = 215320, XrefRangeEnd = 215328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClothingSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ClothingSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
