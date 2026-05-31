using System;
using System.Runtime.CompilerServices;
using FIMSpace.FGenerating;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace FIMSpace.FProceduralAnimation;

public class RAF_PoseManipulator : RagdollAnimatorFeatureUpdate
{
	private static readonly IntPtr NativeFieldInfoPtr_tolerMinV;

	private static readonly IntPtr NativeFieldInfoPtr_tolerMaxV;

	private static readonly IntPtr NativeFieldInfoPtr_addDampV;

	private static readonly IntPtr NativeFieldInfoPtr_springChangeV;

	private static readonly IntPtr NativeFieldInfoPtr_reverseLogicV;

	private static readonly IntPtr NativeMethodInfoPtr_get_UseFixedUpdate_Public_Virtual_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBaseSpringValue_Private_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPowerMultiplicator_Private_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe FUniversalVariable tolerMinV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tolerMinV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tolerMinV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable tolerMaxV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tolerMaxV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tolerMaxV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable addDampV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addDampV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addDampV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable springChangeV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springChangeV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springChangeV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable reverseLogicV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverseLogicV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverseLogicV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe override bool UseFixedUpdate
	{
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 26835, RefRangeEnd = 26870, XrefRangeStart = 26835, XrefRangeEnd = 26870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_UseFixedUpdate_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static RAF_PoseManipulator()
	{
		Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RAF_PoseManipulator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr);
		NativeFieldInfoPtr_tolerMinV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr, "tolerMinV");
		NativeFieldInfoPtr_tolerMaxV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr, "tolerMaxV");
		NativeFieldInfoPtr_addDampV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr, "addDampV");
		NativeFieldInfoPtr_springChangeV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr, "springChangeV");
		NativeFieldInfoPtr_reverseLogicV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr, "reverseLogicV");
		NativeMethodInfoPtr_get_UseFixedUpdate_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr, 100677661);
		NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr, 100677662);
		NativeMethodInfoPtr_FixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr, 100677663);
		NativeMethodInfoPtr_GetBaseSpringValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr, 100677664);
		NativeMethodInfoPtr_GetPowerMultiplicator_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr, 100677665);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr, 100677666);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238589, XrefRangeEnd = 238620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238620, XrefRangeEnd = 238684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238684, XrefRangeEnd = 238691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBaseSpringValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseSpringValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238691, XrefRangeEnd = 238693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPowerMultiplicator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPowerMultiplicator_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RAF_PoseManipulator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RAF_PoseManipulator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RAF_PoseManipulator(IntPtr pointer)
		: base(pointer)
	{
	}
}
