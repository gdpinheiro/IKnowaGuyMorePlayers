using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

[System.Serializable]
public class MissionConfig : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_timeLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseReward;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseXP;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredPrefabs;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float timeLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLimit)) = num;
		}
	}

	public unsafe int targetScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetScore);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetScore)) = num;
		}
	}

	public unsafe float baseReward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseReward);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseReward)) = num;
		}
	}

	public unsafe int baseXP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseXP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseXP)) = num;
		}
	}

	public unsafe Transform spawnArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnArea);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> requiredPrefabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredPrefabs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredPrefabs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static MissionConfig()
	{
		Il2CppClassPointerStore<MissionConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MissionConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionConfig>.NativeClassPtr);
		NativeFieldInfoPtr_timeLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionConfig>.NativeClassPtr, "timeLimit");
		NativeFieldInfoPtr_targetScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionConfig>.NativeClassPtr, "targetScore");
		NativeFieldInfoPtr_baseReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionConfig>.NativeClassPtr, "baseReward");
		NativeFieldInfoPtr_baseXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionConfig>.NativeClassPtr, "baseXP");
		NativeFieldInfoPtr_spawnArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionConfig>.NativeClassPtr, "spawnArea");
		NativeFieldInfoPtr_requiredPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionConfig>.NativeClassPtr, "requiredPrefabs");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionConfig>.NativeClassPtr, 100663536);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23279, RefRangeEnd = 23280, XrefRangeStart = 23278, XrefRangeEnd = 23279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissionConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionConfig>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MissionConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
