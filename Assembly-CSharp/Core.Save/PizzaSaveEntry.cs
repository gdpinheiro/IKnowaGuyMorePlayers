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
public class PizzaSaveEntry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_posX;

	private static readonly System.IntPtr NativeFieldInfoPtr_posY;

	private static readonly System.IntPtr NativeFieldInfoPtr_posZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotY;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotW;

	private static readonly System.IntPtr NativeFieldInfoPtr_doughState;

	private static readonly System.IntPtr NativeFieldInfoPtr_blendShapeTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_sauceVisible;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_toppings;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float posX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posX)) = num;
		}
	}

	public unsafe float posY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posY)) = num;
		}
	}

	public unsafe float posZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posZ)) = num;
		}
	}

	public unsafe float rotX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotX)) = num;
		}
	}

	public unsafe float rotY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotY)) = num;
		}
	}

	public unsafe float rotZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotZ)) = num;
		}
	}

	public unsafe float rotW
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotW);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotW)) = num;
		}
	}

	public unsafe int doughState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doughState);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doughState)) = num;
		}
	}

	public unsafe float blendShapeTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendShapeTarget);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendShapeTarget)) = num;
		}
	}

	public unsafe bool sauceVisible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sauceVisible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sauceVisible)) = flag;
		}
	}

	public unsafe int cookingQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingQuality);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingQuality)) = num;
		}
	}

	public unsafe List<PizzaIngredientEntry> toppings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toppings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PizzaIngredientEntry>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toppings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static PizzaSaveEntry()
	{
		Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "PizzaSaveEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr);
		NativeFieldInfoPtr_posX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "posX");
		NativeFieldInfoPtr_posY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "posY");
		NativeFieldInfoPtr_posZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "posZ");
		NativeFieldInfoPtr_rotX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "rotX");
		NativeFieldInfoPtr_rotY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "rotY");
		NativeFieldInfoPtr_rotZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "rotZ");
		NativeFieldInfoPtr_rotW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "rotW");
		NativeFieldInfoPtr_doughState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "doughState");
		NativeFieldInfoPtr_blendShapeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "blendShapeTarget");
		NativeFieldInfoPtr_sauceVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "sauceVisible");
		NativeFieldInfoPtr_cookingQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "cookingQuality");
		NativeFieldInfoPtr_toppings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, "toppings");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr, 100676021);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 215405, RefRangeEnd = 215410, XrefRangeStart = 215397, XrefRangeEnd = 215405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PizzaSaveEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PizzaSaveEntry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PizzaSaveEntry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
