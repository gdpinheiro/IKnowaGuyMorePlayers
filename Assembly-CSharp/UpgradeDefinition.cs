using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UpgradeDefinition : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayNameKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_descriptionKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_price;

	private static readonly System.IntPtr NativeFieldInfoPtr_icon;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlockedPizzaType;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlocksIngredient;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlockedIngredientType;

	private static readonly System.IntPtr NativeFieldInfoPtr_prerequisites;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCrypto;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_legacyAutoUnlockLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_showInTree;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoUnlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_treeCategoryId;

	private static readonly System.IntPtr NativeFieldInfoPtr_treeColumn;

	private static readonly System.IntPtr NativeFieldInfoPtr_treeRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkedMachineSO;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string upgradeId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string displayNameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayNameKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayNameKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string descriptionKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptionKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptionKey)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe Sprite icon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe PizzaType unlockedPizzaType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedPizzaType);
			return *(PizzaType*)num;
		}
		set
		{
			*(PizzaType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedPizzaType)) = pizzaType;
		}
	}

	public unsafe bool unlocksIngredient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlocksIngredient);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlocksIngredient)) = flag;
		}
	}

	public unsafe IngredientType unlockedIngredientType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedIngredientType);
			return *(IngredientType*)num;
		}
		set
		{
			*(IngredientType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedIngredientType)) = ingredientType;
		}
	}

	public unsafe List<string> prerequisites
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prerequisites);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prerequisites)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool useCrypto
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCrypto);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCrypto)) = flag;
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

	public unsafe int legacyAutoUnlockLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_legacyAutoUnlockLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_legacyAutoUnlockLevel)) = num;
		}
	}

	public unsafe bool showInTree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showInTree);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showInTree)) = flag;
		}
	}

	public unsafe bool isAutoUnlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAutoUnlock);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAutoUnlock)) = flag;
		}
	}

	public unsafe string treeCategoryId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeCategoryId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeCategoryId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int treeColumn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeColumn);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeColumn)) = num;
		}
	}

	public unsafe int treeRow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeRow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeRow)) = num;
		}
	}

	public unsafe MachineSO linkedMachineSO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkedMachineSO);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MachineSO>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkedMachineSO)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)machineSO));
		}
	}

	static UpgradeDefinition()
	{
		Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UpgradeDefinition");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr);
		NativeFieldInfoPtr_upgradeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "upgradeId");
		NativeFieldInfoPtr_displayNameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "displayNameKey");
		NativeFieldInfoPtr_descriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "descriptionKey");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "price");
		NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "icon");
		NativeFieldInfoPtr_unlockedPizzaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "unlockedPizzaType");
		NativeFieldInfoPtr_unlocksIngredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "unlocksIngredient");
		NativeFieldInfoPtr_unlockedIngredientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "unlockedIngredientType");
		NativeFieldInfoPtr_prerequisites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "prerequisites");
		NativeFieldInfoPtr_useCrypto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "useCrypto");
		NativeFieldInfoPtr_requiredLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "requiredLevel");
		NativeFieldInfoPtr_legacyAutoUnlockLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "legacyAutoUnlockLevel");
		NativeFieldInfoPtr_showInTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "showInTree");
		NativeFieldInfoPtr_isAutoUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "isAutoUnlock");
		NativeFieldInfoPtr_treeCategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "treeCategoryId");
		NativeFieldInfoPtr_treeColumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "treeColumn");
		NativeFieldInfoPtr_treeRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "treeRow");
		NativeFieldInfoPtr_linkedMachineSO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, "linkedMachineSO");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr, 100664192);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36466, XrefRangeEnd = 36492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UpgradeDefinition()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeDefinition>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UpgradeDefinition(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
