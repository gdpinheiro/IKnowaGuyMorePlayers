using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation;

public class RA2BoneCollisionHandlerBase : RagdollAnimator2BoneIndicator
{
	private static readonly IntPtr NativeFieldInfoPtr_Colliding;

	private static readonly IntPtr NativeFieldInfoPtr_UseSelfCollisions;

	private static readonly IntPtr NativeFieldInfoPtr_LastNonPhysicsCollisionTime;

	private static readonly IntPtr NativeFieldInfoPtr_Ignores;

	private static readonly IntPtr NativeMethodInfoPtr_EnableSavingEnteredCollisionsList_Public_Abstract_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsCollidingWith_Public_Abstract_Virtual_New_Boolean_Collider_0;

	private static readonly IntPtr NativeMethodInfoPtr_CollidesWithAnything_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetFirstCollidingCollider_Public_Abstract_Virtual_New_Collider_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartNonPhysicsCollision_Public_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTimeSinceLastNonPhysicsCollision_Public_Virtual_New_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe bool Colliding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Colliding);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Colliding)) = flag;
		}
	}

	public unsafe bool UseSelfCollisions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSelfCollisions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSelfCollisions)) = flag;
		}
	}

	public unsafe float LastNonPhysicsCollisionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastNonPhysicsCollisionTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastNonPhysicsCollisionTime)) = num;
		}
	}

	public unsafe List<Transform> Ignores
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ignores);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ignores)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static RA2BoneCollisionHandlerBase()
	{
		Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RA2BoneCollisionHandlerBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr);
		NativeFieldInfoPtr_Colliding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr, "Colliding");
		NativeFieldInfoPtr_UseSelfCollisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr, "UseSelfCollisions");
		NativeFieldInfoPtr_LastNonPhysicsCollisionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr, "LastNonPhysicsCollisionTime");
		NativeFieldInfoPtr_Ignores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr, "Ignores");
		NativeMethodInfoPtr_EnableSavingEnteredCollisionsList_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr, 100677157);
		NativeMethodInfoPtr_IsCollidingWith_Public_Abstract_Virtual_New_Boolean_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr, 100677158);
		NativeMethodInfoPtr_CollidesWithAnything_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr, 100677159);
		NativeMethodInfoPtr_GetFirstCollidingCollider_Public_Abstract_Virtual_New_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr, 100677160);
		NativeMethodInfoPtr_StartNonPhysicsCollision_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr, 100677161);
		NativeMethodInfoPtr_GetTimeSinceLastNonPhysicsCollision_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr, 100677162);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr, 100677163);
	}

	[CallerCount(0)]
	public unsafe virtual void EnableSavingEnteredCollisionsList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EnableSavingEnteredCollisionsList_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsCollidingWith(Collider collider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collider);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsCollidingWith_Public_Abstract_Virtual_New_Boolean_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool CollidesWithAnything()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CollidesWithAnything_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Collider GetFirstCollidingCollider()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetFirstCollidingCollider_Public_Abstract_Virtual_New_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232608, XrefRangeEnd = 232609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void StartNonPhysicsCollision()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_StartNonPhysicsCollision_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232609, XrefRangeEnd = 232610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float GetTimeSinceLastNonPhysicsCollision()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetTimeSinceLastNonPhysicsCollision_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232618, RefRangeEnd = 232620, XrefRangeStart = 232610, XrefRangeEnd = 232618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RA2BoneCollisionHandlerBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RA2BoneCollisionHandlerBase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RA2BoneCollisionHandlerBase(IntPtr pointer)
		: base(pointer)
	{
	}
}
