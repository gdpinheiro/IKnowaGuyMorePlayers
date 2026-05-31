using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class IngredientSO : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_ingredientNameKey;

	private static readonly IntPtr NativeFieldInfoPtr_ingredientDescriptionKey;

	private static readonly IntPtr NativeFieldInfoPtr_ingredientType;

	private static readonly IntPtr NativeFieldInfoPtr_ingredientMesh;

	private static readonly IntPtr NativeFieldInfoPtr_ingredientMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_ingredientIcon;

	private static readonly IntPtr NativeFieldInfoPtr_ingredientPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_color;

	private static readonly IntPtr NativeFieldInfoPtr_price;

	private static readonly IntPtr NativeFieldInfoPtr_isShadyIngredient;

	private static readonly IntPtr NativeFieldInfoPtr_refillAmount;

	private static readonly IntPtr NativeFieldInfoPtr_useCustomStackSize;

	private static readonly IntPtr NativeFieldInfoPtr_customMaxStackSize;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string ingredientNameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientNameKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientNameKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ingredientDescriptionKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientDescriptionKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientDescriptionKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe IngredientType ingredientType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientType);
			return *(IngredientType*)num;
		}
		set
		{
			*(IngredientType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientType)) = ingredientType;
		}
	}

	public unsafe Mesh ingredientMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientMesh);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe Material ingredientMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Sprite ingredientIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe GameObject ingredientPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Color color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = color;
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

	public unsafe bool isShadyIngredient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShadyIngredient);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShadyIngredient)) = flag;
		}
	}

	public unsafe int refillAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refillAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refillAmount)) = num;
		}
	}

	public unsafe bool useCustomStackSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomStackSize);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomStackSize)) = flag;
		}
	}

	public unsafe int customMaxStackSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customMaxStackSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customMaxStackSize)) = num;
		}
	}

	static IngredientSO()
	{
		Il2CppClassPointerStore<IngredientSO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "IngredientSO");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr);
		NativeFieldInfoPtr_ingredientNameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "ingredientNameKey");
		NativeFieldInfoPtr_ingredientDescriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "ingredientDescriptionKey");
		NativeFieldInfoPtr_ingredientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "ingredientType");
		NativeFieldInfoPtr_ingredientMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "ingredientMesh");
		NativeFieldInfoPtr_ingredientMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "ingredientMaterial");
		NativeFieldInfoPtr_ingredientIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "ingredientIcon");
		NativeFieldInfoPtr_ingredientPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "ingredientPrefab");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "color");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "price");
		NativeFieldInfoPtr_isShadyIngredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "isShadyIngredient");
		NativeFieldInfoPtr_refillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "refillAmount");
		NativeFieldInfoPtr_useCustomStackSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "useCustomStackSize");
		NativeFieldInfoPtr_customMaxStackSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, "customMaxStackSize");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr, 100670940);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125875, XrefRangeEnd = 125884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IngredientSO()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientSO>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IngredientSO(IntPtr pointer)
		: base(pointer)
	{
	}
}
