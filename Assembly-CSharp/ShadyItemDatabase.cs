using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class ShadyItemDatabase : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_burnableItems;

	private static readonly IntPtr NativeFieldInfoPtr_washableItems;

	private static readonly IntPtr NativeFieldInfoPtr_contrabandItems;

	private static readonly IntPtr NativeFieldInfoPtr_shadyPizzaIngredients;

	private static readonly IntPtr NativeFieldInfoPtr_darkWebMachines;

	private static readonly IntPtr NativeMethodInfoPtr_GetBurnableById_Public_BurnableSO_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBurnableItemPrefab_Public_GameObject_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllBurnables_Public_List_1_BurnableSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllBurnableItemIds_Public_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBurnableCount_Public_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetWashableById_Public_WashableSO_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetWashableItemPrefab_Public_GameObject_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllWashables_Public_List_1_WashableSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllWashableItemIds_Public_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetWashableCount_Public_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetContrabandById_Public_ContrabandSO_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllContraband_Public_List_1_ContrabandSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMarketContraband_Public_List_1_ContrabandSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetContrabandCount_Public_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetContrabandByIndex_Public_ContrabandSO_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetContrabandIndex_Public_Int32_ContrabandSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllShadyIngredients_Public_List_1_IngredientSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetShadyIngredientByType_Public_IngredientSO_IngredientType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetShadyIngredientByIndex_Public_IngredientSO_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetShadyIngredientIndex_Public_Int32_IngredientSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetShadyIngredientCount_Public_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRewardForItem_Public_Single_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemPrefab_Public_GameObject_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllItemIds_Public_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTotalItemCount_Public_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDarkWebMachines_Public_List_1_DarkWebMachineEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDarkWebMachineByType_Public_DarkWebMachineEntry_MachineType_0;

	private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Boolean_byref_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ValidateBurnableList_Private_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ValidateWashableList_Private_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ValidateContrabandList_Private_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<BurnableSO> burnableItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_burnableItems);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<BurnableSO>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_burnableItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<WashableSO> washableItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washableItems);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<WashableSO>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washableItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ContrabandSO> contrabandItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contrabandItems);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ContrabandSO>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contrabandItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<IngredientSO> shadyPizzaIngredients
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyPizzaIngredients);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<IngredientSO>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyPizzaIngredients)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DarkWebMachineEntry> darkWebMachines
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_darkWebMachines);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DarkWebMachineEntry>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_darkWebMachines)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ShadyItemDatabase()
	{
		Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShadyItemDatabase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr);
		NativeFieldInfoPtr_burnableItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, "burnableItems");
		NativeFieldInfoPtr_washableItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, "washableItems");
		NativeFieldInfoPtr_contrabandItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, "contrabandItems");
		NativeFieldInfoPtr_shadyPizzaIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, "shadyPizzaIngredients");
		NativeFieldInfoPtr_darkWebMachines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, "darkWebMachines");
		NativeMethodInfoPtr_GetBurnableById_Public_BurnableSO_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671342);
		NativeMethodInfoPtr_GetBurnableItemPrefab_Public_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671343);
		NativeMethodInfoPtr_GetAllBurnables_Public_List_1_BurnableSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671344);
		NativeMethodInfoPtr_GetAllBurnableItemIds_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671345);
		NativeMethodInfoPtr_GetBurnableCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671346);
		NativeMethodInfoPtr_GetWashableById_Public_WashableSO_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671347);
		NativeMethodInfoPtr_GetWashableItemPrefab_Public_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671348);
		NativeMethodInfoPtr_GetAllWashables_Public_List_1_WashableSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671349);
		NativeMethodInfoPtr_GetAllWashableItemIds_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671350);
		NativeMethodInfoPtr_GetWashableCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671351);
		NativeMethodInfoPtr_GetContrabandById_Public_ContrabandSO_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671352);
		NativeMethodInfoPtr_GetAllContraband_Public_List_1_ContrabandSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671353);
		NativeMethodInfoPtr_GetMarketContraband_Public_List_1_ContrabandSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671354);
		NativeMethodInfoPtr_GetContrabandCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671355);
		NativeMethodInfoPtr_GetContrabandByIndex_Public_ContrabandSO_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671356);
		NativeMethodInfoPtr_GetContrabandIndex_Public_Int32_ContrabandSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671357);
		NativeMethodInfoPtr_GetAllShadyIngredients_Public_List_1_IngredientSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671358);
		NativeMethodInfoPtr_GetShadyIngredientByType_Public_IngredientSO_IngredientType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671359);
		NativeMethodInfoPtr_GetShadyIngredientByIndex_Public_IngredientSO_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671360);
		NativeMethodInfoPtr_GetShadyIngredientIndex_Public_Int32_IngredientSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671361);
		NativeMethodInfoPtr_GetShadyIngredientCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671362);
		NativeMethodInfoPtr_GetRewardForItem_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671363);
		NativeMethodInfoPtr_GetItemPrefab_Public_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671364);
		NativeMethodInfoPtr_GetAllItemIds_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671365);
		NativeMethodInfoPtr_GetTotalItemCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671366);
		NativeMethodInfoPtr_GetDarkWebMachines_Public_List_1_DarkWebMachineEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671367);
		NativeMethodInfoPtr_GetDarkWebMachineByType_Public_DarkWebMachineEntry_MachineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671368);
		NativeMethodInfoPtr_Validate_Public_Boolean_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671369);
		NativeMethodInfoPtr_ValidateBurnableList_Private_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671370);
		NativeMethodInfoPtr_ValidateWashableList_Private_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671371);
		NativeMethodInfoPtr_ValidateContrabandList_Private_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671372);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr, 100671373);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 131986, RefRangeEnd = 131989, XrefRangeStart = 131954, XrefRangeEnd = 131986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BurnableSO GetBurnableById(string itemId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBurnableById_Public_BurnableSO_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BurnableSO>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131989, XrefRangeEnd = 131990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetBurnableItemPrefab(string itemId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBurnableItemPrefab_Public_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131990, XrefRangeEnd = 132017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BurnableSO> GetAllBurnables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllBurnables_Public_List_1_BurnableSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<BurnableSO>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132045, RefRangeEnd = 132046, XrefRangeStart = 132017, XrefRangeEnd = 132045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> GetAllBurnableItemIds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllBurnableItemIds_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132064, RefRangeEnd = 132065, XrefRangeStart = 132046, XrefRangeEnd = 132064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBurnableCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBurnableCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 132097, RefRangeEnd = 132100, XrefRangeStart = 132065, XrefRangeEnd = 132097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WashableSO GetWashableById(string itemId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWashableById_Public_WashableSO_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<WashableSO>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132100, XrefRangeEnd = 132101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetWashableItemPrefab(string itemId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWashableItemPrefab_Public_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132101, XrefRangeEnd = 132128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<WashableSO> GetAllWashables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllWashables_Public_List_1_WashableSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<WashableSO>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132156, RefRangeEnd = 132157, XrefRangeStart = 132128, XrefRangeEnd = 132156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> GetAllWashableItemIds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllWashableItemIds_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132175, RefRangeEnd = 132176, XrefRangeStart = 132157, XrefRangeEnd = 132175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetWashableCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWashableCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 132210, RefRangeEnd = 132217, XrefRangeStart = 132176, XrefRangeEnd = 132210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ContrabandSO GetContrabandById(string contrabandId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contrabandId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContrabandById_Public_ContrabandSO_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ContrabandSO>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132217, XrefRangeEnd = 132244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ContrabandSO> GetAllContraband()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllContraband_Public_List_1_ContrabandSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ContrabandSO>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132271, RefRangeEnd = 132272, XrefRangeStart = 132244, XrefRangeEnd = 132271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ContrabandSO> GetMarketContraband()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarketContraband_Public_List_1_ContrabandSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ContrabandSO>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132290, RefRangeEnd = 132291, XrefRangeStart = 132272, XrefRangeEnd = 132290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetContrabandCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContrabandCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132295, RefRangeEnd = 132296, XrefRangeStart = 132291, XrefRangeEnd = 132295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ContrabandSO GetContrabandByIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContrabandByIndex_Public_ContrabandSO_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ContrabandSO>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132303, RefRangeEnd = 132304, XrefRangeStart = 132296, XrefRangeEnd = 132303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetContrabandIndex(ContrabandSO contraband)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contraband);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContrabandIndex_Public_Int32_ContrabandSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132304, XrefRangeEnd = 132331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<IngredientSO> GetAllShadyIngredients()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllShadyIngredients_Public_List_1_IngredientSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<IngredientSO>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132345, RefRangeEnd = 132346, XrefRangeStart = 132331, XrefRangeEnd = 132345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IngredientSO GetShadyIngredientByType(IngredientType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadyIngredientByType_Public_IngredientSO_IngredientType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IngredientSO>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132346, XrefRangeEnd = 132350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IngredientSO GetShadyIngredientByIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadyIngredientByIndex_Public_IngredientSO_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IngredientSO>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132357, RefRangeEnd = 132358, XrefRangeStart = 132350, XrefRangeEnd = 132357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetShadyIngredientIndex(IngredientSO ingredient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ingredient);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadyIngredientIndex_Public_Int32_IngredientSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132358, XrefRangeEnd = 132376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetShadyIngredientCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadyIngredientCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 132390, RefRangeEnd = 132392, XrefRangeStart = 132376, XrefRangeEnd = 132390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetRewardForItem(string itemId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRewardForItem_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132405, RefRangeEnd = 132406, XrefRangeStart = 132392, XrefRangeEnd = 132405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetItemPrefab(string itemId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemPrefab_Public_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132406, XrefRangeEnd = 132441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> GetAllItemIds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllItemIds_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132444, RefRangeEnd = 132445, XrefRangeStart = 132441, XrefRangeEnd = 132444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTotalItemCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalItemCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132472, RefRangeEnd = 132473, XrefRangeStart = 132445, XrefRangeEnd = 132472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<DarkWebMachineEntry> GetDarkWebMachines()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDarkWebMachines_Public_List_1_DarkWebMachineEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DarkWebMachineEntry>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132487, RefRangeEnd = 132488, XrefRangeStart = 132473, XrefRangeEnd = 132487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DarkWebMachineEntry GetDarkWebMachineByType(MachineType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDarkWebMachineByType_Public_DarkWebMachineEntry_MachineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DarkWebMachineEntry>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132488, XrefRangeEnd = 132499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Validate(out List<string> errors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Validate_Public_Boolean_byref_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num2 = num;
		errors = ((num2 == 0) ? null : new List<string>(num2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132541, RefRangeEnd = 132542, XrefRangeStart = 132499, XrefRangeEnd = 132541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateBurnableList(List<string> errors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errors);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateBurnableList_Private_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132584, RefRangeEnd = 132585, XrefRangeStart = 132542, XrefRangeEnd = 132584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateWashableList(List<string> errors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errors);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateWashableList_Private_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132627, RefRangeEnd = 132628, XrefRangeStart = 132585, XrefRangeEnd = 132627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateContrabandList(List<string> errors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errors);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateContrabandList_Private_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132628, XrefRangeEnd = 132664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadyItemDatabase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadyItemDatabase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShadyItemDatabase(IntPtr pointer)
		: base(pointer)
	{
	}
}
