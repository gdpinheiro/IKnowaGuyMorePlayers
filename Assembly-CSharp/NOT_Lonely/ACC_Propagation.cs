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

public class ACC_Propagation : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_pathPoints;

	private static readonly IntPtr NativeFieldInfoPtr_propagationInterval;

	private static readonly IntPtr NativeFieldInfoPtr_currentDistance;

	private static readonly IntPtr NativeFieldInfoPtr_posRandom;

	private static readonly IntPtr NativeFieldInfoPtr_propPos;

	private static readonly IntPtr NativeFieldInfoPtr_propRot;

	private static readonly IntPtr NativeFieldInfoPtr_propScale;

	private static readonly IntPtr NativeFieldInfoPtr_count;

	private static readonly IntPtr NativeMethodInfoPtr_SpawnObjectsAlongPath_Public_List_1_ACC_PropObject_ACC_Cable_Il2CppReferenceArray_1_GameObject_Int32_Vector2_Single_Vector3_Vector3_Vector2_Single_Single_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SpawnObject_Private_Void_ACC_Cable_Il2CppReferenceArray_1_GameObject_Int32_List_1_ACC_PropObject_byref_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTransformValues_Private_Void_Vector3_Vector3_Vector2_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalculateValues_Private_Void_Vector2_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateSpawnedObjects_Public_Void_ACC_Cable_List_1_ACC_PropObject_Vector2_Single_Single_Vector3_Vector3_Vector2_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPointOnPath_Private_Vector3_Il2CppStructArray_1_Vector3_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTangentOnPath_Private_Vector3_Il2CppStructArray_1_Vector3_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe float propagationInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propagationInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propagationInterval)) = num;
		}
	}

	public unsafe float currentDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDistance)) = num;
		}
	}

	public unsafe float posRandom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posRandom);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posRandom)) = num;
		}
	}

	public unsafe Vector3 propPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propPos)) = vector;
		}
	}

	public unsafe Quaternion propRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propRot);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propRot)) = quaternion;
		}
	}

	public unsafe Vector3 propScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propScale)) = vector;
		}
	}

	public unsafe int count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = num;
		}
	}

	static ACC_Propagation()
	{
		Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NOT_Lonely", "ACC_Propagation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr);
		NativeFieldInfoPtr_pathPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, "pathPoints");
		NativeFieldInfoPtr_propagationInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, "propagationInterval");
		NativeFieldInfoPtr_currentDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, "currentDistance");
		NativeFieldInfoPtr_posRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, "posRandom");
		NativeFieldInfoPtr_propPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, "propPos");
		NativeFieldInfoPtr_propRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, "propRot");
		NativeFieldInfoPtr_propScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, "propScale");
		NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, "count");
		NativeMethodInfoPtr_SpawnObjectsAlongPath_Public_List_1_ACC_PropObject_ACC_Cable_Il2CppReferenceArray_1_GameObject_Int32_Vector2_Single_Vector3_Vector3_Vector2_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, 100676407);
		NativeMethodInfoPtr_SpawnObject_Private_Void_ACC_Cable_Il2CppReferenceArray_1_GameObject_Int32_List_1_ACC_PropObject_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, 100676408);
		NativeMethodInfoPtr_GetTransformValues_Private_Void_Vector3_Vector3_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, 100676409);
		NativeMethodInfoPtr_CalculateValues_Private_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, 100676410);
		NativeMethodInfoPtr_UpdateSpawnedObjects_Public_Void_ACC_Cable_List_1_ACC_PropObject_Vector2_Single_Single_Vector3_Vector3_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, 100676411);
		NativeMethodInfoPtr_GetPointOnPath_Private_Vector3_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, 100676412);
		NativeMethodInfoPtr_GetTangentOnPath_Private_Vector3_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, 100676413);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr, 100676414);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220439, XrefRangeEnd = 220449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ACC_PropObject> SpawnObjectsAlongPath(ACC_Cable cable, Il2CppReferenceArray<GameObject> propPrefabs, int propCount, Vector2 startEndOffsets, float positionRandom, Vector3 rotationMin, Vector3 rotationMax, Vector2 scaleMinMax, float followPathRotation, float verticalPosOffset, int prefabSelectionMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[11];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cable);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)propPrefabs);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &propCount;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &startEndOffsets;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &positionRandom;
		*(Vector3**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &rotationMin;
		*(Vector3**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &rotationMax;
		*(Vector2**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = &scaleMinMax;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(IntPtr)))) = &followPathRotation;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(IntPtr)))) = &verticalPosOffset;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(IntPtr)))) = &prefabSelectionMode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnObjectsAlongPath_Public_List_1_ACC_PropObject_ACC_Cable_Il2CppReferenceArray_1_GameObject_Int32_Vector2_Single_Vector3_Vector3_Vector2_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ACC_PropObject>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 220481, RefRangeEnd = 220483, XrefRangeStart = 220449, XrefRangeEnd = 220481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnObject(ACC_Cable cable, Il2CppReferenceArray<GameObject> propPrefabs, int prefabSelectionMode, List<ACC_PropObject> spawnedObjects, ref int prefabIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cable);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)propPrefabs);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &prefabSelectionMode;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnedObjects);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref prefabIndex);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnObject_Private_Void_ACC_Cable_Il2CppReferenceArray_1_GameObject_Int32_List_1_ACC_PropObject_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 220501, RefRangeEnd = 220505, XrefRangeStart = 220483, XrefRangeEnd = 220501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetTransformValues(Vector3 rotationMin, Vector3 rotationMax, Vector2 scaleMinMax, float followPathRotation, float verticalPosOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&rotationMin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &rotationMax;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &scaleMinMax;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &followPathRotation;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &verticalPosOffset;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTransformValues_Private_Void_Vector3_Vector3_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 220511, RefRangeEnd = 220515, XrefRangeStart = 220505, XrefRangeEnd = 220511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateValues(Vector2 startEndOffsets, float positionRandom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&startEndOffsets);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &positionRandom;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateValues_Private_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220515, XrefRangeEnd = 220536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSpawnedObjects(ACC_Cable cable, List<ACC_PropObject> spawnedObjects, Vector2 startEndOffsets, float positionRandom, float verticalPosOffset, Vector3 rotationMin, Vector3 rotationMax, Vector2 scaleMinMax, float followPathRotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cable);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnedObjects);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &startEndOffsets;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &positionRandom;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &verticalPosOffset;
		*(Vector3**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &rotationMin;
		*(Vector3**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &rotationMax;
		*(Vector2**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = &scaleMinMax;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(IntPtr)))) = &followPathRotation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSpawnedObjects_Public_Void_ACC_Cable_List_1_ACC_PropObject_Vector2_Single_Single_Vector3_Vector3_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 220543, RefRangeEnd = 220544, XrefRangeStart = 220536, XrefRangeEnd = 220543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPointOnPath(Il2CppStructArray<Vector3> pathPoints, float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pathPoints);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &distance;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPointOnPath_Private_Vector3_Il2CppStructArray_1_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 220557, RefRangeEnd = 220558, XrefRangeStart = 220544, XrefRangeEnd = 220557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetTangentOnPath(Il2CppStructArray<Vector3> pathPoints, float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pathPoints);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &distance;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTangentOnPath_Private_Vector3_Il2CppStructArray_1_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(158)]
	[CachedScanResults(RefRangeStart = 42846, RefRangeEnd = 43004, XrefRangeStart = 42846, XrefRangeEnd = 43004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ACC_Propagation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACC_Propagation>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ACC_Propagation(IntPtr pointer)
		: base(pointer)
	{
	}
}
