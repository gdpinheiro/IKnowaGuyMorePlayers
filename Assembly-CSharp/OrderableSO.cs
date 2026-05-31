using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class OrderableSO : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_orderableNameKey;

	private static readonly IntPtr NativeFieldInfoPtr_orderableDescriptionKey;

	private static readonly IntPtr NativeFieldInfoPtr_orderableType;

	private static readonly IntPtr NativeFieldInfoPtr_orderableIcon;

	private static readonly IntPtr NativeFieldInfoPtr_price;

	private static readonly IntPtr NativeFieldInfoPtr_isDirectSpawn;

	private static readonly IntPtr NativeFieldInfoPtr_spawnPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_refillAmount;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string orderableNameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableNameKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableNameKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string orderableDescriptionKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableDescriptionKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableDescriptionKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe OrderableType orderableType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableType);
			return *(OrderableType*)num;
		}
		set
		{
			*(OrderableType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableType)) = orderableType;
		}
	}

	public unsafe Sprite orderableIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderableIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
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

	public unsafe bool isDirectSpawn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDirectSpawn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDirectSpawn)) = flag;
		}
	}

	public unsafe GameObject spawnPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
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

	static OrderableSO()
	{
		Il2CppClassPointerStore<OrderableSO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OrderableSO");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderableSO>.NativeClassPtr);
		NativeFieldInfoPtr_orderableNameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderableSO>.NativeClassPtr, "orderableNameKey");
		NativeFieldInfoPtr_orderableDescriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderableSO>.NativeClassPtr, "orderableDescriptionKey");
		NativeFieldInfoPtr_orderableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderableSO>.NativeClassPtr, "orderableType");
		NativeFieldInfoPtr_orderableIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderableSO>.NativeClassPtr, "orderableIcon");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderableSO>.NativeClassPtr, "price");
		NativeFieldInfoPtr_isDirectSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderableSO>.NativeClassPtr, "isDirectSpawn");
		NativeFieldInfoPtr_spawnPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderableSO>.NativeClassPtr, "spawnPrefab");
		NativeFieldInfoPtr_refillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderableSO>.NativeClassPtr, "refillAmount");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderableSO>.NativeClassPtr, 100670943);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126303, XrefRangeEnd = 126304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OrderableSO()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderableSO>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OrderableSO(IntPtr pointer)
		: base(pointer)
	{
	}
}
