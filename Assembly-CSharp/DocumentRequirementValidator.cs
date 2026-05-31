using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public static class DocumentRequirementValidator : Il2CppSystem.Object
{
	public sealed class ValidationResult : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_IsValid;

		private static readonly System.IntPtr NativeFieldInfoPtr_CompletionPercentage;

		private static readonly System.IntPtr NativeFieldInfoPtr_MissingRequirements;

		private static readonly System.IntPtr NativeFieldInfoPtr_CompletedRequirements;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateValid_Public_Static_ValidationResult_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateInvalid_Public_Static_ValidationResult_List_1_String_List_1_String_Single_0;

		public unsafe bool IsValid
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsValid);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsValid)) = flag;
			}
		}

		public unsafe float CompletionPercentage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompletionPercentage);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompletionPercentage)) = num;
			}
		}

		public unsafe List<string> MissingRequirements
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingRequirements);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissingRequirements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<string> CompletedRequirements
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompletedRequirements);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompletedRequirements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static ValidationResult()
		{
			Il2CppClassPointerStore<ValidationResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr, "ValidationResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr);
			NativeFieldInfoPtr_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "IsValid");
			NativeFieldInfoPtr_CompletionPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "CompletionPercentage");
			NativeFieldInfoPtr_MissingRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "MissingRequirements");
			NativeFieldInfoPtr_CompletedRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "CompletedRequirements");
			NativeMethodInfoPtr_CreateValid_Public_Static_ValidationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, 100671705);
			NativeMethodInfoPtr_CreateInvalid_Public_Static_ValidationResult_List_1_String_List_1_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, 100671706);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137140, XrefRangeEnd = 137152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValidationResult CreateValid()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateValid_Public_Static_ValidationResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValidationResult(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137152, XrefRangeEnd = 137164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValidationResult CreateInvalid(List<string> missing, List<string> completed, float percentage)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)missing);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)completed);
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &percentage;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInvalid_Public_Static_ValidationResult_List_1_String_List_1_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValidationResult(pointer);
		}

		public ValidationResult(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ValidationResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateDocument_Public_Static_ValidationResult_IForgeable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateDocumentAgainstData_Public_Static_ValidationResult_IForgeable_DocumentSO_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasAllRequiredStamps_Public_Static_Boolean_IForgeable_DocumentSO_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissingStamps_Public_Static_Il2CppStructArray_1_StampType_IForgeable_DocumentSO_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsStampRequired_Public_Static_Boolean_DocumentSO_StampType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateStampPlacement_Public_Static_Boolean_DocumentSO_StampType_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStampPlacementAccuracy_Public_Static_Single_DocumentSO_StampType_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateDocumentQuality_Public_Static_Single_ForgeryDocument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQualityRating_Public_Static_DocumentQuality_Single_0;

	static DocumentRequirementValidator()
	{
		Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DocumentRequirementValidator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr);
		NativeMethodInfoPtr_ValidateDocument_Public_Static_ValidationResult_IForgeable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr, 100671696);
		NativeMethodInfoPtr_ValidateDocumentAgainstData_Public_Static_ValidationResult_IForgeable_DocumentSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr, 100671697);
		NativeMethodInfoPtr_HasAllRequiredStamps_Public_Static_Boolean_IForgeable_DocumentSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr, 100671698);
		NativeMethodInfoPtr_GetMissingStamps_Public_Static_Il2CppStructArray_1_StampType_IForgeable_DocumentSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr, 100671699);
		NativeMethodInfoPtr_IsStampRequired_Public_Static_Boolean_DocumentSO_StampType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr, 100671700);
		NativeMethodInfoPtr_ValidateStampPlacement_Public_Static_Boolean_DocumentSO_StampType_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr, 100671701);
		NativeMethodInfoPtr_GetStampPlacementAccuracy_Public_Static_Single_DocumentSO_StampType_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr, 100671702);
		NativeMethodInfoPtr_CalculateDocumentQuality_Public_Static_Single_ForgeryDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr, 100671703);
		NativeMethodInfoPtr_GetQualityRating_Public_Static_DocumentQuality_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentRequirementValidator>.NativeClassPtr, 100671704);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137164, XrefRangeEnd = 137217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ValidationResult ValidateDocument(IForgeable document)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)document);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateDocument_Public_Static_ValidationResult_IForgeable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ValidationResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 137285, RefRangeEnd = 137286, XrefRangeStart = 137217, XrefRangeEnd = 137285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ValidationResult ValidateDocumentAgainstData(IForgeable document, DocumentSO documentData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)document);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)documentData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateDocumentAgainstData_Public_Static_ValidationResult_IForgeable_DocumentSO_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ValidationResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137286, XrefRangeEnd = 137296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasAllRequiredStamps(IForgeable document, DocumentSO documentData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)document);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)documentData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasAllRequiredStamps_Public_Static_Boolean_IForgeable_DocumentSO_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137296, XrefRangeEnd = 137323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<StampType> GetMissingStamps(IForgeable document, DocumentSO documentData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)document);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)documentData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissingStamps_Public_Static_Il2CppStructArray_1_StampType_IForgeable_DocumentSO_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<StampType>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137323, XrefRangeEnd = 137329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsStampRequired(DocumentSO documentData, StampType stampType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)documentData);
		*(StampType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stampType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsStampRequired_Public_Static_Boolean_DocumentSO_StampType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137329, XrefRangeEnd = 137347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ValidateStampPlacement(DocumentSO documentData, StampType stampType, Vector2 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)documentData);
		*(StampType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stampType;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateStampPlacement_Public_Static_Boolean_DocumentSO_StampType_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 137366, RefRangeEnd = 137367, XrefRangeStart = 137347, XrefRangeEnd = 137366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetStampPlacementAccuracy(DocumentSO documentData, StampType stampType, Vector2 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)documentData);
		*(StampType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stampType;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStampPlacementAccuracy_Public_Static_Single_DocumentSO_StampType_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137367, XrefRangeEnd = 137398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalculateDocumentQuality(ForgeryDocument document)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)document);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateDocumentQuality_Public_Static_Single_ForgeryDocument_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static DocumentQuality GetQualityRating(float qualityScore)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&qualityScore);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQualityRating_Public_Static_DocumentQuality_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DocumentQuality*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public DocumentRequirementValidator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
