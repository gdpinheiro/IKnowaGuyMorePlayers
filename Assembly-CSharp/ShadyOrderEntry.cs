using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class ShadyOrderEntry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_taskType;

	private static readonly System.IntPtr NativeFieldInfoPtr_taskDescription;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ShadyTaskType taskType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskType);
			return *(ShadyTaskType*)num;
		}
		set
		{
			*(ShadyTaskType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskType)) = shadyTaskType;
		}
	}

	public unsafe string taskDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskDescription);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ShadyOrderEntry()
	{
		Il2CppClassPointerStore<ShadyOrderEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShadyOrderEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadyOrderEntry>.NativeClassPtr);
		NativeFieldInfoPtr_taskType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyOrderEntry>.NativeClassPtr, "taskType");
		NativeFieldInfoPtr_taskDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyOrderEntry>.NativeClassPtr, "taskDescription");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyOrderEntry>.NativeClassPtr, 100668581);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95839, XrefRangeEnd = 95844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadyOrderEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadyOrderEntry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShadyOrderEntry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
