using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

[System.Serializable]
public class PlacedMachineData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_machineType;

	private static readonly System.IntPtr NativeFieldInfoPtr_machineInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_placementPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_placementRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_placementTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe MachineType machineType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineType);
			return *(MachineType*)num;
		}
		set
		{
			*(MachineType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineType)) = machineType;
		}
	}

	public unsafe GameObject machineInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineInstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machineInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Vector3 placementPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementPosition)) = vector;
		}
	}

	public unsafe Quaternion placementRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementRotation)) = quaternion;
		}
	}

	public unsafe Il2CppSystem.DateTime placementTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementTime)) = dateTime;
		}
	}

	static PlacedMachineData()
	{
		Il2CppClassPointerStore<PlacedMachineData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlacedMachineData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacedMachineData>.NativeClassPtr);
		NativeFieldInfoPtr_machineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacedMachineData>.NativeClassPtr, "machineType");
		NativeFieldInfoPtr_machineInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacedMachineData>.NativeClassPtr, "machineInstance");
		NativeFieldInfoPtr_placementPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacedMachineData>.NativeClassPtr, "placementPosition");
		NativeFieldInfoPtr_placementRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacedMachineData>.NativeClassPtr, "placementRotation");
		NativeFieldInfoPtr_placementTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacedMachineData>.NativeClassPtr, "placementTime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacedMachineData>.NativeClassPtr, 100663769);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlacedMachineData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlacedMachineData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlacedMachineData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
