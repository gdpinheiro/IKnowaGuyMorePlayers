using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class DialogEntry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dialogText;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayDuration;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string dialogText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float displayDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayDuration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayDuration)) = num;
		}
	}

	static DialogEntry()
	{
		Il2CppClassPointerStore<DialogEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DialogEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogEntry>.NativeClassPtr);
		NativeFieldInfoPtr_dialogText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogEntry>.NativeClassPtr, "dialogText");
		NativeFieldInfoPtr_displayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogEntry>.NativeClassPtr, "displayDuration");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogEntry>.NativeClassPtr, 100668847);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98001, XrefRangeEnd = 98006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DialogEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogEntry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DialogEntry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
