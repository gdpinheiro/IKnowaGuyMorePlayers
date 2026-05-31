using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class RedlineCallerData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_callerName;

	private static readonly System.IntPtr NativeFieldInfoPtr_introDialogue;

	private static readonly System.IntPtr NativeFieldInfoPtr_orderDialogue;

	private static readonly System.IntPtr NativeFieldInfoPtr_declineDialogue;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string callerName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callerName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callerName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string introDialogue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_introDialogue);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_introDialogue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string orderDialogue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderDialogue);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderDialogue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string declineDialogue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_declineDialogue);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_declineDialogue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static RedlineCallerData()
	{
		Il2CppClassPointerStore<RedlineCallerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RedlineCallerData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RedlineCallerData>.NativeClassPtr);
		NativeFieldInfoPtr_callerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedlineCallerData>.NativeClassPtr, "callerName");
		NativeFieldInfoPtr_introDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedlineCallerData>.NativeClassPtr, "introDialogue");
		NativeFieldInfoPtr_orderDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedlineCallerData>.NativeClassPtr, "orderDialogue");
		NativeFieldInfoPtr_declineDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedlineCallerData>.NativeClassPtr, "declineDialogue");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedlineCallerData>.NativeClassPtr, 100671340);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RedlineCallerData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RedlineCallerData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RedlineCallerData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
