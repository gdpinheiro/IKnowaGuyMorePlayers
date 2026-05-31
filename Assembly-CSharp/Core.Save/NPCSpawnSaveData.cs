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
public class NPCSpawnSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_currentDialogueRound;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedPrefabsInCurrentRound;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextNormalSpawnIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_allRoundsExhausted;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyPatternPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyDarkWebIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyWashingIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyIncineratorIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyForgeryIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedShadyQuestNumbers;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadySpawnedToday;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastShadySpawnDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasSeenWashingPreview;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasSeenIncineratorPreview;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasSeenForgeryPreview;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int currentDialogueRound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDialogueRound);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDialogueRound)) = num;
		}
	}

	public unsafe List<int> spawnedPrefabsInCurrentRound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedPrefabsInCurrentRound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedPrefabsInCurrentRound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int nextNormalSpawnIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextNormalSpawnIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextNormalSpawnIndex)) = num;
		}
	}

	public unsafe bool allRoundsExhausted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allRoundsExhausted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allRoundsExhausted)) = flag;
		}
	}

	public unsafe int shadyPatternPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyPatternPosition);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyPatternPosition)) = num;
		}
	}

	public unsafe int shadyDarkWebIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyDarkWebIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyDarkWebIndex)) = num;
		}
	}

	public unsafe int shadyWashingIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyWashingIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyWashingIndex)) = num;
		}
	}

	public unsafe int shadyIncineratorIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyIncineratorIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyIncineratorIndex)) = num;
		}
	}

	public unsafe int shadyForgeryIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyForgeryIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyForgeryIndex)) = num;
		}
	}

	public unsafe List<int> forcedShadyQuestNumbers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedShadyQuestNumbers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedShadyQuestNumbers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int shadySpawnedToday
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadySpawnedToday);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadySpawnedToday)) = num;
		}
	}

	public unsafe int lastShadySpawnDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastShadySpawnDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastShadySpawnDay)) = num;
		}
	}

	public unsafe bool hasSeenWashingPreview
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSeenWashingPreview);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSeenWashingPreview)) = flag;
		}
	}

	public unsafe bool hasSeenIncineratorPreview
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSeenIncineratorPreview);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSeenIncineratorPreview)) = flag;
		}
	}

	public unsafe bool hasSeenForgeryPreview
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSeenForgeryPreview);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSeenForgeryPreview)) = flag;
		}
	}

	static NPCSpawnSaveData()
	{
		Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "NPCSpawnSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_currentDialogueRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "currentDialogueRound");
		NativeFieldInfoPtr_spawnedPrefabsInCurrentRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "spawnedPrefabsInCurrentRound");
		NativeFieldInfoPtr_nextNormalSpawnIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "nextNormalSpawnIndex");
		NativeFieldInfoPtr_allRoundsExhausted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "allRoundsExhausted");
		NativeFieldInfoPtr_shadyPatternPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "shadyPatternPosition");
		NativeFieldInfoPtr_shadyDarkWebIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "shadyDarkWebIndex");
		NativeFieldInfoPtr_shadyWashingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "shadyWashingIndex");
		NativeFieldInfoPtr_shadyIncineratorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "shadyIncineratorIndex");
		NativeFieldInfoPtr_shadyForgeryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "shadyForgeryIndex");
		NativeFieldInfoPtr_forcedShadyQuestNumbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "forcedShadyQuestNumbers");
		NativeFieldInfoPtr_shadySpawnedToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "shadySpawnedToday");
		NativeFieldInfoPtr_lastShadySpawnDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "lastShadySpawnDay");
		NativeFieldInfoPtr_hasSeenWashingPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "hasSeenWashingPreview");
		NativeFieldInfoPtr_hasSeenIncineratorPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "hasSeenIncineratorPreview");
		NativeFieldInfoPtr_hasSeenForgeryPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, "hasSeenForgeryPreview");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr, 100676001);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215295, RefRangeEnd = 215296, XrefRangeStart = 215282, XrefRangeEnd = 215295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NPCSpawnSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpawnSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NPCSpawnSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
