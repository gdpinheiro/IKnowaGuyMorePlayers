using System;
using System.Runtime.CompilerServices;
using Core.Map;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UI.Map;

public static class QuestListAggregator : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("UI.Map.QuestListAggregator+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Aggregate_b__0_0_Internal_Int32_QuestListEntry_QuestListEntry_0;

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

		public unsafe static Il2CppSystem.Comparison<QuestListEntry> __9__0_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<QuestListEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__0_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuestListAggregator>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__0_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100674535);
			NativeMethodInfoPtr__Aggregate_b__0_0_Internal_Int32_QuestListEntry_QuestListEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100674536);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192673, XrefRangeEnd = 192676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _Aggregate_b__0_0(QuestListEntry a, QuestListEntry b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Aggregate_b__0_0_Internal_Int32_QuestListEntry_QuestListEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Aggregate_Public_Static_List_1_QuestListEntry_MapPinFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterMatches_Private_Static_Boolean_MapPinFilter_MapPinStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SectionForStatus_Private_Static_QuestSection_MapPinStatus_0;

	static QuestListAggregator()
	{
		Il2CppClassPointerStore<QuestListAggregator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UI.Map", "QuestListAggregator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestListAggregator>.NativeClassPtr);
		NativeMethodInfoPtr_Aggregate_Public_Static_List_1_QuestListEntry_MapPinFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestListAggregator>.NativeClassPtr, 100674531);
		NativeMethodInfoPtr_FilterMatches_Private_Static_Boolean_MapPinFilter_MapPinStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestListAggregator>.NativeClassPtr, 100674532);
		NativeMethodInfoPtr_SectionForStatus_Private_Static_QuestSection_MapPinStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestListAggregator>.NativeClassPtr, 100674533);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 192752, RefRangeEnd = 192753, XrefRangeStart = 192676, XrefRangeEnd = 192752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<QuestListEntry> Aggregate(MapPinFilter filter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&filter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Aggregate_Public_Static_List_1_QuestListEntry_MapPinFilter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<QuestListEntry>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static bool FilterMatches(MapPinFilter filter, MapPinStatus status)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&filter);
		*(MapPinStatus**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &status;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterMatches_Private_Static_Boolean_MapPinFilter_MapPinStatus_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static QuestSection SectionForStatus(MapPinStatus status)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SectionForStatus_Private_Static_QuestSection_MapPinStatus_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(QuestSection*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public QuestListAggregator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
