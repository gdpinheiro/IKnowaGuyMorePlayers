using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class ShadyNPCDialogueDataCollection : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_shadyNpcs;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<ShadyNPCDialogueData> shadyNpcs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyNpcs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShadyNPCDialogueData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyNpcs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ShadyNPCDialogueDataCollection()
	{
		Il2CppClassPointerStore<ShadyNPCDialogueDataCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShadyNPCDialogueDataCollection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadyNPCDialogueDataCollection>.NativeClassPtr);
		NativeFieldInfoPtr_shadyNpcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueDataCollection>.NativeClassPtr, "shadyNpcs");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueDataCollection>.NativeClassPtr, 100663459);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23261, XrefRangeEnd = 23269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadyNPCDialogueDataCollection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadyNPCDialogueDataCollection>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShadyNPCDialogueDataCollection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
