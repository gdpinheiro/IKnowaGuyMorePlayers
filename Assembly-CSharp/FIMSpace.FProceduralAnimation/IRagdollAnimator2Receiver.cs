using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation;

public class IRagdollAnimator2Receiver : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_RagdollAnimator2_OnCollisionEnterEvent_Public_Abstract_Virtual_New_Void_RA2BoneCollisionHandler_Collision_0;

	static IRagdollAnimator2Receiver()
	{
		Il2CppClassPointerStore<IRagdollAnimator2Receiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "IRagdollAnimator2Receiver");
		NativeMethodInfoPtr_RagdollAnimator2_OnCollisionEnterEvent_Public_Abstract_Virtual_New_Void_RA2BoneCollisionHandler_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRagdollAnimator2Receiver>.NativeClassPtr, 100677236);
	}

	[CallerCount(0)]
	public unsafe virtual void RagdollAnimator2_OnCollisionEnterEvent(RA2BoneCollisionHandler hitted, UnityEngine.Collision mainCollision)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hitted);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mainCollision);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RagdollAnimator2_OnCollisionEnterEvent_Public_Abstract_Virtual_New_Void_RA2BoneCollisionHandler_Collision_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IRagdollAnimator2Receiver(IntPtr pointer)
		: base(pointer)
	{
	}
}
