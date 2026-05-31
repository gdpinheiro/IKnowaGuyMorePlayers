using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Core.Save;

[System.Serializable]
public class StreetReputationSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_streetLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_streetRep;

	private static readonly System.IntPtr NativeFieldInfoPtr_streetTier;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int streetLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetLevel)) = num;
		}
	}

	public unsafe int streetRep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetRep);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetRep)) = num;
		}
	}

	public unsafe int streetTier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetTier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetTier)) = num;
		}
	}

	static StreetReputationSaveData()
	{
		Il2CppClassPointerStore<StreetReputationSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "StreetReputationSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetReputationSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_streetLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetReputationSaveData>.NativeClassPtr, "streetLevel");
		NativeFieldInfoPtr_streetRep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetReputationSaveData>.NativeClassPtr, "streetRep");
		NativeFieldInfoPtr_streetTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetReputationSaveData>.NativeClassPtr, "streetTier");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetReputationSaveData>.NativeClassPtr, 100675991);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StreetReputationSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetReputationSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StreetReputationSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
