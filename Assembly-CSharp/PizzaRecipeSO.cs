using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class PizzaRecipeSO : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_recipeNameKey;

	private static readonly IntPtr NativeFieldInfoPtr_descriptionKey;

	private static readonly IntPtr NativeFieldInfoPtr_pizzaType;

	private static readonly IntPtr NativeFieldInfoPtr_requiredTier;

	private static readonly IntPtr NativeFieldInfoPtr_requiredLevel;

	private static readonly IntPtr NativeFieldInfoPtr_ingredientQuantities;

	private static readonly IntPtr NativeFieldInfoPtr_idealCookingTime;

	private static readonly IntPtr NativeFieldInfoPtr_cookingTolerance;

	private static readonly IntPtr NativeFieldInfoPtr_sellPrice;

	private static readonly IntPtr NativeFieldInfoPtr_baseScore;

	private static readonly IntPtr NativeMethodInfoPtr_IsUnlocked_Public_Boolean_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ValidateIngredients_Public_Boolean_List_1_IngredientType_0;

	private static readonly IntPtr NativeMethodInfoPtr_EvaluateIngredientQuality_Public_IngredientQuality_Dictionary_2_IngredientType_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetIngredientQualityMultiplier_Public_Single_IngredientQuality_0;

	private static readonly IntPtr NativeMethodInfoPtr_EvaluateCookingTime_Public_CookingQuality_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCookingQualityMultiplier_Public_Single_CookingQuality_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string recipeNameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recipeNameKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recipeNameKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string descriptionKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptionKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptionKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe PizzaType pizzaType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaType);
			return *(PizzaType*)num;
		}
		set
		{
			*(PizzaType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaType)) = pizzaType;
		}
	}

	public unsafe int requiredTier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredTier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredTier)) = num;
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

	public unsafe List<IngredientRequirement> ingredientQuantities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientQuantities);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<IngredientRequirement>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientQuantities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float idealCookingTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idealCookingTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idealCookingTime)) = num;
		}
	}

	public unsafe float cookingTolerance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingTolerance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingTolerance)) = num;
		}
	}

	public unsafe float sellPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellPrice);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellPrice)) = num;
		}
	}

	public unsafe int baseScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseScore);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseScore)) = num;
		}
	}

	static PizzaRecipeSO()
	{
		Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PizzaRecipeSO");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr);
		NativeFieldInfoPtr_recipeNameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, "recipeNameKey");
		NativeFieldInfoPtr_descriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, "descriptionKey");
		NativeFieldInfoPtr_pizzaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, "pizzaType");
		NativeFieldInfoPtr_requiredTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, "requiredTier");
		NativeFieldInfoPtr_requiredLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, "requiredLevel");
		NativeFieldInfoPtr_ingredientQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, "ingredientQuantities");
		NativeFieldInfoPtr_idealCookingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, "idealCookingTime");
		NativeFieldInfoPtr_cookingTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, "cookingTolerance");
		NativeFieldInfoPtr_sellPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, "sellPrice");
		NativeFieldInfoPtr_baseScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, "baseScore");
		NativeMethodInfoPtr_IsUnlocked_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, 100671097);
		NativeMethodInfoPtr_ValidateIngredients_Public_Boolean_List_1_IngredientType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, 100671098);
		NativeMethodInfoPtr_EvaluateIngredientQuality_Public_IngredientQuality_Dictionary_2_IngredientType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, 100671099);
		NativeMethodInfoPtr_GetIngredientQualityMultiplier_Public_Single_IngredientQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, 100671100);
		NativeMethodInfoPtr_EvaluateCookingTime_Public_CookingQuality_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, 100671101);
		NativeMethodInfoPtr_GetCookingQualityMultiplier_Public_Single_CookingQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, 100671102);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr, 100671103);
	}

	[CallerCount(0)]
	public unsafe bool IsUnlocked(int currentTier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&currentTier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUnlocked_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129200, RefRangeEnd = 129201, XrefRangeStart = 129178, XrefRangeEnd = 129200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidateIngredients(List<IngredientType> pizzaIngredients)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pizzaIngredients);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateIngredients_Public_Boolean_List_1_IngredientType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 129223, RefRangeEnd = 129226, XrefRangeStart = 129201, XrefRangeEnd = 129223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IngredientQuality EvaluateIngredientQuality(Dictionary<IngredientType, int> ingredientCounts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ingredientCounts);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateIngredientQuality_Public_IngredientQuality_Dictionary_2_IngredientType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(IngredientQuality*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129226, RefRangeEnd = 129227, XrefRangeStart = 129226, XrefRangeEnd = 129226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetIngredientQualityMultiplier(IngredientQuality quality)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIngredientQualityMultiplier_Public_Single_IngredientQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129227, RefRangeEnd = 129228, XrefRangeStart = 129227, XrefRangeEnd = 129227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CookingQuality EvaluateCookingTime(float actualCookingTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actualCookingTime);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateCookingTime_Public_CookingQuality_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(CookingQuality*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129228, RefRangeEnd = 129229, XrefRangeStart = 129228, XrefRangeEnd = 129228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetCookingQualityMultiplier(CookingQuality quality)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCookingQualityMultiplier_Public_Single_CookingQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129229, XrefRangeEnd = 129245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PizzaRecipeSO()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PizzaRecipeSO>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PizzaRecipeSO(IntPtr pointer)
		: base(pointer)
	{
	}
}
