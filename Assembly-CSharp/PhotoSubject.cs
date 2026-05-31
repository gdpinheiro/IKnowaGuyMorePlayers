using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class PhotoSubject : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_subjectType;

	private static readonly IntPtr NativeFieldInfoPtr_customSubjectId;

	private static readonly IntPtr NativeFieldInfoPtr_detectionRadius;

	private static readonly IntPtr NativeFieldInfoPtr_subjectIndex;

	private static readonly IntPtr NativeMethodInfoPtr_get_SubjectIndex_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SubjectType_Public_get_PhotoSubjectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DetectionRadius_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSubjectId_Public_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDisplayName_Public_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe PhotoSubjectType subjectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subjectType);
			return *(PhotoSubjectType*)num;
		}
		set
		{
			*(PhotoSubjectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subjectType)) = photoSubjectType;
		}
	}

	public unsafe string customSubjectId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customSubjectId);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customSubjectId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float detectionRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detectionRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detectionRadius)) = num;
		}
	}

	public unsafe int subjectIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subjectIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subjectIndex)) = num;
		}
	}

	public unsafe int SubjectIndex
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123418, RefRangeEnd = 123419, XrefRangeStart = 123418, XrefRangeEnd = 123418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SubjectIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe PhotoSubjectType SubjectType
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57063, RefRangeEnd = 57064, XrefRangeStart = 57063, XrefRangeEnd = 57064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SubjectType_Public_get_PhotoSubjectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(PhotoSubjectType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float DetectionRadius
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DetectionRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static PhotoSubject()
	{
		Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PhotoSubject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr);
		NativeFieldInfoPtr_subjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr, "subjectType");
		NativeFieldInfoPtr_customSubjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr, "customSubjectId");
		NativeFieldInfoPtr_detectionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr, "detectionRadius");
		NativeFieldInfoPtr_subjectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr, "subjectIndex");
		NativeMethodInfoPtr_get_SubjectIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr, 100670769);
		NativeMethodInfoPtr_get_SubjectType_Public_get_PhotoSubjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr, 100670770);
		NativeMethodInfoPtr_get_DetectionRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr, 100670771);
		NativeMethodInfoPtr_GetSubjectId_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr, 100670772);
		NativeMethodInfoPtr_GetDisplayName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr, 100670773);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr, 100670774);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123419, XrefRangeEnd = 123425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSubjectId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubjectId_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123425, XrefRangeEnd = 123434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDisplayName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDisplayName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123434, XrefRangeEnd = 123435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhotoSubject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoSubject>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PhotoSubject(IntPtr pointer)
		: base(pointer)
	{
	}
}
