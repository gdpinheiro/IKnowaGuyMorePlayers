using System;
using System.Runtime.CompilerServices;
using FIMSpace.FGenerating;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace FIMSpace.FProceduralAnimation;

public class RAF_SwitchAttachable : RagdollAnimatorFeatureBase
{
	private static readonly IntPtr NativeFieldInfoPtr_attachableV;

	private static readonly IntPtr NativeFieldInfoPtr_parentV;

	private static readonly IntPtr NativeFieldInfoPtr_attached;

	private static readonly IntPtr NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshAttachableState_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe FUniversalVariable attachableV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachableV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachableV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable parentV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentV);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe RA2AttachableObject attached
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attached);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RA2AttachableObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attached)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rA2AttachableObject));
		}
	}

	static RAF_SwitchAttachable()
	{
		Il2CppClassPointerStore<RAF_SwitchAttachable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RAF_SwitchAttachable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RAF_SwitchAttachable>.NativeClassPtr);
		NativeFieldInfoPtr_attachableV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_SwitchAttachable>.NativeClassPtr, "attachableV");
		NativeFieldInfoPtr_parentV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_SwitchAttachable>.NativeClassPtr, "parentV");
		NativeFieldInfoPtr_attached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_SwitchAttachable>.NativeClassPtr, "attached");
		NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_SwitchAttachable>.NativeClassPtr, 100677697);
		NativeMethodInfoPtr_RefreshAttachableState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_SwitchAttachable>.NativeClassPtr, 100677698);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_SwitchAttachable>.NativeClassPtr, 100677699);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238883, XrefRangeEnd = 238893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool OnInit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238919, RefRangeEnd = 238920, XrefRangeStart = 238893, XrefRangeEnd = 238919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshAttachableState(bool logIfNullParent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&logIfNullParent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshAttachableState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RAF_SwitchAttachable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RAF_SwitchAttachable>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RAF_SwitchAttachable(IntPtr pointer)
		: base(pointer)
	{
	}
}
