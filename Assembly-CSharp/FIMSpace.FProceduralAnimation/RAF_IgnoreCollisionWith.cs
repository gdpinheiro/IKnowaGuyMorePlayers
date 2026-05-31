using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace FIMSpace.FProceduralAnimation;

public class RAF_IgnoreCollisionWith : RagdollAnimatorFeatureBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static RAF_IgnoreCollisionWith()
	{
		Il2CppClassPointerStore<RAF_IgnoreCollisionWith>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RAF_IgnoreCollisionWith");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RAF_IgnoreCollisionWith>.NativeClassPtr);
		NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_IgnoreCollisionWith>.NativeClassPtr, 100677631);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_IgnoreCollisionWith>.NativeClassPtr, 100677632);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238078, XrefRangeEnd = 238093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238093, XrefRangeEnd = 238094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RAF_IgnoreCollisionWith()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RAF_IgnoreCollisionWith>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RAF_IgnoreCollisionWith(IntPtr pointer)
		: base(pointer)
	{
	}
}
