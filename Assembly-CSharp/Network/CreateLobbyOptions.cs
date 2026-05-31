using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Network;

public class CreateLobbyOptions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LobbyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxPlayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsPrivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_HostName;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string LobbyName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LobbyName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LobbyName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int MaxPlayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxPlayers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxPlayers)) = num;
		}
	}

	public unsafe bool IsPrivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPrivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPrivate)) = flag;
		}
	}

	public unsafe string HostName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HostName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HostName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Dictionary<string, string> CustomData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static CreateLobbyOptions()
	{
		Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Network", "CreateLobbyOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr);
		NativeFieldInfoPtr_LobbyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "LobbyName");
		NativeFieldInfoPtr_MaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "MaxPlayers");
		NativeFieldInfoPtr_IsPrivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "IsPrivate");
		NativeFieldInfoPtr_HostName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "HostName");
		NativeFieldInfoPtr_CustomData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "CustomData");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100675031);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201534, RefRangeEnd = 201535, XrefRangeStart = 201529, XrefRangeEnd = 201534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreateLobbyOptions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreateLobbyOptions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
