using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class TonySliceDialogueData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_idleLines;

	private static readonly System.IntPtr NativeFieldInfoPtr_opening;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerOption1;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerOption2;

	private static readonly System.IntPtr NativeFieldInfoPtr_monologueLines;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalOption1;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalOption2;

	private static readonly System.IntPtr NativeFieldInfoPtr_endingDone;

	private static readonly System.IntPtr NativeFieldInfoPtr_endingStay;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStringArray idleLines
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleLines);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleLines)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe string opening
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opening);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opening)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string playerOption1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerOption1);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerOption1)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string playerOption2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerOption2);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerOption2)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppStringArray monologueLines
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monologueLines);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monologueLines)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe string finalOption1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalOption1);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalOption1)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string finalOption2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalOption2);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalOption2)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string endingDone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endingDone);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endingDone)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string endingStay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endingStay);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endingStay)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static TonySliceDialogueData()
	{
		Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TonySliceDialogueData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr);
		NativeFieldInfoPtr_idleLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr, "idleLines");
		NativeFieldInfoPtr_opening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr, "opening");
		NativeFieldInfoPtr_playerOption1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr, "playerOption1");
		NativeFieldInfoPtr_playerOption2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr, "playerOption2");
		NativeFieldInfoPtr_monologueLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr, "monologueLines");
		NativeFieldInfoPtr_finalOption1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr, "finalOption1");
		NativeFieldInfoPtr_finalOption2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr, "finalOption2");
		NativeFieldInfoPtr_endingDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr, "endingDone");
		NativeFieldInfoPtr_endingStay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr, "endingStay");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr, 100663460);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TonySliceDialogueData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TonySliceDialogueData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TonySliceDialogueData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
