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
public class PhotographBoardSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_photos;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<StuckPhotoEntry> photos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_photos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StuckPhotoEntry>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_photos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static PhotographBoardSaveData()
	{
		Il2CppClassPointerStore<PhotographBoardSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "PhotographBoardSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotographBoardSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_photos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotographBoardSaveData>.NativeClassPtr, "photos");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotographBoardSaveData>.NativeClassPtr, 100676016);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215396, RefRangeEnd = 215397, XrefRangeStart = 215388, XrefRangeEnd = 215396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhotographBoardSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotographBoardSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PhotographBoardSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
