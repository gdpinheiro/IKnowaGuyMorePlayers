using System;
using System.Runtime.CompilerServices;
using FIMSpace.FGenerating;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation;

public class RAF_FallGetUpAnimate : RagdollAnimatorFeatureBase
{
	private static readonly IntPtr NativeFieldInfoPtr_springPowerOnFallV;

	private static readonly IntPtr NativeFieldInfoPtr_durationV;

	private static readonly IntPtr NativeFieldInfoPtr_fallClipNameV;

	private static readonly IntPtr NativeFieldInfoPtr_fallTransitionV;

	private static readonly IntPtr NativeFieldInfoPtr_fallStateLayerV;

	private static readonly IntPtr NativeFieldInfoPtr_onFallEventV;

	private static readonly IntPtr NativeFieldInfoPtr_getUpFacedownClipNameV;

	private static readonly IntPtr NativeFieldInfoPtr_getUpFromBackClipNameV;

	private static readonly IntPtr NativeFieldInfoPtr_getUpCrossfadeV;

	private static readonly IntPtr NativeFieldInfoPtr_getUpAnimatorLayer;

	private static readonly IntPtr NativeFieldInfoPtr_getUpEventV;

	private static readonly IntPtr NativeFieldInfoPtr_ragdolledPropertyV;

	private static readonly IntPtr NativeFieldInfoPtr_repositionBaseTransformV;

	private static readonly IntPtr NativeFieldInfoPtr_findRigidbodyV;

	private static readonly IntPtr NativeFieldInfoPtr_bodyVelocityV;

	private static readonly IntPtr NativeFieldInfoPtr_supportGetupRestoreV;

	private static readonly IntPtr NativeFieldInfoPtr_getupRestoreClipStateV;

	private static readonly IntPtr NativeFieldInfoPtr_getupRestoreReposeV;

	private static readonly IntPtr NativeFieldInfoPtr_modeV;

	private static readonly IntPtr NativeFieldInfoPtr__ragProperty;

	private static readonly IntPtr NativeFieldInfoPtr__fallClipState;

	private static readonly IntPtr NativeFieldInfoPtr__getupFaceState;

	private static readonly IntPtr NativeFieldInfoPtr__getupBackState;

	private static readonly IntPtr NativeFieldInfoPtr__h_velocity;

	private static readonly IntPtr NativeFieldInfoPtr__restoreState;

	private static readonly IntPtr NativeFieldInfoPtr_ClipTimePlayOffset;

	private static readonly IntPtr NativeFieldInfoPtr_groundHit;

	private static readonly IntPtr NativeFieldInfoPtr_characterRigidbody;

	private static readonly IntPtr NativeFieldInfoPtr_getupType;

	private static readonly IntPtr NativeFieldInfoPtr__sd;

	private static readonly IntPtr NativeFieldInfoPtr__sdVelo;

