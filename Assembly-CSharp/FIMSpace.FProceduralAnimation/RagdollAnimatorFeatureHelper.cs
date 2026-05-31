using System;
using System.Runtime.CompilerServices;
using FIMSpace.FGenerating;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FIMSpace.FProceduralAnimation;

[System.Serializable]
public class RagdollAnimatorFeatureHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CustomName;

	private static readonly System.IntPtr NativeFieldInfoPtr_enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_handler;

	private static readonly System.IntPtr NativeFieldInfoPtr_FeatureReference;

	private static readonly System.IntPtr NativeFieldInfoPtr__RuntimeFeature_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_customStringList;

	private static readonly System.IntPtr NativeFieldInfoPtr_customObjectList;

	private static readonly System.IntPtr NativeFieldInfoPtr_customEventsList;

	private static readonly System.IntPtr NativeFieldInfoPtr_variables;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentRagdollHandler_Public_get_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RuntimeFeature_Public_get_RagdollAnimatorFeatureBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RuntimeFeature_Private_set_Void_RagdollAnimatorFeatureBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveFeature_Public_get_RagdollAnimatorFeatureBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreparePlaymodeModule_Public_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeRagdollFeature_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestVariable_Public_FUniversalVariable_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasVariable_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopySettingsFrom_Public_Void_RagdollAnimatorFeatureHelper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string CustomName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool enabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled)) = flag;
		}
	}

	public unsafe RagdollHandler handler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollHandler));
		}
	}

	public unsafe RagdollAnimatorFeatureBase FeatureReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FeatureReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollAnimatorFeatureBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FeatureReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollAnimatorFeatureBase));
		}
	}

	public unsafe RagdollAnimatorFeatureBase _RuntimeFeature_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RuntimeFeature_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollAnimatorFeatureBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RuntimeFeature_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollAnimatorFeatureBase));
		}
	}

	public unsafe List<string> customStringList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customStringList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customStringList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<UnityEngine.Object> customObjectList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customObjectList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UnityEngine.Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customObjectList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<UnityEvent> customEventsList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customEventsList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UnityEvent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customEventsList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FUniversalVariable> variables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FUniversalVariable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool Enabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 235577, RefRangeEnd = 235592, XrefRangeStart = 235573, XrefRangeEnd = 235577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe RagdollHandler ParentRagdollHandler
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 43540, RefRangeEnd = 43551, XrefRangeStart = 43540, XrefRangeEnd = 43551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentRagdollHandler_Public_get_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollHandler>(intPtr) : null;
		}
	}

	public unsafe RagdollAnimatorFeatureBase RuntimeFeature
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 43149, RefRangeEnd = 43165, XrefRangeStart = 43149, XrefRangeEnd = 43165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RuntimeFeature_Public_get_RagdollAnimatorFeatureBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollAnimatorFeatureBase>(intPtr) : null;
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 232707, RefRangeEnd = 232714, XrefRangeStart = 232707, XrefRangeEnd = 232714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RuntimeFeature_Private_set_Void_RagdollAnimatorFeatureBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe RagdollAnimatorFeatureBase ActiveFeature
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 43149, RefRangeEnd = 43165, XrefRangeStart = 43149, XrefRangeEnd = 43165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActiveFeature_Public_get_RagdollAnimatorFeatureBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollAnimatorFeatureBase>(intPtr) : null;
		}
	}

	static RagdollAnimatorFeatureHelper()
	{
		Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RagdollAnimatorFeatureHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr);
		NativeFieldInfoPtr_CustomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, "CustomName");
		NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, "enabled");
		NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, "handler");
		NativeFieldInfoPtr_FeatureReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, "FeatureReference");
		NativeFieldInfoPtr__RuntimeFeature_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, "<RuntimeFeature>k__BackingField");
		NativeFieldInfoPtr_customStringList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, "customStringList");
		NativeFieldInfoPtr_customObjectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, "customObjectList");
		NativeFieldInfoPtr_customEventsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, "customEventsList");
		NativeFieldInfoPtr_variables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, "variables");
		NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677491);
		NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677492);
		NativeMethodInfoPtr_get_ParentRagdollHandler_Public_get_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677493);
		NativeMethodInfoPtr_get_RuntimeFeature_Public_get_RagdollAnimatorFeatureBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677494);
		NativeMethodInfoPtr_set_RuntimeFeature_Private_set_Void_RagdollAnimatorFeatureBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677495);
		NativeMethodInfoPtr_get_ActiveFeature_Public_get_RagdollAnimatorFeatureBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677496);
		NativeMethodInfoPtr_Init_Internal_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677497);
		NativeMethodInfoPtr_PreparePlaymodeModule_Public_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677498);
		NativeMethodInfoPtr_DisposeRagdollFeature_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677499);
		NativeMethodInfoPtr_RequestVariable_Public_FUniversalVariable_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677500);
		NativeMethodInfoPtr_HasVariable_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677501);
		NativeMethodInfoPtr_CopySettingsFrom_Public_Void_RagdollAnimatorFeatureHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677502);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr, 100677503);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235612, RefRangeEnd = 235614, XrefRangeStart = 235592, XrefRangeEnd = 235612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(RagdollHandler handler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235614, XrefRangeEnd = 235629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreparePlaymodeModule(RagdollHandler parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreparePlaymodeModule_Public_Void_RagdollHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235638, RefRangeEnd = 235640, XrefRangeStart = 235629, XrefRangeEnd = 235638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeRagdollFeature()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeRagdollFeature_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(95)]
	[CachedScanResults(RefRangeStart = 235657, RefRangeEnd = 235752, XrefRangeStart = 235640, XrefRangeEnd = 235657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FUniversalVariable RequestVariable(string name, Il2CppSystem.Object defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultValue);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestVariable_Public_FUniversalVariable_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235752, XrefRangeEnd = 235758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasVariable(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasVariable_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235758, XrefRangeEnd = 235786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopySettingsFrom(RagdollAnimatorFeatureHelper copyFrom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopySettingsFrom_Public_Void_RagdollAnimatorFeatureHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235798, RefRangeEnd = 235799, XrefRangeStart = 235786, XrefRangeEnd = 235798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollAnimatorFeatureHelper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollAnimatorFeatureHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RagdollAnimatorFeatureHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
