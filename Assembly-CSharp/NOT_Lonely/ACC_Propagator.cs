using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace NOT_Lonely;

public class ACC_Propagator : MonoBehaviour
{
	public enum PrefabSelectionMode
	{
		Sequental,
		Random
	}

	private static readonly IntPtr NativeFieldInfoPtr_propPrefabs;

	private static readonly IntPtr NativeFieldInfoPtr_propCount;

	private static readonly IntPtr NativeFieldInfoPtr_usePropGrouping;

	private static readonly IntPtr NativeFieldInfoPtr_propGroupSize;

	private static readonly IntPtr NativeFieldInfoPtr_propVerticalPosOffset;

	private static readonly IntPtr NativeFieldInfoPtr_propPositionRandom;

	private static readonly IntPtr NativeFieldInfoPtr_propRotationMin;

	private static readonly IntPtr NativeFieldInfoPtr_propRotationMax;

	private static readonly IntPtr NativeFieldInfoPtr_propScaleMinMax;

	private static readonly IntPtr NativeFieldInfoPtr_propFollowPathRotation;

	private static readonly IntPtr NativeFieldInfoPtr_prefabSelectionMode;

	private static readonly IntPtr NativeFieldInfoPtr_startEndOffsets;

	private static readonly IntPtr NativeFieldInfoPtr_pathPoints;

	private static readonly IntPtr NativeFieldInfoPtr_spawnedObjects;

	private static readonly IntPtr NativeFieldInfoPtr_cable;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SpawnObjectsAlongPath_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPointOnPath_Private_Vector3_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTangentOnPath_Private_Vector3_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<GameObject> propPrefabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propPrefabs);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propPrefabs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int propCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propCount)) = num;
		}
	}

	public unsafe bool usePropGrouping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePropGrouping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePropGrouping)) = flag;
		}
	}

	public unsafe int propGroupSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propGroupSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propGroupSize)) = num;
		}
	}

	public unsafe float propVerticalPosOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propVerticalPosOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propVerticalPosOffset)) = num;
		}
	}

	public unsafe float propPositionRandom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propPositionRandom);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propPositionRandom)) = num;
		}
	}

	public unsafe Vector3 propRotationMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propRotationMin);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propRotationMin)) = vector;
		}
	}

	public unsafe Vector3 propRotationMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propRotationMax);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propRotationMax)) = vector;
		}
	}

	public unsafe Vector2 propScaleMinMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propScaleMinMax);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propScaleMinMax)) = vector;
		}
	}

	public unsafe float propFollowPathRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propFollowPathRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propFollowPathRotation)) = num;
		}
	}

	public unsafe PrefabSelectionMode prefabSelectionMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabSelectionMode);
			return *(PrefabSelectionMode*)num;
		}
		set
		{
			*(PrefabSelectionMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabSelectionMode)) = prefabSelectionMode;
		}
	}

	public unsafe Vector2 startEndOffsets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startEndOffsets);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startEndOffsets)) = vector;
		}
	}

	public unsafe Il2CppStructArray<Vector3> pathPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathPoints);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathPoints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe List<Transform> spawnedObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedObjects);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ACC_Cable cable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cable);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ACC_Cable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aCC_Cable));
		}
	}

	static ACC_Propagator()
	{
		Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NOT_Lonely", "ACC_Propagator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr);
		NativeFieldInfoPtr_propPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "propPrefabs");
		NativeFieldInfoPtr_propCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "propCount");
		NativeFieldInfoPtr_usePropGrouping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "usePropGrouping");
		NativeFieldInfoPtr_propGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "propGroupSize");
		NativeFieldInfoPtr_propVerticalPosOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "propVerticalPosOffset");
		NativeFieldInfoPtr_propPositionRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "propPositionRandom");
		NativeFieldInfoPtr_propRotationMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "propRotationMin");
		NativeFieldInfoPtr_propRotationMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "propRotationMax");
		NativeFieldInfoPtr_propScaleMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "propScaleMinMax");
		NativeFieldInfoPtr_propFollowPathRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "propFollowPathRotation");
		NativeFieldInfoPtr_prefabSelectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "prefabSelectionMode");
		NativeFieldInfoPtr_startEndOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "startEndOffsets");
		NativeFieldInfoPtr_pathPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "pathPoints");
		NativeFieldInfoPtr_spawnedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "spawnedObjects");
		NativeFieldInfoPtr_cable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, "cable");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, 100676415);
		NativeMethodInfoPtr_SpawnObjectsAlongPath_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, 100676416);
		NativeMethodInfoPtr_GetPointOnPath_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, 100676417);
		NativeMethodInfoPtr_GetTangentOnPath_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, 100676418);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr, 100676419);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220558, XrefRangeEnd = 220571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 220629, RefRangeEnd = 220630, XrefRangeStart = 220571, XrefRangeEnd = 220629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnObjectsAlongPath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnObjectsAlongPath_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 220639, RefRangeEnd = 220640, XrefRangeStart = 220630, XrefRangeEnd = 220639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPointOnPath(float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&distance);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPointOnPath_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 220650, RefRangeEnd = 220651, XrefRangeStart = 220640, XrefRangeEnd = 220650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetTangentOnPath(float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&distance);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTangentOnPath_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220651, XrefRangeEnd = 220665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ACC_Propagator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACC_Propagator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ACC_Propagator(IntPtr pointer)
		: base(pointer)
	{
	}
}
