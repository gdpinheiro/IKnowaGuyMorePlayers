using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation;

public static class RagdollHandlerUtilities : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__33_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__79_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__79_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__79_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__100_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_FreezeAndDestroyRagdollDummy_b__33_0_Internal_Void_RagdollChainBone_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimator_b__79_0_Internal_Void_RagdollChainBone_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimator_b__79_1_Internal_Void_RagdollChainBone_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimator_b__79_2_Internal_Void_InBetweenBone_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_ResetAngularVelocityForAllBones_b__100_0_Internal_Void_RagdollChainBone_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Action<RagdollChainBone> __9__33_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RagdollChainBone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__33_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe static Il2CppSystem.Action<RagdollChainBone> __9__79_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__79_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RagdollChainBone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__79_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe static Il2CppSystem.Action<RagdollChainBone> __9__79_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__79_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RagdollChainBone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__79_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe static Il2CppSystem.Action<RagdollChainBone.InBetweenBone> __9__79_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__79_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RagdollChainBone.InBetweenBone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__79_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe static Il2CppSystem.Action<RagdollChainBone> __9__100_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__100_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RagdollChainBone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__100_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__33_0");
			NativeFieldInfoPtr___9__79_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__79_0");
			NativeFieldInfoPtr___9__79_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__79_1");
			NativeFieldInfoPtr___9__79_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__79_2");
			NativeFieldInfoPtr___9__100_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__100_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100677403);
			NativeMethodInfoPtr__User_FreezeAndDestroyRagdollDummy_b__33_0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100677404);
			NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimator_b__79_0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100677405);
			NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimator_b__79_1_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100677406);
			NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimator_b__79_2_Internal_Void_InBetweenBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100677407);
			NativeMethodInfoPtr__User_ResetAngularVelocityForAllBones_b__100_0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100677408);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233213, XrefRangeEnd = 233216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_FreezeAndDestroyRagdollDummy_b__33_0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_FreezeAndDestroyRagdollDummy_b__33_0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233216, XrefRangeEnd = 233221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_ForceMatchPhysicalBonesWithAnimator_b__79_0(RagdollChainBone b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimator_b__79_0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233221, XrefRangeEnd = 233226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_ForceMatchPhysicalBonesWithAnimator_b__79_1(RagdollChainBone b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimator_b__79_1_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233226, XrefRangeEnd = 233228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_ForceMatchPhysicalBonesWithAnimator_b__79_2(RagdollChainBone.InBetweenBone b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimator_b__79_2_Internal_Void_InBetweenBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233228, XrefRangeEnd = 233231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_ResetAngularVelocityForAllBones_b__100_0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_ResetAngularVelocityForAllBones_b__100_0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass101_0")]
	public sealed class __c__DisplayClass101_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_angularSpeedLimit;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_SetAllAngularSpeedLimit_b__0_Internal_Void_RagdollChainBone_0;

		public unsafe float angularSpeedLimit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularSpeedLimit);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularSpeedLimit)) = num;
			}
		}

		static __c__DisplayClass101_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass101_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass101_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass101_0>.NativeClassPtr);
			NativeFieldInfoPtr_angularSpeedLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass101_0>.NativeClassPtr, "angularSpeedLimit");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass101_0>.NativeClassPtr, 100677409);
			NativeMethodInfoPtr__User_SetAllAngularSpeedLimit_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass101_0>.NativeClassPtr, 100677410);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass101_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass101_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233231, XrefRangeEnd = 233233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_SetAllAngularSpeedLimit_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_SetAllAngularSpeedLimit_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass101_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass102_0")]
	public sealed class __c__DisplayClass102_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_interpolation;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_SetAllIterpolation_b__0_Internal_Void_RagdollChainBone_0;

		public unsafe RigidbodyInterpolation interpolation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interpolation);
				return *(RigidbodyInterpolation*)num;
			}
			set
			{
				*(RigidbodyInterpolation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interpolation)) = rigidbodyInterpolation;
			}
		}

		static __c__DisplayClass102_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass102_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr);
			NativeFieldInfoPtr_interpolation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr, "interpolation");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr, 100677411);
			NativeMethodInfoPtr__User_SetAllIterpolation_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr, 100677412);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass102_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233233, XrefRangeEnd = 233235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_SetAllIterpolation_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_SetAllIterpolation_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass102_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass25_0")]
	public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_iHandler;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_DisableMecanimAfter_b__0_Internal_Void_0;

		public unsafe IRagdollAnimator2HandlerOwner iHandler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iHandler);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IRagdollAnimator2HandlerOwner>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollAnimator2HandlerOwner));
			}
		}

		static __c__DisplayClass25_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass25_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr);
			NativeFieldInfoPtr_iHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, "iHandler");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, 100677413);
			NativeMethodInfoPtr__User_DisableMecanimAfter_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, 100677414);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass25_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233235, XrefRangeEnd = 233245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_DisableMecanimAfter_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_DisableMecanimAfter_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass25_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass31_0")]
	public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3 pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector;
			}
		}

		static __c__DisplayClass31_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass31_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr);
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr, "pos");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr, 100677415);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass31_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass31_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass31_1")]
	public sealed class __c__DisplayClass31_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_nearestDist;

		private static readonly System.IntPtr NativeFieldInfoPtr_nearestB;

		private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass31_0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_GetNearestRagdollBoneControllerToPosition_b__0_Internal_Void_RagdollChainBone_0;

		public unsafe float nearestDist
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearestDist);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearestDist)) = num;
			}
		}

		public unsafe RagdollChainBone nearestB
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearestB);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearestB)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollChainBone));
			}
		}

		public unsafe __c__DisplayClass31_0 field_Public___c__DisplayClass31_0_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass31_0_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass31_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass31_0_0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass31_));
			}
		}

		static __c__DisplayClass31_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass31_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass31_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass31_1>.NativeClassPtr);
			NativeFieldInfoPtr_nearestDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass31_1>.NativeClassPtr, "nearestDist");
			NativeFieldInfoPtr_nearestB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass31_1>.NativeClassPtr, "nearestB");
			NativeFieldInfoPtr_field_Public___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass31_1>.NativeClassPtr, "CS$<>8__locals1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass31_1>.NativeClassPtr, 100677416);
			NativeMethodInfoPtr__User_GetNearestRagdollBoneControllerToPosition_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass31_1>.NativeClassPtr, 100677417);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass31_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass31_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233245, XrefRangeEnd = 233247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_GetNearestRagdollBoneControllerToPosition_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_GetNearestRagdollBoneControllerToPosition_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass31_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass31_2")]
	public sealed class __c__DisplayClass31_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_nearestB;

		private static readonly System.IntPtr NativeFieldInfoPtr_nearestDist;

		private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass31_0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_GetNearestRagdollBoneControllerToPosition_b__1_Internal_Void_RagdollChainBone_0;

		public unsafe RagdollChainBone nearestB
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearestB);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearestB)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollChainBone));
			}
		}

		public unsafe float nearestDist
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearestDist);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearestDist)) = num;
			}
		}

		public unsafe __c__DisplayClass31_0 field_Public___c__DisplayClass31_0_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass31_0_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass31_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass31_0_0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass31_));
			}
		}

		static __c__DisplayClass31_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass31_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass31_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass31_2>.NativeClassPtr);
			NativeFieldInfoPtr_nearestB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass31_2>.NativeClassPtr, "nearestB");
			NativeFieldInfoPtr_nearestDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass31_2>.NativeClassPtr, "nearestDist");
			NativeFieldInfoPtr_field_Public___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass31_2>.NativeClassPtr, "CS$<>8__locals2");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass31_2>.NativeClassPtr, 100677418);
			NativeMethodInfoPtr__User_GetNearestRagdollBoneControllerToPosition_b__1_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass31_2>.NativeClassPtr, 100677419);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass31_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass31_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233247, XrefRangeEnd = 233250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_GetNearestRagdollBoneControllerToPosition_b__1(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_GetNearestRagdollBoneControllerToPosition_b__1_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass31_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass34_0")]
	public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rigs;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_GetAllRigidbodies_b__0_Internal_Void_RagdollChainBone_0;

		public unsafe List<Rigidbody> rigs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigs);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Rigidbody>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static __c__DisplayClass34_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass34_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr);
			NativeFieldInfoPtr_rigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, "rigs");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, 100677420);
			NativeMethodInfoPtr__User_GetAllRigidbodies_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, 100677421);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass34_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233250, XrefRangeEnd = 233256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_GetAllRigidbodies_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_GetAllRigidbodies_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass34_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass35_0")]
	public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_bones;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_GetAllRagdollDummyBoneSetups_b__0_Internal_Void_RagdollChainBone_0;

		public unsafe List<RagdollChainBone> bones
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bones);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RagdollChainBone>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static __c__DisplayClass35_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass35_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr);
			NativeFieldInfoPtr_bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr, "bones");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr, 100677422);
			NativeMethodInfoPtr__User_GetAllRagdollDummyBoneSetups_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr, 100677423);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass35_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass35_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233256, XrefRangeEnd = 233262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_GetAllRagdollDummyBoneSetups_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_GetAllRagdollDummyBoneSetups_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass35_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass41_0")]
	public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_handler;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_Teleport_b__0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_Teleport_b__1_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_Teleport_b__2_Internal_Void_0;

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

		static __c__DisplayClass41_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass41_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr);
			NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, "handler");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, 100677424);
			NativeMethodInfoPtr__User_Teleport_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, 100677425);
			NativeMethodInfoPtr__User_Teleport_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, 100677426);
			NativeMethodInfoPtr__User_Teleport_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, 100677427);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass41_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233262, XrefRangeEnd = 233270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_Teleport_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_Teleport_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_Teleport_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_Teleport_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233270, XrefRangeEnd = 233293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_Teleport_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_Teleport_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass41_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass80_0")]
	public sealed class __c__DisplayClass80_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_handler;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimatorKinematic_b__0_Internal_Void_0;

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

		static __c__DisplayClass80_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass80_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass80_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass80_0>.NativeClassPtr);
			NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass80_0>.NativeClassPtr, "handler");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass80_0>.NativeClassPtr, 100677428);
			NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimatorKinematic_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass80_0>.NativeClassPtr, 100677429);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass80_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass80_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233293, XrefRangeEnd = 233294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_ForceMatchPhysicalBonesWithAnimatorKinematic_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_ForceMatchPhysicalBonesWithAnimatorKinematic_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass80_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass84_0")]
	public sealed class __c__DisplayClass84_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rigb;

		private static readonly System.IntPtr NativeFieldInfoPtr_velocity;

		private static readonly System.IntPtr NativeFieldInfoPtr_forceMode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_AddRigidbodyImpact_b__0_Internal_Void_0;

		public unsafe Rigidbody rigb
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigb);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigb)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody));
			}
		}

		public unsafe Vector3 velocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity)) = vector;
			}
		}

		public unsafe ForceMode forceMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMode);
				return *(ForceMode*)num;
			}
			set
			{
				*(ForceMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMode)) = forceMode;
			}
		}

		static __c__DisplayClass84_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass84_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass84_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass84_0>.NativeClassPtr);
			NativeFieldInfoPtr_rigb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass84_0>.NativeClassPtr, "rigb");
			NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass84_0>.NativeClassPtr, "velocity");
			NativeFieldInfoPtr_forceMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass84_0>.NativeClassPtr, "forceMode");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass84_0>.NativeClassPtr, 100677430);
			NativeMethodInfoPtr__User_AddRigidbodyImpact_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass84_0>.NativeClassPtr, 100677431);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass84_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass84_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233294, XrefRangeEnd = 233295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_AddRigidbodyImpact_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_AddRigidbodyImpact_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass84_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass85_0")]
	public sealed class __c__DisplayClass85_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rigb;

		private static readonly System.IntPtr NativeFieldInfoPtr_velocity;

		private static readonly System.IntPtr NativeFieldInfoPtr_forcePosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_forceMode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_AddRigidbodyImpactAtPosition_b__0_Internal_Void_0;

		public unsafe Rigidbody rigb
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigb);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigb)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody));
			}
		}

		public unsafe Vector3 velocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity)) = vector;
			}
		}

		public unsafe Vector3 forcePosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePosition)) = vector;
			}
		}

		public unsafe ForceMode forceMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMode);
				return *(ForceMode*)num;
			}
			set
			{
				*(ForceMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMode)) = forceMode;
			}
		}

		static __c__DisplayClass85_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass85_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass85_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass85_0>.NativeClassPtr);
			NativeFieldInfoPtr_rigb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass85_0>.NativeClassPtr, "rigb");
			NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass85_0>.NativeClassPtr, "velocity");
			NativeFieldInfoPtr_forcePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass85_0>.NativeClassPtr, "forcePosition");
			NativeFieldInfoPtr_forceMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass85_0>.NativeClassPtr, "forceMode");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass85_0>.NativeClassPtr, 100677432);
			NativeMethodInfoPtr__User_AddRigidbodyImpactAtPosition_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass85_0>.NativeClassPtr, 100677433);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass85_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass85_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233295, XrefRangeEnd = 233296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_AddRigidbodyImpactAtPosition_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_AddRigidbodyImpactAtPosition_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass85_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass86_0")]
	public sealed class __c__DisplayClass86_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rigb;

		private static readonly System.IntPtr NativeFieldInfoPtr_explosionForce;

		private static readonly System.IntPtr NativeFieldInfoPtr_explosionPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_explosionRadius;

		private static readonly System.IntPtr NativeFieldInfoPtr_upwardsModifier;

		private static readonly System.IntPtr NativeFieldInfoPtr_forceMode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_AddRigidbodyExplosionForce_b__0_Internal_Void_0;

		public unsafe Rigidbody rigb
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigb);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigb)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody));
			}
		}

		public unsafe float explosionForce
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explosionForce);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explosionForce)) = num;
			}
		}

		public unsafe Vector3 explosionPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explosionPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explosionPosition)) = vector;
			}
		}

		public unsafe float explosionRadius
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explosionRadius);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explosionRadius)) = num;
			}
		}

		public unsafe float upwardsModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upwardsModifier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upwardsModifier)) = num;
			}
		}

		public unsafe ForceMode forceMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMode);
				return *(ForceMode*)num;
			}
			set
			{
				*(ForceMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMode)) = forceMode;
			}
		}

		static __c__DisplayClass86_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass86_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass86_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass86_0>.NativeClassPtr);
			NativeFieldInfoPtr_rigb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass86_0>.NativeClassPtr, "rigb");
			NativeFieldInfoPtr_explosionForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass86_0>.NativeClassPtr, "explosionForce");
			NativeFieldInfoPtr_explosionPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass86_0>.NativeClassPtr, "explosionPosition");
			NativeFieldInfoPtr_explosionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass86_0>.NativeClassPtr, "explosionRadius");
			NativeFieldInfoPtr_upwardsModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass86_0>.NativeClassPtr, "upwardsModifier");
			NativeFieldInfoPtr_forceMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass86_0>.NativeClassPtr, "forceMode");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass86_0>.NativeClassPtr, 100677434);
			NativeMethodInfoPtr__User_AddRigidbodyExplosionForce_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass86_0>.NativeClassPtr, 100677435);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass86_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass86_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233296, XrefRangeEnd = 233297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_AddRigidbodyExplosionForce_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_AddRigidbodyExplosionForce_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass86_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass91_0")]
	public sealed class __c__DisplayClass91_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_handler;

		private static readonly System.IntPtr NativeFieldInfoPtr_velocity;

		private static readonly System.IntPtr NativeFieldInfoPtr_impactDuration;

		private static readonly System.IntPtr NativeFieldInfoPtr_mode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_AddAllBonesImpact_b__0_Internal_Void_0;

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

		public unsafe Vector3 velocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity)) = vector;
			}
		}

		public unsafe float impactDuration
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactDuration);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactDuration)) = num;
			}
		}

		public unsafe ForceMode mode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
				return *(ForceMode*)num;
			}
			set
			{
				*(ForceMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = forceMode;
			}
		}

		static __c__DisplayClass91_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass91_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass91_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass91_0>.NativeClassPtr);
			NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass91_0>.NativeClassPtr, "handler");
			NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass91_0>.NativeClassPtr, "velocity");
			NativeFieldInfoPtr_impactDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass91_0>.NativeClassPtr, "impactDuration");
			NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass91_0>.NativeClassPtr, "mode");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass91_0>.NativeClassPtr, 100677436);
			NativeMethodInfoPtr__User_AddAllBonesImpact_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass91_0>.NativeClassPtr, 100677437);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass91_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass91_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233297, XrefRangeEnd = 233298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_AddAllBonesImpact_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_AddAllBonesImpact_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass91_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass92_0")]
	public sealed class __c__DisplayClass92_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_handler;

		private static readonly System.IntPtr NativeFieldInfoPtr_velocity;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_SetAllBonesVelocity_b__0_Internal_Void_0;

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

		public unsafe Vector3 velocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity)) = vector;
			}
		}

		static __c__DisplayClass92_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass92_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass92_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass92_0>.NativeClassPtr);
			NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass92_0>.NativeClassPtr, "handler");
			NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass92_0>.NativeClassPtr, "velocity");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass92_0>.NativeClassPtr, 100677438);
			NativeMethodInfoPtr__User_SetAllBonesVelocity_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass92_0>.NativeClassPtr, 100677439);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass92_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass92_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233298, XrefRangeEnd = 233299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_SetAllBonesVelocity_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_SetAllBonesVelocity_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass92_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass93_0")]
	public sealed class __c__DisplayClass93_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_kinematic;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_SetAllKinematic_b__0_Internal_Void_RagdollChainBone_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_SetAllKinematic_b__1_Internal_Void_InBetweenBone_0;

		public unsafe bool kinematic
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kinematic);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kinematic)) = flag;
			}
		}

		static __c__DisplayClass93_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass93_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass93_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass93_0>.NativeClassPtr);
			NativeFieldInfoPtr_kinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass93_0>.NativeClassPtr, "kinematic");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass93_0>.NativeClassPtr, 100677440);
			NativeMethodInfoPtr__User_SetAllKinematic_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass93_0>.NativeClassPtr, 100677441);
			NativeMethodInfoPtr__User_SetAllKinematic_b__1_Internal_Void_InBetweenBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass93_0>.NativeClassPtr, 100677442);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass93_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass93_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233299, XrefRangeEnd = 233301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_SetAllKinematic_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_SetAllKinematic_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233301, XrefRangeEnd = 233306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_SetAllKinematic_b__1(RagdollChainBone.InBetweenBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_SetAllKinematic_b__1_Internal_Void_InBetweenBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass93_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass94_0")]
	public sealed class __c__DisplayClass94_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_useGravity;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_SwitchAllBonesUseGravity_b__0_Internal_Void_RagdollChainBone_0;

		public unsafe bool useGravity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGravity);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGravity)) = flag;
			}
		}

		static __c__DisplayClass94_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass94_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass94_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass94_0>.NativeClassPtr);
			NativeFieldInfoPtr_useGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass94_0>.NativeClassPtr, "useGravity");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass94_0>.NativeClassPtr, 100677443);
			NativeMethodInfoPtr__User_SwitchAllBonesUseGravity_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass94_0>.NativeClassPtr, 100677444);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass94_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass94_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233306, XrefRangeEnd = 233308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_SwitchAllBonesUseGravity_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_SwitchAllBonesUseGravity_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass94_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass95_0")]
	public sealed class __c__DisplayClass95_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxVelocity;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_SwitchAllBonesMaxVelocity_b__0_Internal_Void_RagdollChainBone_0;

		public unsafe float MaxVelocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxVelocity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxVelocity)) = num;
			}
		}

		static __c__DisplayClass95_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass95_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass95_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass95_0>.NativeClassPtr);
			NativeFieldInfoPtr_MaxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass95_0>.NativeClassPtr, "MaxVelocity");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass95_0>.NativeClassPtr, 100677445);
			NativeMethodInfoPtr__User_SwitchAllBonesMaxVelocity_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass95_0>.NativeClassPtr, 100677446);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass95_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass95_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233308, XrefRangeEnd = 233310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_SwitchAllBonesMaxVelocity_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_SwitchAllBonesMaxVelocity_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass95_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass96_0")]
	public sealed class __c__DisplayClass96_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_drag;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_ChangeAllRigidbodiesDrag_b__0_Internal_Void_RagdollChainBone_0;

		public unsafe float drag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drag);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drag)) = num;
			}
		}

		static __c__DisplayClass96_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass96_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass96_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass96_0>.NativeClassPtr);
			NativeFieldInfoPtr_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass96_0>.NativeClassPtr, "drag");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass96_0>.NativeClassPtr, 100677447);
			NativeMethodInfoPtr__User_ChangeAllRigidbodiesDrag_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass96_0>.NativeClassPtr, 100677448);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass96_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass96_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233310, XrefRangeEnd = 233312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_ChangeAllRigidbodiesDrag_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_ChangeAllRigidbodiesDrag_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass96_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass97_0")]
	public sealed class __c__DisplayClass97_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_drag;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_ChangeAllRigidbodiesAngularDrag_b__0_Internal_Void_RagdollChainBone_0;

		public unsafe float drag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drag);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drag)) = num;
			}
		}

		static __c__DisplayClass97_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass97_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass97_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass97_0>.NativeClassPtr);
			NativeFieldInfoPtr_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass97_0>.NativeClassPtr, "drag");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass97_0>.NativeClassPtr, 100677449);
			NativeMethodInfoPtr__User_ChangeAllRigidbodiesAngularDrag_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass97_0>.NativeClassPtr, 100677450);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass97_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass97_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233312, XrefRangeEnd = 233314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_ChangeAllRigidbodiesAngularDrag_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_ChangeAllRigidbodiesAngularDrag_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass97_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass98_0")]
	public sealed class __c__DisplayClass98_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_handler;

		private static readonly System.IntPtr NativeFieldInfoPtr_force;

		private static readonly System.IntPtr NativeFieldInfoPtr_duration;

		private static readonly System.IntPtr NativeFieldInfoPtr_mode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_AddAllImpact_b__0_Internal_Void_RagdollChainBone_0;

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

		public unsafe Vector3 force
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_force);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_force)) = vector;
			}
		}

		public unsafe float duration
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration)) = num;
			}
		}

		public unsafe ForceMode mode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
				return *(ForceMode*)num;
			}
			set
			{
				*(ForceMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = forceMode;
			}
		}

		static __c__DisplayClass98_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass98_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass98_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass98_0>.NativeClassPtr);
			NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass98_0>.NativeClassPtr, "handler");
			NativeFieldInfoPtr_force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass98_0>.NativeClassPtr, "force");
			NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass98_0>.NativeClassPtr, "duration");
			NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass98_0>.NativeClassPtr, "mode");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass98_0>.NativeClassPtr, 100677451);
			NativeMethodInfoPtr__User_AddAllImpact_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass98_0>.NativeClassPtr, 100677452);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass98_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass98_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233314, XrefRangeEnd = 233315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_AddAllImpact_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_AddAllImpact_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass98_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("FIMSpace.FProceduralAnimation.RagdollHandlerUtilities+<>c__DisplayClass99_0")]
	public sealed class __c__DisplayClass99_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_worldVelocity;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__User_SetAllVelocity_b__0_Internal_Void_RagdollChainBone_0;

		public unsafe Vector3 worldVelocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldVelocity);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldVelocity)) = vector;
			}
		}

		static __c__DisplayClass99_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass99_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, "<>c__DisplayClass99_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass99_0>.NativeClassPtr);
			NativeFieldInfoPtr_worldVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass99_0>.NativeClassPtr, "worldVelocity");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass99_0>.NativeClassPtr, 100677453);
			NativeMethodInfoPtr__User_SetAllVelocity_b__0_Internal_Void_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass99_0>.NativeClassPtr, 100677454);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass99_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass99_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233315, XrefRangeEnd = 233316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _User_SetAllVelocity_b__0(RagdollChainBone bone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__User_SetAllVelocity_b__0_Internal_Void_RagdollChainBone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass99_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetOrGenerate_Public_Static_T_Transform_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetOrGenerate_Public_Static_T_Transform_0, Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_DestroyComponent_Public_Static_Void_Transform_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_DestroyComponent_Public_Static_Void_Transform_0, Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCollidersOnTheCharacterBones_Public_Static_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPhysicsComponentsOnTheCharacterBones_Public_Static_Void_RagdollHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindAndRemoveJointAndRigidbodyComponentsOnTheCharacterBones_Public_Static_Void_RagdollHandler_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindAndRemoveAllPhysicalComponentsOnTheCharacterBones_Public_Static_Void_RagdollHandler_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindBonesCollidersInSourceBonesAndAssignAsReferenceCollidersIfFound_Public_Static_Void_RagdollHandler_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateInertiaTensor_Public_Static_Void_Rigidbody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DragRigidbodyTowards_Public_Static_Void_Rigidbody_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotateRigidbodyTowards_Public_Static_Void_Rigidbody_Quaternion_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRigidbodyForceToMoveTowards_Public_Static_Void_Rigidbody_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVelocityToMoveTowards_Public_Static_Vector3_Rigidbody_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAccelerationTowardsWorldPosition_Public_Static_Void_Rigidbody_Vector3_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAccelerationTowardsWorldPositionDiff_Public_Static_Void_Rigidbody_Vector3_Vector3_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAccelerationToMoveTowards_Public_Static_Vector3_Rigidbody_Vector3_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRigidbodyTorqueToRotateTowards_Public_Static_Void_Rigidbody_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustColliderBasingOnStartEndPosition_Public_Static_Void_Vector3_Vector3_Transform_Collider_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustColliderDirectionParams_Public_Static_Void_Collider_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaxLinearVelocityU2022_Public_Static_Void_Rigidbody_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrGenerate_Public_Static_T_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyComponent_Public_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LayerMaskContains_Public_Static_Boolean_LayerMask_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchKinematic_Public_Static_Void_Rigidbody_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchKinematicAndProjection_Public_Static_Void_Rigidbody_IRagdollAnimator2HandlerOwner_Boolean_ConfigurableJoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_FadeMusclesPower_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_FadeMusclesPowerMultiplicator_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_DisableMecanimAfter_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_TransitionMusclesPowerMultiplier_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetNearestRagdollColliderToPosition_Public_Static_Collider_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetNearestRagdollRigidbodyToPosition_Public_Static_Rigidbody_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetNearestAnimatorTransformBoneToPosition_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetNearestPhysicalTransformBoneToPosition_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetNearestRagdollBoneControllerToPosition_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ChangeAllCollidersPhysicMaterial_Public_Static_Void_IRagdollAnimator2HandlerOwner_PhysicsMaterial_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_FreezeAndDestroyRagdollDummy_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetAllRigidbodies_Public_Static_List_1_Rigidbody_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetAllRagdollDummyBoneSetups_Public_Static_List_1_RagdollChainBone_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_UpdateRigidbodyParametersForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_UpdateColliderParametersForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_UpdatePhysicsParametersForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_UpdateLayersAfterManualChanges_Public_Static_Void_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_UpdateAllBonesParametersAfterManualChanges_Public_Static_Void_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_Teleport_Public_Static_Void_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Nullable_1_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_TranslateTo_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_WarpRefresh_Public_Static_Void_IRagdollAnimator2HandlerOwner_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetStoredAnchorRootOffset_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetStoredAnchorRootOffsetRot_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_BoneWorldForward_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_BoneWorldUp_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_BoneWorldRight_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetRagdollBonesStateBounds_Public_Static_Bounds_IRagdollAnimator2HandlerOwner_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetPosition_BottomCenter_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetPosition_Center_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetPosition_AnchorBottom_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetPosition_AnchorCenter_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetPosition_HipsToFoot_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetPosition_FeetMiddle_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetMappedRotationHipsToLegsMiddle_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetMappedRotationHipsToHead_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetMappedRotationHeadToHips_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetRotation_Mapped_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetRotation_MappedFor_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_ERagdollGetUpType_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetAverageDirectionOf_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollBonesChain_ECapsuleDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetUpByRotationPossible_Public_Static_Boolean_IRagdollAnimator2HandlerOwner_Boolean_Nullable_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_IsOnBack_Public_Static_Boolean_IRagdollAnimator2HandlerOwner_Boolean_Nullable_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_CoreLowTranslationFactor_Public_Static_Single_IRagdollAnimator2HandlerOwner_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_CanGetUpByRotation_Public_Static_ERagdollGetUpType_IRagdollAnimator2HandlerOwner_Boolean_Nullable_1_Vector3_Boolean_Single_Nullable_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_LayingOnSide_Public_Static_ERagdollGetUpType_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ProbeGroundBelowAnchorBone_Public_Static_RaycastHit_IRagdollAnimator2HandlerOwner_LayerMask_Nullable_1_Single_Nullable_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ProbeGroundBelowHips_Public_Static_RaycastHit_IRagdollAnimator2HandlerOwner_LayerMask_Single_Nullable_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ProbeGroundBelow_Public_Static_RaycastHit_IRagdollAnimator2HandlerOwner_RagdollChainBone_LayerMask_Single_Nullable_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_TransitionToStandingMode_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_Single_Single_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_TransitionToStandingMode_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetBoneSetupByHumanoidBone_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_HumanBodyBones_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetBoneSetupByBoneID_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_ERagdollBoneID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetBoneSetupBySourceAnimatorBone_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetBoneSetupByBoneName_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetBoneSetupByDummyBone_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetPhysicalBoneBySourceBone_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetSourceBoneByPhysicalBone_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ForceMatchPhysicalBonesWithAnimator_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ForceMatchPhysicalBonesWithAnimatorKinematic_Public_Static_Void_IRagdollAnimator2HandlerOwner_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SwitchFallState_Public_Static_Void_IRagdollAnimator2HandlerOwner_EAnimatingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SwitchFallState_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_AddBoneImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_RagdollChainBone_Vector3_Single_ForceMode_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_AddRigidbodyImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Single_ForceMode_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_AddRigidbodyImpactAtPosition_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Vector3_Single_ForceMode_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_AddRigidbodyExplosionForce_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Single_Vector3_Single_Single_Single_ForceMode_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_AddChainImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_RagdollBonesChain_Vector3_Single_ForceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_AddChainImpactAtPosition_Public_Static_Void_IRagdollAnimator2HandlerOwner_RagdollBonesChain_Vector3_Vector3_Single_ForceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_AddChainImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_ERagdollChainType_Vector3_Single_ForceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_AddChainImpactAtPosition_Public_Static_Void_IRagdollAnimator2HandlerOwner_ERagdollChainType_Vector3_Vector3_Single_ForceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_AddAllBonesImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_ForceMode_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SetAllBonesVelocity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SetAllKinematic_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SwitchAllBonesUseGravity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SwitchAllBonesMaxVelocity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ChangeAllRigidbodiesDrag_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ChangeAllRigidbodiesAngularDrag_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_AddAllImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_ForceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SetAllVelocity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_ResetAngularVelocityForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SetAllAngularSpeedLimit_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SetAllIterpolation_Public_Static_Void_IRagdollAnimator2HandlerOwner_RigidbodyInterpolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyLimbImpact_Public_Static_Void_Rigidbody_Vector3_ForceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyLimbImpactAtPosition_Public_Static_Void_Rigidbody_Vector3_Vector3_ForceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyLimbExplosionForce_Public_Static_Void_Rigidbody_Single_Vector3_Single_Single_ForceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SetPhysicalTorqueOnRigidbody_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Single_Boolean_ForceMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SetAllPhysicalTorque_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_Boolean_Transform_Nullable_1_Vector3_ForceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_SetPhysicalTorque_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Single_Boolean_Transform_Nullable_1_Vector3_ForceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetAllBonesMaxVelocity_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetChainBonesAverageTranslation_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetChainBonesAverageAngularVelocity_Public_Static_Single_IRagdollAnimator2HandlerOwner_ERagdollChainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetChainBonesVelocity_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_ERagdollChainType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_GetChainAngularVelocity_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_ERagdollChainType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_User_FallImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_Single_Single_Rigidbody_0;

	static RagdollHandlerUtilities()
	{
		Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RagdollHandlerUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_AddCollidersOnTheCharacterBones_Public_Static_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677287);
		NativeMethodInfoPtr_AddPhysicsComponentsOnTheCharacterBones_Public_Static_Void_RagdollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677288);
		NativeMethodInfoPtr_FindAndRemoveJointAndRigidbodyComponentsOnTheCharacterBones_Public_Static_Void_RagdollHandler_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677289);
		NativeMethodInfoPtr_FindAndRemoveAllPhysicalComponentsOnTheCharacterBones_Public_Static_Void_RagdollHandler_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677290);
		NativeMethodInfoPtr_FindBonesCollidersInSourceBonesAndAssignAsReferenceCollidersIfFound_Public_Static_Void_RagdollHandler_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677291);
		NativeMethodInfoPtr_CalculateInertiaTensor_Public_Static_Void_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677292);
		NativeMethodInfoPtr_DragRigidbodyTowards_Public_Static_Void_Rigidbody_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677293);
		NativeMethodInfoPtr_RotateRigidbodyTowards_Public_Static_Void_Rigidbody_Quaternion_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677294);
		NativeMethodInfoPtr_AddRigidbodyForceToMoveTowards_Public_Static_Void_Rigidbody_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677295);
		NativeMethodInfoPtr_GetVelocityToMoveTowards_Public_Static_Vector3_Rigidbody_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677296);
		NativeMethodInfoPtr_AddAccelerationTowardsWorldPosition_Public_Static_Void_Rigidbody_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677297);
		NativeMethodInfoPtr_AddAccelerationTowardsWorldPositionDiff_Public_Static_Void_Rigidbody_Vector3_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677298);
		NativeMethodInfoPtr_GetAccelerationToMoveTowards_Public_Static_Vector3_Rigidbody_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677299);
		NativeMethodInfoPtr_AddRigidbodyTorqueToRotateTowards_Public_Static_Void_Rigidbody_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677300);
		NativeMethodInfoPtr_AdjustColliderBasingOnStartEndPosition_Public_Static_Void_Vector3_Vector3_Transform_Collider_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677301);
		NativeMethodInfoPtr_AdjustColliderDirectionParams_Public_Static_Void_Collider_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677302);
		NativeMethodInfoPtr_SetMaxLinearVelocityU2022_Public_Static_Void_Rigidbody_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677303);
		NativeMethodInfoPtr_GetOrGenerate_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677304);
		NativeMethodInfoPtr_DestroyComponent_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677305);
		NativeMethodInfoPtr_LayerMaskContains_Public_Static_Boolean_LayerMask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677306);
		NativeMethodInfoPtr_SwitchKinematic_Public_Static_Void_Rigidbody_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677307);
		NativeMethodInfoPtr_SwitchKinematicAndProjection_Public_Static_Void_Rigidbody_IRagdollAnimator2HandlerOwner_Boolean_ConfigurableJoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677308);
		NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677309);
		NativeMethodInfoPtr_User_FadeMusclesPower_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677310);
		NativeMethodInfoPtr_User_FadeMusclesPowerMultiplicator_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677311);
		NativeMethodInfoPtr_User_DisableMecanimAfter_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677312);
		NativeMethodInfoPtr_User_TransitionMusclesPowerMultiplier_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677313);
		NativeMethodInfoPtr_User_GetNearestRagdollColliderToPosition_Public_Static_Collider_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677314);
		NativeMethodInfoPtr_User_GetNearestRagdollRigidbodyToPosition_Public_Static_Rigidbody_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677315);
		NativeMethodInfoPtr_User_GetNearestAnimatorTransformBoneToPosition_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677316);
		NativeMethodInfoPtr_User_GetNearestPhysicalTransformBoneToPosition_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677317);
		NativeMethodInfoPtr_User_GetNearestRagdollBoneControllerToPosition_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677318);
		NativeMethodInfoPtr_User_ChangeAllCollidersPhysicMaterial_Public_Static_Void_IRagdollAnimator2HandlerOwner_PhysicsMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677319);
		NativeMethodInfoPtr_User_FreezeAndDestroyRagdollDummy_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677320);
		NativeMethodInfoPtr_User_GetAllRigidbodies_Public_Static_List_1_Rigidbody_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677321);
		NativeMethodInfoPtr_User_GetAllRagdollDummyBoneSetups_Public_Static_List_1_RagdollChainBone_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677322);
		NativeMethodInfoPtr_User_UpdateRigidbodyParametersForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677323);
		NativeMethodInfoPtr_User_UpdateColliderParametersForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677324);
		NativeMethodInfoPtr_User_UpdatePhysicsParametersForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677325);
		NativeMethodInfoPtr_User_UpdateLayersAfterManualChanges_Public_Static_Void_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677326);
		NativeMethodInfoPtr_User_UpdateAllBonesParametersAfterManualChanges_Public_Static_Void_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677327);
		NativeMethodInfoPtr_User_Teleport_Public_Static_Void_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Nullable_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677328);
		NativeMethodInfoPtr_User_TranslateTo_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677329);
		NativeMethodInfoPtr_User_WarpRefresh_Public_Static_Void_IRagdollAnimator2HandlerOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677330);
		NativeMethodInfoPtr_User_GetStoredAnchorRootOffset_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677331);
		NativeMethodInfoPtr_User_GetStoredAnchorRootOffsetRot_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677332);
		NativeMethodInfoPtr_User_BoneWorldForward_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677333);
		NativeMethodInfoPtr_User_BoneWorldUp_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677334);
		NativeMethodInfoPtr_User_BoneWorldRight_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677335);
		NativeMethodInfoPtr_User_GetRagdollBonesStateBounds_Public_Static_Bounds_IRagdollAnimator2HandlerOwner_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677336);
		NativeMethodInfoPtr_User_GetPosition_BottomCenter_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677337);
		NativeMethodInfoPtr_User_GetPosition_Center_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677338);
		NativeMethodInfoPtr_User_GetPosition_AnchorBottom_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677339);
		NativeMethodInfoPtr_User_GetPosition_AnchorCenter_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677340);
		NativeMethodInfoPtr_User_GetPosition_HipsToFoot_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677341);
		NativeMethodInfoPtr_User_GetPosition_FeetMiddle_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677342);
		NativeMethodInfoPtr_User_GetMappedRotationHipsToLegsMiddle_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677343);
		NativeMethodInfoPtr_User_GetMappedRotationHipsToHead_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677344);
		NativeMethodInfoPtr_User_GetMappedRotationHeadToHips_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677345);
		NativeMethodInfoPtr_User_GetRotation_Mapped_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677346);
		NativeMethodInfoPtr_User_GetRotation_MappedFor_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_ERagdollGetUpType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677347);
		NativeMethodInfoPtr_User_GetAverageDirectionOf_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollBonesChain_ECapsuleDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677348);
		NativeMethodInfoPtr_User_GetUpByRotationPossible_Public_Static_Boolean_IRagdollAnimator2HandlerOwner_Boolean_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677349);
		NativeMethodInfoPtr_User_IsOnBack_Public_Static_Boolean_IRagdollAnimator2HandlerOwner_Boolean_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677350);
		NativeMethodInfoPtr_User_CoreLowTranslationFactor_Public_Static_Single_IRagdollAnimator2HandlerOwner_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677351);
		NativeMethodInfoPtr_User_CanGetUpByRotation_Public_Static_ERagdollGetUpType_IRagdollAnimator2HandlerOwner_Boolean_Nullable_1_Vector3_Boolean_Single_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677352);
		NativeMethodInfoPtr_User_LayingOnSide_Public_Static_ERagdollGetUpType_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677353);
		NativeMethodInfoPtr_User_ProbeGroundBelowAnchorBone_Public_Static_RaycastHit_IRagdollAnimator2HandlerOwner_LayerMask_Nullable_1_Single_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677354);
		NativeMethodInfoPtr_User_ProbeGroundBelowHips_Public_Static_RaycastHit_IRagdollAnimator2HandlerOwner_LayerMask_Single_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677355);
		NativeMethodInfoPtr_User_ProbeGroundBelow_Public_Static_RaycastHit_IRagdollAnimator2HandlerOwner_RagdollChainBone_LayerMask_Single_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677356);
		NativeMethodInfoPtr_User_TransitionToStandingMode_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677357);
		NativeMethodInfoPtr_User_TransitionToStandingMode_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677358);
		NativeMethodInfoPtr_User_GetBoneSetupByHumanoidBone_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_HumanBodyBones_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677359);
		NativeMethodInfoPtr_User_GetBoneSetupByBoneID_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_ERagdollBoneID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677360);
		NativeMethodInfoPtr_User_GetBoneSetupBySourceAnimatorBone_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677361);
		NativeMethodInfoPtr_User_GetBoneSetupByBoneName_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677362);
		NativeMethodInfoPtr_User_GetBoneSetupByDummyBone_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677363);
		NativeMethodInfoPtr_User_GetPhysicalBoneBySourceBone_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677364);
		NativeMethodInfoPtr_User_GetSourceBoneByPhysicalBone_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677365);
		NativeMethodInfoPtr_User_ForceMatchPhysicalBonesWithAnimator_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677366);
		NativeMethodInfoPtr_User_ForceMatchPhysicalBonesWithAnimatorKinematic_Public_Static_Void_IRagdollAnimator2HandlerOwner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677367);
		NativeMethodInfoPtr_User_SwitchFallState_Public_Static_Void_IRagdollAnimator2HandlerOwner_EAnimatingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677368);
		NativeMethodInfoPtr_User_SwitchFallState_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677369);
		NativeMethodInfoPtr_User_AddBoneImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_RagdollChainBone_Vector3_Single_ForceMode_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677370);
		NativeMethodInfoPtr_User_AddRigidbodyImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Single_ForceMode_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677371);
		NativeMethodInfoPtr_User_AddRigidbodyImpactAtPosition_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Vector3_Single_ForceMode_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677372);
		NativeMethodInfoPtr_User_AddRigidbodyExplosionForce_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Single_Vector3_Single_Single_Single_ForceMode_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677373);
		NativeMethodInfoPtr_User_AddChainImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_RagdollBonesChain_Vector3_Single_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677374);
		NativeMethodInfoPtr_User_AddChainImpactAtPosition_Public_Static_Void_IRagdollAnimator2HandlerOwner_RagdollBonesChain_Vector3_Vector3_Single_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677375);
		NativeMethodInfoPtr_User_AddChainImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_ERagdollChainType_Vector3_Single_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677376);
		NativeMethodInfoPtr_User_AddChainImpactAtPosition_Public_Static_Void_IRagdollAnimator2HandlerOwner_ERagdollChainType_Vector3_Vector3_Single_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677377);
		NativeMethodInfoPtr_User_AddAllBonesImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_ForceMode_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677378);
		NativeMethodInfoPtr_User_SetAllBonesVelocity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677379);
		NativeMethodInfoPtr_User_SetAllKinematic_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677380);
		NativeMethodInfoPtr_User_SwitchAllBonesUseGravity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677381);
		NativeMethodInfoPtr_User_SwitchAllBonesMaxVelocity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677382);
		NativeMethodInfoPtr_User_ChangeAllRigidbodiesDrag_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677383);
		NativeMethodInfoPtr_User_ChangeAllRigidbodiesAngularDrag_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677384);
		NativeMethodInfoPtr_User_AddAllImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677385);
		NativeMethodInfoPtr_User_SetAllVelocity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677386);
		NativeMethodInfoPtr_User_ResetAngularVelocityForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677387);
		NativeMethodInfoPtr_User_SetAllAngularSpeedLimit_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677388);
		NativeMethodInfoPtr_User_SetAllIterpolation_Public_Static_Void_IRagdollAnimator2HandlerOwner_RigidbodyInterpolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677389);
		NativeMethodInfoPtr_ApplyLimbImpact_Public_Static_Void_Rigidbody_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677390);
		NativeMethodInfoPtr_ApplyLimbImpactAtPosition_Public_Static_Void_Rigidbody_Vector3_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677391);
		NativeMethodInfoPtr_ApplyLimbExplosionForce_Public_Static_Void_Rigidbody_Single_Vector3_Single_Single_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677392);
		NativeMethodInfoPtr_User_SetPhysicalTorqueOnRigidbody_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Single_Boolean_ForceMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677393);
		NativeMethodInfoPtr_User_SetAllPhysicalTorque_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_Boolean_Transform_Nullable_1_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677394);
		NativeMethodInfoPtr_User_SetPhysicalTorque_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Single_Boolean_Transform_Nullable_1_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677395);
		NativeMethodInfoPtr_User_GetAllBonesMaxVelocity_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677396);
		NativeMethodInfoPtr_User_GetChainBonesAverageTranslation_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677397);
		NativeMethodInfoPtr_User_GetChainBonesAverageAngularVelocity_Public_Static_Single_IRagdollAnimator2HandlerOwner_ERagdollChainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677398);
		NativeMethodInfoPtr_User_GetChainBonesVelocity_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_ERagdollChainType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677399);
		NativeMethodInfoPtr_User_GetChainAngularVelocity_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_ERagdollChainType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677400);
		NativeMethodInfoPtr_User_FallImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_Single_Single_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollHandlerUtilities>.NativeClassPtr, 100677401);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233346, RefRangeEnd = 233348, XrefRangeStart = 233316, XrefRangeEnd = 233346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddCollidersOnTheCharacterBones(RagdollHandler handler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCollidersOnTheCharacterBones_Public_Static_Void_RagdollHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233438, RefRangeEnd = 233439, XrefRangeStart = 233348, XrefRangeEnd = 233438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddPhysicsComponentsOnTheCharacterBones(RagdollHandler handler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPhysicsComponentsOnTheCharacterBones_Public_Static_Void_RagdollHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233493, RefRangeEnd = 233494, XrefRangeStart = 233439, XrefRangeEnd = 233493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FindAndRemoveJointAndRigidbodyComponentsOnTheCharacterBones(RagdollHandler handler, bool log = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &log;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindAndRemoveJointAndRigidbodyComponentsOnTheCharacterBones_Public_Static_Void_RagdollHandler_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233494, XrefRangeEnd = 233553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FindAndRemoveAllPhysicalComponentsOnTheCharacterBones(RagdollHandler handler, bool log = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &log;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindAndRemoveAllPhysicalComponentsOnTheCharacterBones_Public_Static_Void_RagdollHandler_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233553, XrefRangeEnd = 233604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FindBonesCollidersInSourceBonesAndAssignAsReferenceCollidersIfFound(RagdollHandler handler, bool setAsOther, bool log = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &setAsOther;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &log;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindBonesCollidersInSourceBonesAndAssignAsReferenceCollidersIfFound_Public_Static_Void_RagdollHandler_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233611, RefRangeEnd = 233612, XrefRangeStart = 233604, XrefRangeEnd = 233611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalculateInertiaTensor(Rigidbody rigidbody)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateInertiaTensor_Public_Static_Void_Rigidbody_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233612, XrefRangeEnd = 233624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DragRigidbodyTowards(this Rigidbody rigidbody, Vector3 worldPosition, float power)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPosition;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &power;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DragRigidbodyTowards_Public_Static_Void_Rigidbody_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233624, XrefRangeEnd = 233631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RotateRigidbodyTowards(this Rigidbody rigidbody, Quaternion worldRotation, float power, float overallLerp = 1f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldRotation;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &power;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &overallLerp;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateRigidbodyTowards_Public_Static_Void_Rigidbody_Quaternion_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233641, RefRangeEnd = 233644, XrefRangeStart = 233631, XrefRangeEnd = 233641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddRigidbodyForceToMoveTowards(this Rigidbody rigidbody, Vector3 worldPosition, float forceMultiply)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPosition;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMultiply;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRigidbodyForceToMoveTowards_Public_Static_Void_Rigidbody_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233644, XrefRangeEnd = 233653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetVelocityToMoveTowards(this Rigidbody rigidbody, Vector3 worldPosition, float forceMultiply)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPosition;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMultiply;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVelocityToMoveTowards_Public_Static_Vector3_Rigidbody_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233656, RefRangeEnd = 233657, XrefRangeStart = 233653, XrefRangeEnd = 233656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddAccelerationTowardsWorldPosition(Rigidbody rigidbody, Vector3 targetPosition, Vector3 lastestPositionDelta, float power, float fixedDelta)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetPosition;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastestPositionDelta;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &power;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fixedDelta;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAccelerationTowardsWorldPosition_Public_Static_Void_Rigidbody_Vector3_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233659, RefRangeEnd = 233660, XrefRangeStart = 233657, XrefRangeEnd = 233659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddAccelerationTowardsWorldPositionDiff(Rigidbody rigidbody, Vector3 positionDifference, Vector3 lastestPositionDelta, float power, float fixedDelta, float overallMultiplier = 1f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionDifference;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastestPositionDelta;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &power;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fixedDelta;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &overallMultiplier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAccelerationTowardsWorldPositionDiff_Public_Static_Void_Rigidbody_Vector3_Vector3_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233667, RefRangeEnd = 233669, XrefRangeStart = 233660, XrefRangeEnd = 233667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetAccelerationToMoveTowards(Rigidbody rigidbody, Vector3 positionDifference, Vector3 lastestPositionDelta, float power, float fixedDelta)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionDifference;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastestPositionDelta;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &power;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fixedDelta;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAccelerationToMoveTowards_Public_Static_Vector3_Rigidbody_Vector3_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 233693, RefRangeEnd = 233698, XrefRangeStart = 233669, XrefRangeEnd = 233693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddRigidbodyTorqueToRotateTowards(this Rigidbody rigidbody, Quaternion worldRotation, float forceMultiply)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldRotation;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMultiply;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRigidbodyTorqueToRotateTowards_Public_Static_Void_Rigidbody_Quaternion_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233725, RefRangeEnd = 233727, XrefRangeStart = 233698, XrefRangeEnd = 233725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AdjustColliderBasingOnStartEndPosition(Vector3 start, Vector3 end, Transform bone, Collider collider, float radius)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collider);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustColliderBasingOnStartEndPosition_Public_Static_Void_Vector3_Vector3_Transform_Collider_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233739, RefRangeEnd = 233740, XrefRangeStart = 233727, XrefRangeEnd = 233739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AdjustColliderDirectionParams(Collider collider, Vector3 colliderDir, float diffLocalMagn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collider);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colliderDir;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &diffLocalMagn;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustColliderDirectionParams_Public_Static_Void_Collider_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233742, RefRangeEnd = 233743, XrefRangeStart = 233740, XrefRangeEnd = 233742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMaxLinearVelocityU2022(this Rigidbody rigidbody, float maxLinearVelocity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxLinearVelocity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaxLinearVelocityU2022_Public_Static_Void_Rigidbody_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 233751, RefRangeEnd = 233761, XrefRangeStart = 233743, XrefRangeEnd = 233751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetOrGenerate<T>(Transform t) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetOrGenerate_Public_Static_T_Transform_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 233768, RefRangeEnd = 233775, XrefRangeStart = 233761, XrefRangeEnd = 233768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyComponent<T>(Transform t) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_DestroyComponent_Public_Static_Void_Transform_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233775, XrefRangeEnd = 233777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LayerMaskContains(LayerMask layerMask, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&layerMask);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LayerMaskContains_Public_Static_Boolean_LayerMask_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233780, RefRangeEnd = 233783, XrefRangeStart = 233777, XrefRangeEnd = 233780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SwitchKinematic(Rigidbody rigidbody, bool restore = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &restore;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchKinematic_Public_Static_Void_Rigidbody_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233783, XrefRangeEnd = 233802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SwitchKinematicAndProjection(Rigidbody rigidbody, IRagdollAnimator2HandlerOwner handler, bool restore = false, ConfigurableJoint joint = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &restore;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchKinematicAndProjection_Public_Static_Void_Rigidbody_IRagdollAnimator2HandlerOwner_Boolean_ConfigurableJoint_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 233809, RefRangeEnd = 233823, XrefRangeStart = 233802, XrefRangeEnd = 233809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyObject(UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233823, XrefRangeEnd = 233836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_FadeMusclesPower(this IRagdollAnimator2HandlerOwner iHandler, float targetMusclesForce = 0f, float duration = 0.75f, float delay = 0f, bool disableMecanimAtEnd = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetMusclesForce;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &disableMecanimAtEnd;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_FadeMusclesPower_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233836, XrefRangeEnd = 233849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_FadeMusclesPowerMultiplicator(this IRagdollAnimator2HandlerOwner iHandler, float targetMusclesMultiply = 0f, float duration = 0.75f, float delay = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetMusclesMultiply;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_FadeMusclesPowerMultiplicator_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233875, RefRangeEnd = 233877, XrefRangeStart = 233849, XrefRangeEnd = 233875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_DisableMecanimAfter(this IRagdollAnimator2HandlerOwner iHandler, float delay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_DisableMecanimAfter_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233877, XrefRangeEnd = 233883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_TransitionMusclesPowerMultiplier(this IRagdollAnimator2HandlerOwner iHandler, float to, float delta)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_TransitionMusclesPowerMultiplier_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233883, XrefRangeEnd = 233886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Collider User_GetNearestRagdollColliderToPosition(this IRagdollAnimator2HandlerOwner iHandler, Vector3 pos, bool fast = true, Il2CppSystem.Nullable<ERagdollChainType> justChain = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fast;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)justChain));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetNearestRagdollColliderToPosition_Public_Static_Collider_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233886, XrefRangeEnd = 233887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rigidbody User_GetNearestRagdollRigidbodyToPosition(this IRagdollAnimator2HandlerOwner iHandler, Vector3 pos, bool fast = true, Il2CppSystem.Nullable<ERagdollChainType> justChain = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fast;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)justChain));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetNearestRagdollRigidbodyToPosition_Public_Static_Rigidbody_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233887, XrefRangeEnd = 233888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform User_GetNearestAnimatorTransformBoneToPosition(this IRagdollAnimator2HandlerOwner iHandler, Vector3 pos, bool fast = true, Il2CppSystem.Nullable<ERagdollChainType> justChain = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fast;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)justChain));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetNearestAnimatorTransformBoneToPosition_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233888, XrefRangeEnd = 233889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform User_GetNearestPhysicalTransformBoneToPosition(this IRagdollAnimator2HandlerOwner iHandler, Vector3 pos, bool fast = true, Il2CppSystem.Nullable<ERagdollChainType> justChain = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fast;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)justChain));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetNearestPhysicalTransformBoneToPosition_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 233933, RefRangeEnd = 233937, XrefRangeStart = 233889, XrefRangeEnd = 233933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RagdollChainBone User_GetNearestRagdollBoneControllerToPosition(this IRagdollAnimator2HandlerOwner iHandler, Vector3 pos, bool fast = true, Il2CppSystem.Nullable<ERagdollChainType> justChain = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fast;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)justChain));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetNearestRagdollBoneControllerToPosition_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_Vector3_Boolean_Nullable_1_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233970, RefRangeEnd = 233972, XrefRangeStart = 233937, XrefRangeEnd = 233970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_ChangeAllCollidersPhysicMaterial(this IRagdollAnimator2HandlerOwner iHandler, PhysicsMaterial targetMaterial)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetMaterial);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ChangeAllCollidersPhysicMaterial_Public_Static_Void_IRagdollAnimator2HandlerOwner_PhysicsMaterial_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233972, XrefRangeEnd = 234003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_FreezeAndDestroyRagdollDummy(this IRagdollAnimator2HandlerOwner iHandler, bool disableAnimator = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &disableAnimator;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_FreezeAndDestroyRagdollDummy_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234003, XrefRangeEnd = 234024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Rigidbody> User_GetAllRigidbodies(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetAllRigidbodies_Public_Static_List_1_Rigidbody_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Rigidbody>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234024, XrefRangeEnd = 234045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<RagdollChainBone> User_GetAllRagdollDummyBoneSetups(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetAllRagdollDummyBoneSetups_Public_Static_List_1_RagdollChainBone_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RagdollChainBone>>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 234078, RefRangeEnd = 234083, XrefRangeStart = 234045, XrefRangeEnd = 234078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_UpdateRigidbodyParametersForAllBones(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_UpdateRigidbodyParametersForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 234118, RefRangeEnd = 234123, XrefRangeStart = 234083, XrefRangeEnd = 234118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_UpdateColliderParametersForAllBones(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_UpdateColliderParametersForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 234162, RefRangeEnd = 234167, XrefRangeStart = 234123, XrefRangeEnd = 234162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_UpdatePhysicsParametersForAllBones(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_UpdatePhysicsParametersForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234250, RefRangeEnd = 234251, XrefRangeStart = 234167, XrefRangeEnd = 234250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_UpdateLayersAfterManualChanges(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_UpdateLayersAfterManualChanges_Public_Static_Void_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 234258, RefRangeEnd = 234263, XrefRangeStart = 234251, XrefRangeEnd = 234258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_UpdateAllBonesParametersAfterManualChanges(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_UpdateAllBonesParametersAfterManualChanges_Public_Static_Void_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234263, XrefRangeEnd = 234287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_Teleport(this IRagdollAnimator2HandlerOwner iHandler, Il2CppSystem.Nullable<Vector3> worldPosition = null, Il2CppSystem.Nullable<Quaternion> worldRotation = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)worldPosition));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)worldRotation));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_Teleport_Public_Static_Void_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Nullable_1_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234287, XrefRangeEnd = 234302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_TranslateTo(this IRagdollAnimator2HandlerOwner iHandler, Vector3 newPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_TranslateTo_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234310, RefRangeEnd = 234312, XrefRangeStart = 234302, XrefRangeEnd = 234310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_WarpRefresh(this IRagdollAnimator2HandlerOwner iHandler, int frames = 3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frames;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_WarpRefresh_Public_Static_Void_IRagdollAnimator2HandlerOwner_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234321, RefRangeEnd = 234323, XrefRangeStart = 234312, XrefRangeEnd = 234321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetStoredAnchorRootOffset(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetStoredAnchorRootOffset_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234323, XrefRangeEnd = 234331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion User_GetStoredAnchorRootOffsetRot(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetStoredAnchorRootOffsetRot_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234331, XrefRangeEnd = 234333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_BoneWorldForward(this IRagdollAnimator2HandlerOwner iHandler, RagdollChainBone bone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_BoneWorldForward_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollChainBone_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234333, XrefRangeEnd = 234335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_BoneWorldUp(this IRagdollAnimator2HandlerOwner iHandler, RagdollChainBone bone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_BoneWorldUp_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollChainBone_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234335, XrefRangeEnd = 234337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_BoneWorldRight(this IRagdollAnimator2HandlerOwner iHandler, RagdollChainBone bone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_BoneWorldRight_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollChainBone_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 234388, RefRangeEnd = 234391, XrefRangeStart = 234337, XrefRangeEnd = 234388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds User_GetRagdollBonesStateBounds(this IRagdollAnimator2HandlerOwner iHandler, bool fast = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fast;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetRagdollBonesStateBounds_Public_Static_Bounds_IRagdollAnimator2HandlerOwner_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234392, RefRangeEnd = 234393, XrefRangeStart = 234391, XrefRangeEnd = 234392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetPosition_BottomCenter(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetPosition_BottomCenter_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234394, RefRangeEnd = 234395, XrefRangeStart = 234393, XrefRangeEnd = 234394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetPosition_Center(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetPosition_Center_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234401, RefRangeEnd = 234402, XrefRangeStart = 234395, XrefRangeEnd = 234401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetPosition_AnchorBottom(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetPosition_AnchorBottom_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234408, RefRangeEnd = 234409, XrefRangeStart = 234402, XrefRangeEnd = 234408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetPosition_AnchorCenter(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetPosition_AnchorCenter_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234411, RefRangeEnd = 234412, XrefRangeStart = 234409, XrefRangeEnd = 234411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetPosition_HipsToFoot(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetPosition_HipsToFoot_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 234436, RefRangeEnd = 234445, XrefRangeStart = 234412, XrefRangeEnd = 234436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetPosition_FeetMiddle(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetPosition_FeetMiddle_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234472, RefRangeEnd = 234473, XrefRangeStart = 234445, XrefRangeEnd = 234472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion User_GetMappedRotationHipsToLegsMiddle(this IRagdollAnimator2HandlerOwner iHandler, Il2CppSystem.Nullable<Vector3> up = null, bool checkIfOnBack = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)up));
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkIfOnBack;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetMappedRotationHipsToLegsMiddle_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234473, XrefRangeEnd = 234499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion User_GetMappedRotationHipsToHead(this IRagdollAnimator2HandlerOwner iHandler, Il2CppSystem.Nullable<Vector3> up = null, bool checkIfOnBack = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)up));
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkIfOnBack;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetMappedRotationHipsToHead_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234499, XrefRangeEnd = 234525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion User_GetMappedRotationHeadToHips(this IRagdollAnimator2HandlerOwner iHandler, Il2CppSystem.Nullable<Vector3> up = null, bool checkIfOnBack = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)up));
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkIfOnBack;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetMappedRotationHeadToHips_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234539, RefRangeEnd = 234540, XrefRangeStart = 234525, XrefRangeEnd = 234539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion User_GetRotation_Mapped(this IRagdollAnimator2HandlerOwner iHandler, Vector3 up)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &up;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetRotation_Mapped_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234540, XrefRangeEnd = 234553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion User_GetRotation_MappedFor(this IRagdollAnimator2HandlerOwner iHandler, ERagdollGetUpType getupType, Vector3 up)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(ERagdollGetUpType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &getupType;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &up;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetRotation_MappedFor_Public_Static_Quaternion_IRagdollAnimator2HandlerOwner_ERagdollGetUpType_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 234602, RefRangeEnd = 234605, XrefRangeStart = 234553, XrefRangeEnd = 234602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetAverageDirectionOf(this IRagdollAnimator2HandlerOwner iHandler, RagdollBonesChain chain, RagdollChainBone.ECapsuleDirection axis)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(RagdollChainBone.ECapsuleDirection**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetAverageDirectionOf_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_RagdollBonesChain_ECapsuleDirection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234605, XrefRangeEnd = 234606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool User_GetUpByRotationPossible(this IRagdollAnimator2HandlerOwner iHandler, bool canBeNone = false, Il2CppSystem.Nullable<Vector3> up = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &canBeNone;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)up));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetUpByRotationPossible_Public_Static_Boolean_IRagdollAnimator2HandlerOwner_Boolean_Nullable_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234606, XrefRangeEnd = 234607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool User_IsOnBack(this IRagdollAnimator2HandlerOwner iHandler, bool canBeNone = false, Il2CppSystem.Nullable<Vector3> up = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &canBeNone;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)up));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_IsOnBack_Public_Static_Boolean_IRagdollAnimator2HandlerOwner_Boolean_Nullable_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234607, RefRangeEnd = 234608, XrefRangeStart = 234607, XrefRangeEnd = 234607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float User_CoreLowTranslationFactor(this IRagdollAnimator2HandlerOwner iHandler, float averageTranslationMagnitude)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &averageTranslationMagnitude;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_CoreLowTranslationFactor_Public_Static_Single_IRagdollAnimator2HandlerOwner_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 234629, RefRangeEnd = 234636, XrefRangeStart = 234608, XrefRangeEnd = 234629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ERagdollGetUpType User_CanGetUpByRotation(this IRagdollAnimator2HandlerOwner iHandler, bool canBeNone = false, Il2CppSystem.Nullable<Vector3> worldUp = null, bool includeLeftRightSide = false, float tolerance = 0.5f, Il2CppSystem.Nullable<bool> quadroped = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &canBeNone;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)worldUp));
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeLeftRightSide;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &tolerance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)quadroped));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_CanGetUpByRotation_Public_Static_ERagdollGetUpType_IRagdollAnimator2HandlerOwner_Boolean_Nullable_1_Vector3_Boolean_Single_Nullable_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ERagdollGetUpType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234648, RefRangeEnd = 234649, XrefRangeStart = 234636, XrefRangeEnd = 234648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ERagdollGetUpType User_LayingOnSide(this IRagdollAnimator2HandlerOwner iHandler, Il2CppSystem.Nullable<Vector3> worldUp = null, bool canBeNone = true, float tolerance = 0.35f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)worldUp));
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &canBeNone;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tolerance;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_LayingOnSide_Public_Static_ERagdollGetUpType_IRagdollAnimator2HandlerOwner_Nullable_1_Vector3_Boolean_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ERagdollGetUpType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234649, XrefRangeEnd = 234653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastHit User_ProbeGroundBelowAnchorBone(this IRagdollAnimator2HandlerOwner iHandler, LayerMask groundMask, Il2CppSystem.Nullable<float> distance = null, Il2CppSystem.Nullable<Vector3> worldUp = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(LayerMask**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &groundMask;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)distance));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)worldUp));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ProbeGroundBelowAnchorBone_Public_Static_RaycastHit_IRagdollAnimator2HandlerOwner_LayerMask_Nullable_1_Single_Nullable_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(RaycastHit*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234653, XrefRangeEnd = 234660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastHit User_ProbeGroundBelowHips(this IRagdollAnimator2HandlerOwner iHandler, LayerMask mask, float distance = 10f, Il2CppSystem.Nullable<Vector3> worldUp = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(LayerMask**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mask;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)worldUp));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ProbeGroundBelowHips_Public_Static_RaycastHit_IRagdollAnimator2HandlerOwner_LayerMask_Single_Nullable_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(RaycastHit*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234660, XrefRangeEnd = 234667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastHit User_ProbeGroundBelow(this IRagdollAnimator2HandlerOwner iHandler, RagdollChainBone bone, LayerMask mask, float distance = 10f, Il2CppSystem.Nullable<Vector3> worldUp = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(LayerMask**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mask;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)worldUp));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ProbeGroundBelow_Public_Static_RaycastHit_IRagdollAnimator2HandlerOwner_RagdollChainBone_LayerMask_Single_Nullable_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(RaycastHit*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234675, RefRangeEnd = 234676, XrefRangeStart = 234667, XrefRangeEnd = 234675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_TransitionToStandingMode(this IRagdollAnimator2HandlerOwner iHandler, float transitionDuration, float blendToAnimatorFor = 0.6f, float animatorTransitionDelay = 0.1f, float freezeSourceAnimatedHips = 0f, float delay = 0f, bool isOnLegsRestoreCall = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transitionDuration;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &blendToAnimatorFor;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &animatorTransitionDelay;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &freezeSourceAnimatedHips;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOnLegsRestoreCall;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_TransitionToStandingMode_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_Single_Single_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 234683, RefRangeEnd = 234687, XrefRangeStart = 234676, XrefRangeEnd = 234683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_TransitionToStandingMode(this IRagdollAnimator2HandlerOwner iHandler, float transitionDuration = 0.8f, float delay = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transitionDuration;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_TransitionToStandingMode_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234687, XrefRangeEnd = 234712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RagdollChainBone User_GetBoneSetupByHumanoidBone(this IRagdollAnimator2HandlerOwner iHandler, HumanBodyBones bone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(HumanBodyBones**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bone;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetBoneSetupByHumanoidBone_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_HumanBodyBones_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234712, XrefRangeEnd = 234717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RagdollChainBone User_GetBoneSetupByBoneID(this IRagdollAnimator2HandlerOwner iHandler, ERagdollBoneID id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(ERagdollBoneID**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetBoneSetupByBoneID_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_ERagdollBoneID_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 234722, RefRangeEnd = 234726, XrefRangeStart = 234717, XrefRangeEnd = 234722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RagdollChainBone User_GetBoneSetupBySourceAnimatorBone(this IRagdollAnimator2HandlerOwner iHandler, Transform skeletonBone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeletonBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetBoneSetupBySourceAnimatorBone_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234726, XrefRangeEnd = 234731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RagdollChainBone User_GetBoneSetupByBoneName(this IRagdollAnimator2HandlerOwner iHandler, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetBoneSetupByBoneName_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234731, XrefRangeEnd = 234736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RagdollChainBone User_GetBoneSetupByDummyBone(this IRagdollAnimator2HandlerOwner iHandler, Transform ragdollDummyTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollDummyTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetBoneSetupByDummyBone_Public_Static_RagdollChainBone_IRagdollAnimator2HandlerOwner_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234736, XrefRangeEnd = 234742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform User_GetPhysicalBoneBySourceBone(this IRagdollAnimator2HandlerOwner iHandler, Transform sourceAnimatorBone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceAnimatorBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetPhysicalBoneBySourceBone_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234742, XrefRangeEnd = 234748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform User_GetSourceBoneByPhysicalBone(this IRagdollAnimator2HandlerOwner iHandler, Transform physicalBoneTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)physicalBoneTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetSourceBoneByPhysicalBone_Public_Static_Transform_IRagdollAnimator2HandlerOwner_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 234797, RefRangeEnd = 234807, XrefRangeStart = 234748, XrefRangeEnd = 234797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_ForceMatchPhysicalBonesWithAnimator(this IRagdollAnimator2HandlerOwner iHandler, bool syncPositions = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &syncPositions;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ForceMatchPhysicalBonesWithAnimator_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234807, XrefRangeEnd = 234825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_ForceMatchPhysicalBonesWithAnimatorKinematic(this IRagdollAnimator2HandlerOwner iHandler, int fixedFrames = 2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fixedFrames;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ForceMatchPhysicalBonesWithAnimatorKinematic_Public_Static_Void_IRagdollAnimator2HandlerOwner_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 234830, RefRangeEnd = 234846, XrefRangeStart = 234825, XrefRangeEnd = 234830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SwitchFallState(this IRagdollAnimator2HandlerOwner iHandler, RagdollHandler.EAnimatingMode state)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(RagdollHandler.EAnimatingMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SwitchFallState_Public_Static_Void_IRagdollAnimator2HandlerOwner_EAnimatingMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 234851, RefRangeEnd = 234863, XrefRangeStart = 234846, XrefRangeEnd = 234851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SwitchFallState(this IRagdollAnimator2HandlerOwner iHandler, bool standing = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &standing;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SwitchFallState_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234868, RefRangeEnd = 234869, XrefRangeStart = 234863, XrefRangeEnd = 234868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_AddBoneImpact(this IRagdollAnimator2HandlerOwner iHandler, RagdollChainBone bone, Vector3 velocity, float duration, ForceMode forceMode = ForceMode.Impulse, float delay = 0f, int waitFixedFrames = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &velocity;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(ForceMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &waitFixedFrames;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_AddBoneImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_RagdollChainBone_Vector3_Single_ForceMode_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 234892, RefRangeEnd = 234895, XrefRangeStart = 234869, XrefRangeEnd = 234892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_AddRigidbodyImpact(this IRagdollAnimator2HandlerOwner iHandler, Rigidbody rigb, Vector3 velocity, float duration, ForceMode forceMode = ForceMode.Impulse, float delay = 0f, int waitFixedFrames = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigb);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &velocity;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(ForceMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &waitFixedFrames;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_AddRigidbodyImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Single_ForceMode_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234895, XrefRangeEnd = 234918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_AddRigidbodyImpactAtPosition(this IRagdollAnimator2HandlerOwner iHandler, Rigidbody rigb, Vector3 velocity, Vector3 forcePosition, float duration, ForceMode forceMode = ForceMode.Impulse, float delay = 0f, int waitFixedFrames = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigb);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &velocity;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcePosition;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(ForceMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &waitFixedFrames;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_AddRigidbodyImpactAtPosition_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Vector3_Single_ForceMode_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234918, XrefRangeEnd = 234941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_AddRigidbodyExplosionForce(this IRagdollAnimator2HandlerOwner iHandler, Rigidbody rigb, float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier = 0f, float duration = 0f, ForceMode forceMode = ForceMode.Impulse, float delay = 0f, int waitFixedFrames = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigb);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &explosionForce;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &explosionPosition;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &explosionRadius;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &upwardsModifier;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(ForceMode**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &waitFixedFrames;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_AddRigidbodyExplosionForce_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Single_Vector3_Single_Single_Single_ForceMode_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 234956, RefRangeEnd = 234962, XrefRangeStart = 234941, XrefRangeEnd = 234956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_AddChainImpact(this IRagdollAnimator2HandlerOwner iHandler, RagdollBonesChain chain, Vector3 velocity, float duration, ForceMode forceMode = ForceMode.Impulse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &velocity;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(ForceMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_AddChainImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_RagdollBonesChain_Vector3_Single_ForceMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234977, RefRangeEnd = 234978, XrefRangeStart = 234962, XrefRangeEnd = 234977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_AddChainImpactAtPosition(this IRagdollAnimator2HandlerOwner iHandler, RagdollBonesChain chain, Vector3 velocity, Vector3 position, float duration, ForceMode forceMode = ForceMode.Impulse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &velocity;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(ForceMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_AddChainImpactAtPosition_Public_Static_Void_IRagdollAnimator2HandlerOwner_RagdollBonesChain_Vector3_Vector3_Single_ForceMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234978, XrefRangeEnd = 234983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_AddChainImpact(this IRagdollAnimator2HandlerOwner iHandler, ERagdollChainType chain, Vector3 velocity, float duration, ForceMode forceMode = ForceMode.Impulse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(ERagdollChainType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chain;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &velocity;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(ForceMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_AddChainImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_ERagdollChainType_Vector3_Single_ForceMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234983, XrefRangeEnd = 234988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_AddChainImpactAtPosition(this IRagdollAnimator2HandlerOwner iHandler, ERagdollChainType chain, Vector3 velocity, Vector3 position, float duration, ForceMode forceMode = ForceMode.Impulse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(ERagdollChainType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chain;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &velocity;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(ForceMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_AddChainImpactAtPosition_Public_Static_Void_IRagdollAnimator2HandlerOwner_ERagdollChainType_Vector3_Vector3_Single_ForceMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 235013, RefRangeEnd = 235030, XrefRangeStart = 234988, XrefRangeEnd = 235013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_AddAllBonesImpact(this IRagdollAnimator2HandlerOwner iHandler, Vector3 velocity, float impactDuration = 0f, ForceMode mode = ForceMode.Impulse, float delay = 0f, int waitExtraFixedSteps = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &velocity;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &impactDuration;
		*(ForceMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &waitExtraFixedSteps;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_AddAllBonesImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_ForceMode_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235030, XrefRangeEnd = 235041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SetAllBonesVelocity(this IRagdollAnimator2HandlerOwner iHandler, Vector3 velocity, float delay = 0f, int waitExtraFixedSteps = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &velocity;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &waitExtraFixedSteps;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SetAllBonesVelocity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 235065, RefRangeEnd = 235071, XrefRangeStart = 235041, XrefRangeEnd = 235065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SetAllKinematic(this IRagdollAnimator2HandlerOwner iHandler, bool kinematic = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &kinematic;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SetAllKinematic_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235071, XrefRangeEnd = 235086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SwitchAllBonesUseGravity(this IRagdollAnimator2HandlerOwner iHandler, bool useGravity = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useGravity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SwitchAllBonesUseGravity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235086, XrefRangeEnd = 235101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SwitchAllBonesMaxVelocity(this IRagdollAnimator2HandlerOwner iHandler, float MaxVelocity = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &MaxVelocity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SwitchAllBonesMaxVelocity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235101, XrefRangeEnd = 235116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_ChangeAllRigidbodiesDrag(this IRagdollAnimator2HandlerOwner iHandler, float drag = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &drag;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ChangeAllRigidbodiesDrag_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235116, XrefRangeEnd = 235131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_ChangeAllRigidbodiesAngularDrag(this IRagdollAnimator2HandlerOwner iHandler, float drag = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &drag;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ChangeAllRigidbodiesAngularDrag_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235131, XrefRangeEnd = 235147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_AddAllImpact(this IRagdollAnimator2HandlerOwner iHandler, Vector3 force, float duration, ForceMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(ForceMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_AddAllImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_ForceMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 235162, RefRangeEnd = 235165, XrefRangeStart = 235147, XrefRangeEnd = 235162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SetAllVelocity(this IRagdollAnimator2HandlerOwner iHandler, Vector3 worldVelocity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldVelocity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SetAllVelocity_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235165, XrefRangeEnd = 235185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_ResetAngularVelocityForAllBones(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_ResetAngularVelocityForAllBones_Public_Static_Void_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235185, XrefRangeEnd = 235200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SetAllAngularSpeedLimit(this IRagdollAnimator2HandlerOwner iHandler, float angularSpeedLimit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &angularSpeedLimit;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SetAllAngularSpeedLimit_Public_Static_Void_IRagdollAnimator2HandlerOwner_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235200, XrefRangeEnd = 235215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SetAllIterpolation(this IRagdollAnimator2HandlerOwner iHandler, RigidbodyInterpolation interpolation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(RigidbodyInterpolation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &interpolation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SetAllIterpolation_Public_Static_Void_IRagdollAnimator2HandlerOwner_RigidbodyInterpolation_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235216, RefRangeEnd = 235217, XrefRangeStart = 235215, XrefRangeEnd = 235216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyLimbImpact(Rigidbody rigidbody, Vector3 powerDirection, ForceMode forceMode = ForceMode.Impulse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &powerDirection;
		*(ForceMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyLimbImpact_Public_Static_Void_Rigidbody_Vector3_ForceMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235218, RefRangeEnd = 235219, XrefRangeStart = 235217, XrefRangeEnd = 235218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyLimbImpactAtPosition(Rigidbody rigidbody, Vector3 powerDirection, Vector3 forcePosition, ForceMode forceMode = ForceMode.Impulse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &powerDirection;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcePosition;
		*(ForceMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyLimbImpactAtPosition_Public_Static_Void_Rigidbody_Vector3_Vector3_ForceMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235219, XrefRangeEnd = 235220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyLimbExplosionForce(Rigidbody rigidbody, float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier = 0f, ForceMode forceMode = ForceMode.Impulse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &explosionForce;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &explosionPosition;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &explosionRadius;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &upwardsModifier;
		*(ForceMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyLimbExplosionForce_Public_Static_Void_Rigidbody_Single_Vector3_Single_Single_ForceMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235220, XrefRangeEnd = 235229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SetPhysicalTorqueOnRigidbody(this IRagdollAnimator2HandlerOwner iHandler, Rigidbody limb, Vector3 rotationPower, float duration, bool relativeSpace = false, ForceMode forceMode = ForceMode.Impulse, bool deltaScale = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)limb);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotationPower;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &relativeSpace;
		*(ForceMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMode;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaScale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SetPhysicalTorqueOnRigidbody_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Single_Boolean_ForceMode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235229, XrefRangeEnd = 235250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SetAllPhysicalTorque(this IRagdollAnimator2HandlerOwner iHandler, Vector3 localEuler, float duration, bool relativeSpace = false, Transform localOf = null, Il2CppSystem.Nullable<Vector3> power = null, ForceMode force = ForceMode.Impulse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &localEuler;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &relativeSpace;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)localOf);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)power));
		*(ForceMode**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SetAllPhysicalTorque_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_Boolean_Transform_Nullable_1_Vector3_ForceMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235250, XrefRangeEnd = 235271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_SetPhysicalTorque(this IRagdollAnimator2HandlerOwner iHandler, Rigidbody rigidbody, Vector3 localEuler, float duration, bool relativeSpace = false, Transform localOf = null, Il2CppSystem.Nullable<Vector3> power = null, ForceMode force = ForceMode.Impulse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &localEuler;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &relativeSpace;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)localOf);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)power));
		*(ForceMode**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_SetPhysicalTorque_Public_Static_Void_IRagdollAnimator2HandlerOwner_Rigidbody_Vector3_Single_Boolean_Transform_Nullable_1_Vector3_ForceMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235271, XrefRangeEnd = 235306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetAllBonesMaxVelocity(this IRagdollAnimator2HandlerOwner iHandler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetAllBonesMaxVelocity_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235328, RefRangeEnd = 235330, XrefRangeStart = 235306, XrefRangeEnd = 235328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetChainBonesAverageTranslation(this IRagdollAnimator2HandlerOwner iHandler, ERagdollChainType chainType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(ERagdollChainType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chainType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetChainBonesAverageTranslation_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235330, XrefRangeEnd = 235350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float User_GetChainBonesAverageAngularVelocity(this IRagdollAnimator2HandlerOwner iHandler, ERagdollChainType chainType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(ERagdollChainType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chainType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetChainBonesAverageAngularVelocity_Public_Static_Single_IRagdollAnimator2HandlerOwner_ERagdollChainType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235372, RefRangeEnd = 235374, XrefRangeStart = 235350, XrefRangeEnd = 235372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetChainBonesVelocity(this IRagdollAnimator2HandlerOwner iHandler, ERagdollChainType chainType, bool average = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(ERagdollChainType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chainType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &average;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetChainBonesVelocity_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_ERagdollChainType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235396, RefRangeEnd = 235398, XrefRangeStart = 235374, XrefRangeEnd = 235396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 User_GetChainAngularVelocity(this IRagdollAnimator2HandlerOwner iHandler, ERagdollChainType chainType, bool average = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(ERagdollChainType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chainType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &average;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_GetChainAngularVelocity_Public_Static_Vector3_IRagdollAnimator2HandlerOwner_ERagdollChainType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235398, XrefRangeEnd = 235408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void User_FallImpact(this IRagdollAnimator2HandlerOwner iHandler, Vector3 impactDirection, float power, float impactDuration = 0.15f, float bodyPushPower = 1f, Rigidbody hittedBone = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iHandler);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &impactDirection;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &power;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &impactDuration;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bodyPushPower;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hittedBone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_User_FallImpact_Public_Static_Void_IRagdollAnimator2HandlerOwner_Vector3_Single_Single_Single_Rigidbody_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RagdollHandlerUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
