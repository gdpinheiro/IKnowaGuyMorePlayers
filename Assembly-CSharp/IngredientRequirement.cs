using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class IngredientRequirement : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ingredientType;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredQuantity;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IngredientType_Int32_0;

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

	public unsafe int requiredQuantity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredQuantity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredQuantity)) = num;
		}
	}

	static IngredientRequirement()
	{
		Il2CppClassPointerStore<IngredientRequirement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "IngredientRequirement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientRequirement>.NativeClassPtr);
		NativeFieldInfoPtr_ingredientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientRequirement>.NativeClassPtr, "ingredientType");
		NativeFieldInfoPtr_requiredQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientRequirement>.NativeClassPtr, "requiredQuantity");
		NativeMethodInfoPtr__ctor_Public_Void_IngredientType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientRequirement>.NativeClassPtr, 100671104);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129245, XrefRangeEnd = 129246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IngredientRequirement(IngredientType type, int quantity)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientRequirement>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &quantity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IngredientType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IngredientRequirement(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
