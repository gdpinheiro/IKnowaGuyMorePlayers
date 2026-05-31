using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class WallClock : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_hourHand;

	private static readonly IntPtr NativeFieldInfoPtr_minuteHand;

	private static readonly IntPtr NativeFieldInfoPtr_secondHand;

	private static readonly IntPtr NativeFieldInfoPtr_smoothMovement;

	private static readonly IntPtr NativeFieldInfoPtr_DEGREES_PER_HOUR;

	private static readonly IntPtr NativeFieldInfoPtr_DEGREES_PER_MINUTE;

	private static readonly IntPtr NativeFieldInfoPtr_DEGREES_PER_SECOND;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateClockHands_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Transform hourHand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hourHand);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hourHand)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform minuteHand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minuteHand);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minuteHand)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform secondHand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondHand);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondHand)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe bool smoothMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothMovement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothMovement)) = flag;
		}
	}

	public unsafe static float DEGREES_PER_HOUR
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEGREES_PER_HOUR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEGREES_PER_HOUR, (void*)(&num));
		}
	}

	public unsafe static float DEGREES_PER_MINUTE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEGREES_PER_MINUTE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEGREES_PER_MINUTE, (void*)(&num));
		}
	}

	public unsafe static float DEGREES_PER_SECOND
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEGREES_PER_SECOND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEGREES_PER_SECOND, (void*)(&num));
		}
	}

	static WallClock()
	{
		Il2CppClassPointerStore<WallClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WallClock");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallClock>.NativeClassPtr);
		NativeFieldInfoPtr_hourHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallClock>.NativeClassPtr, "hourHand");
		NativeFieldInfoPtr_minuteHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallClock>.NativeClassPtr, "minuteHand");
		NativeFieldInfoPtr_secondHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallClock>.NativeClassPtr, "secondHand");
		NativeFieldInfoPtr_smoothMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallClock>.NativeClassPtr, "smoothMovement");
		NativeFieldInfoPtr_DEGREES_PER_HOUR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallClock>.NativeClassPtr, "DEGREES_PER_HOUR");
		NativeFieldInfoPtr_DEGREES_PER_MINUTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallClock>.NativeClassPtr, "DEGREES_PER_MINUTE");
		NativeFieldInfoPtr_DEGREES_PER_SECOND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallClock>.NativeClassPtr, "DEGREES_PER_SECOND");
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallClock>.NativeClassPtr, 100665444);
		NativeMethodInfoPtr_UpdateClockHands_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallClock>.NativeClassPtr, 100665445);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallClock>.NativeClassPtr, 100665446);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59285, XrefRangeEnd = 59293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59312, RefRangeEnd = 59313, XrefRangeStart = 59293, XrefRangeEnd = 59312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateClockHands(float timeInHours)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&timeInHours);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateClockHands_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59313, XrefRangeEnd = 59314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WallClock()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallClock>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WallClock(IntPtr pointer)
		: base(pointer)
	{
	}
}
