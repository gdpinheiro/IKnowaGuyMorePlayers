using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;

public static class NPCDataLoader : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("NPCDataLoader+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__87_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__88_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__101_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__102_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__113_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetRandomNormalNPCData_b__87_0_Internal_Boolean_NPCDialogueData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetRandomShadyNPCData_b__88_0_Internal_Boolean_NPCDialogueData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetNextShadyCustomerForSpawn_b__101_0_Internal_Boolean_ShadyNPCDialogueData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__BuildShadyCategoryQueues_b__102_1_Internal_Int32_ShadyNPCDialogueData_ShadyNPCDialogueData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetTutorialShadyQuest_b__113_0_Internal_Boolean_ShadyNPCDialogueData_0;

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NPCDialogueData> __9__87_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__87_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NPCDialogueData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__87_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NPCDialogueData> __9__88_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__88_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NPCDialogueData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__88_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<ShadyNPCDialogueData> __9__101_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__101_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ShadyNPCDialogueData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__101_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<ShadyNPCDialogueData> __9__102_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__102_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ShadyNPCDialogueData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__102_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<ShadyNPCDialogueData> __9__113_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__113_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ShadyNPCDialogueData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__113_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__87_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__87_0");
			NativeFieldInfoPtr___9__88_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__88_0");
			NativeFieldInfoPtr___9__101_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__101_0");
			NativeFieldInfoPtr___9__102_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__102_1");
			NativeFieldInfoPtr___9__113_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__113_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663399);
			NativeMethodInfoPtr__GetRandomNormalNPCData_b__87_0_Internal_Boolean_NPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663400);
			NativeMethodInfoPtr__GetRandomShadyNPCData_b__88_0_Internal_Boolean_NPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663401);
			NativeMethodInfoPtr__GetNextShadyCustomerForSpawn_b__101_0_Internal_Boolean_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663402);
			NativeMethodInfoPtr__BuildShadyCategoryQueues_b__102_1_Internal_Int32_ShadyNPCDialogueData_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663403);
			NativeMethodInfoPtr__GetTutorialShadyQuest_b__113_0_Internal_Boolean_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663404);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetRandomNormalNPCData_b__87_0(NPCDialogueData d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetRandomNormalNPCData_b__87_0_Internal_Boolean_NPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _GetRandomShadyNPCData_b__88_0(NPCDialogueData d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetRandomShadyNPCData_b__88_0_Internal_Boolean_NPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19891, XrefRangeEnd = 19895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetNextShadyCustomerForSpawn_b__101_0(ShadyNPCDialogueData q)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)q);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetNextShadyCustomerForSpawn_b__101_0_Internal_Boolean_ShadyNPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19895, XrefRangeEnd = 19897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _BuildShadyCategoryQueues_b__102_1(ShadyNPCDialogueData a, ShadyNPCDialogueData b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BuildShadyCategoryQueues_b__102_1_Internal_Int32_ShadyNPCDialogueData_ShadyNPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _GetTutorialShadyQuest_b__113_0(ShadyNPCDialogueData d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetTutorialShadyQuest_b__113_0_Internal_Boolean_ShadyNPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NPCDataLoader+<>c__DisplayClass102_0")]
	public sealed class __c__DisplayClass102_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cat;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__BuildShadyCategoryQueues_b__0_Internal_Boolean_ShadyNPCDialogueData_0;

		public unsafe ShadyMissionCategory cat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cat);
				return *(ShadyMissionCategory*)num;
			}
			set
			{
				*(ShadyMissionCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cat)) = shadyMissionCategory;
			}
		}

		static __c__DisplayClass102_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "<>c__DisplayClass102_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr);
			NativeFieldInfoPtr_cat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr, "cat");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr, 100663405);
			NativeMethodInfoPtr__BuildShadyCategoryQueues_b__0_Internal_Boolean_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr, 100663406);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass102_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass102_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _BuildShadyCategoryQueues_b__0(ShadyNPCDialogueData d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BuildShadyCategoryQueues_b__0_Internal_Boolean_ShadyNPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass102_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NPCDataLoader+<>c__DisplayClass107_0")]
	public sealed class __c__DisplayClass107_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_prefabNumber;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetShadyCustomerByPrefabNumber_b__0_Internal_Boolean_ShadyNPCDialogueData_0;

		public unsafe int prefabNumber
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabNumber);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabNumber)) = num;
			}
		}

		static __c__DisplayClass107_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass107_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "<>c__DisplayClass107_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass107_0>.NativeClassPtr);
			NativeFieldInfoPtr_prefabNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass107_0>.NativeClassPtr, "prefabNumber");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass107_0>.NativeClassPtr, 100663407);
			NativeMethodInfoPtr__GetShadyCustomerByPrefabNumber_b__0_Internal_Boolean_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass107_0>.NativeClassPtr, 100663408);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass107_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass107_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetShadyCustomerByPrefabNumber_b__0(ShadyNPCDialogueData d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetShadyCustomerByPrefabNumber_b__0_Internal_Boolean_ShadyNPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass107_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NPCDataLoader+<>c__DisplayClass108_0")]
	public sealed class __c__DisplayClass108_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_missionNumber;

		private static readonly System.IntPtr NativeFieldInfoPtr_category;

		private static readonly System.IntPtr NativeFieldInfoPtr_level;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetShadyCustomerByMissionNumber_b__0_Internal_Boolean_ShadyNPCDialogueData_0;

		public unsafe int missionNumber
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNumber);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNumber)) = num;
			}
		}

		public unsafe ShadyMissionCategory category
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category);
				return *(ShadyMissionCategory*)num;
			}
			set
			{
				*(ShadyMissionCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category)) = shadyMissionCategory;
			}
		}

		public unsafe int level
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level)) = num;
			}
		}

		static __c__DisplayClass108_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "<>c__DisplayClass108_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr);
			NativeFieldInfoPtr_missionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr, "missionNumber");
			NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr, "category");
			NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr, "level");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr, 100663409);
			NativeMethodInfoPtr__GetShadyCustomerByMissionNumber_b__0_Internal_Boolean_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr, 100663410);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass108_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass108_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetShadyCustomerByMissionNumber_b__0(ShadyNPCDialogueData d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetShadyCustomerByMissionNumber_b__0_Internal_Boolean_ShadyNPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass108_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NPCDataLoader+<>c__DisplayClass109_0")]
	public sealed class __c__DisplayClass109_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_missionNumber;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetShadyCustomerByMissionNumber_b__0_Internal_Boolean_ShadyNPCDialogueData_0;

		public unsafe int missionNumber
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNumber);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNumber)) = num;
			}
		}

		static __c__DisplayClass109_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "<>c__DisplayClass109_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr);
			NativeFieldInfoPtr_missionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr, "missionNumber");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr, 100663411);
			NativeMethodInfoPtr__GetShadyCustomerByMissionNumber_b__0_Internal_Boolean_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr, 100663412);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass109_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetShadyCustomerByMissionNumber_b__0(ShadyNPCDialogueData d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetShadyCustomerByMissionNumber_b__0_Internal_Boolean_ShadyNPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass109_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NPCDataLoader+<>c__DisplayClass110_0")]
	public sealed class __c__DisplayClass110_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_deliveryType;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetNextShadyCustomerByDeliveryType_b__0_Internal_Boolean_ShadyNPCDialogueData_0;

		public unsafe ShadyDeliveryType deliveryType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveryType);
				return *(ShadyDeliveryType*)num;
			}
			set
			{
				*(ShadyDeliveryType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveryType)) = shadyDeliveryType;
			}
		}

		static __c__DisplayClass110_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass110_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "<>c__DisplayClass110_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass110_0>.NativeClassPtr);
			NativeFieldInfoPtr_deliveryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass110_0>.NativeClassPtr, "deliveryType");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass110_0>.NativeClassPtr, 100663413);
			NativeMethodInfoPtr__GetNextShadyCustomerByDeliveryType_b__0_Internal_Boolean_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass110_0>.NativeClassPtr, 100663414);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass110_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass110_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetNextShadyCustomerByDeliveryType_b__0(ShadyNPCDialogueData q)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)q);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetNextShadyCustomerByDeliveryType_b__0_Internal_Boolean_ShadyNPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass110_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NPCDataLoader+<>c__DisplayClass111_0")]
	public sealed class __c__DisplayClass111_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_taskType;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetNextShadyCustomerByTaskType_b__0_Internal_Boolean_ShadyNPCDialogueData_0;

		public unsafe ShadyTaskType taskType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskType);
				return *(ShadyTaskType*)num;
			}
			set
			{
				*(ShadyTaskType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskType)) = shadyTaskType;
			}
		}

		static __c__DisplayClass111_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass111_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "<>c__DisplayClass111_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass111_0>.NativeClassPtr);
			NativeFieldInfoPtr_taskType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass111_0>.NativeClassPtr, "taskType");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass111_0>.NativeClassPtr, 100663415);
			NativeMethodInfoPtr__GetNextShadyCustomerByTaskType_b__0_Internal_Boolean_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass111_0>.NativeClassPtr, 100663416);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass111_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass111_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19897, XrefRangeEnd = 19899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetNextShadyCustomerByTaskType_b__0(ShadyNPCDialogueData q)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)q);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetNextShadyCustomerByTaskType_b__0_Internal_Boolean_ShadyNPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass111_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NPCDataLoader+<>c__DisplayClass114_0")]
	public sealed class __c__DisplayClass114_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_prefabNumber;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetNormalCustomerByPrefabNumber_b__0_Internal_Boolean_NPCDialogueData_0;

		public unsafe int prefabNumber
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabNumber);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabNumber)) = num;
			}
		}

		static __c__DisplayClass114_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "<>c__DisplayClass114_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr);
			NativeFieldInfoPtr_prefabNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr, "prefabNumber");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr, 100663417);
			NativeMethodInfoPtr__GetNormalCustomerByPrefabNumber_b__0_Internal_Boolean_NPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr, 100663418);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass114_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass114_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetNormalCustomerByPrefabNumber_b__0(NPCDialogueData d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetNormalCustomerByPrefabNumber_b__0_Internal_Boolean_NPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass114_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NPCDataLoader+<>c__DisplayClass89_0")]
	public sealed class __c__DisplayClass89_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_npcName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetNPCDataByName_b__0_Internal_Boolean_NPCDialogueData_0;

		public unsafe string npcName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static __c__DisplayClass89_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "<>c__DisplayClass89_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr);
			NativeFieldInfoPtr_npcName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr, "npcName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr, 100663419);
			NativeMethodInfoPtr__GetNPCDataByName_b__0_Internal_Boolean_NPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr, 100663420);
		}

		[CallerCount(2493)]
		[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass89_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19899, XrefRangeEnd = 19923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetNPCDataByName_b__0(NPCDialogueData d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetNPCDataByName_b__0_Internal_Boolean_NPCDialogueData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass89_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NPCDataLoader+<PreloadNormalDataAsync>d__69")]
	public sealed class _PreloadNormalDataAsync_d__69 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr__localeCode_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__request_5__3;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeFieldInfoPtr__lines_5__4;

		private static readonly System.IntPtr NativeFieldInfoPtr__i_5__5;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__2;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe AsyncUniTaskMethodBuilder __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncUniTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe string _localeCode_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__localeCode_5__2);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__localeCode_5__2)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe ResourceRequest _request_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__request_5__3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__request_5__3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceRequest));
			}
		}

		public unsafe UnityAsyncExtensions.ResourceRequestAwaiter __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new UnityAsyncExtensions.ResourceRequestAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityAsyncExtensions.ResourceRequestAwaiter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceRequestAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnityAsyncExtensions.ResourceRequestAwaiter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppStringArray _lines_5__4
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lines_5__4);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lines_5__4)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe int _i_5__5
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__5);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__5)) = num;
			}
		}

		public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__2);
				return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*)num;
			}
			set
			{
				*(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__2)) = awaiter;
			}
		}

		static _PreloadNormalDataAsync_d__69()
		{
			Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "<PreloadNormalDataAsync>d__69");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr__localeCode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr, "<localeCode>5__2");
			NativeFieldInfoPtr__request_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr, "<request>5__3");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr, "<>u__1");
			NativeFieldInfoPtr__lines_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr, "<lines>5__4");
			NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr, "<i>5__5");
			NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr, "<>u__2");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr, 100663421);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr, 100663422);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20048, RefRangeEnd = 20051, XrefRangeStart = 19923, XrefRangeEnd = 20048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20051, XrefRangeEnd = 20052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _PreloadNormalDataAsync_d__69(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _PreloadNormalDataAsync_d__69()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_PreloadNormalDataAsync_d__69>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("NPCDataLoader+<PreloadShadyDataAsync>d__70")]
	public sealed class _PreloadShadyDataAsync_d__70 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe AsyncUniTaskMethodBuilder __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncUniTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*)num;
			}
			set
			{
				*(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1)) = awaiter;
			}
		}

		static _PreloadShadyDataAsync_d__70()
		{
			Il2CppClassPointerStore<_PreloadShadyDataAsync_d__70>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "<PreloadShadyDataAsync>d__70");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_PreloadShadyDataAsync_d__70>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PreloadShadyDataAsync_d__70>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PreloadShadyDataAsync_d__70>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PreloadShadyDataAsync_d__70>.NativeClassPtr, "<>u__1");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PreloadShadyDataAsync_d__70>.NativeClassPtr, 100663423);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PreloadShadyDataAsync_d__70>.NativeClassPtr, 100663424);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20076, RefRangeEnd = 20078, XrefRangeStart = 20052, XrefRangeEnd = 20076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _PreloadShadyDataAsync_d__70(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _PreloadShadyDataAsync_d__70()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_PreloadShadyDataAsync_d__70>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_BASE_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_NORMAL_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_NORMAL_FILE_NAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHADY_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHADY_TUTORIAL_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHADY_DARKWEB_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHADY_WASHING_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHADY_INCINERATOR_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHADY_FORGERY_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_DARKWEB_LEVELS;

	private static readonly System.IntPtr NativeFieldInfoPtr_WASHING_LEVELS;

	private static readonly System.IntPtr NativeFieldInfoPtr_INCINERATOR_LEVELS;

	private static readonly System.IntPtr NativeFieldInfoPtr_FORGERY_LEVELS;

	private static readonly System.IntPtr NativeFieldInfoPtr_QUEST_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_QUEST_FILE_NAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_CASEOH_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CASEOH_FILE_NAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_DARKWEB_LISTINGS_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_DARKWEB_LISTINGS_FILE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHADY_INGREDIENT_LISTINGS_FILE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DUMMY_NPC_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_DUMMY_NPC_FILE;

	private static readonly System.IntPtr NativeFieldInfoPtr_REDLINE_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_REDLINE_FILE;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedData;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedNormalCustomers;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedShadyCustomers;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShadyLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedQuestNPCGroups;

	private static readonly System.IntPtr NativeFieldInfoPtr_isQuestLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedCaseOhQuests;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCaseOhLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedListingTexts;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDarkWebListingsLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedIngredientListingTexts;

	private static readonly System.IntPtr NativeFieldInfoPtr_isIngredientListingsLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedDummyNPCData;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDummyNPCLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedRedlineCallers;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRedlineLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_TONY_SLICE_FOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_TONY_SLICE_FILE;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedTonySliceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTonySliceLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedLocaleCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentDialogueRound;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedPrefabsInCurrentRound;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextNormalSpawnIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_allRoundsExhausted;

	private static readonly System.IntPtr NativeFieldInfoPtr_RANDOM_COOLDOWN_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_recentRandomPrefabs;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHADY_SPAWN_PATTERN;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyPatternPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyCategoryQueues;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadyCategoryIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedShadyQuestNumbers;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasSeenWashingPreview;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasSeenIncineratorPreview;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasSeenForgeryPreview;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GenericOrderDialogue_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AcceptButtonText_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DeclineButtonText_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomShadyAcceptText_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomShadyDeclineText_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrderDialogue_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreloadNormalDataAsync_Public_Static_UniTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreloadShadyDataAsync_Public_Static_UniTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckLocaleChange_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllNPCData_Public_Static_List_1_NPCDialogueData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadTSVFile_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseTSVLine_Private_Static_NPCDialogueData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseTSVFields_Private_Static_List_1_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadJSONFiles_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseJsonFile_Private_Static_Void_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextNormalCustomerForSpawn_Public_Static_ValueTuple_2_NPCDialogueData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdvanceToNextRound_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetRounds_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AreAllNormalRoundsExhausted_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomNPCWithCooldown_Private_Static_NPCDialogueData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentDialogueRound_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpawnedCountInCurrentRound_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNormalCustomerCount_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomNPCData_Public_Static_NPCDialogueData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomNormalNPCData_Public_Static_NPCDialogueData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomShadyNPCData_Public_Static_NPCDialogueData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNPCDataByName_Public_Static_NPCDialogueData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCache_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearDataCacheOnly_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentLocaleCode_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSampleJson_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLoadedCount_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadyCustomerCount_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllShadyNPCData_Public_Static_List_1_ShadyNPCDialogueData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadShadyCategoryLevels_Private_Static_Void_String_ShadyMissionCategory_Il2CppReferenceArray_1_ValueTuple_3_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadShadyCategoryFolder_Private_Static_Void_String_ShadyMissionCategory_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseShadyTSVFile_Private_Static_Void_TextAsset_ShadyMissionCategory_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseShadyMissionLine_Private_Static_ShadyNPCDialogueData_String_ShadyMissionCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextShadyCustomerForSpawn_Public_Static_ShadyNPCDialogueData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildShadyCategoryQueues_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUpgradeUnlocked_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRandomShadyQuest_Private_Static_ShadyNPCDialogueData_ShadyMissionCategory_List_1_ShadyNPCDialogueData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGenericShadyDialogue_Private_Static_String_ShadyMissionCategory_ShadyDeliveryType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkShadyQuestAsForced_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadyCustomerByPrefabNumber_Public_Static_ShadyNPCDialogueData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadyCustomerByMissionNumber_Public_Static_ShadyNPCDialogueData_Int32_ShadyMissionCategory_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadyCustomerByMissionNumber_Public_Static_ShadyNPCDialogueData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextShadyCustomerByDeliveryType_Public_Static_ShadyNPCDialogueData_ShadyDeliveryType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextShadyCustomerByTaskType_Public_Static_ShadyNPCDialogueData_ShadyTaskType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextShadyCustomerWithFilter_Private_Static_ShadyNPCDialogueData_Func_2_ShadyNPCDialogueData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTutorialShadyQuest_Public_Static_ShadyNPCDialogueData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNormalCustomerByPrefabNumber_Public_Static_NPCDialogueData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllShadyPrefabNumbers_Public_Static_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdvanceShadyCategoryIndexPastQuest_Public_Static_Void_ShadyMissionCategory_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetShadyRounds_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpawnedShadyCount_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AreAllShadyQuestsExhausted_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllOpenWorldQuestData_Public_Static_Dictionary_2_Int32_OpenWorldNPCQuestGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseOpenWorldQuestLines_Private_Static_OpenWorldQuestData_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuestGroupByNPCNumber_Public_Static_OpenWorldNPCQuestGroup_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSeenPreviewPopup_Public_Static_Boolean_ShadyMissionCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkPreviewPopupSeen_Public_Static_Void_ShadyMissionCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpawnState_Public_Static_ValueTuple_8_Int32_HashSet_1_Int32_Int32_Int32_Int32_Int32_Int32_ValueTuple_3_HashSet_1_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreSpawnState_Public_Static_Void_Int32_HashSet_1_Int32_Int32_Int32_Int32_Int32_Int32_HashSet_1_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviewPopupState_Public_Static_ValueTuple_3_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestorePreviewPopupState_Public_Static_Void_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadDarkWebListings_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetListingTexts_Public_Static_List_1_DarkWebListingText_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetListingText_Public_Static_DarkWebListingText_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadShadyIngredientListings_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomIngredientListing_Public_Static_DarkWebListingText_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIngredientListingTexts_Public_Static_List_1_DarkWebListingText_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCaseOhQuestData_Public_Static_List_1_CaseOhQuestData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseCaseOhQuestLines_Private_Static_CaseOhQuestData_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCaseOhQuest_Public_Static_CaseOhQuestData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCaseOhQuestCount_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRedlineCallers_Public_Static_List_1_RedlineCallerData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllDummyNPCData_Public_Static_Dictionary_2_Int32_DummyNPCDialogueData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDummyNPCData_Public_Static_DummyNPCDialogueData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadTonySliceData_Public_Static_TonySliceDialogueData_0;

	public unsafe static string BASE_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BASE_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BASE_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NORMAL_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NORMAL_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NORMAL_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NORMAL_FILE_NAME
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NORMAL_FILE_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NORMAL_FILE_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SHADY_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHADY_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHADY_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SHADY_TUTORIAL_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHADY_TUTORIAL_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHADY_TUTORIAL_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SHADY_DARKWEB_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHADY_DARKWEB_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHADY_DARKWEB_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SHADY_WASHING_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHADY_WASHING_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHADY_WASHING_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SHADY_INCINERATOR_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHADY_INCINERATOR_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHADY_INCINERATOR_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SHADY_FORGERY_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHADY_FORGERY_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHADY_FORGERY_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.ValueTuple<string, string, string>> DARKWEB_LEVELS
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DARKWEB_LEVELS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.ValueTuple<string, string, string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DARKWEB_LEVELS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.ValueTuple<string, string, string>> WASHING_LEVELS
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WASHING_LEVELS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.ValueTuple<string, string, string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WASHING_LEVELS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.ValueTuple<string, string, string>> INCINERATOR_LEVELS
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INCINERATOR_LEVELS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.ValueTuple<string, string, string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INCINERATOR_LEVELS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.ValueTuple<string, string, string>> FORGERY_LEVELS
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FORGERY_LEVELS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.ValueTuple<string, string, string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FORGERY_LEVELS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string QUEST_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QUEST_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QUEST_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string QUEST_FILE_NAME
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QUEST_FILE_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QUEST_FILE_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CASEOH_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CASEOH_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CASEOH_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CASEOH_FILE_NAME
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CASEOH_FILE_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CASEOH_FILE_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DARKWEB_LISTINGS_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DARKWEB_LISTINGS_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DARKWEB_LISTINGS_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DARKWEB_LISTINGS_FILE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DARKWEB_LISTINGS_FILE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DARKWEB_LISTINGS_FILE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SHADY_INGREDIENT_LISTINGS_FILE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHADY_INGREDIENT_LISTINGS_FILE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHADY_INGREDIENT_LISTINGS_FILE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DUMMY_NPC_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DUMMY_NPC_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DUMMY_NPC_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DUMMY_NPC_FILE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DUMMY_NPC_FILE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DUMMY_NPC_FILE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string REDLINE_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REDLINE_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REDLINE_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string REDLINE_FILE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REDLINE_FILE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REDLINE_FILE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<NPCDialogueData> cachedData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NPCDialogueData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<NPCDialogueData> cachedNormalCustomers
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedNormalCustomers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NPCDialogueData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedNormalCustomers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static bool isLoaded
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isLoaded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isLoaded, (void*)(&flag));
		}
	}

	public unsafe static List<ShadyNPCDialogueData> cachedShadyCustomers
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedShadyCustomers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShadyNPCDialogueData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedShadyCustomers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static bool isShadyLoaded
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isShadyLoaded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isShadyLoaded, (void*)(&flag));
		}
	}

	public unsafe static Dictionary<int, OpenWorldNPCQuestGroup> cachedQuestNPCGroups
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedQuestNPCGroups, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, OpenWorldNPCQuestGroup>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedQuestNPCGroups, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static bool isQuestLoaded
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isQuestLoaded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isQuestLoaded, (void*)(&flag));
		}
	}

	public unsafe static List<CaseOhQuestData> cachedCaseOhQuests
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedCaseOhQuests, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CaseOhQuestData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedCaseOhQuests, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static bool isCaseOhLoaded
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isCaseOhLoaded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isCaseOhLoaded, (void*)(&flag));
		}
	}

	public unsafe static Dictionary<string, List<DarkWebListingText>> cachedListingTexts
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedListingTexts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, List<DarkWebListingText>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedListingTexts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static bool isDarkWebListingsLoaded
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isDarkWebListingsLoaded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isDarkWebListingsLoaded, (void*)(&flag));
		}
	}

	public unsafe static Dictionary<string, List<DarkWebListingText>> cachedIngredientListingTexts
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedIngredientListingTexts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, List<DarkWebListingText>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedIngredientListingTexts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static bool isIngredientListingsLoaded
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isIngredientListingsLoaded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isIngredientListingsLoaded, (void*)(&flag));
		}
	}

	public unsafe static Dictionary<int, DummyNPCDialogueData> cachedDummyNPCData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedDummyNPCData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, DummyNPCDialogueData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedDummyNPCData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static bool isDummyNPCLoaded
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isDummyNPCLoaded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isDummyNPCLoaded, (void*)(&flag));
		}
	}

	public unsafe static List<RedlineCallerData> cachedRedlineCallers
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedRedlineCallers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RedlineCallerData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedRedlineCallers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static bool isRedlineLoaded
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isRedlineLoaded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isRedlineLoaded, (void*)(&flag));
		}
	}

	public unsafe static string TONY_SLICE_FOLDER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TONY_SLICE_FOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TONY_SLICE_FOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TONY_SLICE_FILE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TONY_SLICE_FILE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TONY_SLICE_FILE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static TonySliceDialogueData cachedTonySliceData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedTonySliceData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TonySliceDialogueData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedTonySliceData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tonySliceDialogueData));
		}
	}

	public unsafe static bool isTonySliceLoaded
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isTonySliceLoaded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isTonySliceLoaded, (void*)(&flag));
		}
	}

	public unsafe static string cachedLocaleCode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedLocaleCode, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedLocaleCode, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int currentDialogueRound
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentDialogueRound, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentDialogueRound, (void*)(&num));
		}
	}

	public unsafe static HashSet<int> spawnedPrefabsInCurrentRound
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_spawnedPrefabsInCurrentRound, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_spawnedPrefabsInCurrentRound, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static int nextNormalSpawnIndex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nextNormalSpawnIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nextNormalSpawnIndex, (void*)(&num));
		}
	}

	public unsafe static bool allRoundsExhausted
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_allRoundsExhausted, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_allRoundsExhausted, (void*)(&flag));
		}
	}

	public unsafe static int RANDOM_COOLDOWN_SIZE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RANDOM_COOLDOWN_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RANDOM_COOLDOWN_SIZE, (void*)(&num));
		}
	}

	public unsafe static Queue<int> recentRandomPrefabs
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_recentRandomPrefabs, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_recentRandomPrefabs, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe static Il2CppStructArray<ShadyMissionCategory> SHADY_SPAWN_PATTERN
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHADY_SPAWN_PATTERN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShadyMissionCategory>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHADY_SPAWN_PATTERN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int shadyPatternPosition
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shadyPatternPosition, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shadyPatternPosition, (void*)(&num));
		}
	}

	public unsafe static Dictionary<ShadyMissionCategory, List<ShadyNPCDialogueData>> shadyCategoryQueues
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shadyCategoryQueues, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ShadyMissionCategory, List<ShadyNPCDialogueData>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shadyCategoryQueues, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<ShadyMissionCategory, int> shadyCategoryIndices
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shadyCategoryIndices, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ShadyMissionCategory, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shadyCategoryIndices, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static HashSet<int> forcedShadyQuestNumbers
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_forcedShadyQuestNumbers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_forcedShadyQuestNumbers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static bool hasSeenWashingPreview
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hasSeenWashingPreview, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hasSeenWashingPreview, (void*)(&flag));
		}
	}

	public unsafe static bool hasSeenIncineratorPreview
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hasSeenIncineratorPreview, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hasSeenIncineratorPreview, (void*)(&flag));
		}
	}

	public unsafe static bool hasSeenForgeryPreview
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hasSeenForgeryPreview, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hasSeenForgeryPreview, (void*)(&flag));
		}
	}

	public unsafe static string GenericOrderDialogue
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20085, RefRangeEnd = 20087, XrefRangeStart = 20078, XrefRangeEnd = 20085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GenericOrderDialogue_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string AcceptButtonText
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20111, RefRangeEnd = 20113, XrefRangeStart = 20087, XrefRangeEnd = 20111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AcceptButtonText_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string DeclineButtonText
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20137, RefRangeEnd = 20139, XrefRangeStart = 20113, XrefRangeEnd = 20137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DeclineButtonText_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static NPCDataLoader()
	{
		Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NPCDataLoader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr);
		NativeFieldInfoPtr_BASE_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "BASE_FOLDER");
		NativeFieldInfoPtr_NORMAL_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "NORMAL_FOLDER");
		NativeFieldInfoPtr_NORMAL_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "NORMAL_FILE_NAME");
		NativeFieldInfoPtr_SHADY_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "SHADY_FOLDER");
		NativeFieldInfoPtr_SHADY_TUTORIAL_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "SHADY_TUTORIAL_FOLDER");
		NativeFieldInfoPtr_SHADY_DARKWEB_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "SHADY_DARKWEB_FOLDER");
		NativeFieldInfoPtr_SHADY_WASHING_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "SHADY_WASHING_FOLDER");
		NativeFieldInfoPtr_SHADY_INCINERATOR_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "SHADY_INCINERATOR_FOLDER");
		NativeFieldInfoPtr_SHADY_FORGERY_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "SHADY_FORGERY_FOLDER");
		NativeFieldInfoPtr_DARKWEB_LEVELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "DARKWEB_LEVELS");
		NativeFieldInfoPtr_WASHING_LEVELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "WASHING_LEVELS");
		NativeFieldInfoPtr_INCINERATOR_LEVELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "INCINERATOR_LEVELS");
		NativeFieldInfoPtr_FORGERY_LEVELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "FORGERY_LEVELS");
		NativeFieldInfoPtr_QUEST_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "QUEST_FOLDER");
		NativeFieldInfoPtr_QUEST_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "QUEST_FILE_NAME");
		NativeFieldInfoPtr_CASEOH_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "CASEOH_FOLDER");
		NativeFieldInfoPtr_CASEOH_FILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "CASEOH_FILE_NAME");
		NativeFieldInfoPtr_DARKWEB_LISTINGS_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "DARKWEB_LISTINGS_FOLDER");
		NativeFieldInfoPtr_DARKWEB_LISTINGS_FILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "DARKWEB_LISTINGS_FILE");
		NativeFieldInfoPtr_SHADY_INGREDIENT_LISTINGS_FILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "SHADY_INGREDIENT_LISTINGS_FILE");
		NativeFieldInfoPtr_DUMMY_NPC_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "DUMMY_NPC_FOLDER");
		NativeFieldInfoPtr_DUMMY_NPC_FILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "DUMMY_NPC_FILE");
		NativeFieldInfoPtr_REDLINE_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "REDLINE_FOLDER");
		NativeFieldInfoPtr_REDLINE_FILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "REDLINE_FILE");
		NativeFieldInfoPtr_cachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "cachedData");
		NativeFieldInfoPtr_cachedNormalCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "cachedNormalCustomers");
		NativeFieldInfoPtr_isLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "isLoaded");
		NativeFieldInfoPtr_cachedShadyCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "cachedShadyCustomers");
		NativeFieldInfoPtr_isShadyLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "isShadyLoaded");
		NativeFieldInfoPtr_cachedQuestNPCGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "cachedQuestNPCGroups");
		NativeFieldInfoPtr_isQuestLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "isQuestLoaded");
		NativeFieldInfoPtr_cachedCaseOhQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "cachedCaseOhQuests");
		NativeFieldInfoPtr_isCaseOhLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "isCaseOhLoaded");
		NativeFieldInfoPtr_cachedListingTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "cachedListingTexts");
		NativeFieldInfoPtr_isDarkWebListingsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "isDarkWebListingsLoaded");
		NativeFieldInfoPtr_cachedIngredientListingTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "cachedIngredientListingTexts");
		NativeFieldInfoPtr_isIngredientListingsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "isIngredientListingsLoaded");
		NativeFieldInfoPtr_cachedDummyNPCData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "cachedDummyNPCData");
		NativeFieldInfoPtr_isDummyNPCLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "isDummyNPCLoaded");
		NativeFieldInfoPtr_cachedRedlineCallers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "cachedRedlineCallers");
		NativeFieldInfoPtr_isRedlineLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "isRedlineLoaded");
		NativeFieldInfoPtr_TONY_SLICE_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "TONY_SLICE_FOLDER");
		NativeFieldInfoPtr_TONY_SLICE_FILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "TONY_SLICE_FILE");
		NativeFieldInfoPtr_cachedTonySliceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "cachedTonySliceData");
		NativeFieldInfoPtr_isTonySliceLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "isTonySliceLoaded");
		NativeFieldInfoPtr_cachedLocaleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "cachedLocaleCode");
		NativeFieldInfoPtr_currentDialogueRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "currentDialogueRound");
		NativeFieldInfoPtr_spawnedPrefabsInCurrentRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "spawnedPrefabsInCurrentRound");
		NativeFieldInfoPtr_nextNormalSpawnIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "nextNormalSpawnIndex");
		NativeFieldInfoPtr_allRoundsExhausted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "allRoundsExhausted");
		NativeFieldInfoPtr_RANDOM_COOLDOWN_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "RANDOM_COOLDOWN_SIZE");
		NativeFieldInfoPtr_recentRandomPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "recentRandomPrefabs");
		NativeFieldInfoPtr_SHADY_SPAWN_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "SHADY_SPAWN_PATTERN");
		NativeFieldInfoPtr_shadyPatternPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "shadyPatternPosition");
		NativeFieldInfoPtr_shadyCategoryQueues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "shadyCategoryQueues");
		NativeFieldInfoPtr_shadyCategoryIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "shadyCategoryIndices");
		NativeFieldInfoPtr_forcedShadyQuestNumbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "forcedShadyQuestNumbers");
		NativeFieldInfoPtr_hasSeenWashingPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "hasSeenWashingPreview");
		NativeFieldInfoPtr_hasSeenIncineratorPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "hasSeenIncineratorPreview");
		NativeFieldInfoPtr_hasSeenForgeryPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, "hasSeenForgeryPreview");
		NativeMethodInfoPtr_get_GenericOrderDialogue_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_get_AcceptButtonText_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_get_DeclineButtonText_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_GetRandomShadyAcceptText_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_GetRandomShadyDeclineText_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_GetOrderDialogue_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_PreloadNormalDataAsync_Public_Static_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_PreloadShadyDataAsync_Public_Static_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_CheckLocaleChange_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_LoadAllNPCData_Public_Static_List_1_NPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_LoadTSVFile_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_ParseTSVLine_Private_Static_NPCDialogueData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_ParseTSVFields_Private_Static_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_LoadJSONFiles_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_ParseJsonFile_Private_Static_Void_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_GetNextNormalCustomerForSpawn_Public_Static_ValueTuple_2_NPCDialogueData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_AdvanceToNextRound_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_ResetRounds_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_AreAllNormalRoundsExhausted_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_GetRandomNPCWithCooldown_Private_Static_NPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_GetCurrentDialogueRound_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_GetSpawnedCountInCurrentRound_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_GetNormalCustomerCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_GetRandomNPCData_Public_Static_NPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_GetRandomNormalNPCData_Public_Static_NPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_GetRandomShadyNPCData_Public_Static_NPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_GetNPCDataByName_Public_Static_NPCDialogueData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_ClearCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_ClearDataCacheOnly_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_GetCurrentLocaleCode_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_CreateSampleJson_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_GetLoadedCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_GetShadyCustomerCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_LoadAllShadyNPCData_Public_Static_List_1_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_LoadShadyCategoryLevels_Private_Static_Void_String_ShadyMissionCategory_Il2CppReferenceArray_1_ValueTuple_3_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_LoadShadyCategoryFolder_Private_Static_Void_String_ShadyMissionCategory_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_ParseShadyTSVFile_Private_Static_Void_TextAsset_ShadyMissionCategory_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_ParseShadyMissionLine_Private_Static_ShadyNPCDialogueData_String_ShadyMissionCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_GetNextShadyCustomerForSpawn_Public_Static_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_BuildShadyCategoryQueues_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_IsUpgradeUnlocked_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_GenerateRandomShadyQuest_Private_Static_ShadyNPCDialogueData_ShadyMissionCategory_List_1_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_GetGenericShadyDialogue_Private_Static_String_ShadyMissionCategory_ShadyDeliveryType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_MarkShadyQuestAsForced_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_GetShadyCustomerByPrefabNumber_Public_Static_ShadyNPCDialogueData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_GetShadyCustomerByMissionNumber_Public_Static_ShadyNPCDialogueData_Int32_ShadyMissionCategory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_GetShadyCustomerByMissionNumber_Public_Static_ShadyNPCDialogueData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_GetNextShadyCustomerByDeliveryType_Public_Static_ShadyNPCDialogueData_ShadyDeliveryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_GetNextShadyCustomerByTaskType_Public_Static_ShadyNPCDialogueData_ShadyTaskType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_GetNextShadyCustomerWithFilter_Private_Static_ShadyNPCDialogueData_Func_2_ShadyNPCDialogueData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_GetTutorialShadyQuest_Public_Static_ShadyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_GetNormalCustomerByPrefabNumber_Public_Static_NPCDialogueData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_GetAllShadyPrefabNumbers_Public_Static_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_AdvanceShadyCategoryIndexPastQuest_Public_Static_Void_ShadyMissionCategory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_ResetShadyRounds_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_GetSpawnedShadyCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_AreAllShadyQuestsExhausted_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_LoadAllOpenWorldQuestData_Public_Static_Dictionary_2_Int32_OpenWorldNPCQuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_ParseOpenWorldQuestLines_Private_Static_OpenWorldQuestData_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_GetQuestGroupByNPCNumber_Public_Static_OpenWorldNPCQuestGroup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_HasSeenPreviewPopup_Public_Static_Boolean_ShadyMissionCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_MarkPreviewPopupSeen_Public_Static_Void_ShadyMissionCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_GetSpawnState_Public_Static_ValueTuple_8_Int32_HashSet_1_Int32_Int32_Int32_Int32_Int32_Int32_ValueTuple_3_HashSet_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_RestoreSpawnState_Public_Static_Void_Int32_HashSet_1_Int32_Int32_Int32_Int32_Int32_Int32_HashSet_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_GetPreviewPopupState_Public_Static_ValueTuple_3_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_RestorePreviewPopupState_Public_Static_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_LoadDarkWebListings_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_GetListingTexts_Public_Static_List_1_DarkWebListingText_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_GetListingText_Public_Static_DarkWebListingText_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_LoadShadyIngredientListings_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_GetRandomIngredientListing_Public_Static_DarkWebListingText_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_GetIngredientListingTexts_Public_Static_List_1_DarkWebListingText_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_LoadCaseOhQuestData_Public_Static_List_1_CaseOhQuestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_ParseCaseOhQuestLines_Private_Static_CaseOhQuestData_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_GetCaseOhQuest_Public_Static_CaseOhQuestData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_GetCaseOhQuestCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_LoadRedlineCallers_Public_Static_List_1_RedlineCallerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_LoadAllDummyNPCData_Public_Static_Dictionary_2_Int32_DummyNPCDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_GetDummyNPCData_Public_Static_DummyNPCDialogueData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_LoadTonySliceData_Public_Static_TonySliceDialogueData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataLoader>.NativeClassPtr, 100663396);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20163, RefRangeEnd = 20165, XrefRangeStart = 20139, XrefRangeEnd = 20163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRandomShadyAcceptText()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomShadyAcceptText_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20189, RefRangeEnd = 20190, XrefRangeStart = 20165, XrefRangeEnd = 20189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRandomShadyDeclineText()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomShadyDeclineText_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20213, RefRangeEnd = 20214, XrefRangeStart = 20190, XrefRangeEnd = 20213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetOrderDialogue(string orderDescription)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(orderDescription);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrderDialogue_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20220, RefRangeEnd = 20221, XrefRangeStart = 20214, XrefRangeEnd = 20220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UniTask PreloadNormalDataAsync()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreloadNormalDataAsync_Public_Static_UniTask_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new UniTask(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20227, RefRangeEnd = 20228, XrefRangeStart = 20221, XrefRangeEnd = 20227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UniTask PreloadShadyDataAsync()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreloadShadyDataAsync_Public_Static_UniTask_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new UniTask(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20239, RefRangeEnd = 20241, XrefRangeStart = 20228, XrefRangeEnd = 20239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckLocaleChange()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckLocaleChange_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 20261, RefRangeEnd = 20269, XrefRangeStart = 20241, XrefRangeEnd = 20261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<NPCDialogueData> LoadAllNPCData()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllNPCData_Public_Static_List_1_NPCDialogueData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NPCDialogueData>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20269, XrefRangeEnd = 20322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadTSVFile()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadTSVFile_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20413, RefRangeEnd = 20415, XrefRangeStart = 20322, XrefRangeEnd = 20413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NPCDialogueData ParseTSVLine(string line)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTSVLine_Private_Static_NPCDialogueData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NPCDialogueData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20415, XrefRangeEnd = 20422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<string> ParseTSVFields(string line)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTSVFields_Private_Static_List_1_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20452, RefRangeEnd = 20453, XrefRangeStart = 20422, XrefRangeEnd = 20452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadJSONFiles()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadJSONFiles_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20513, RefRangeEnd = 20514, XrefRangeStart = 20453, XrefRangeEnd = 20513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParseJsonFile(TextAsset jsonFile)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)jsonFile);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseJsonFile_Private_Static_Void_TextAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20586, RefRangeEnd = 20587, XrefRangeStart = 20514, XrefRangeEnd = 20586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<NPCDialogueData, int> GetNextNormalCustomerForSpawn()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextNormalCustomerForSpawn_Public_Static_ValueTuple_2_NPCDialogueData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<NPCDialogueData, int>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20587, XrefRangeEnd = 20596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AdvanceToNextRound()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdvanceToNextRound_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20596, XrefRangeEnd = 20611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetRounds()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetRounds_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20611, XrefRangeEnd = 20615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AreAllNormalRoundsExhausted()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AreAllNormalRoundsExhausted_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20668, RefRangeEnd = 20669, XrefRangeStart = 20615, XrefRangeEnd = 20668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NPCDialogueData GetRandomNPCWithCooldown()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomNPCWithCooldown_Private_Static_NPCDialogueData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NPCDialogueData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20669, XrefRangeEnd = 20673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCurrentDialogueRound()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentDialogueRound_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20673, XrefRangeEnd = 20678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSpawnedCountInCurrentRound()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpawnedCountInCurrentRound_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20678, XrefRangeEnd = 20684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNormalCustomerCount()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNormalCustomerCount_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20684, XrefRangeEnd = 20693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NPCDialogueData GetRandomNPCData()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomNPCData_Public_Static_NPCDialogueData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NPCDialogueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20720, RefRangeEnd = 20721, XrefRangeStart = 20693, XrefRangeEnd = 20720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NPCDialogueData GetRandomNormalNPCData()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomNormalNPCData_Public_Static_NPCDialogueData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NPCDialogueData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20721, XrefRangeEnd = 20748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NPCDialogueData GetRandomShadyNPCData()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomShadyNPCData_Public_Static_NPCDialogueData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NPCDialogueData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20748, XrefRangeEnd = 20767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NPCDialogueData GetNPCDataByName(string npcName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(npcName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNPCDataByName_Public_Static_NPCDialogueData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NPCDialogueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20801, RefRangeEnd = 20802, XrefRangeStart = 20767, XrefRangeEnd = 20801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearCache()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCache_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 20846, RefRangeEnd = 20853, XrefRangeStart = 20802, XrefRangeEnd = 20846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearDataCacheOnly()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearDataCacheOnly_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 20864, RefRangeEnd = 20878, XrefRangeStart = 20853, XrefRangeEnd = 20864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCurrentLocaleCode()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentLocaleCode_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20878, XrefRangeEnd = 21041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateSampleJson()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSampleJson_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21041, XrefRangeEnd = 21046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLoadedCount()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLoadedCount_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21052, RefRangeEnd = 21054, XrefRangeStart = 21046, XrefRangeEnd = 21052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetShadyCustomerCount()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadyCustomerCount_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 21078, RefRangeEnd = 21086, XrefRangeStart = 21054, XrefRangeEnd = 21078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<ShadyNPCDialogueData> LoadAllShadyNPCData()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllShadyNPCData_Public_Static_List_1_ShadyNPCDialogueData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShadyNPCDialogueData>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21086, XrefRangeEnd = 21094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadShadyCategoryLevels(string baseFolderPath, ShadyMissionCategory category, Il2CppReferenceArray<Il2CppSystem.ValueTuple<string, string, string>> levels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(baseFolderPath);
		*(ShadyMissionCategory**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)levels);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadShadyCategoryLevels_Private_Static_Void_String_ShadyMissionCategory_Il2CppReferenceArray_1_ValueTuple_3_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21151, RefRangeEnd = 21152, XrefRangeStart = 21094, XrefRangeEnd = 21151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadShadyCategoryFolder(string folderPath, ShadyMissionCategory category, string requiredUpgradeId, string parentTierUpgradeId = null, int level = 1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
		*(ShadyMissionCategory**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(requiredUpgradeId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parentTierUpgradeId);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadShadyCategoryFolder_Private_Static_Void_String_ShadyMissionCategory_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21178, RefRangeEnd = 21179, XrefRangeStart = 21152, XrefRangeEnd = 21178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParseShadyTSVFile(TextAsset tsvFile, ShadyMissionCategory category, string requiredUpgradeId, string parentTierUpgradeId, int level = 1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tsvFile);
		*(ShadyMissionCategory**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(requiredUpgradeId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parentTierUpgradeId);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseShadyTSVFile_Private_Static_Void_TextAsset_ShadyMissionCategory_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21244, RefRangeEnd = 21245, XrefRangeStart = 21179, XrefRangeEnd = 21244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShadyNPCDialogueData ParseShadyMissionLine(string line, ShadyMissionCategory category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
		*(ShadyMissionCategory**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseShadyMissionLine_Private_Static_ShadyNPCDialogueData_String_ShadyMissionCategory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21327, RefRangeEnd = 21328, XrefRangeStart = 21245, XrefRangeEnd = 21327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShadyNPCDialogueData GetNextShadyCustomerForSpawn()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextShadyCustomerForSpawn_Public_Static_ShadyNPCDialogueData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21395, RefRangeEnd = 21397, XrefRangeStart = 21328, XrefRangeEnd = 21395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildShadyCategoryQueues()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildShadyCategoryQueues_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21410, RefRangeEnd = 21412, XrefRangeStart = 21397, XrefRangeEnd = 21410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsUpgradeUnlocked(string upgradeId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(upgradeId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUpgradeUnlocked_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21455, RefRangeEnd = 21456, XrefRangeStart = 21412, XrefRangeEnd = 21455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShadyNPCDialogueData GenerateRandomShadyQuest(ShadyMissionCategory category, List<ShadyNPCDialogueData> categoryPool)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&category);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)categoryPool);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRandomShadyQuest_Private_Static_ShadyNPCDialogueData_ShadyMissionCategory_List_1_ShadyNPCDialogueData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21543, RefRangeEnd = 21544, XrefRangeStart = 21456, XrefRangeEnd = 21543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetGenericShadyDialogue(ShadyMissionCategory category, ShadyDeliveryType deliveryType, string itemName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&category);
		*(ShadyDeliveryType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deliveryType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(itemName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenericShadyDialogue_Private_Static_String_ShadyMissionCategory_ShadyDeliveryType_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21552, RefRangeEnd = 21553, XrefRangeStart = 21544, XrefRangeEnd = 21552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MarkShadyQuestAsForced(int missionNumber)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&missionNumber);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkShadyQuestAsForced_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21553, XrefRangeEnd = 21570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShadyNPCDialogueData GetShadyCustomerByPrefabNumber(int prefabNumber)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&prefabNumber);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadyCustomerByPrefabNumber_Public_Static_ShadyNPCDialogueData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21587, RefRangeEnd = 21588, XrefRangeStart = 21570, XrefRangeEnd = 21587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShadyNPCDialogueData GetShadyCustomerByMissionNumber(int missionNumber, ShadyMissionCategory category, int level)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&missionNumber);
		*(ShadyMissionCategory**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadyCustomerByMissionNumber_Public_Static_ShadyNPCDialogueData_Int32_ShadyMissionCategory_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21605, RefRangeEnd = 21606, XrefRangeStart = 21588, XrefRangeEnd = 21605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShadyNPCDialogueData GetShadyCustomerByMissionNumber(int missionNumber)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&missionNumber);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadyCustomerByMissionNumber_Public_Static_ShadyNPCDialogueData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21621, RefRangeEnd = 21622, XrefRangeStart = 21606, XrefRangeEnd = 21621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShadyNPCDialogueData GetNextShadyCustomerByDeliveryType(ShadyDeliveryType deliveryType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deliveryType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextShadyCustomerByDeliveryType_Public_Static_ShadyNPCDialogueData_ShadyDeliveryType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21637, RefRangeEnd = 21638, XrefRangeStart = 21622, XrefRangeEnd = 21637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShadyNPCDialogueData GetNextShadyCustomerByTaskType(ShadyTaskType taskType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&taskType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextShadyCustomerByTaskType_Public_Static_ShadyNPCDialogueData_ShadyTaskType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21660, RefRangeEnd = 21662, XrefRangeStart = 21638, XrefRangeEnd = 21660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShadyNPCDialogueData GetNextShadyCustomerWithFilter(Il2CppSystem.Func<ShadyNPCDialogueData, bool> filter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextShadyCustomerWithFilter_Private_Static_ShadyNPCDialogueData_Func_2_ShadyNPCDialogueData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21684, RefRangeEnd = 21685, XrefRangeStart = 21662, XrefRangeEnd = 21684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShadyNPCDialogueData GetTutorialShadyQuest()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTutorialShadyQuest_Public_Static_ShadyNPCDialogueData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21705, RefRangeEnd = 21706, XrefRangeStart = 21685, XrefRangeEnd = 21705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NPCDialogueData GetNormalCustomerByPrefabNumber(int prefabNumber)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&prefabNumber);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNormalCustomerByPrefabNumber_Public_Static_NPCDialogueData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NPCDialogueData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21706, XrefRangeEnd = 21736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<int> GetAllShadyPrefabNumbers()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllShadyPrefabNumbers_Public_Static_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21776, RefRangeEnd = 21777, XrefRangeStart = 21736, XrefRangeEnd = 21776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AdvanceShadyCategoryIndexPastQuest(ShadyMissionCategory category, int missionNumber)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&category);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &missionNumber;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdvanceShadyCategoryIndexPastQuest_Public_Static_Void_ShadyMissionCategory_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21777, XrefRangeEnd = 21793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetShadyRounds()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetShadyRounds_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21812, RefRangeEnd = 21814, XrefRangeStart = 21793, XrefRangeEnd = 21812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSpawnedShadyCount()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpawnedShadyCount_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21835, RefRangeEnd = 21837, XrefRangeStart = 21814, XrefRangeEnd = 21835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AreAllShadyQuestsExhausted()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AreAllShadyQuestsExhausted_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21868, RefRangeEnd = 21869, XrefRangeStart = 21837, XrefRangeEnd = 21868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<int, OpenWorldNPCQuestGroup> LoadAllOpenWorldQuestData()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllOpenWorldQuestData_Public_Static_Dictionary_2_Int32_OpenWorldNPCQuestGroup_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, OpenWorldNPCQuestGroup>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21869, XrefRangeEnd = 22035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static OpenWorldQuestData ParseOpenWorldQuestLines(string line1, string line2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(line1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(line2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseOpenWorldQuestLines_Private_Static_OpenWorldQuestData_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OpenWorldQuestData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22042, RefRangeEnd = 22043, XrefRangeStart = 22035, XrefRangeEnd = 22042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static OpenWorldNPCQuestGroup GetQuestGroupByNPCNumber(int npcNumber)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&npcNumber);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuestGroupByNPCNumber_Public_Static_OpenWorldNPCQuestGroup_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OpenWorldNPCQuestGroup>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22044, RefRangeEnd = 22045, XrefRangeStart = 22043, XrefRangeEnd = 22044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasSeenPreviewPopup(ShadyMissionCategory category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&category);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSeenPreviewPopup_Public_Static_Boolean_ShadyMissionCategory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22049, RefRangeEnd = 22050, XrefRangeStart = 22045, XrefRangeEnd = 22049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MarkPreviewPopupSeen(ShadyMissionCategory category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&category);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkPreviewPopupSeen_Public_Static_Void_ShadyMissionCategory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22117, RefRangeEnd = 22118, XrefRangeStart = 22050, XrefRangeEnd = 22117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<int, HashSet<int>, int, int, int, int, int, Il2CppSystem.ValueTuple<HashSet<int>, int, bool>> GetSpawnState()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpawnState_Public_Static_ValueTuple_8_Int32_HashSet_1_Int32_Int32_Int32_Int32_Int32_Int32_ValueTuple_3_HashSet_1_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<int, HashSet<int>, int, int, int, int, int, Il2CppSystem.ValueTuple<HashSet<int>, int, bool>>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22158, RefRangeEnd = 22159, XrefRangeStart = 22118, XrefRangeEnd = 22158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RestoreSpawnState(int dialogueRound, HashSet<int> spawnedPrefabs, int shadyPatternPos, int shadyDarkWebIdx, int shadyWashingIdx, int shadyIncineratorIdx, int shadyForgeryIdx, HashSet<int> forcedQuests, int normalSpawnIndex = 0, bool roundsExhausted = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&dialogueRound);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnedPrefabs);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadyPatternPos;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadyDarkWebIdx;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadyWashingIdx;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadyIncineratorIdx;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadyForgeryIdx;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forcedQuests);
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &normalSpawnIndex;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &roundsExhausted;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreSpawnState_Public_Static_Void_Int32_HashSet_1_Int32_Int32_Int32_Int32_Int32_Int32_HashSet_1_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22166, RefRangeEnd = 22167, XrefRangeStart = 22159, XrefRangeEnd = 22166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<bool, bool, bool> GetPreviewPopupState()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreviewPopupState_Public_Static_ValueTuple_3_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<bool, bool, bool>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22173, RefRangeEnd = 22174, XrefRangeStart = 22167, XrefRangeEnd = 22173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RestorePreviewPopupState(bool washing, bool incinerator, bool forgery)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&washing);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &incinerator;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forgery;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestorePreviewPopupState_Public_Static_Void_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22272, RefRangeEnd = 22274, XrefRangeStart = 22174, XrefRangeEnd = 22272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadDarkWebListings()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadDarkWebListings_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22274, XrefRangeEnd = 22284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<DarkWebListingText> GetListingTexts(string itemId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetListingTexts_Public_Static_List_1_DarkWebListingText_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DarkWebListingText>>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 22307, RefRangeEnd = 22313, XrefRangeStart = 22284, XrefRangeEnd = 22307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DarkWebListingText GetListingText(string itemId, int listingIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &listingIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetListingText_Public_Static_DarkWebListingText_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DarkWebListingText>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22411, RefRangeEnd = 22413, XrefRangeStart = 22313, XrefRangeEnd = 22411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadShadyIngredientListings()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadShadyIngredientListings_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22413, XrefRangeEnd = 22428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DarkWebListingText GetRandomIngredientListing(string ingredientItemId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ingredientItemId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomIngredientListing_Public_Static_DarkWebListingText_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DarkWebListingText>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22428, XrefRangeEnd = 22438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<DarkWebListingText> GetIngredientListingTexts(string ingredientItemId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ingredientItemId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIngredientListingTexts_Public_Static_List_1_DarkWebListingText_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DarkWebListingText>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22560, RefRangeEnd = 22562, XrefRangeStart = 22438, XrefRangeEnd = 22560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<CaseOhQuestData> LoadCaseOhQuestData()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCaseOhQuestData_Public_Static_List_1_CaseOhQuestData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CaseOhQuestData>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22719, RefRangeEnd = 22720, XrefRangeStart = 22562, XrefRangeEnd = 22719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CaseOhQuestData ParseCaseOhQuestLines(string line1, string line2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(line1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(line2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseCaseOhQuestLines_Private_Static_CaseOhQuestData_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CaseOhQuestData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22728, RefRangeEnd = 22730, XrefRangeStart = 22720, XrefRangeEnd = 22728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CaseOhQuestData GetCaseOhQuest(int questIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&questIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaseOhQuest_Public_Static_CaseOhQuestData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CaseOhQuestData>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 22735, RefRangeEnd = 22738, XrefRangeStart = 22730, XrefRangeEnd = 22735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCaseOhQuestCount()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaseOhQuestCount_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22755, RefRangeEnd = 22756, XrefRangeStart = 22738, XrefRangeEnd = 22755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<RedlineCallerData> LoadRedlineCallers()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRedlineCallers_Public_Static_List_1_RedlineCallerData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RedlineCallerData>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22791, RefRangeEnd = 22792, XrefRangeStart = 22756, XrefRangeEnd = 22791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<int, DummyNPCDialogueData> LoadAllDummyNPCData()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllDummyNPCData_Public_Static_Dictionary_2_Int32_DummyNPCDialogueData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, DummyNPCDialogueData>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22799, RefRangeEnd = 22801, XrefRangeStart = 22792, XrefRangeEnd = 22799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DummyNPCDialogueData GetDummyNPCData(int npcNumber)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&npcNumber);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDummyNPCData_Public_Static_DummyNPCDialogueData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DummyNPCDialogueData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22831, RefRangeEnd = 22832, XrefRangeStart = 22801, XrefRangeEnd = 22831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TonySliceDialogueData LoadTonySliceData()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadTonySliceData_Public_Static_TonySliceDialogueData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TonySliceDialogueData>(intPtr) : null;
	}

	public NPCDataLoader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
