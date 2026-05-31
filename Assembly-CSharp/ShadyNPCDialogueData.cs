using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class ShadyNPCDialogueData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_missionNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_level;

	private static readonly System.IntPtr NativeFieldInfoPtr_category;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefabNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcName;

	private static readonly System.IntPtr NativeFieldInfoPtr_dialogues;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_deliveryType;

	private static readonly System.IntPtr NativeFieldInfoPtr_openWorldStartHour;

	private static readonly System.IntPtr NativeFieldInfoPtr_openWorldEndHour;

	private static readonly System.IntPtr NativeFieldInfoPtr_openWorldLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeryFirstName;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgerySurname;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeryAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeryBreed;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeryNationalId;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeryPhotoRequired;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredUpgradeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_parentTierUpgradeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPreviewOnly;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadyTaskType_Public_ShadyTaskType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBurnableQuest_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWashableQuest_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsContrabandQuest_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsForgeryQuest_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredContrabandId_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCourierDelivery_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHandoverDelivery_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOpenWorldDelivery_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseTags_Public_Static_ValueTuple_8_String_String_ShadyDeliveryType_String_String_String_String_ValueTuple_5_String_Boolean_Single_Single_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseHourMinute_Private_Static_Single_String_0;

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

	public unsafe List<string> dialogues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogues);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string requiredItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredItem);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredItem)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

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

	public unsafe float openWorldStartHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openWorldStartHour);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openWorldStartHour)) = num;
		}
	}

	public unsafe float openWorldEndHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openWorldEndHour);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openWorldEndHour)) = num;
		}
	}

	public unsafe string openWorldLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openWorldLocation);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openWorldLocation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string forgeryFirstName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeryFirstName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeryFirstName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string forgerySurname
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgerySurname);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgerySurname)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string forgeryAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeryAmount);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeryAmount)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string forgeryBreed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeryBreed);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeryBreed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string forgeryNationalId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeryNationalId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeryNationalId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool forgeryPhotoRequired
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeryPhotoRequired);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forgeryPhotoRequired)) = flag;
		}
	}

	public unsafe string requiredUpgradeId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredUpgradeId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredUpgradeId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string parentTierUpgradeId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentTierUpgradeId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentTierUpgradeId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool isPreviewOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPreviewOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPreviewOnly)) = flag;
		}
	}

	static ShadyNPCDialogueData()
	{
		Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShadyNPCDialogueData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr);
		NativeFieldInfoPtr_missionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "missionNumber");
		NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "level");
		NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "category");
		NativeFieldInfoPtr_prefabNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "prefabNumber");
		NativeFieldInfoPtr_npcName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "npcName");
		NativeFieldInfoPtr_dialogues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "dialogues");
		NativeFieldInfoPtr_requiredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "requiredItem");
		NativeFieldInfoPtr_deliveryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "deliveryType");
		NativeFieldInfoPtr_openWorldStartHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "openWorldStartHour");
		NativeFieldInfoPtr_openWorldEndHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "openWorldEndHour");
		NativeFieldInfoPtr_openWorldLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "openWorldLocation");
		NativeFieldInfoPtr_forgeryFirstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "forgeryFirstName");
		NativeFieldInfoPtr_forgerySurname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "forgerySurname");
		NativeFieldInfoPtr_forgeryAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "forgeryAmount");
		NativeFieldInfoPtr_forgeryBreed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "forgeryBreed");
		NativeFieldInfoPtr_forgeryNationalId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "forgeryNationalId");
		NativeFieldInfoPtr_forgeryPhotoRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "forgeryPhotoRequired");
		NativeFieldInfoPtr_requiredUpgradeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "requiredUpgradeId");
		NativeFieldInfoPtr_parentTierUpgradeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "parentTierUpgradeId");
		NativeFieldInfoPtr_isPreviewOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, "isPreviewOnly");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_GetShadyTaskType_Public_ShadyTaskType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_IsBurnableQuest_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_IsWashableQuest_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_IsContrabandQuest_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_IsForgeryQuest_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_GetRequiredContrabandId_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_IsCourierDelivery_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_IsHandoverDelivery_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_IsOpenWorldDelivery_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_ParseTags_Public_Static_ValueTuple_8_String_String_ShadyDeliveryType_String_String_String_String_ValueTuple_5_String_Boolean_Single_Single_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_ParseHourMinute_Private_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr, 100663458);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 23100, RefRangeEnd = 23104, XrefRangeStart = 23092, XrefRangeEnd = 23100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadyNPCDialogueData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadyNPCDialogueData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 23106, RefRangeEnd = 23108, XrefRangeStart = 23104, XrefRangeEnd = 23106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadyTaskType GetShadyTaskType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadyTaskType_Public_ShadyTaskType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ShadyTaskType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 23108, RefRangeEnd = 23113, XrefRangeStart = 23108, XrefRangeEnd = 23108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBurnableQuest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBurnableQuest_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 23113, RefRangeEnd = 23120, XrefRangeStart = 23113, XrefRangeEnd = 23113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsWashableQuest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWashableQuest_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 23120, RefRangeEnd = 23129, XrefRangeStart = 23120, XrefRangeEnd = 23120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsContrabandQuest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsContrabandQuest_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 23129, RefRangeEnd = 23138, XrefRangeStart = 23129, XrefRangeEnd = 23129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsForgeryQuest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsForgeryQuest_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 23138, RefRangeEnd = 23144, XrefRangeStart = 23138, XrefRangeEnd = 23138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRequiredContrabandId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRequiredContrabandId_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 23144, RefRangeEnd = 23147, XrefRangeStart = 23144, XrefRangeEnd = 23144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCourierDelivery()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCourierDelivery_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 23147, RefRangeEnd = 23155, XrefRangeStart = 23147, XrefRangeEnd = 23147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsHandoverDelivery()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHandoverDelivery_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 23155, RefRangeEnd = 23159, XrefRangeStart = 23155, XrefRangeEnd = 23155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsOpenWorldDelivery()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOpenWorldDelivery_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23255, RefRangeEnd = 23256, XrefRangeStart = 23159, XrefRangeEnd = 23255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<string, string, ShadyDeliveryType, string, string, string, string, Il2CppSystem.ValueTuple<string, bool, float, float, string>> ParseTags(string rawText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rawText);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTags_Public_Static_ValueTuple_8_String_String_ShadyDeliveryType_String_String_String_String_ValueTuple_5_String_Boolean_Single_Single_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<string, string, ShadyDeliveryType, string, string, string, string, Il2CppSystem.ValueTuple<string, bool, float, float, string>>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 23259, RefRangeEnd = 23261, XrefRangeStart = 23256, XrefRangeEnd = 23259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ParseHourMinute(string hhmm)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hhmm);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseHourMinute_Private_Static_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ShadyNPCDialogueData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
