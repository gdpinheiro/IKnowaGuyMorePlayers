using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class BurnableSO : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_itemId;

	private static readonly IntPtr NativeFieldInfoPtr_nameKey;

	private static readonly IntPtr NativeFieldInfoPtr_rewardAmount;

	private static readonly IntPtr NativeFieldInfoPtr_requiredMachineLevel;

	private static readonly IntPtr NativeFieldInfoPtr_prefab;

	private static readonly IntPtr NativeMethodInfoPtr_get_ItemId_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_NameKey_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RewardAmount_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RequiredMachineLevel_Public_get_MachineLevel_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Prefab_Public_get_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedName_Public_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Boolean_byref_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string itemId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemId);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string nameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float rewardAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardAmount)) = num;
		}
	}

	public unsafe Incinerator.MachineLevel requiredMachineLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredMachineLevel);
			return *(Incinerator.MachineLevel*)num;
		}
		set
		{
			*(Incinerator.MachineLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredMachineLevel)) = machineLevel;
		}
	}

	public unsafe GameObject prefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe string ItemId
	{
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 24312, RefRangeEnd = 24460, XrefRangeStart = 24312, XrefRangeEnd = 24460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ItemId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string NameKey
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 43540, RefRangeEnd = 43551, XrefRangeStart = 43540, XrefRangeEnd = 43551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NameKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe float RewardAmount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131876, RefRangeEnd = 131877, XrefRangeStart = 131876, XrefRangeEnd = 131876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RewardAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Incinerator.MachineLevel RequiredMachineLevel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RequiredMachineLevel_Public_get_MachineLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Incinerator.MachineLevel*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe GameObject Prefab
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 43149, RefRangeEnd = 43165, XrefRangeStart = 43149, XrefRangeEnd = 43165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Prefab_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
	}

	static BurnableSO()
	{
		Il2CppClassPointerStore<BurnableSO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BurnableSO");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr);
		NativeFieldInfoPtr_itemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, "itemId");
		NativeFieldInfoPtr_nameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, "nameKey");
		NativeFieldInfoPtr_rewardAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, "rewardAmount");
		NativeFieldInfoPtr_requiredMachineLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, "requiredMachineLevel");
		NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, "prefab");
		NativeMethodInfoPtr_get_ItemId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, 100671313);
		NativeMethodInfoPtr_get_NameKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, 100671314);
		NativeMethodInfoPtr_get_RewardAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, 100671315);
		NativeMethodInfoPtr_get_RequiredMachineLevel_Public_get_MachineLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, 100671316);
		NativeMethodInfoPtr_get_Prefab_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, 100671317);
		NativeMethodInfoPtr_GetLocalizedName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, 100671318);
		NativeMethodInfoPtr_Validate_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, 100671319);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr, 100671320);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131877, XrefRangeEnd = 131890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLocalizedName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131907, RefRangeEnd = 131908, XrefRangeStart = 131890, XrefRangeEnd = 131907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Validate(out string error)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Validate_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		error = IL2CPP.Il2CppStringToManaged((IntPtr)num);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131908, XrefRangeEnd = 131909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BurnableSO()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurnableSO>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BurnableSO(IntPtr pointer)
		: base(pointer)
	{
	}
}
