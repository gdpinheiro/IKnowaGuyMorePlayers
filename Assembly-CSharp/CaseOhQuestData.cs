using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class CaseOhQuestData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_questNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_questName;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefabIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcName;

	private static readonly System.IntPtr NativeFieldInfoPtr_openingLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_dialogueOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_pizzaCount;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int questNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questNumber)) = num;
		}
	}

	public unsafe string questName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string prefabIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe string secondLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondLine);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondLine)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe int pizzaCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaCount)) = num;
		}
	}

	static CaseOhQuestData()
	{
		Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CaseOhQuestData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr);
		NativeFieldInfoPtr_questNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr, "questNumber");
		NativeFieldInfoPtr_questName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr, "questName");
		NativeFieldInfoPtr_prefabIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr, "prefabIdentifier");
		NativeFieldInfoPtr_npcName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr, "npcName");
		NativeFieldInfoPtr_openingLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr, "openingLine");
		NativeFieldInfoPtr_secondLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr, "secondLine");
		NativeFieldInfoPtr_dialogueOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr, "dialogueOptions");
		NativeFieldInfoPtr_pizzaCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr, "pizzaCount");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr, 100663314);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19883, XrefRangeEnd = 19891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CaseOhQuestData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseOhQuestData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CaseOhQuestData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
