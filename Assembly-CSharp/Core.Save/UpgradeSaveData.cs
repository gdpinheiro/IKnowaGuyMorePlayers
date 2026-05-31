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
public class UpgradeSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_schemaVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_purchasedUpgrades;

	private static readonly System.IntPtr NativeFieldInfoPtr_upperWallOwned;

	private static readonly System.IntPtr NativeFieldInfoPtr_upperWallActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowerWallOwned;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowerWallActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_floorOwned;

	private static readonly System.IntPtr NativeFieldInfoPtr_floorActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_outsideWallOwned;

	private static readonly System.IntPtr NativeFieldInfoPtr_outsideWallActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_awningColorOwned;

	private static readonly System.IntPtr NativeFieldInfoPtr_awningColorActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_signTypeOwned;

	private static readonly System.IntPtr NativeFieldInfoPtr_signTypeActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_frontXP;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyXP;

	private static readonly System.IntPtr NativeFieldInfoPtr_bitcoinMinerL1Purchased;

	private static readonly System.IntPtr NativeFieldInfoPtr_bitcoinMinerL2Purchased;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int schemaVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schemaVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schemaVersion)) = num;
		}
	}

	public unsafe List<string> purchasedUpgrades
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purchasedUpgrades);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purchasedUpgrades)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int upperWallOwned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upperWallOwned);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upperWallOwned)) = num;
		}
	}

	public unsafe int upperWallActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upperWallActive);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upperWallActive)) = num;
		}
	}

	public unsafe int lowerWallOwned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowerWallOwned);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowerWallOwned)) = num;
		}
	}

	public unsafe int lowerWallActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowerWallActive);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowerWallActive)) = num;
		}
	}

	public unsafe int floorOwned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorOwned);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorOwned)) = num;
		}
	}

	public unsafe int floorActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorActive);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorActive)) = num;
		}
	}

	public unsafe int outsideWallOwned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideWallOwned);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideWallOwned)) = num;
		}
	}

	public unsafe int outsideWallActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideWallActive);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideWallActive)) = num;
		}
	}

	public unsafe int awningColorOwned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awningColorOwned);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awningColorOwned)) = num;
		}
	}

	public unsafe int awningColorActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awningColorActive);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awningColorActive)) = num;
		}
	}

	public unsafe int signTypeOwned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signTypeOwned);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signTypeOwned)) = num;
		}
	}

	public unsafe int signTypeActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signTypeActive);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signTypeActive)) = num;
		}
	}

	public unsafe float frontXP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontXP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontXP)) = num;
		}
	}

	public unsafe float shadyXP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyXP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyXP)) = num;
		}
	}

	public unsafe int bitcoinMinerL1Purchased
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bitcoinMinerL1Purchased);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bitcoinMinerL1Purchased)) = num;
		}
	}

	public unsafe int bitcoinMinerL2Purchased
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bitcoinMinerL2Purchased);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bitcoinMinerL2Purchased)) = num;
		}
	}

	static UpgradeSaveData()
	{
		Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "UpgradeSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_schemaVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "schemaVersion");
		NativeFieldInfoPtr_purchasedUpgrades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "purchasedUpgrades");
		NativeFieldInfoPtr_upperWallOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "upperWallOwned");
		NativeFieldInfoPtr_upperWallActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "upperWallActive");
		NativeFieldInfoPtr_lowerWallOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "lowerWallOwned");
		NativeFieldInfoPtr_lowerWallActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "lowerWallActive");
		NativeFieldInfoPtr_floorOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "floorOwned");
		NativeFieldInfoPtr_floorActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "floorActive");
		NativeFieldInfoPtr_outsideWallOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "outsideWallOwned");
		NativeFieldInfoPtr_outsideWallActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "outsideWallActive");
		NativeFieldInfoPtr_awningColorOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "awningColorOwned");
		NativeFieldInfoPtr_awningColorActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "awningColorActive");
		NativeFieldInfoPtr_signTypeOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "signTypeOwned");
		NativeFieldInfoPtr_signTypeActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "signTypeActive");
		NativeFieldInfoPtr_frontXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "frontXP");
		NativeFieldInfoPtr_shadyXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "shadyXP");
		NativeFieldInfoPtr_bitcoinMinerL1Purchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "bitcoinMinerL1Purchased");
		NativeFieldInfoPtr_bitcoinMinerL2Purchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, "bitcoinMinerL2Purchased");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr, 100675989);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215248, RefRangeEnd = 215249, XrefRangeStart = 215240, XrefRangeEnd = 215248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UpgradeSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UpgradeSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
