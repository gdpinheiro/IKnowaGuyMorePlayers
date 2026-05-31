using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace FIMSpace.FProceduralAnimation;

public class RAF_BlendOnSourceCollision : RAF_BlendOnCollisions
{
	private static readonly IntPtr NativeMethodInfoPtr_InitIndicators_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCollisionHandler_Protected_Virtual_RA2BoneCollisionHandlerBase_RagdollChainBone_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static RAF_BlendOnSourceCollision()
	{
		Il2CppClassPointerStore<RAF_BlendOnSourceCollision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RAF_BlendOnSourceCollision");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RAF_BlendOnSourceCollision>.NativeClassPtr);
		NativeMethodInfoPtr_InitIndicators_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnSourceCollision>.NativeClassPtr, 100677545);
		NativeMethodInfoPtr_GetCollisionHandler_Protected_Virtual_RA2BoneCollisionHandlerBase_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnSourceCollision>.NativeClassPtr, 100677546);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnSourceCollision>.NativeClassPtr, 100677547);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236685, XrefRangeEnd = 236773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitIndicators()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitIndicators_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236773, XrefRangeEnd = 236777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override RA2BoneCollisionHandlerBase GetCollisionHandler(RagdollChainBone bone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCollisionHandler_Protected_Virtual_RA2BoneCollisionHandlerBase_RagdollChainBone_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RA2BoneCollisionHandlerBase>(intPtr) : null;
	}

	[CallerCount(42)]
	[CachedScanResults(RefRangeStart = 43568, RefRangeEnd = 43610, XrefRangeStart = 43568, XrefRangeEnd = 43610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RAF_BlendOnSourceCollision()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RAF_BlendOnSourceCollision>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RAF_BlendOnSourceCollision(IntPtr pointer)
		: base(pointer)
	{
	}
}
