using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace AdventureNature.Rendering;

public class HierarchicalObjectSpawner : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_areaMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnRadiusLargeObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnRadiusMediumObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_splineStripWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_visualizeSplineArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnTag;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSlopeAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSlopeAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_largeObjectPrefabs;

	private static readonly System.IntPtr NativeFieldInfoPtr_largeObjectWeights;

	private static readonly System.IntPtr NativeFieldInfoPtr_mediumObjectPrefabs;

	private static readonly System.IntPtr NativeFieldInfoPtr_mediumObjectWeights;

	private static readonly System.IntPtr NativeFieldInfoPtr_smallObjectPrefabs;

	private static readonly System.IntPtr NativeFieldInfoPtr_smallObjectWeights;

	private static readonly System.IntPtr NativeFieldInfoPtr_largeObjectCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_mediumObjectCountPerLarge;

	private static readonly System.IntPtr NativeFieldInfoPtr_smallObjectCountPerMedium;

	private static readonly System.IntPtr NativeFieldInfoPtr_largeObjectSizeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_mediumObjectSizeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_smallObjectSizeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_alignToGround;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationYRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomFullRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationXRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationZRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_seed;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastSeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawGizmo;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastRotation;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateWeightArrays_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeWeights_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeWeightArray_Private_Void_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnObjects_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearObjects_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomWeightedPrefab_Private_GameObject_Il2CppReferenceArray_1_GameObject_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpawnPositionOnTerrain_Private_Vector3_Vector3_Single_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateObject_Private_GameObject_GameObject_Vector3_Vector2_Nullable_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe SplineAreaMode areaMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaMode);
			return *(SplineAreaMode*)num;
		}
		set
		{
			*(SplineAreaMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaMode)) = splineAreaMode;
		}
	}

	public unsafe float spawnRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRadius)) = num;
		}
	}

	public unsafe float spawnRadiusLargeObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRadiusLargeObject);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRadiusLargeObject)) = num;
		}
	}

	public unsafe float spawnRadiusMediumObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRadiusMediumObject);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRadiusMediumObject)) = num;
		}
	}

	public unsafe float splineStripWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splineStripWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splineStripWidth)) = num;
		}
	}

	public unsafe bool visualizeSplineArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualizeSplineArea);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualizeSplineArea)) = flag;
		}
	}

	public unsafe string spawnTag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnTag);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnTag)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float minSlopeAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlopeAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlopeAngle)) = num;
		}
	}

	public unsafe float maxSlopeAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlopeAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlopeAngle)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> largeObjectPrefabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeObjectPrefabs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeObjectPrefabs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<float> largeObjectWeights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeObjectWeights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeObjectWeights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> mediumObjectPrefabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumObjectPrefabs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumObjectPrefabs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<float> mediumObjectWeights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumObjectWeights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumObjectWeights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> smallObjectPrefabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallObjectPrefabs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallObjectPrefabs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<float> smallObjectWeights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallObjectWeights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallObjectWeights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int largeObjectCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeObjectCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeObjectCount)) = num;
		}
	}

	public unsafe int mediumObjectCountPerLarge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumObjectCountPerLarge);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumObjectCountPerLarge)) = num;
		}
	}

	public unsafe int smallObjectCountPerMedium
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallObjectCountPerMedium);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallObjectCountPerMedium)) = num;
		}
	}

	public unsafe Vector2 largeObjectSizeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeObjectSizeRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeObjectSizeRange)) = vector;
		}
	}

	public unsafe Vector2 mediumObjectSizeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumObjectSizeRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumObjectSizeRange)) = vector;
		}
	}

	public unsafe Vector2 smallObjectSizeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallObjectSizeRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallObjectSizeRange)) = vector;
		}
	}

	public unsafe bool alignToGround
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignToGround);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignToGround)) = flag;
		}
	}

	public unsafe Vector2 rotationYRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationYRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationYRange)) = vector;
		}
	}

	public unsafe bool randomFullRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomFullRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomFullRotation)) = flag;
		}
	}

	public unsafe Vector2 rotationXRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationXRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationXRange)) = vector;
		}
	}

	public unsafe Vector2 rotationZRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationZRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationZRange)) = vector;
		}
	}

	public unsafe int seed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed)) = num;
		}
	}

	public unsafe int lastSeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSeed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSeed)) = num;
		}
	}

	public unsafe bool drawGizmo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawGizmo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawGizmo)) = flag;
		}
	}

	public unsafe Vector3 lastPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPosition)) = vector;
		}
	}

	public unsafe Quaternion lastRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRotation)) = quaternion;
		}
	}

	static HierarchicalObjectSpawner()
	{
		Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdventureNature.Rendering", "HierarchicalObjectSpawner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr);
		NativeFieldInfoPtr_areaMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "areaMode");
		NativeFieldInfoPtr_spawnRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "spawnRadius");
		NativeFieldInfoPtr_spawnRadiusLargeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "spawnRadiusLargeObject");
		NativeFieldInfoPtr_spawnRadiusMediumObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "spawnRadiusMediumObject");
		NativeFieldInfoPtr_splineStripWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "splineStripWidth");
		NativeFieldInfoPtr_visualizeSplineArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "visualizeSplineArea");
		NativeFieldInfoPtr_spawnTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "spawnTag");
		NativeFieldInfoPtr_minSlopeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "minSlopeAngle");
		NativeFieldInfoPtr_maxSlopeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "maxSlopeAngle");
		NativeFieldInfoPtr_largeObjectPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "largeObjectPrefabs");
		NativeFieldInfoPtr_largeObjectWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "largeObjectWeights");
		NativeFieldInfoPtr_mediumObjectPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "mediumObjectPrefabs");
		NativeFieldInfoPtr_mediumObjectWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "mediumObjectWeights");
		NativeFieldInfoPtr_smallObjectPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "smallObjectPrefabs");
		NativeFieldInfoPtr_smallObjectWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "smallObjectWeights");
		NativeFieldInfoPtr_largeObjectCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "largeObjectCount");
		NativeFieldInfoPtr_mediumObjectCountPerLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "mediumObjectCountPerLarge");
		NativeFieldInfoPtr_smallObjectCountPerMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "smallObjectCountPerMedium");
		NativeFieldInfoPtr_largeObjectSizeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "largeObjectSizeRange");
		NativeFieldInfoPtr_mediumObjectSizeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "mediumObjectSizeRange");
		NativeFieldInfoPtr_smallObjectSizeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "smallObjectSizeRange");
		NativeFieldInfoPtr_alignToGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "alignToGround");
		NativeFieldInfoPtr_rotationYRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "rotationYRange");
		NativeFieldInfoPtr_randomFullRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "randomFullRotation");
		NativeFieldInfoPtr_rotationXRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "rotationXRange");
		NativeFieldInfoPtr_rotationZRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "rotationZRange");
		NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "seed");
		NativeFieldInfoPtr_lastSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "lastSeed");
		NativeFieldInfoPtr_drawGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "drawGizmo");
		NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "lastPosition");
		NativeFieldInfoPtr_lastRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, "lastRotation");
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, 100678050);
		NativeMethodInfoPtr_ValidateWeightArrays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, 100678051);
		NativeMethodInfoPtr_NormalizeWeights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, 100678052);
		NativeMethodInfoPtr_NormalizeWeightArray_Private_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, 100678053);
		NativeMethodInfoPtr_SpawnObjects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, 100678054);
		NativeMethodInfoPtr_ClearObjects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, 100678055);
		NativeMethodInfoPtr_GetRandomWeightedPrefab_Private_GameObject_Il2CppReferenceArray_1_GameObject_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, 100678056);
		NativeMethodInfoPtr_GetSpawnPositionOnTerrain_Private_Vector3_Vector3_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, 100678057);
		NativeMethodInfoPtr_InstantiateObject_Private_GameObject_GameObject_Vector3_Vector2_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, 100678058);
		NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, 100678059);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr, 100678060);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243376, XrefRangeEnd = 243388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243404, RefRangeEnd = 243405, XrefRangeStart = 243388, XrefRangeEnd = 243404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateWeightArrays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateWeightArrays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243405, XrefRangeEnd = 243408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NormalizeWeights()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizeWeights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 243410, RefRangeEnd = 243416, XrefRangeStart = 243408, XrefRangeEnd = 243410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NormalizeWeightArray(Il2CppStructArray<float> weights)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)weights);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizeWeightArray_Private_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243416, XrefRangeEnd = 243472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnObjects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnObjects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243472, XrefRangeEnd = 243483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearObjects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearObjects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 243499, RefRangeEnd = 243502, XrefRangeStart = 243483, XrefRangeEnd = 243499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetRandomWeightedPrefab(Il2CppReferenceArray<GameObject> prefabs, Il2CppStructArray<float> weights)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefabs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)weights);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomWeightedPrefab_Private_GameObject_Il2CppReferenceArray_1_GameObject_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 243528, RefRangeEnd = 243531, XrefRangeStart = 243502, XrefRangeEnd = 243528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetSpawnPositionOnTerrain(Vector3 center, float radius, out Vector3 normal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&center);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref normal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpawnPositionOnTerrain_Private_Vector3_Vector3_Single_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 243583, RefRangeEnd = 243586, XrefRangeStart = 243531, XrefRangeEnd = 243583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject InstantiateObject(GameObject prefab, Vector3 position, Vector2 sizeRange, Il2CppSystem.Nullable<Vector3> groundNormal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeRange;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)groundNormal));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstantiateObject_Private_GameObject_GameObject_Vector3_Vector2_Nullable_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243586, XrefRangeEnd = 243590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243590, XrefRangeEnd = 243595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchicalObjectSpawner()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchicalObjectSpawner>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HierarchicalObjectSpawner(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
