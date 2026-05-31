using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class NPCDialogueData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_npcName;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefabNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_dialogues;

	private static readonly System.IntPtr NativeFieldInfoPtr_dialogueSequence;

	private static readonly System.IntPtr NativeFieldInfoPtr_acceptButtonText;

	private static readonly System.IntPtr NativeFieldInfoPtr_declineButtonText;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShady;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyTaskType;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyTaskDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyDropLocationHint;

	private static readonly System.IntPtr NativeFieldInfoPtr_postAcceptDialogue;

	private static readonly System.IntPtr NativeFieldInfoPtr_orderTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_customOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_beverageOrder;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDialogueForRound_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDialogueRoundCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadyTaskType_Public_ShadyTaskType_0;

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

	public unsafe int prefabNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabNumber)) = num;
		}
	}

	public unsafe List<string> dialogues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogues);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DialogueEntryData> dialogueSequence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogueSequence);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DialogueEntryData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogueSequence)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string acceptButtonText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acceptButtonText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acceptButtonText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string declineButtonText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_declineButtonText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_declineButtonText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool isShady
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShady);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShady)) = flag;
		}
	}

	public unsafe string shadyTaskType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyTaskType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyTaskType)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string shadyTaskDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyTaskDescription);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyTaskDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string shadyDropLocationHint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyDropLocationHint);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyDropLocationHint)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<DialogueEntryData> postAcceptDialogue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postAcceptDialogue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DialogueEntryData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postAcceptDialogue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float orderTimeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderTimeout);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderTimeout)) = num;
		}
	}

	public unsafe List<PizzaOrderData> customOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customOrder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PizzaOrderData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customOrder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BeverageOrderData> beverageOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_beverageOrder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BeverageOrderData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_beverageOrder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static NPCDialogueData()
	{
		Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NPCDialogueData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr);
		NativeFieldInfoPtr_npcName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "npcName");
		NativeFieldInfoPtr_prefabNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "prefabNumber");
		NativeFieldInfoPtr_dialogues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "dialogues");
		NativeFieldInfoPtr_dialogueSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "dialogueSequence");
		NativeFieldInfoPtr_acceptButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "acceptButtonText");
		NativeFieldInfoPtr_declineButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "declineButtonText");
		NativeFieldInfoPtr_isShady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "isShady");
		NativeFieldInfoPtr_shadyTaskType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "shadyTaskType");
		NativeFieldInfoPtr_shadyTaskDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "shadyTaskDescription");
		NativeFieldInfoPtr_shadyDropLocationHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "shadyDropLocationHint");
		NativeFieldInfoPtr_postAcceptDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "postAcceptDialogue");
		NativeFieldInfoPtr_orderTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "orderTimeout");
		NativeFieldInfoPtr_customOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "customOrder");
		NativeFieldInfoPtr_beverageOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, "beverageOrder");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_GetDialogueForRound_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_GetDialogueRoundCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_GetShadyTaskType_Public_ShadyTaskType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr, 100663428);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 22874, RefRangeEnd = 22877, XrefRangeStart = 22832, XrefRangeEnd = 22874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NPCDialogueData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCDialogueData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22881, RefRangeEnd = 22883, XrefRangeStart = 22877, XrefRangeEnd = 22881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDialogueForRound(int round)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&round);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDialogueForRound_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22884, RefRangeEnd = 22885, XrefRangeStart = 22883, XrefRangeEnd = 22884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetDialogueRoundCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDialogueRoundCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22905, RefRangeEnd = 22906, XrefRangeStart = 22885, XrefRangeEnd = 22905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadyTaskType GetShadyTaskType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadyTaskType_Public_ShadyTaskType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ShadyTaskType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public NPCDialogueData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
