using System;
using System.Runtime.CompilerServices;
using FIMSpace.FGenerating;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace FIMSpace.FProceduralAnimation;

public class RAF_BlendOnCollisions : RagdollAnimatorFeatureBase
{
	public class BlendOnCollisionChain : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_OwnerChain;

		private static readonly System.IntPtr NativeFieldInfoPtr_ParentOfChain;

		private static readonly System.IntPtr NativeFieldInfoPtr_Bones;

		private static readonly System.IntPtr NativeFieldInfoPtr_SkipLastBoneCollisionCheck;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RagdollBonesChain_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_Boolean_Boolean_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBoneControllerBlendsToDummyBones_Public_Void_0;

		public unsafe RagdollBonesChain OwnerChain
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OwnerChain);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OwnerChain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollBonesChain));
			}
		}

		public unsafe BlendOnCollisionChain ParentOfChain
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParentOfChain);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BlendOnCollisionChain>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParentOfChain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blendOnCollisionChain));
			}
		}

		public unsafe List<BlendOnCollisionBone> Bones
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bones);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BlendOnCollisionBone>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool SkipLastBoneCollisionCheck
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkipLastBoneCollisionCheck);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkipLastBoneCollisionCheck)) = flag;
			}
		}

		static BlendOnCollisionChain()
		{
			Il2CppClassPointerStore<BlendOnCollisionChain>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "BlendOnCollisionChain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendOnCollisionChain>.NativeClassPtr);
			NativeFieldInfoPtr_OwnerChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendOnCollisionChain>.NativeClassPtr, "OwnerChain");
			NativeFieldInfoPtr_ParentOfChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendOnCollisionChain>.NativeClassPtr, "ParentOfChain");
			NativeFieldInfoPtr_Bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendOnCollisionChain>.NativeClassPtr, "Bones");
			NativeFieldInfoPtr_SkipLastBoneCollisionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendOnCollisionChain>.NativeClassPtr, "SkipLastBoneCollisionCheck");
			NativeMethodInfoPtr__ctor_Public_Void_RagdollBonesChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendOnCollisionChain>.NativeClassPtr, 100677538);
			NativeMethodInfoPtr_Update_Public_Void_Single_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendOnCollisionChain>.NativeClassPtr, 100677539);
			NativeMethodInfoPtr_ApplyBoneControllerBlendsToDummyBones_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendOnCollisionChain>.NativeClassPtr, 100677540);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236199, RefRangeEnd = 236200, XrefRangeStart = 236190, XrefRangeEnd = 236199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendOnCollisionChain(RagdollBonesChain chain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendOnCollisionChain>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RagdollBonesChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236231, RefRangeEnd = 236232, XrefRangeStart = 236200, XrefRangeEnd = 236231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(float delta, bool applyOnWholeChain, bool sensitive, float blendOffDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&delta);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &applyOnWholeChain;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sensitive;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &blendOffDelay;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_Single_Boolean_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 236246, RefRangeEnd = 236250, XrefRangeStart = 236232, XrefRangeEnd = 236246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyBoneControllerBlendsToDummyBones()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBoneControllerBlendsToDummyBones_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BlendOnCollisionChain(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class BlendOnCollisionBone : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ParentChain;

		private static readonly System.IntPtr NativeFieldInfoPtr_ParentBone;

		private static readonly System.IntPtr NativeFieldInfoPtr_CollisionHandler;

		private static readonly System.IntPtr NativeFieldInfoPtr_Blend;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastBlendIn;

		private static readonly System.IntPtr NativeFieldInfoPtr_sd;

		private static readonly System.IntPtr NativeMethodInfoPtr_WasColliding_Public_Boolean_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BlendOnCollisionChain_RagdollChainBone_RA2BoneCollisionHandlerBase_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BlendIn_Public_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BlendOff_Public_Void_Single_Single_0;

		public unsafe BlendOnCollisionChain ParentChain
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParentChain);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BlendOnCollisionChain>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParentChain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blendOnCollisionChain));
			}
		}

		public unsafe RagdollChainBone ParentBone
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParentBone);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollChainBone>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParentBone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollChainBone));
			}
		}

		public unsafe RA2BoneCollisionHandlerBase CollisionHandler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CollisionHandler);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RA2BoneCollisionHandlerBase>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CollisionHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rA2BoneCollisionHandlerBase));
			}
		}

		public unsafe float Blend
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Blend);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Blend)) = num;
			}
		}

		public unsafe float lastBlendIn
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastBlendIn);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastBlendIn)) = num;
			}
		}

		public unsafe float sd
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sd);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sd)) = num;
			}
		}

		static BlendOnCollisionBone()
		{
			Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "BlendOnCollisionBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr);
			NativeFieldInfoPtr_ParentChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr, "ParentChain");
			NativeFieldInfoPtr_ParentBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr, "ParentBone");
			NativeFieldInfoPtr_CollisionHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr, "CollisionHandler");
			NativeFieldInfoPtr_Blend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr, "Blend");
			NativeFieldInfoPtr_lastBlendIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr, "lastBlendIn");
			NativeFieldInfoPtr_sd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr, "sd");
			NativeMethodInfoPtr_WasColliding_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr, 100677541);
			NativeMethodInfoPtr__ctor_Public_Void_BlendOnCollisionChain_RagdollChainBone_RA2BoneCollisionHandlerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr, 100677542);
			NativeMethodInfoPtr_BlendIn_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr, 100677543);
			NativeMethodInfoPtr_BlendOff_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr, 100677544);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236250, XrefRangeEnd = 236251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WasColliding(float duration = 0.4f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&duration);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WasColliding_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236255, RefRangeEnd = 236256, XrefRangeStart = 236251, XrefRangeEnd = 236255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendOnCollisionBone(BlendOnCollisionChain chain, RagdollChainBone bone, RA2BoneCollisionHandlerBase handler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendOnCollisionBone>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BlendOnCollisionChain_RagdollChainBone_RA2BoneCollisionHandlerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 236257, RefRangeEnd = 236261, XrefRangeStart = 236256, XrefRangeEnd = 236257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendIn(float delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&delta);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlendIn_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236263, RefRangeEnd = 236265, XrefRangeStart = 236261, XrefRangeEnd = 236263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendOff(float delta, float blendOffDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&delta);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &blendOffDelay;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlendOff_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BlendOnCollisionBone(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_blendChains;

	private static readonly System.IntPtr NativeFieldInfoPtr_legChains;

	private static readonly System.IntPtr NativeFieldInfoPtr_legBlendChains;

	private static readonly System.IntPtr NativeFieldInfoPtr_coreChain;

	private static readonly System.IntPtr NativeFieldInfoPtr_coreBlendChain;

	private static readonly System.IntPtr NativeFieldInfoPtr_blendingSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_applyOnWholeChains;

	private static readonly System.IntPtr NativeFieldInfoPtr_sensitiveBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipFeet;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignoreSelf;

	private static readonly System.IntPtr NativeFieldInfoPtr_coreBlendLegs;

	private static readonly System.IntPtr NativeFieldInfoPtr_turnOffLegs;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitIndicators_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionHandler_Protected_Virtual_New_RA2BoneCollisionHandlerBase_RagdollChainBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroyFeature_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisableRagdoll_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBlending_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlendInAll_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlendLegChain_Private_Void_RagdollBonesChain_Single_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableRagdoll_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<BlendOnCollisionChain> blendChains
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendChains);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BlendOnCollisionChain>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendChains)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RagdollBonesChain> legChains
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_legChains);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RagdollBonesChain>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_legChains)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BlendOnCollisionChain> legBlendChains
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_legBlendChains);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BlendOnCollisionChain>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_legBlendChains)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe RagdollBonesChain coreChain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coreChain);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollBonesChain>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coreChain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollBonesChain));
		}
	}

	public unsafe BlendOnCollisionChain coreBlendChain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coreBlendChain);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BlendOnCollisionChain>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coreBlendChain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blendOnCollisionChain));
		}
	}

	public unsafe FUniversalVariable blendingSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingSpeed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingSpeed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable applyOnWholeChains
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyOnWholeChains);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyOnWholeChains)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable sensitiveBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sensitiveBlend);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sensitiveBlend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable skipFeet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipFeet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipFeet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable ignoreSelf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreSelf);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreSelf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable coreBlendLegs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coreBlendLegs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coreBlendLegs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	public unsafe FUniversalVariable turnOffLegs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnOffLegs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FUniversalVariable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnOffLegs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fUniversalVariable));
		}
	}

	static RAF_BlendOnCollisions()
	{
		Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RAF_BlendOnCollisions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr);
		NativeFieldInfoPtr_blendChains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "blendChains");
		NativeFieldInfoPtr_legChains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "legChains");
		NativeFieldInfoPtr_legBlendChains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "legBlendChains");
		NativeFieldInfoPtr_coreChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "coreChain");
		NativeFieldInfoPtr_coreBlendChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "coreBlendChain");
		NativeFieldInfoPtr_blendingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "blendingSpeed");
		NativeFieldInfoPtr_applyOnWholeChains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "applyOnWholeChains");
		NativeFieldInfoPtr_sensitiveBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "sensitiveBlend");
		NativeFieldInfoPtr_skipFeet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "skipFeet");
		NativeFieldInfoPtr_ignoreSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "ignoreSelf");
		NativeFieldInfoPtr_coreBlendLegs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "coreBlendLegs");
		NativeFieldInfoPtr_turnOffLegs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, "turnOffLegs");
		NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, 100677528);
		NativeMethodInfoPtr_InitIndicators_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, 100677529);
		NativeMethodInfoPtr_GetCollisionHandler_Protected_Virtual_New_RA2BoneCollisionHandlerBase_RagdollChainBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, 100677530);
		NativeMethodInfoPtr_OnDestroyFeature_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, 100677531);
		NativeMethodInfoPtr_OnDisableRagdoll_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, 100677532);
		NativeMethodInfoPtr_UpdateBlending_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, 100677533);
		NativeMethodInfoPtr_BlendInAll_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, 100677534);
		NativeMethodInfoPtr_BlendLegChain_Private_Void_RagdollBonesChain_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, 100677535);
		NativeMethodInfoPtr_OnEnableRagdoll_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, 100677536);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr, 100677537);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236265, XrefRangeEnd = 236420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool OnInit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnInit_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236420, XrefRangeEnd = 236422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void InitIndicators()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitIndicators_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236422, XrefRangeEnd = 236431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual RA2BoneCollisionHandlerBase GetCollisionHandler(RagdollChainBone bone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCollisionHandler_Protected_Virtual_New_RA2BoneCollisionHandlerBase_RagdollChainBone_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RA2BoneCollisionHandlerBase>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236431, XrefRangeEnd = 236466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDestroyFeature()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDestroyFeature_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236466, XrefRangeEnd = 236505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDisableRagdoll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDisableRagdoll_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236505, XrefRangeEnd = 236622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateBlending()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBlending_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236668, RefRangeEnd = 236669, XrefRangeStart = 236622, XrefRangeEnd = 236668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlendInAll(float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlendInAll_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 236682, RefRangeEnd = 236685, XrefRangeStart = 236669, XrefRangeEnd = 236682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlendLegChain(RagdollBonesChain chain, float target, float delta, bool skipFeet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipFeet;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlendLegChain_Private_Void_RagdollBonesChain_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17126)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 17126, XrefRangeStart = 0, XrefRangeEnd = 17126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnEnableRagdoll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnEnableRagdoll_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(42)]
	[CachedScanResults(RefRangeStart = 43568, RefRangeEnd = 43610, XrefRangeStart = 43568, XrefRangeEnd = 43610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RAF_BlendOnCollisions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RAF_BlendOnCollisions>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RAF_BlendOnCollisions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
