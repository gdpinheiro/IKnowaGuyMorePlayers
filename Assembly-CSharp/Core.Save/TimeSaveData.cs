using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Core.Save;

[System.Serializable]
public class TimeSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_currentDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayDurationInMinutes;

	private static readonly System.IntPtr NativeFieldInfoPtr_use24HourFormat;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int currentDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDay)) = num;
		}
	}

	public unsafe float currentTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTime)) = num;
		}
	}

	public unsafe float dayDurationInMinutes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayDurationInMinutes);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayDurationInMinutes)) = num;
		}
	}

	public unsafe bool use24HourFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_use24HourFormat);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_use24HourFormat)) = flag;
		}
	}

	static TimeSaveData()
	{
		Il2CppClassPointerStore<TimeSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "TimeSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_currentDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSaveData>.NativeClassPtr, "currentDay");
		NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSaveData>.NativeClassPtr, "currentTime");
		NativeFieldInfoPtr_dayDurationInMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSaveData>.NativeClassPtr, "dayDurationInMinutes");
		NativeFieldInfoPtr_use24HourFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSaveData>.NativeClassPtr, "use24HourFormat");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSaveData>.NativeClassPtr, 100675990);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TimeSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
