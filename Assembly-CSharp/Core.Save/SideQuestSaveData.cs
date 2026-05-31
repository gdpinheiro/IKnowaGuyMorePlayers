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
public class SideQuestSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_shadyCompleted;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyCounterCompleted;

	private static readonly System.IntPtr NativeFieldInfoPtr_completedQuestNPCNumbers;

	private static readonly System.IntPtr NativeFieldInfoPtr_completedShadyCounterQuestNumbers;

	private static readonly System.IntPtr NativeFieldInfoPtr_installmentPaid;

	private static readonly System.IntPtr NativeFieldInfoPtr_activated;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeQuests;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextQuestId;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int shadyCompleted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyCompleted);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyCompleted)) = num;
		}
	}

	public unsafe int shadyCounterCompleted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyCounterCompleted);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyCounterCompleted)) = num;
		}
	}

	public unsafe List<int> completedQuestNPCNumbers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedQuestNPCNumbers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedQuestNPCNumbers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> completedShadyCounterQuestNumbers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedShadyCounterQuestNumbers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedShadyCounterQuestNumbers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool installmentPaid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_installmentPaid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_installmentPaid)) = flag;
		}
	}

	public unsafe bool activated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activated)) = flag;
		}
	}

	public unsafe List<QuestSaveEntry> activeQuests
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeQuests);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<QuestSaveEntry>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeQuests)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int nextQuestId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextQuestId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextQuestId)) = num;
		}
	}

	static SideQuestSaveData()
	{
		Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "SideQuestSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_shadyCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr, "shadyCompleted");
		NativeFieldInfoPtr_shadyCounterCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr, "shadyCounterCompleted");
		NativeFieldInfoPtr_completedQuestNPCNumbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr, "completedQuestNPCNumbers");
		NativeFieldInfoPtr_completedShadyCounterQuestNumbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr, "completedShadyCounterQuestNumbers");
		NativeFieldInfoPtr_installmentPaid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr, "installmentPaid");
		NativeFieldInfoPtr_activated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr, "activated");
		NativeFieldInfoPtr_activeQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr, "activeQuests");
		NativeFieldInfoPtr_nextQuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr, "nextQuestId");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr, 100676009);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215319, RefRangeEnd = 215320, XrefRangeStart = 215306, XrefRangeEnd = 215319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SideQuestSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SideQuestSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SideQuestSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
