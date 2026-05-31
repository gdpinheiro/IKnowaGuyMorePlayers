using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Netcode;

public class DarkWebNetworkState : NetworkBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_shadyItemDatabase;

	private static readonly System.IntPtr NativeFieldInfoPtr_TabNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_SyncedCart;

	private static readonly System.IntPtr NativeFieldInfoPtr_SyncedTabIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_VirusGameType;

	private static readonly System.IntPtr NativeFieldInfoPtr_VirusProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_VirusTimeRemaining;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScamPurchaseMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_PurchasedMachineMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnCartChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnTabChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnPopupTriggered;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnScamPurchaseChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_SCAM_PRINCE_100;

	private static readonly System.IntPtr NativeFieldInfoPtr_SCAM_PRINCE_500;

	private static readonly System.IntPtr NativeFieldInfoPtr_SCAM_PRINCE_1000;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnCartChanged_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnCartChanged_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnTabChanged_Public_add_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnTabChanged_Public_rem_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnPopupTriggered_Public_add_Void_Action_3_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnPopupTriggered_Public_rem_Void_Action_3_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnScamPurchaseChanged_Public_add_Void_Action_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnScamPurchaseChanged_Public_rem_Void_Action_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnNetworkSpawn_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnNetworkDespawn_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnScamMaskChanged_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSyncedCartListChanged_Private_Void_NetworkListEvent_1_NetworkCartEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSyncedTabIndexChanged_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteCartRpc_Public_Void_Il2CppStructArray_1_NetworkCartEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteCart_Public_Void_Dictionary_2_ValueTuple_2_ContrabandSO_String_ValueTuple_2_ContrabandListing_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadCart_Public_Dictionary_2_ValueTuple_2_ContrabandSO_String_ValueTuple_2_ContrabandListing_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindListingIndex_Private_Int32_ContrabandSO_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetListingByIndex_Private_ContrabandListing_ContrabandSO_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteTabRpc_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteTab_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadTab_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TabNameToIndex_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TabIndexToName_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteVirusStateRpc_Public_Void_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteVirusProgressRpc_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearVirusStateRpc_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BroadcastPopupRpc_Public_Void_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BroadcastPopupClientRpc_Private_Void_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScamPurchasedRpc_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsScamPurchased_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMachinePurchasedRpc_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMachinePurchased_Public_Boolean_MachineType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveSectionKey_Public_Virtual_Final_New_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveState_Public_Virtual_Final_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadState_Public_Virtual_Final_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___initializeVariables_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___initializeRpcs_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___rpc_handler_4251851397_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___rpc_handler_1166963956_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___rpc_handler_1656419121_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___rpc_handler_3225087287_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___rpc_handler_2700394755_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___rpc_handler_3791841625_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___rpc_handler_2932297656_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___rpc_handler_4076549021_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___rpc_handler_714399392_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___getTypeName_FamOrAssem_Virtual_String_0;

	public unsafe ShadyItemDatabase shadyItemDatabase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyItemDatabase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShadyItemDatabase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadyItemDatabase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadyItemDatabase));
		}
	}

	public unsafe static Il2CppStringArray TabNames
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TabNames, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TabNames, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe NetworkList<NetworkCartEntry> SyncedCart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SyncedCart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkList<NetworkCartEntry>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SyncedCart)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkList));
		}
	}

	public unsafe NetworkVariable<int> SyncedTabIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SyncedTabIndex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SyncedTabIndex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkVariable));
		}
	}

	public unsafe NetworkVariable<int> VirusGameType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirusGameType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirusGameType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkVariable));
		}
	}

	public unsafe NetworkVariable<int> VirusProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirusProgress);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirusProgress)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkVariable));
		}
	}

	public unsafe NetworkVariable<float> VirusTimeRemaining
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirusTimeRemaining);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VirusTimeRemaining)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkVariable));
		}
	}

	public unsafe NetworkVariable<int> ScamPurchaseMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScamPurchaseMask);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScamPurchaseMask)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkVariable));
		}
	}

	public unsafe NetworkVariable<int> PurchasedMachineMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PurchasedMachineMask);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PurchasedMachineMask)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkVariable));
		}
	}

	public unsafe Il2CppSystem.Action OnCartChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCartChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCartChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<string> OnTabChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTabChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTabChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<int, float, float> OnPopupTriggered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPopupTriggered);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, float, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPopupTriggered)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<int> OnScamPurchaseChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnScamPurchaseChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnScamPurchaseChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe static int SCAM_PRINCE_100
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SCAM_PRINCE_100, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SCAM_PRINCE_100, (void*)(&num));
		}
	}

	public unsafe static int SCAM_PRINCE_500
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SCAM_PRINCE_500, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SCAM_PRINCE_500, (void*)(&num));
		}
	}

	public unsafe static int SCAM_PRINCE_1000
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SCAM_PRINCE_1000, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SCAM_PRINCE_1000, (void*)(&num));
		}
	}

	public unsafe virtual string SaveSectionKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159284, XrefRangeEnd = 159286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SaveSectionKey_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static DarkWebNetworkState()
	{
		Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DarkWebNetworkState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr);
		NativeFieldInfoPtr_shadyItemDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "shadyItemDatabase");
		NativeFieldInfoPtr_TabNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "TabNames");
		NativeFieldInfoPtr_SyncedCart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "SyncedCart");
		NativeFieldInfoPtr_SyncedTabIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "SyncedTabIndex");
		NativeFieldInfoPtr_VirusGameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "VirusGameType");
		NativeFieldInfoPtr_VirusProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "VirusProgress");
		NativeFieldInfoPtr_VirusTimeRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "VirusTimeRemaining");
		NativeFieldInfoPtr_ScamPurchaseMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "ScamPurchaseMask");
		NativeFieldInfoPtr_PurchasedMachineMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "PurchasedMachineMask");
		NativeFieldInfoPtr_OnCartChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "OnCartChanged");
		NativeFieldInfoPtr_OnTabChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "OnTabChanged");
		NativeFieldInfoPtr_OnPopupTriggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "OnPopupTriggered");
		NativeFieldInfoPtr_OnScamPurchaseChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "OnScamPurchaseChanged");
		NativeFieldInfoPtr_SCAM_PRINCE_100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "SCAM_PRINCE_100");
		NativeFieldInfoPtr_SCAM_PRINCE_500 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "SCAM_PRINCE_500");
		NativeFieldInfoPtr_SCAM_PRINCE_1000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, "SCAM_PRINCE_1000");
		NativeMethodInfoPtr_add_OnCartChanged_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673032);
		NativeMethodInfoPtr_remove_OnCartChanged_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673033);
		NativeMethodInfoPtr_add_OnTabChanged_Public_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673034);
		NativeMethodInfoPtr_remove_OnTabChanged_Public_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673035);
		NativeMethodInfoPtr_add_OnPopupTriggered_Public_add_Void_Action_3_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673036);
		NativeMethodInfoPtr_remove_OnPopupTriggered_Public_rem_Void_Action_3_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673037);
		NativeMethodInfoPtr_add_OnScamPurchaseChanged_Public_add_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673038);
		NativeMethodInfoPtr_remove_OnScamPurchaseChanged_Public_rem_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673039);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673040);
		NativeMethodInfoPtr_OnNetworkSpawn_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673041);
		NativeMethodInfoPtr_OnNetworkDespawn_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673042);
		NativeMethodInfoPtr_OnScamMaskChanged_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673043);
		NativeMethodInfoPtr_OnSyncedCartListChanged_Private_Void_NetworkListEvent_1_NetworkCartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673044);
		NativeMethodInfoPtr_OnSyncedTabIndexChanged_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673045);
		NativeMethodInfoPtr_WriteCartRpc_Public_Void_Il2CppStructArray_1_NetworkCartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673046);
		NativeMethodInfoPtr_WriteCart_Public_Void_Dictionary_2_ValueTuple_2_ContrabandSO_String_ValueTuple_2_ContrabandListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673047);
		NativeMethodInfoPtr_ReadCart_Public_Dictionary_2_ValueTuple_2_ContrabandSO_String_ValueTuple_2_ContrabandListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673048);
		NativeMethodInfoPtr_FindListingIndex_Private_Int32_ContrabandSO_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673049);
		NativeMethodInfoPtr_GetListingByIndex_Private_ContrabandListing_ContrabandSO_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673050);
		NativeMethodInfoPtr_WriteTabRpc_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673051);
		NativeMethodInfoPtr_WriteTab_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673052);
		NativeMethodInfoPtr_ReadTab_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673053);
		NativeMethodInfoPtr_TabNameToIndex_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673054);
		NativeMethodInfoPtr_TabIndexToName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673055);
		NativeMethodInfoPtr_WriteVirusStateRpc_Public_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673056);
		NativeMethodInfoPtr_WriteVirusProgressRpc_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673057);
		NativeMethodInfoPtr_ClearVirusStateRpc_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673058);
		NativeMethodInfoPtr_BroadcastPopupRpc_Public_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673059);
		NativeMethodInfoPtr_BroadcastPopupClientRpc_Private_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673060);
		NativeMethodInfoPtr_SetScamPurchasedRpc_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673061);
		NativeMethodInfoPtr_IsScamPurchased_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673062);
		NativeMethodInfoPtr_SetMachinePurchasedRpc_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673063);
		NativeMethodInfoPtr_IsMachinePurchased_Public_Boolean_MachineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673064);
		NativeMethodInfoPtr_get_SaveSectionKey_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673065);
		NativeMethodInfoPtr_SaveState_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673066);
		NativeMethodInfoPtr_LoadState_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673067);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673068);
		NativeMethodInfoPtr___initializeVariables_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673070);
		NativeMethodInfoPtr___initializeRpcs_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673071);
		NativeMethodInfoPtr___rpc_handler_4251851397_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673072);
		NativeMethodInfoPtr___rpc_handler_1166963956_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673073);
		NativeMethodInfoPtr___rpc_handler_1656419121_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673074);
		NativeMethodInfoPtr___rpc_handler_3225087287_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673075);
		NativeMethodInfoPtr___rpc_handler_2700394755_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673076);
		NativeMethodInfoPtr___rpc_handler_3791841625_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673077);
		NativeMethodInfoPtr___rpc_handler_2932297656_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673078);
		NativeMethodInfoPtr___rpc_handler_4076549021_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673079);
		NativeMethodInfoPtr___rpc_handler_714399392_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673080);
		NativeMethodInfoPtr___getTypeName_FamOrAssem_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr, 100673081);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 158850, RefRangeEnd = 158852, XrefRangeStart = 158846, XrefRangeEnd = 158850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnCartChanged(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnCartChanged_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 158856, RefRangeEnd = 158857, XrefRangeStart = 158852, XrefRangeEnd = 158856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnCartChanged(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnCartChanged_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 158862, RefRangeEnd = 158864, XrefRangeStart = 158857, XrefRangeEnd = 158862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnTabChanged(Il2CppSystem.Action<string> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnTabChanged_Public_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 158869, RefRangeEnd = 158870, XrefRangeStart = 158864, XrefRangeEnd = 158869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnTabChanged(Il2CppSystem.Action<string> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnTabChanged_Public_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 158875, RefRangeEnd = 158877, XrefRangeStart = 158870, XrefRangeEnd = 158875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnPopupTriggered(Il2CppSystem.Action<int, float, float> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnPopupTriggered_Public_add_Void_Action_3_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 158882, RefRangeEnd = 158883, XrefRangeStart = 158877, XrefRangeEnd = 158882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnPopupTriggered(Il2CppSystem.Action<int, float, float> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnPopupTriggered_Public_rem_Void_Action_3_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158883, XrefRangeEnd = 158888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnScamPurchaseChanged(Il2CppSystem.Action<int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnScamPurchaseChanged_Public_add_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158888, XrefRangeEnd = 158893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnScamPurchaseChanged(Il2CppSystem.Action<int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnScamPurchaseChanged_Public_rem_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158893, XrefRangeEnd = 158900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158900, XrefRangeEnd = 158946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnNetworkSpawn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnNetworkSpawn_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158946, XrefRangeEnd = 158989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnNetworkDespawn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnNetworkDespawn_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnScamMaskChanged(int oldVal, int newVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&oldVal);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newVal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnScamMaskChanged_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnSyncedCartListChanged(NetworkListEvent<NetworkCartEntry> changeEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)changeEvent));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSyncedCartListChanged_Private_Void_NetworkListEvent_1_NetworkCartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158989, XrefRangeEnd = 158993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSyncedTabIndexChanged(int oldVal, int newVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&oldVal);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newVal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSyncedTabIndexChanged_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 159033, RefRangeEnd = 159035, XrefRangeStart = 158993, XrefRangeEnd = 159033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteCartRpc(Il2CppStructArray<NetworkCartEntry> entries)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entries);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteCartRpc_Public_Void_Il2CppStructArray_1_NetworkCartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 159070, RefRangeEnd = 159072, XrefRangeStart = 159035, XrefRangeEnd = 159070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteCart(Dictionary<Il2CppSystem.ValueTuple<ContrabandSO, string>, Il2CppSystem.ValueTuple<ContrabandListing, int>> listingCart)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listingCart);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteCart_Public_Void_Dictionary_2_ValueTuple_2_ContrabandSO_String_ValueTuple_2_ContrabandListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159102, RefRangeEnd = 159103, XrefRangeStart = 159072, XrefRangeEnd = 159102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<Il2CppSystem.ValueTuple<ContrabandSO, string>, Il2CppSystem.ValueTuple<ContrabandListing, int>> ReadCart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadCart_Public_Dictionary_2_ValueTuple_2_ContrabandSO_String_ValueTuple_2_ContrabandListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.ValueTuple<ContrabandSO, string>, Il2CppSystem.ValueTuple<ContrabandListing, int>>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159105, RefRangeEnd = 159106, XrefRangeStart = 159103, XrefRangeEnd = 159105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindListingIndex(ContrabandSO contraband, string listingId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contraband);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(listingId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindListingIndex_Private_Int32_ContrabandSO_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe ContrabandListing GetListingByIndex(ContrabandSO contraband, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contraband);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetListingByIndex_Private_ContrabandListing_ContrabandSO_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContrabandListing>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159118, RefRangeEnd = 159119, XrefRangeStart = 159106, XrefRangeEnd = 159118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteTabRpc(int tabIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tabIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteTabRpc_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159132, RefRangeEnd = 159133, XrefRangeStart = 159119, XrefRangeEnd = 159132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteTab(string tabName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tabName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteTab_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159139, RefRangeEnd = 159140, XrefRangeStart = 159133, XrefRangeEnd = 159139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ReadTab()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadTab_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159140, XrefRangeEnd = 159148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TabNameToIndex(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TabNameToIndex_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 159154, RefRangeEnd = 159156, XrefRangeStart = 159148, XrefRangeEnd = 159154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TabIndexToName(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TabIndexToName_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 159175, RefRangeEnd = 159177, XrefRangeStart = 159156, XrefRangeEnd = 159175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteVirusStateRpc(int gameType, int progress, float timeRemaining)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&gameType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeRemaining;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteVirusStateRpc_Public_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 159189, RefRangeEnd = 159191, XrefRangeStart = 159177, XrefRangeEnd = 159189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteVirusProgressRpc(int progress)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&progress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteVirusProgressRpc_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 159202, RefRangeEnd = 159204, XrefRangeStart = 159191, XrefRangeEnd = 159202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearVirusStateRpc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearVirusStateRpc_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159204, XrefRangeEnd = 159225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BroadcastPopupRpc(int variantIndex, float posX, float posY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&variantIndex);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &posX;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &posY;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BroadcastPopupRpc_Public_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 159249, RefRangeEnd = 159252, XrefRangeStart = 159225, XrefRangeEnd = 159249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BroadcastPopupClientRpc(int variantIndex, float posX, float posY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&variantIndex);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &posX;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &posY;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BroadcastPopupClientRpc_Private_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159264, RefRangeEnd = 159265, XrefRangeStart = 159252, XrefRangeEnd = 159264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetScamPurchasedRpc(int bitIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bitIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScamPurchasedRpc_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 159265, RefRangeEnd = 159272, XrefRangeStart = 159265, XrefRangeEnd = 159265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsScamPurchased(int bitIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bitIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsScamPurchased_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159272, XrefRangeEnd = 159284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMachinePurchasedRpc(int machineTypeInt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&machineTypeInt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMachinePurchasedRpc_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsMachinePurchased(MachineType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMachinePurchased_Public_Boolean_MachineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159286, XrefRangeEnd = 159302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SaveState(int slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&slot);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveState_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159302, XrefRangeEnd = 159314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LoadState(int slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&slot);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadState_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159314, XrefRangeEnd = 159352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DarkWebNetworkState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkWebNetworkState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159352, XrefRangeEnd = 159439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void __initializeVariables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr___initializeVariables_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159439, XrefRangeEnd = 159513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void __initializeRpcs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr___initializeRpcs_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159513, XrefRangeEnd = 159526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __rpc_handler_4251851397(NetworkBehaviour target, FastBufferReader reader, __RpcParams rpcParams)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rpcParams));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___rpc_handler_4251851397_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159526, XrefRangeEnd = 159532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __rpc_handler_1166963956(NetworkBehaviour target, FastBufferReader reader, __RpcParams rpcParams)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rpcParams));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___rpc_handler_1166963956_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159532, XrefRangeEnd = 159543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __rpc_handler_1656419121(NetworkBehaviour target, FastBufferReader reader, __RpcParams rpcParams)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rpcParams));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___rpc_handler_1656419121_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159543, XrefRangeEnd = 159549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __rpc_handler_3225087287(NetworkBehaviour target, FastBufferReader reader, __RpcParams rpcParams)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rpcParams));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___rpc_handler_3225087287_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159549, XrefRangeEnd = 159554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __rpc_handler_2700394755(NetworkBehaviour target, FastBufferReader reader, __RpcParams rpcParams)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rpcParams));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___rpc_handler_2700394755_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159554, XrefRangeEnd = 159587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __rpc_handler_3791841625(NetworkBehaviour target, FastBufferReader reader, __RpcParams rpcParams)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rpcParams));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___rpc_handler_3791841625_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159587, XrefRangeEnd = 159600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __rpc_handler_2932297656(NetworkBehaviour target, FastBufferReader reader, __RpcParams rpcParams)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rpcParams));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___rpc_handler_2932297656_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159600, XrefRangeEnd = 159617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __rpc_handler_4076549021(NetworkBehaviour target, FastBufferReader reader, __RpcParams rpcParams)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rpcParams));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___rpc_handler_4076549021_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159617, XrefRangeEnd = 159634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __rpc_handler_714399392(NetworkBehaviour target, FastBufferReader reader, __RpcParams rpcParams)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rpcParams));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___rpc_handler_714399392_Private_Static_Void_NetworkBehaviour_FastBufferReader___RpcParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159634, XrefRangeEnd = 159636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string __getTypeName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr___getTypeName_FamOrAssem_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public DarkWebNetworkState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
