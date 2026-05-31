using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Core.Save;

[System.Serializable]
public class NPCQuestProgress : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_npcNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentQuestIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_thankYouPending;

	private static readonly System.IntPtr NativeFieldInfoPtr_questAccepted;

	private static readonly System.IntPtr NativeFieldInfoPtr_deliveredCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_questType;

	private static readonly System.IntPtr NativeFieldInfoPtr_deliveredPizzaMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_deliveredPhotoMask;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int npcNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcNumber)) = num;
		}
	}

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

	public unsafe bool thankYouPending
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thankYouPending);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thankYouPending)) = flag;
		}
	}

	public unsafe bool questAccepted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questAccepted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questAccepted)) = flag;
		}
	}

	public unsafe int deliveredCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveredCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveredCount)) = num;
		}
	}

	public unsafe int requiredCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredCount)) = num;
		}
	}

	public unsafe int questType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questType)) = num;
		}
	}

	public unsafe int deliveredPizzaMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveredPizzaMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveredPizzaMask)) = num;
		}
	}

	public unsafe int deliveredPhotoMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveredPhotoMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveredPhotoMask)) = num;
		}
	}

	static NPCQuestProgress()
	{
		Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "NPCQuestProgress");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr);
		NativeFieldInfoPtr_npcNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr, "npcNumber");
		NativeFieldInfoPtr_currentQuestIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr, "currentQuestIndex");
		NativeFieldInfoPtr_thankYouPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr, "thankYouPending");
		NativeFieldInfoPtr_questAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr, "questAccepted");
		NativeFieldInfoPtr_deliveredCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr, "deliveredCount");
		NativeFieldInfoPtr_requiredCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr, "requiredCount");
		NativeFieldInfoPtr_questType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr, "questType");
		NativeFieldInfoPtr_deliveredPizzaMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr, "deliveredPizzaMask");
		NativeFieldInfoPtr_deliveredPhotoMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr, "deliveredPhotoMask");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr, 100676008);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NPCQuestProgress()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCQuestProgress>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NPCQuestProgress(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
