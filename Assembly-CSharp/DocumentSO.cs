using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public class DocumentSO : ScriptableObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr_documentType;

	private static readonly System.IntPtr NativeFieldInfoPtr_documentNameKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_documentDescriptionKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_documentIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_documentMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_documentPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredStamps;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseStreetRep;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresPhoto;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredForgeryLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficultyLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseTimeLimit;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DocumentType_Public_get_DocumentType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DocumentNameKey_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DocumentDescriptionKey_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DocumentIcon_Public_get_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DocumentMaterial_Public_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DocumentPrefab_Public_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RequiredStamps_Public_get_Il2CppStructArray_1_StampRequirement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BaseStreetRep_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BaseMoney_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RequiresPhoto_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RequiredForgeryLevel_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DifficultyLevel_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BaseTimeLimit_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDocumentName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDocumentDescription_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredStampTypes_Public_Il2CppStructArray_1_StampType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStampRequirement_Public_Nullable_1_StampRequirement_StampType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalRequirementCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe DocumentType documentType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentType);
			return *(DocumentType*)num;
		}
		set
		{
			*(DocumentType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentType)) = documentType;
		}
	}

	public unsafe string documentNameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentNameKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentNameKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string documentDescriptionKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentDescriptionKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentDescriptionKey)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Sprite documentIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Material documentMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe GameObject documentPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Il2CppStructArray<StampRequirement> requiredStamps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredStamps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<StampRequirement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredStamps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int baseStreetRep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseStreetRep);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseStreetRep)) = num;
		}
	}

	public unsafe int baseMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMoney);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMoney)) = num;
		}
	}

	public unsafe bool requiresPhoto
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresPhoto);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresPhoto)) = flag;
		}
	}

	public unsafe int requiredForgeryLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredForgeryLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredForgeryLevel)) = num;
		}
	}

	public unsafe int difficultyLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyLevel)) = num;
		}
	}

	public unsafe float baseTimeLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTimeLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTimeLimit)) = num;
		}
	}

	public unsafe DocumentType DocumentType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DocumentType_Public_get_DocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(DocumentType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe string DocumentNameKey
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 43540, RefRangeEnd = 43551, XrefRangeStart = 43540, XrefRangeEnd = 43551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DocumentNameKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string DocumentDescriptionKey
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43141, RefRangeEnd = 43144, XrefRangeStart = 43141, XrefRangeEnd = 43144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DocumentDescriptionKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe Sprite DocumentIcon
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 43149, RefRangeEnd = 43165, XrefRangeStart = 43149, XrefRangeEnd = 43165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DocumentIcon_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
	}

	public unsafe Material DocumentMaterial
	{
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 57380, RefRangeEnd = 57408, XrefRangeStart = 57380, XrefRangeEnd = 57408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DocumentMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
	}

	public unsafe GameObject DocumentPrefab
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137054, RefRangeEnd = 137055, XrefRangeStart = 137054, XrefRangeEnd = 137054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DocumentPrefab_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
	}

	public unsafe Il2CppStructArray<StampRequirement> RequiredStamps
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RequiredStamps_Public_get_Il2CppStructArray_1_StampRequirement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<StampRequirement>>(intPtr) : null;
		}
	}

	public unsafe int BaseStreetRep
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137055, RefRangeEnd = 137059, XrefRangeStart = 137055, XrefRangeEnd = 137055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BaseStreetRep_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int BaseMoney
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 137059, RefRangeEnd = 137069, XrefRangeStart = 137059, XrefRangeEnd = 137059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BaseMoney_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool RequiresPhoto
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 137069, RefRangeEnd = 137076, XrefRangeStart = 137069, XrefRangeEnd = 137069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RequiresPhoto_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int RequiredForgeryLevel
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137076, RefRangeEnd = 137077, XrefRangeStart = 137076, XrefRangeEnd = 137076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RequiredForgeryLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int DifficultyLevel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DifficultyLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float BaseTimeLimit
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BaseTimeLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static DocumentSO()
	{
		Il2CppClassPointerStore<DocumentSO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DocumentSO");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr);
		NativeFieldInfoPtr_documentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "documentType");
		NativeFieldInfoPtr_documentNameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "documentNameKey");
		NativeFieldInfoPtr_documentDescriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "documentDescriptionKey");
		NativeFieldInfoPtr_documentIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "documentIcon");
		NativeFieldInfoPtr_documentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "documentMaterial");
		NativeFieldInfoPtr_documentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "documentPrefab");
		NativeFieldInfoPtr_requiredStamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "requiredStamps");
		NativeFieldInfoPtr_baseStreetRep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "baseStreetRep");
		NativeFieldInfoPtr_baseMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "baseMoney");
		NativeFieldInfoPtr_requiresPhoto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "requiresPhoto");
		NativeFieldInfoPtr_requiredForgeryLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "requiredForgeryLevel");
		NativeFieldInfoPtr_difficultyLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "difficultyLevel");
		NativeFieldInfoPtr_baseTimeLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, "baseTimeLimit");
		NativeMethodInfoPtr_get_DocumentType_Public_get_DocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671649);
		NativeMethodInfoPtr_get_DocumentNameKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671650);
		NativeMethodInfoPtr_get_DocumentDescriptionKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671651);
		NativeMethodInfoPtr_get_DocumentIcon_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671652);
		NativeMethodInfoPtr_get_DocumentMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671653);
		NativeMethodInfoPtr_get_DocumentPrefab_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671654);
		NativeMethodInfoPtr_get_RequiredStamps_Public_get_Il2CppStructArray_1_StampRequirement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671655);
		NativeMethodInfoPtr_get_BaseStreetRep_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671656);
		NativeMethodInfoPtr_get_BaseMoney_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671657);
		NativeMethodInfoPtr_get_RequiresPhoto_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671658);
		NativeMethodInfoPtr_get_RequiredForgeryLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671659);
		NativeMethodInfoPtr_get_DifficultyLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671660);
		NativeMethodInfoPtr_get_BaseTimeLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671661);
		NativeMethodInfoPtr_GetDocumentName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671662);
		NativeMethodInfoPtr_GetDocumentDescription_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671663);
		NativeMethodInfoPtr_GetRequiredStampTypes_Public_Il2CppStructArray_1_StampType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671664);
		NativeMethodInfoPtr_GetStampRequirement_Public_Nullable_1_StampRequirement_StampType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671665);
		NativeMethodInfoPtr_GetTotalRequirementCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671666);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr, 100671667);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137077, XrefRangeEnd = 137081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDocumentName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDocumentName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137081, XrefRangeEnd = 137088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDocumentDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDocumentDescription_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 137093, RefRangeEnd = 137100, XrefRangeStart = 137088, XrefRangeEnd = 137093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<StampType> GetRequiredStampTypes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRequiredStampTypes_Public_Il2CppStructArray_1_StampType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<StampType>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 137104, RefRangeEnd = 137106, XrefRangeStart = 137100, XrefRangeEnd = 137104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<StampRequirement> GetStampRequirement(StampType stampType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stampType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStampRequirement_Public_Nullable_1_StampRequirement_StampType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<StampRequirement>(pointer);
	}

	[CallerCount(0)]
	public unsafe int GetTotalRequirementCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalRequirementCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137106, XrefRangeEnd = 137115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DocumentSO()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentSO>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DocumentSO(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
