using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Network;

public static class PlayerDataKeys : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerName;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsReady;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharacterId;

	private static readonly System.IntPtr NativeFieldInfoPtr_NetcodeClientId;

	public unsafe static string PlayerName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string IsReady
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsReady, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsReady, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CharacterId
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharacterId, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharacterId, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NetcodeClientId
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NetcodeClientId, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NetcodeClientId, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static PlayerDataKeys()
	{
		Il2CppClassPointerStore<PlayerDataKeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Network", "PlayerDataKeys");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDataKeys>.NativeClassPtr);
		NativeFieldInfoPtr_PlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataKeys>.NativeClassPtr, "PlayerName");
		NativeFieldInfoPtr_IsReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataKeys>.NativeClassPtr, "IsReady");
		NativeFieldInfoPtr_CharacterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataKeys>.NativeClassPtr, "CharacterId");
		NativeFieldInfoPtr_NetcodeClientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataKeys>.NativeClassPtr, "NetcodeClientId");
	}

	public PlayerDataKeys(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
