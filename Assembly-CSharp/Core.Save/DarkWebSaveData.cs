using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Core.Save;

[System.Serializable]
public class DarkWebSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_scamPurchaseMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_purchasedMachineMask;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int scamPurchaseMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scamPurchaseMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scamPurchaseMask)) = num;
		}
	}

	public unsafe int purchasedMachineMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purchasedMachineMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purchasedMachineMask)) = num;
		}
	}

	static DarkWebSaveData()
	{
		Il2CppClassPointerStore<DarkWebSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "DarkWebSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkWebSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_scamPurchaseMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebSaveData>.NativeClassPtr, "scamPurchaseMask");
		NativeFieldInfoPtr_purchasedMachineMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebSaveData>.NativeClassPtr, "purchasedMachineMask");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebSaveData>.NativeClassPtr, 100676028);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DarkWebSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkWebSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DarkWebSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
