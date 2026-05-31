using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class MissionResult : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_missionId;

	private static readonly System.IntPtr NativeFieldInfoPtr_success;

	private static readonly System.IntPtr NativeFieldInfoPtr_completionTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_score;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyReward;

	private static readonly System.IntPtr NativeFieldInfoPtr_xpReward;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

	public unsafe string missionId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool success
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_success);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_success)) = flag;
		}
	}

	public unsafe float completionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completionTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completionTime)) = num;
		}
	}

	public unsafe int score
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_score);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_score)) = num;
		}
	}

	public unsafe float moneyReward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyReward);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyReward)) = num;
		}
	}

	public unsafe int xpReward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xpReward);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xpReward)) = num;
		}
	}

	static MissionResult()
	{
		Il2CppClassPointerStore<MissionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MissionResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionResult>.NativeClassPtr);
		NativeFieldInfoPtr_missionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionResult>.NativeClassPtr, "missionId");
		NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionResult>.NativeClassPtr, "success");
		NativeFieldInfoPtr_completionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionResult>.NativeClassPtr, "completionTime");
		NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionResult>.NativeClassPtr, "score");
		NativeFieldInfoPtr_moneyReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionResult>.NativeClassPtr, "moneyReward");
		NativeFieldInfoPtr_xpReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionResult>.NativeClassPtr, "xpReward");
		NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionResult>.NativeClassPtr, 100663535);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 23275, RefRangeEnd = 23278, XrefRangeStart = 23273, XrefRangeEnd = 23275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissionResult(string id, bool wasSuccessful)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionResult>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wasSuccessful;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MissionResult(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
