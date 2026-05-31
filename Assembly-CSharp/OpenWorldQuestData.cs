using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class OpenWorldQuestData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_missionLevelReq;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcName;

	private static readonly System.IntPtr NativeFieldInfoPtr_openingLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_dialogueOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_thankYouResponse;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleDialogue;

	private static readonly System.IntPtr NativeFieldInfoPtr_questType;

	private static readonly System.IntPtr NativeFieldInfoPtr_questParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_questDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_parsedParams;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToShadyNPCDialogueData_Public_ShadyNPCDialogueData_0;

	public unsafe int missionLevelReq
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionLevelReq);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionLevelReq)) = num;
		}
	}

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

	public unsafe string npcName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string openingLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openingLine);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openingLine)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<QuestDialogueOption> dialogueOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogueOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<QuestDialogueOption>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogueOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string requiredItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredItem);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredItem)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string thankYouResponse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thankYouResponse);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thankYouResponse)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string idleDialogue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleDialogue);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleDialogue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string questType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questType)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string questParams
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questParams);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questParams)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string questDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questDescription);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ParsedQuestParams parsedParams
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parsedParams);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ParsedQuestParams>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parsedParams)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parsedQuestParams));
		}
	}

	static OpenWorldQuestData()
	{
		Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OpenWorldQuestData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr);
		NativeFieldInfoPtr_missionLevelReq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "missionLevelReq");
		NativeFieldInfoPtr_npcNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "npcNumber");
		NativeFieldInfoPtr_npcName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "npcName");
		NativeFieldInfoPtr_openingLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "openingLine");
		NativeFieldInfoPtr_dialogueOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "dialogueOptions");
		NativeFieldInfoPtr_requiredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "requiredItem");
		NativeFieldInfoPtr_thankYouResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "thankYouResponse");
		NativeFieldInfoPtr_idleDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "idleDialogue");
		NativeFieldInfoPtr_questType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "questType");
		NativeFieldInfoPtr_questParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "questParams");
		NativeFieldInfoPtr_questDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "questDescription");
		NativeFieldInfoPtr_parsedParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, "parsedParams");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_ToShadyNPCDialogueData_Public_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr, 100663437);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22962, XrefRangeEnd = 22970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OpenWorldQuestData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenWorldQuestData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22970, XrefRangeEnd = 22988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadyNPCDialogueData ToShadyNPCDialogueData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToShadyNPCDialogueData_Public_ShadyNPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
	}

	public OpenWorldQuestData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
