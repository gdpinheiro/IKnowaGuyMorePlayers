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
public class WholePizzaData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pizzaType;

	private static readonly System.IntPtr NativeFieldInfoPtr_ingredients;

	private static readonly System.IntPtr NativeFieldInfoPtr_score;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_pizzaObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasShadyIngredient;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyIngredientType;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PizzaType_List_1_IngredientType_Single_CookingQuality_GameObject_Boolean_IngredientType_0;

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

	public unsafe List<IngredientType> ingredients
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredients);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IngredientType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredients)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float score
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_score);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_score)) = num;
		}
	}

	public unsafe CookingQuality cookingQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingQuality);
			return *(CookingQuality*)num;
		}
		set
		{
			*(CookingQuality*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingQuality)) = cookingQuality;
		}
	}

	public unsafe GameObject pizzaObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool hasShadyIngredient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasShadyIngredient);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasShadyIngredient)) = flag;
		}
	}

	public unsafe IngredientType shadyIngredientType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyIngredientType);
			return *(IngredientType*)num;
		}
		set
		{
			*(IngredientType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyIngredientType)) = ingredientType;
		}
	}

	static WholePizzaData()
	{
		Il2CppClassPointerStore<WholePizzaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WholePizzaData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WholePizzaData>.NativeClassPtr);
		NativeFieldInfoPtr_pizzaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WholePizzaData>.NativeClassPtr, "pizzaType");
		NativeFieldInfoPtr_ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WholePizzaData>.NativeClassPtr, "ingredients");
		NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WholePizzaData>.NativeClassPtr, "score");
		NativeFieldInfoPtr_cookingQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WholePizzaData>.NativeClassPtr, "cookingQuality");
		NativeFieldInfoPtr_pizzaObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WholePizzaData>.NativeClassPtr, "pizzaObject");
		NativeFieldInfoPtr_hasShadyIngredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WholePizzaData>.NativeClassPtr, "hasShadyIngredient");
		NativeFieldInfoPtr_shadyIngredientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WholePizzaData>.NativeClassPtr, "shadyIngredientType");
		NativeMethodInfoPtr__ctor_Public_Void_PizzaType_List_1_IngredientType_Single_CookingQuality_GameObject_Boolean_IngredientType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WholePizzaData>.NativeClassPtr, 100670428);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118764, XrefRangeEnd = 118773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WholePizzaData(PizzaType type, List<IngredientType> ing, float score, CookingQuality quality, GameObject obj, bool hasShadyIngredient = false, IngredientType shadyIngredientType = IngredientType.Mozzarella)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WholePizzaData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ing);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &score;
		*(CookingQuality**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasShadyIngredient;
		*(IngredientType**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadyIngredientType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_PizzaType_List_1_IngredientType_Single_CookingQuality_GameObject_Boolean_IngredientType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WholePizzaData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