	private static readonly IntPtr NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroyFeature_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnFallStateChange_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshHashes_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalculateHash_Private_Void_FUniversalVariable_byref_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyOnFallSwitches_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyOnGetUpSwitches_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CallGetUpAnimation_Protected_Void_RagdollHandler_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlayGetUpAnimation_Protected_Virtual_New_Void_RagdollHandler_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlayOnFallAnimation_Protected_Virtual_New_Void_RagdollHandler_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateFeature_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SmoothChangeSpringsValueOnFall_Private_Void_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshHelperEvents_Private_Boolean_RagdollAnimatorFeatureHelper_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe FUniversalVariable springPowerOnFallV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springPowerOnFallV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springPowerOnFallV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable durationV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_durationV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_durationV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable fallClipNameV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallClipNameV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallClipNameV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable fallTransitionV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallTransitionV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallTransitionV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable fallStateLayerV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallStateLayerV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallStateLayerV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable onFallEventV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFallEventV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFallEventV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable getUpFacedownClipNameV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpFacedownClipNameV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpFacedownClipNameV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable getUpFromBackClipNameV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpFromBackClipNameV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpFromBackClipNameV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable getUpCrossfadeV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpCrossfadeV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpCrossfadeV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable getUpAnimatorLayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpAnimatorLayer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpAnimatorLayer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable getUpEventV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpEventV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpEventV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable ragdolledPropertyV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdolledPropertyV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdolledPropertyV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable repositionBaseTransformV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repositionBaseTransformV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repositionBaseTransformV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable findRigidbodyV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_findRigidbodyV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_findRigidbodyV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable bodyVelocityV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyVelocityV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyVelocityV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable supportGetupRestoreV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportGetupRestoreV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportGetupRestoreV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable getupRestoreClipStateV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getupRestoreClipStateV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getupRestoreClipStateV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable getupRestoreReposeV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getupRestoreReposeV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getupRestoreReposeV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable modeV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modeV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modeV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe int _ragProperty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ragProperty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ragProperty)) = num;
		}
	}

	public unsafe int _fallClipState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fallClipState);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fallClipState)) = num;
		}
	}

	public unsafe int _getupFaceState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__getupFaceState);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__getupFaceState)) = num;
		}
	}

	public unsafe int _getupBackState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__getupBackState);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__getupBackState)) = num;
		}
	}

	public unsafe int _h_velocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__h_velocity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__h_velocity)) = num;
		}
	}

	public unsafe int _restoreState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreState);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreState)) = num;
		}
	}

	public unsafe float ClipTimePlayOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClipTimePlayOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClipTimePlayOffset)) = num;
		}
	}

	public unsafe RaycastHit groundHit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundHit);
			return *(RaycastHit*)num;
		}
		set
		{
			*(RaycastHit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundHit)) = raycastHit;
		}
	}

	public unsafe Rigidbody characterRigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterRigidbody);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterRigidbody)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody));
		}
	}

	public unsafe ERagdollGetUpType getupType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getupType);
			return *(ERagdollGetUpType*)num;
		}
		set
		{
			*(ERagdollGetUpType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getupType)) = eRagdollGetUpType;
		}
	}

	public unsafe float _sd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sd)) = num;
		}
	}

	public unsafe float _sdVelo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sdVelo);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sdVelo)) = num;
		}
	}

	static RAF_FallGetUpAnimate()
	{
		Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RAF_FallGetUpAnimate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr);
		NativeFieldInfoPtr_springPowerOnFallV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "springPowerOnFallV");
		NativeFieldInfoPtr_durationV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "durationV");
		NativeFieldInfoPtr_fallClipNameV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "fallClipNameV");
		NativeFieldInfoPtr_fallTransitionV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "fallTransitionV");
		NativeFieldInfoPtr_fallStateLayerV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "fallStateLayerV");
		NativeFieldInfoPtr_onFallEventV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "onFallEventV");
		NativeFieldInfoPtr_getUpFacedownClipNameV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "getUpFacedownClipNameV");
		NativeFieldInfoPtr_getUpFromBackClipNameV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "getUpFromBackClipNameV");
		NativeFieldInfoPtr_getUpCrossfadeV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "getUpCrossfadeV");
		NativeFieldInfoPtr_getUpAnimatorLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "getUpAnimatorLayer");
		NativeFieldInfoPtr_getUpEventV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "getUpEventV");
		NativeFieldInfoPtr_ragdolledPropertyV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "ragdolledPropertyV");
		NativeFieldInfoPtr_repositionBaseTransformV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "repositionBaseTransformV");
		NativeFieldInfoPtr_findRigidbodyV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "findRigidbodyV");
		NativeFieldInfoPtr_bodyVelocityV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "bodyVelocityV");
		NativeFieldInfoPtr_supportGetupRestoreV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "supportGetupRestoreV");
		NativeFieldInfoPtr_getupRestoreClipStateV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "getupRestoreClipStateV");
		NativeFieldInfoPtr_getupRestoreReposeV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "getupRestoreReposeV");
		NativeFieldInfoPtr_modeV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "modeV");
		NativeFieldInfoPtr__ragProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "_ragProperty");
		NativeFieldInfoPtr__fallClipState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "_fallClipState");
		NativeFieldInfoPtr__getupFaceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "_getupFaceState");
		NativeFieldInfoPtr__getupBackState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "_getupBackState");
		NativeFieldInfoPtr__h_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "_h_velocity");
		NativeFieldInfoPtr__restoreState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "_restoreState");
		NativeFieldInfoPtr_ClipTimePlayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "ClipTimePlayOffset");
		NativeFieldInfoPtr_groundHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "groundHit");
		NativeFieldInfoPtr_characterRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "characterRigidbody");
		NativeFieldInfoPtr_getupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "getupType");
		NativeFieldInfoPtr__sd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "_sd");
		NativeFieldInfoPtr__sdVelo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, "_sdVelo");
		NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677596);
		NativeMethodInfoPtr_OnDestroyFeature_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677597);
		NativeMethodInfoPtr_OnFallStateChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677598);
		NativeMethodInfoPtr_RefreshHashes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677599);
		NativeMethodInfoPtr_CalculateHash_Private_Void_FUniversalVariable_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677600);
		NativeMethodInfoPtr_ApplyOnFallSwitches_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677601);
		NativeMethodInfoPtr_ApplyOnGetUpSwitches_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677602);
		NativeMethodInfoPtr_CallGetUpAnimation_Protected_Void_RagdollHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677603);
		NativeMethodInfoPtr_PlayGetUpAnimation_Protected_Virtual_New_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677604);
		NativeMethodInfoPtr_PlayOnFallAnimation_Protected_Virtual_New_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677605);
		NativeMethodInfoPtr_UpdateFeature_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677606);
		NativeMethodInfoPtr_SmoothChangeSpringsValueOnFall_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677607);
		NativeMethodInfoPtr_RefreshHelperEvents_Private_Boolean_RagdollAnimatorFeatureHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677608);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr, 100677609);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237353, XrefRangeEnd = 237496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool OnInit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237496, XrefRangeEnd = 237510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDestroyFeature()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDestroyFeature_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237510, XrefRangeEnd = 237516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFallStateChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFallStateChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237516, XrefRangeEnd = 237533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshHashes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshHashes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237533, XrefRangeEnd = 237535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateHash(FUniversalVariable variable, ref int hash)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)variable);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref hash);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateHash_Private_Void_FUniversalVariable_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ApplyOnFallSwitches()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyOnFallSwitches_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237535, XrefRangeEnd = 237606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyOnGetUpSwitches()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyOnGetUpSwitches_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237610, RefRangeEnd = 237611, XrefRangeStart = 237606, XrefRangeEnd = 237610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CallGetUpAnimation(RagdollHandler handler, int getupHash)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &getupHash;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallGetUpAnimation_Protected_Void_RagdollHandler_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237611, XrefRangeEnd = 237613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PlayGetUpAnimation(RagdollHandler handler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PlayGetUpAnimation_Protected_Virtual_New_Void_RagdollHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237613, XrefRangeEnd = 237622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PlayOnFallAnimation(RagdollHandler handler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PlayOnFallAnimation_Protected_Virtual_New_Void_RagdollHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237622, XrefRangeEnd = 237647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFeature()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFeature_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237658, RefRangeEnd = 237660, XrefRangeStart = 237647, XrefRangeEnd = 237658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SmoothChangeSpringsValueOnFall(float to, float duration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&to);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &duration;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothChangeSpringsValueOnFall_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237660, XrefRangeEnd = 237677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RefreshHelperEvents(RagdollAnimatorFeatureHelper helper)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)helper);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshHelperEvents_Private_Boolean_RagdollAnimatorFeatureHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237677, XrefRangeEnd = 237678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RAF_FallGetUpAnimate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RAF_FallGetUpAnimate>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RAF_FallGetUpAnimate(IntPtr pointer)
		: base(pointer)
	{
	}
}
