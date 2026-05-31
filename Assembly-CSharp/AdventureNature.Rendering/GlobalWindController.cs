using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace AdventureNature.Rendering;

public class GlobalWindController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_GlobalWindStrength;

	private static readonly IntPtr NativeFieldInfoPtr_DirectionalWindStrengthMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_DirectionalWindSpeedMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_WindDirection;

	private static readonly IntPtr NativeFieldInfoPtr_OmnidirectionalWindStrengthMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_OmnidirectionalWindSpeedMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_DetailWindMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_GradientTopToBottom;

	private static readonly IntPtr NativeFieldInfoPtr_WindSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_WindStrength;

	private static readonly IntPtr NativeFieldInfoPtr_TrunkCurvature;

	private static readonly IntPtr NativeFieldInfoPtr_EnableEditorVisualization;

	private static readonly IntPtr NativeFieldInfoPtr_ArrowModelPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_GizmoRadius;

	private static readonly IntPtr NativeFieldInfoPtr_GizmoColor;

	private static readonly IntPtr NativeFieldInfoPtr_arrowInstance;

	private static readonly IntPtr NativeFieldInfoPtr_lastWindDirection;

	private static readonly IntPtr NativeFieldInfoPtr_lastTransformY;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SyncWindAndTransform_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyGlobals_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateArrow_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float GlobalWindStrength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GlobalWindStrength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GlobalWindStrength)) = num;
		}
	}

	public unsafe float DirectionalWindStrengthMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalWindStrengthMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalWindStrengthMultiplier)) = num;
		}
	}

	public unsafe float DirectionalWindSpeedMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalWindSpeedMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalWindSpeedMultiplier)) = num;
		}
	}

	public unsafe float WindDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindDirection);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindDirection)) = num;
		}
	}

	public unsafe float OmnidirectionalWindStrengthMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OmnidirectionalWindStrengthMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OmnidirectionalWindStrengthMultiplier)) = num;
		}
	}

	public unsafe float OmnidirectionalWindSpeedMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OmnidirectionalWindSpeedMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OmnidirectionalWindSpeedMultiplier)) = num;
		}
	}

	public unsafe float DetailWindMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DetailWindMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DetailWindMultiplier)) = num;
		}
	}

	public unsafe Vector2 GradientTopToBottom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GradientTopToBottom);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GradientTopToBottom)) = vector;
		}
	}

	public unsafe float WindSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindSpeed)) = num;
		}
	}

	public unsafe float WindStrength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindStrength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindStrength)) = num;
		}
	}

	public unsafe float TrunkCurvature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TrunkCurvature);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TrunkCurvature)) = num;
		}
	}

	public unsafe bool EnableEditorVisualization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableEditorVisualization);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableEditorVisualization)) = flag;
		}
	}

	public unsafe GameObject ArrowModelPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ArrowModelPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ArrowModelPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float GizmoRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GizmoRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GizmoRadius)) = num;
		}
	}

	public unsafe Color GizmoColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GizmoColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GizmoColor)) = color;
		}
	}

	public unsafe GameObject arrowInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrowInstance);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrowInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float lastWindDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWindDirection);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWindDirection)) = num;
		}
	}

	public unsafe float lastTransformY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTransformY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTransformY)) = num;
		}
	}

	static GlobalWindController()
	{
		Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdventureNature.Rendering", "GlobalWindController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr);
		NativeFieldInfoPtr_GlobalWindStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "GlobalWindStrength");
		NativeFieldInfoPtr_DirectionalWindStrengthMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "DirectionalWindStrengthMultiplier");
		NativeFieldInfoPtr_DirectionalWindSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "DirectionalWindSpeedMultiplier");
		NativeFieldInfoPtr_WindDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "WindDirection");
		NativeFieldInfoPtr_OmnidirectionalWindStrengthMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "OmnidirectionalWindStrengthMultiplier");
		NativeFieldInfoPtr_OmnidirectionalWindSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "OmnidirectionalWindSpeedMultiplier");
		NativeFieldInfoPtr_DetailWindMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "DetailWindMultiplier");
		NativeFieldInfoPtr_GradientTopToBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "GradientTopToBottom");
		NativeFieldInfoPtr_WindSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "WindSpeed");
		NativeFieldInfoPtr_WindStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "WindStrength");
		NativeFieldInfoPtr_TrunkCurvature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "TrunkCurvature");
		NativeFieldInfoPtr_EnableEditorVisualization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "EnableEditorVisualization");
		NativeFieldInfoPtr_ArrowModelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "ArrowModelPrefab");
		NativeFieldInfoPtr_GizmoRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "GizmoRadius");
		NativeFieldInfoPtr_GizmoColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "GizmoColor");
		NativeFieldInfoPtr_arrowInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "arrowInstance");
		NativeFieldInfoPtr_lastWindDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "lastWindDirection");
		NativeFieldInfoPtr_lastTransformY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, "lastTransformY");
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, 100678044);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, 100678045);
		NativeMethodInfoPtr_SyncWindAndTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, 100678046);
		NativeMethodInfoPtr_ApplyGlobals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, 100678047);
		NativeMethodInfoPtr_UpdateArrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, 100678048);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr, 100678049);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243324, XrefRangeEnd = 243326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 243338, RefRangeEnd = 243340, XrefRangeStart = 243326, XrefRangeEnd = 243338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SyncWindAndTransform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncWindAndTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 243373, RefRangeEnd = 243375, XrefRangeStart = 243340, XrefRangeEnd = 243373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyGlobals()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyGlobals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17126)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 17126, XrefRangeStart = 0, XrefRangeEnd = 17126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateArrow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateArrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243375, XrefRangeEnd = 243376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlobalWindController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalWindController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GlobalWindController(IntPtr pointer)
		: base(pointer)
	{
	}
}
