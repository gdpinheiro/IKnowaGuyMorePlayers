using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class DeliverySpawnArea : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_gridSize;

	private static readonly IntPtr NativeFieldInfoPtr_cellSize;

	private static readonly IntPtr NativeFieldInfoPtr_gridOffset;

	private static readonly IntPtr NativeFieldInfoPtr_raycastStartHeight;

	private static readonly IntPtr NativeFieldInfoPtr_raycastDistance;

	private static readonly IntPtr NativeFieldInfoPtr_raycastLayers;

	private static readonly IntPtr NativeFieldInfoPtr_stackOffset;

	private static readonly IntPtr NativeFieldInfoPtr_showGrid;

	private static readonly IntPtr NativeFieldInfoPtr_showRaycasts;

	private static readonly IntPtr NativeFieldInfoPtr_showAxes;

	private static readonly IntPtr NativeFieldInfoPtr_spawnPointSize;

	private static readonly IntPtr NativeFieldInfoPtr_spawnColor;

	private static readonly IntPtr NativeFieldInfoPtr_raycastColor;

	private static readonly IntPtr NativeFieldInfoPtr_currentSpawnIndex;

	private static readonly IntPtr NativeMethodInfoPtr_GetNextSpawnPosition_Public_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_SpawnObject_Public_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetWorldPosition_Private_Vector3_Vector3Int_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetSpawnIndex_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRandomSpawnPoint_Public_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector3Int gridSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridSize);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridSize)) = vector3Int;
		}
	}

	public unsafe float cellSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSize)) = num;
		}
	}

	public unsafe Vector3 gridOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridOffset)) = vector;
		}
	}

	public unsafe float raycastStartHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raycastStartHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raycastStartHeight)) = num;
		}
	}

	public unsafe float raycastDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raycastDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raycastDistance)) = num;
		}
	}

	public unsafe LayerMask raycastLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raycastLayers);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raycastLayers)) = layerMask;
		}
	}

	public unsafe float stackOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackOffset)) = num;
		}
	}

	public unsafe bool showGrid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showGrid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showGrid)) = flag;
		}
	}

	public unsafe bool showRaycasts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showRaycasts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showRaycasts)) = flag;
		}
	}

	public unsafe bool showAxes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showAxes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showAxes)) = flag;
		}
	}

	public unsafe float spawnPointSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnPointSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnPointSize)) = num;
		}
	}

	public unsafe Color spawnColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnColor)) = color;
		}
	}

	public unsafe Color raycastColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raycastColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raycastColor)) = color;
		}
	}

	public unsafe int currentSpawnIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSpawnIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSpawnIndex)) = num;
		}
	}

	static DeliverySpawnArea()
	{
		Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DeliverySpawnArea");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr);
		NativeFieldInfoPtr_gridSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "gridSize");
		NativeFieldInfoPtr_cellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "cellSize");
		NativeFieldInfoPtr_gridOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "gridOffset");
		NativeFieldInfoPtr_raycastStartHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "raycastStartHeight");
		NativeFieldInfoPtr_raycastDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "raycastDistance");
		NativeFieldInfoPtr_raycastLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "raycastLayers");
		NativeFieldInfoPtr_stackOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "stackOffset");
		NativeFieldInfoPtr_showGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "showGrid");
		NativeFieldInfoPtr_showRaycasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "showRaycasts");
		NativeFieldInfoPtr_showAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "showAxes");
		NativeFieldInfoPtr_spawnPointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "spawnPointSize");
		NativeFieldInfoPtr_spawnColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "spawnColor");
		NativeFieldInfoPtr_raycastColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "raycastColor");
		NativeFieldInfoPtr_currentSpawnIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, "currentSpawnIndex");
		NativeMethodInfoPtr_GetNextSpawnPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, 100665489);
		NativeMethodInfoPtr_SpawnObject_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, 100665490);
		NativeMethodInfoPtr_GetWorldPosition_Private_Vector3_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, 100665491);
		NativeMethodInfoPtr_ResetSpawnIndex_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, 100665492);
		NativeMethodInfoPtr_GetRandomSpawnPoint_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, 100665493);
		NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, 100665494);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, 100665495);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr, 100665496);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59779, RefRangeEnd = 59780, XrefRangeStart = 59763, XrefRangeEnd = 59779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetNextSpawnPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextSpawnPosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59780, XrefRangeEnd = 59783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnObject(GameObject obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnObject_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 59785, RefRangeEnd = 59787, XrefRangeStart = 59783, XrefRangeEnd = 59785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetWorldPosition(Vector3Int cellIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&cellIndex);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldPosition_Private_Vector3_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ResetSpawnIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetSpawnIndex_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59787, XrefRangeEnd = 59803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetRandomSpawnPoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomSpawnPoint_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59803, XrefRangeEnd = 59836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59836, XrefRangeEnd = 59840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DeliverySpawnArea()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliverySpawnArea>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DeliverySpawnArea(IntPtr pointer)
		: base(pointer)
	{
	}
}
