using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class ShadyQuestOrder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_orderId;

	private static readonly System.IntPtr NativeFieldInfoPtr_questData;

	private static readonly System.IntPtr NativeFieldInfoPtr_state;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemNetworkId;

	private static readonly System.IntPtr NativeFieldInfoPtr_cryptoPayment;

	private static readonly System.IntPtr NativeFieldInfoPtr_createdTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcName;

	private static readonly System.IntPtr NativeFieldInfoPtr_remainingTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxWaitTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_questName;

	private static readonly System.IntPtr NativeFieldInfoPtr_questDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_locationHint;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBurnable;

	private static readonly System.IntPtr NativeFieldInfoPtr_isWashable;

	private static readonly System.IntPtr NativeFieldInfoPtr_isContraband;

	private static readonly System.IntPtr NativeFieldInfoPtr_isForgery;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentTaskText;

	private static readonly System.IntPtr NativeFieldInfoPtr_contrabandId;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredDocumentType;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeryFirstName;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgerySurname;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeryAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeryBreed;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeryNationalId;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgeryPhotoRequired;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOpenWorldQuest;

	private static readonly System.IntPtr NativeFieldInfoPtr_openWorldStartHour;

	private static readonly System.IntPtr NativeFieldInfoPtr_openWorldEndHour;

	private static readonly System.IntPtr NativeFieldInfoPtr_openWorldLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_openWorldCreatedDay;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string orderId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ShadyNPCDialogueData questData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyNPCDialogueData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadyNPCDialogueData));
		}
	}

	public unsafe ShadyQuestState state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state);
			return *(ShadyQuestState*)num;
		}
		set
		{
			*(ShadyQuestState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state)) = shadyQuestState;
		}
	}

	public unsafe ulong itemNetworkId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemNetworkId);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemNetworkId)) = num;
		}
	}

	public unsafe float cryptoPayment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cryptoPayment);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cryptoPayment)) = num;
		}
	}

	public unsafe float createdTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createdTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createdTime)) = num;
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

	public unsafe float remainingTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingTime)) = num;
		}
	}

	public unsafe float maxWaitTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWaitTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWaitTime)) = num;
		}
	}

	public unsafe string questName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string questDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questDescription);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_questDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string locationHint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationHint);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationHint)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool isBurnable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBurnable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBurnable)) = flag;
		}
	}

	public unsafe bool isWashable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWashable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWashable)) = flag;
		}
	}

	public unsafe bool isContraband
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isContraband);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isContraband)) = flag;
		}
	}

	public unsafe bool isForgery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isForgery);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isForgery)) = flag;
		}
	}

	public unsafe string currentTaskText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTaskText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTaskText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string contrabandId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contrabandId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contrabandId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string requiredDocumentType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredDocumentType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredDocumentType)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe bool isOpenWorldQuest
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOpenWorldQuest);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOpenWorldQuest)) = flag;
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

	public unsafe int openWorldCreatedDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openWorldCreatedDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openWorldCreatedDay)) = num;
		}
	}

	static ShadyQuestOrder()
	{
		Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShadyQuestOrder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr);
		NativeFieldInfoPtr_orderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "orderId");
		NativeFieldInfoPtr_questData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "questData");
		NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "state");
		NativeFieldInfoPtr_itemNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "itemNetworkId");
		NativeFieldInfoPtr_cryptoPayment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "cryptoPayment");
		NativeFieldInfoPtr_createdTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "createdTime");
		NativeFieldInfoPtr_npcName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "npcName");
		NativeFieldInfoPtr_remainingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "remainingTime");
		NativeFieldInfoPtr_maxWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "maxWaitTime");
		NativeFieldInfoPtr_questName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "questName");
		NativeFieldInfoPtr_questDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "questDescription");
		NativeFieldInfoPtr_locationHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "locationHint");
		NativeFieldInfoPtr_isBurnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "isBurnable");
		NativeFieldInfoPtr_isWashable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "isWashable");
		NativeFieldInfoPtr_isContraband = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "isContraband");
		NativeFieldInfoPtr_isForgery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "isForgery");
		NativeFieldInfoPtr_currentTaskText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "currentTaskText");
		NativeFieldInfoPtr_contrabandId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "contrabandId");
		NativeFieldInfoPtr_requiredDocumentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "requiredDocumentType");
		NativeFieldInfoPtr_forgeryFirstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "forgeryFirstName");
		NativeFieldInfoPtr_forgerySurname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "forgerySurname");
		NativeFieldInfoPtr_forgeryAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "forgeryAmount");
		NativeFieldInfoPtr_forgeryBreed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "forgeryBreed");
		NativeFieldInfoPtr_forgeryNationalId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "forgeryNationalId");
		NativeFieldInfoPtr_forgeryPhotoRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "forgeryPhotoRequired");
		NativeFieldInfoPtr_isOpenWorldQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "isOpenWorldQuest");
		NativeFieldInfoPtr_openWorldStartHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "openWorldStartHour");
		NativeFieldInfoPtr_openWorldEndHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "openWorldEndHour");
		NativeFieldInfoPtr_openWorldLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "openWorldLocation");
		NativeFieldInfoPtr_openWorldCreatedDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, "openWorldCreatedDay");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr, 100671918);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 140685, RefRangeEnd = 140690, XrefRangeStart = 140677, XrefRangeEnd = 140685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadyQuestOrder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadyQuestOrder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShadyQuestOrder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
