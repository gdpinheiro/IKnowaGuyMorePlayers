using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Core.Save;

[System.Serializable]
public class CleaningSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dirtinessTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstDecalActivated;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseHuntTriggered;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastActivatedDecalCount;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float dirtinessTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtinessTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtinessTimer)) = num;
		}
	}

	public unsafe bool firstDecalActivated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstDecalActivated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstDecalActivated)) = flag;
		}
	}

	public unsafe bool mouseHuntTriggered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseHuntTriggered);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseHuntTriggered)) = flag;
		}
	}

	public unsafe int lastActivatedDecalCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastActivatedDecalCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastActivatedDecalCount)) = num;
		}
	}

	static CleaningSaveData()
	{
		Il2CppClassPointerStore<CleaningSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "CleaningSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleaningSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_dirtinessTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleaningSaveData>.NativeClassPtr, "dirtinessTimer");
		NativeFieldInfoPtr_firstDecalActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleaningSaveData>.NativeClassPtr, "firstDecalActivated");
		NativeFieldInfoPtr_mouseHuntTriggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleaningSaveData>.NativeClassPtr, "mouseHuntTriggered");
		NativeFieldInfoPtr_lastActivatedDecalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleaningSaveData>.NativeClassPtr, "lastActivatedDecalCount");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleaningSaveData>.NativeClassPtr, 100675998);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CleaningSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleaningSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CleaningSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
