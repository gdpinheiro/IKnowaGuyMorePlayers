using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Core.Save;

[System.Serializable]
public class CaseOhSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_currentQuestIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_permanentlyDeclined;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int currentQuestIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentQuestIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentQuestIndex)) = num;
		}
	}

	public unsafe bool permanentlyDeclined
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_permanentlyDeclined);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_permanentlyDeclined)) = flag;
		}
	}

	static CaseOhSaveData()
	{
		Il2CppClassPointerStore<CaseOhSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "CaseOhSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaseOhSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_currentQuestIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOhSaveData>.NativeClassPtr, "currentQuestIndex");
		NativeFieldInfoPtr_permanentlyDeclined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOhSaveData>.NativeClassPtr, "permanentlyDeclined");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseOhSaveData>.NativeClassPtr, 100676002);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CaseOhSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseOhSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CaseOhSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
