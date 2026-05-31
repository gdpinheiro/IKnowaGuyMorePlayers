using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class FlyingCameraController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_baseSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_sprintMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_moveSmoothTime;

	private static readonly IntPtr NativeFieldInfoPtr_MinSmoothTime;

	private static readonly IntPtr NativeFieldInfoPtr_MaxSmoothTime;

	private static readonly IntPtr NativeFieldInfoPtr_SmoothTimeStep;

	private static readonly IntPtr NativeFieldInfoPtr_MinSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_MaxSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_SpeedScrollStep;

	private static readonly IntPtr NativeFieldInfoPtr_mouseSensitivity;

	private static readonly IntPtr NativeFieldInfoPtr_smoothLookSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_defaultFov;

	private static readonly IntPtr NativeFieldInfoPtr_currentFov;

	private static readonly IntPtr NativeFieldInfoPtr_MinFov;

	private static readonly IntPtr NativeFieldInfoPtr_MaxFov;

	private static readonly IntPtr NativeFieldInfoPtr_FovStep;

	private static readonly IntPtr NativeFieldInfoPtr_flyCamera;

	private static readonly IntPtr NativeFieldInfoPtr_yaw;

	private static readonly IntPtr NativeFieldInfoPtr_pitch;

	private static readonly IntPtr NativeFieldInfoPtr_targetYaw;

	private static readonly IntPtr NativeFieldInfoPtr_targetPitch;

	private static readonly IntPtr NativeFieldInfoPtr_currentVelocity;

	private static readonly IntPtr NativeFieldInfoPtr_smoothRef;

	private static readonly IntPtr NativeFieldInfoPtr_hudHidden;

	private static readonly IntPtr NativeFieldInfoPtr_playerCamera;

	private static readonly IntPtr NativeFieldInfoPtr_playerController;

	private static readonly IntPtr NativeFieldInfoPtr_wasMoveEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_wasLookEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_wasJumpEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Static_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Activate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleLook_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleMovement_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleSpeedScroll_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleFOV_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleSmoothing_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleHUDToggle_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateStatsUI_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ToggleFlyingOverlay_Private_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_FindLocalPlayerController_Private_Static_PlayerMovementController_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float baseSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseSpeed)) = num;
		}
	}

	public unsafe float speedMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMultiplier)) = num;
		}
	}

	public unsafe float sprintMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprintMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprintMultiplier)) = num;
		}
	}

	public unsafe float moveSmoothTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveSmoothTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveSmoothTime)) = num;
		}
	}

	public unsafe static float MinSmoothTime
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinSmoothTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinSmoothTime, (void*)(&num));
		}
	}

	public unsafe static float MaxSmoothTime
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxSmoothTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxSmoothTime, (void*)(&num));
		}
	}

	public unsafe static float SmoothTimeStep
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SmoothTimeStep, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SmoothTimeStep, (void*)(&num));
		}
	}

	public unsafe static float MinSpeed
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinSpeed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinSpeed, (void*)(&num));
		}
	}

	public unsafe static float MaxSpeed
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxSpeed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxSpeed, (void*)(&num));
		}
	}

	public unsafe static float SpeedScrollStep
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpeedScrollStep, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpeedScrollStep, (void*)(&num));
		}
	}

	public unsafe float mouseSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseSensitivity)) = num;
		}
	}

	public unsafe float smoothLookSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothLookSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothLookSpeed)) = num;
		}
	}

	public unsafe float defaultFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultFov);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultFov)) = num;
		}
	}

	public unsafe float currentFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFov);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFov)) = num;
		}
	}

	public unsafe static float MinFov
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinFov, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinFov, (void*)(&num));
		}
	}

	public unsafe static float MaxFov
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxFov, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxFov, (void*)(&num));
		}
	}

	public unsafe static float FovStep
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FovStep, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FovStep, (void*)(&num));
		}
	}

	public unsafe Camera flyCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flyCamera);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flyCamera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera));
		}
	}

	public unsafe float yaw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yaw);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yaw)) = num;
		}
	}

	public unsafe float pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitch)) = num;
		}
	}

	public unsafe float targetYaw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetYaw);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetYaw)) = num;
		}
	}

	public unsafe float targetPitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetPitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetPitch)) = num;
		}
	}

	public unsafe Vector3 currentVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVelocity)) = vector;
		}
	}

	public unsafe Vector3 smoothRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothRef);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothRef)) = vector;
		}
	}

	public unsafe bool hudHidden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hudHidden);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hudHidden)) = flag;
		}
	}

	public unsafe Camera playerCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCamera);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCamera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera));
		}
	}

	public unsafe PlayerMovementController playerController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerMovementController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerMovementController));
		}
	}

	public unsafe bool wasMoveEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasMoveEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasMoveEnabled)) = flag;
		}
	}

	public unsafe bool wasLookEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasLookEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasLookEnabled)) = flag;
		}
	}

	public unsafe bool wasJumpEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasJumpEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasJumpEnabled)) = flag;
		}
	}

	public unsafe static FlyingCameraController instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<FlyingCameraController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)flyingCameraController));
		}
	}

	public unsafe static bool IsActive
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 63557, RefRangeEnd = 63564, XrefRangeStart = 63545, XrefRangeEnd = 63557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsActive_Public_Static_get_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static FlyingCameraController()
	{
		Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlyingCameraController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr);
		NativeFieldInfoPtr_baseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "baseSpeed");
		NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "speedMultiplier");
		NativeFieldInfoPtr_sprintMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "sprintMultiplier");
		NativeFieldInfoPtr_moveSmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "moveSmoothTime");
		NativeFieldInfoPtr_MinSmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "MinSmoothTime");
		NativeFieldInfoPtr_MaxSmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "MaxSmoothTime");
		NativeFieldInfoPtr_SmoothTimeStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "SmoothTimeStep");
		NativeFieldInfoPtr_MinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "MinSpeed");
		NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "MaxSpeed");
		NativeFieldInfoPtr_SpeedScrollStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "SpeedScrollStep");
		NativeFieldInfoPtr_mouseSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "mouseSensitivity");
		NativeFieldInfoPtr_smoothLookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "smoothLookSpeed");
		NativeFieldInfoPtr_defaultFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "defaultFov");
		NativeFieldInfoPtr_currentFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "currentFov");
		NativeFieldInfoPtr_MinFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "MinFov");
		NativeFieldInfoPtr_MaxFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "MaxFov");
		NativeFieldInfoPtr_FovStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "FovStep");
		NativeFieldInfoPtr_flyCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "flyCamera");
		NativeFieldInfoPtr_yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "yaw");
		NativeFieldInfoPtr_pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "pitch");
		NativeFieldInfoPtr_targetYaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "targetYaw");
		NativeFieldInfoPtr_targetPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "targetPitch");
		NativeFieldInfoPtr_currentVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "currentVelocity");
		NativeFieldInfoPtr_smoothRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "smoothRef");
		NativeFieldInfoPtr_hudHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "hudHidden");
		NativeFieldInfoPtr_playerCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "playerCamera");
		NativeFieldInfoPtr_playerController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "playerController");
		NativeFieldInfoPtr_wasMoveEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "wasMoveEnabled");
		NativeFieldInfoPtr_wasLookEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "wasLookEnabled");
		NativeFieldInfoPtr_wasJumpEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "wasJumpEnabled");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, "instance");
		NativeMethodInfoPtr_get_IsActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665812);
		NativeMethodInfoPtr_Toggle_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665813);
		NativeMethodInfoPtr_Activate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665814);
		NativeMethodInfoPtr_Deactivate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665815);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665816);
		NativeMethodInfoPtr_HandleLook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665817);
		NativeMethodInfoPtr_HandleMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665818);
		NativeMethodInfoPtr_HandleSpeedScroll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665819);
		NativeMethodInfoPtr_HandleFOV_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665820);
		NativeMethodInfoPtr_HandleSmoothing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665821);
		NativeMethodInfoPtr_HandleHUDToggle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665822);
		NativeMethodInfoPtr_UpdateStatsUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665823);
		NativeMethodInfoPtr_ToggleFlyingOverlay_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665824);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665825);
		NativeMethodInfoPtr_FindLocalPlayerController_Private_Static_PlayerMovementController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665826);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr, 100665827);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63587, RefRangeEnd = 63588, XrefRangeStart = 63564, XrefRangeEnd = 63587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Toggle()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Toggle_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 63661, RefRangeEnd = 63663, XrefRangeStart = 63588, XrefRangeEnd = 63661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Activate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Activate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 63702, RefRangeEnd = 63704, XrefRangeStart = 63663, XrefRangeEnd = 63702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deactivate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deactivate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63704, XrefRangeEnd = 63736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63736, XrefRangeEnd = 63743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleLook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleLook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63743, XrefRangeEnd = 63775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleMovement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63775, XrefRangeEnd = 63783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleSpeedScroll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleSpeedScroll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63783, XrefRangeEnd = 63792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleFOV()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleFOV_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63792, XrefRangeEnd = 63798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleSmoothing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleSmoothing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63798, XrefRangeEnd = 63803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleHUDToggle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleHUDToggle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63803, XrefRangeEnd = 63853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateStatsUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateStatsUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63887, RefRangeEnd = 63888, XrefRangeStart = 63853, XrefRangeEnd = 63887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleFlyingOverlay(bool visible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&visible);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleFlyingOverlay_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63888, XrefRangeEnd = 63899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63935, RefRangeEnd = 63936, XrefRangeStart = 63899, XrefRangeEnd = 63935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayerMovementController FindLocalPlayerController()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindLocalPlayerController_Private_Static_PlayerMovementController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerMovementController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63936, XrefRangeEnd = 63937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FlyingCameraController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlyingCameraController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FlyingCameraController(IntPtr pointer)
		: base(pointer)
	{
	}
}
