using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class DocumentDatabase : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_documents;

	private static readonly IntPtr NativeFieldInfoPtr_stamps;

	private static readonly IntPtr NativeFieldInfoPtr_documentLookup;

	private static readonly IntPtr NativeFieldInfoPtr_stampLookup;

	private static readonly IntPtr NativeFieldInfoPtr_isInitialized;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_EnsureInitialized_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDocument_Public_DocumentSO_DocumentType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllDocuments_Public_IReadOnlyList_1_DocumentSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAvailableDocuments_Public_List_1_DocumentSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDocumentsByDifficulty_Public_List_1_DocumentSO_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRandomDocument_Public_DocumentSO_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasDocument_Public_Boolean_DocumentType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStamp_Public_StampSO_StampType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllStamps_Public_IReadOnlyList_1_StampSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRequiredStampsForDocument_Public_List_1_StampSO_DocumentSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasStamp_Public_Boolean_StampType_0;

	private static readonly IntPtr NativeMethodInfoPtr_RegisterDocument_Public_Void_DocumentSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_RegisterStamp_Public_Void_StampSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnregisterDocument_Public_Void_DocumentSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnregisterStamp_Public_Void_StampSO_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DocumentCount_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_StampCount_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<DocumentSO> documents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documents);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DocumentSO>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<StampSO> stamps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stamps);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<StampSO>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stamps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<DocumentType, DocumentSO> documentLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentLookup);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<DocumentType, DocumentSO>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<StampType, StampSO> stampLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stampLookup);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StampType, StampSO>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stampLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe bool isInitialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitialized)) = flag;
		}
	}

	public unsafe int DocumentCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137036, XrefRangeEnd = 137037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DocumentCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int StampCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137037, XrefRangeEnd = 137038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StampCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static DocumentDatabase()
	{
		Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DocumentDatabase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr);
		NativeFieldInfoPtr_documents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, "documents");
		NativeFieldInfoPtr_stamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, "stamps");
		NativeFieldInfoPtr_documentLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, "documentLookup");
		NativeFieldInfoPtr_stampLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, "stampLookup");
		NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, "isInitialized");
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671628);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671629);
		NativeMethodInfoPtr_EnsureInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671630);
		NativeMethodInfoPtr_GetDocument_Public_DocumentSO_DocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671631);
		NativeMethodInfoPtr_GetAllDocuments_Public_IReadOnlyList_1_DocumentSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671632);
		NativeMethodInfoPtr_GetAvailableDocuments_Public_List_1_DocumentSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671633);
		NativeMethodInfoPtr_GetDocumentsByDifficulty_Public_List_1_DocumentSO_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671634);
		NativeMethodInfoPtr_GetRandomDocument_Public_DocumentSO_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671635);
		NativeMethodInfoPtr_HasDocument_Public_Boolean_DocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671636);
		NativeMethodInfoPtr_GetStamp_Public_StampSO_StampType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671637);
		NativeMethodInfoPtr_GetAllStamps_Public_IReadOnlyList_1_StampSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671638);
		NativeMethodInfoPtr_GetRequiredStampsForDocument_Public_List_1_StampSO_DocumentSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671639);
		NativeMethodInfoPtr_HasStamp_Public_Boolean_StampType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671640);
		NativeMethodInfoPtr_RegisterDocument_Public_Void_DocumentSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671641);
		NativeMethodInfoPtr_RegisterStamp_Public_Void_StampSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671642);
		NativeMethodInfoPtr_UnregisterDocument_Public_Void_DocumentSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671643);
		NativeMethodInfoPtr_UnregisterStamp_Public_Void_StampSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671644);
		NativeMethodInfoPtr_get_DocumentCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671645);
		NativeMethodInfoPtr_get_StampCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671646);
		NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671647);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr, 100671648);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 136894, RefRangeEnd = 136901, XrefRangeStart = 136833, XrefRangeEnd = 136894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136901, XrefRangeEnd = 136902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureInitialized()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136906, RefRangeEnd = 136907, XrefRangeStart = 136902, XrefRangeEnd = 136906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DocumentSO GetDocument(DocumentType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDocument_Public_DocumentSO_DocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DocumentSO>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136907, XrefRangeEnd = 136911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IReadOnlyList<DocumentSO> GetAllDocuments()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllDocuments_Public_IReadOnlyList_1_DocumentSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IReadOnlyList<DocumentSO>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136911, XrefRangeEnd = 136938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<DocumentSO> GetAvailableDocuments()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAvailableDocuments_Public_List_1_DocumentSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DocumentSO>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136965, RefRangeEnd = 136966, XrefRangeStart = 136938, XrefRangeEnd = 136965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<DocumentSO> GetDocumentsByDifficulty(int maxDifficulty)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&maxDifficulty);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDocumentsByDifficulty_Public_List_1_DocumentSO_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DocumentSO>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136966, XrefRangeEnd = 136972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DocumentSO GetRandomDocument(int maxDifficulty = 5)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&maxDifficulty);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomDocument_Public_DocumentSO_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DocumentSO>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136972, XrefRangeEnd = 136977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasDocument(DocumentType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasDocument_Public_Boolean_DocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136981, RefRangeEnd = 136982, XrefRangeStart = 136977, XrefRangeEnd = 136981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StampSO GetStamp(StampType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStamp_Public_StampSO_StampType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StampSO>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136982, XrefRangeEnd = 136986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IReadOnlyList<StampSO> GetAllStamps()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllStamps_Public_IReadOnlyList_1_StampSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IReadOnlyList<StampSO>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136986, XrefRangeEnd = 137005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<StampSO> GetRequiredStampsForDocument(DocumentSO document)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)document);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRequiredStampsForDocument_Public_List_1_StampSO_DocumentSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<StampSO>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137005, XrefRangeEnd = 137010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasStamp(StampType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasStamp_Public_Boolean_StampType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137010, XrefRangeEnd = 137020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterDocument(DocumentSO document)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)document);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterDocument_Public_Void_DocumentSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137020, XrefRangeEnd = 137030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterStamp(StampSO stamp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stamp);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterStamp_Public_Void_StampSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137030, XrefRangeEnd = 137033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterDocument(DocumentSO document)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)document);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterDocument_Public_Void_DocumentSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137033, XrefRangeEnd = 137036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterStamp(StampSO stamp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stamp);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterStamp_Public_Void_StampSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137038, XrefRangeEnd = 137039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Refresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137039, XrefRangeEnd = 137054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DocumentDatabase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentDatabase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DocumentDatabase(IntPtr pointer)
		: base(pointer)
	{
	}
}
