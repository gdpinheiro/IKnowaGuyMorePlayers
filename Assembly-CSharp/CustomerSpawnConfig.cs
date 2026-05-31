using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class CustomerSpawnConfig : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaymentType;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsShady;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcData;

	private static readonly System.IntPtr NativeFieldInfoPtr_DialogueRound;

	public unsafe GameObject Prefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Prefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Prefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe PaymentType PaymentType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaymentType);
			return *(PaymentType*)num;
		}
		set
		{
			*(PaymentType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaymentType)) = paymentType;
		}
	}

	public unsafe bool IsShady
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsShady);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsShady)) = flag;
		}
	}

	public unsafe NPCDialogueData NpcData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NPCDialogueData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nPCDialogueData));
		}
	}

	public unsafe int DialogueRound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DialogueRound);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DialogueRound)) = num;
		}
	}

	static CustomerSpawnConfig()
	{
		Il2CppClassPointerStore<CustomerSpawnConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CustomerSpawnConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSpawnConfig>.NativeClassPtr);
		NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSpawnConfig>.NativeClassPtr, "Prefab");
		NativeFieldInfoPtr_PaymentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSpawnConfig>.NativeClassPtr, "PaymentType");
		NativeFieldInfoPtr_IsShady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSpawnConfig>.NativeClassPtr, "IsShady");
		NativeFieldInfoPtr_NpcData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSpawnConfig>.NativeClassPtr, "NpcData");
		NativeFieldInfoPtr_DialogueRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSpawnConfig>.NativeClassPtr, "DialogueRound");
	}

	public CustomerSpawnConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CustomerSpawnConfig()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSpawnConfig>.NativeClassPtr))
	{
	}
}
