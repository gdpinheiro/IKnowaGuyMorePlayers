using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Network;

public class LobbyQueryResult : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Lobbies;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalPages;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<LobbyInfo> Lobbies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Lobbies);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LobbyInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Lobbies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int TotalCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalCount)) = num;
		}
	}

	public unsafe int CurrentPage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentPage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentPage)) = num;
		}
	}

	public unsafe int TotalPages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalPages);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalPages)) = num;
		}
	}

	static LobbyQueryResult()
	{
		Il2CppClassPointerStore<LobbyQueryResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Network", "LobbyQueryResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyQueryResult>.NativeClassPtr);
		NativeFieldInfoPtr_Lobbies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQueryResult>.NativeClassPtr, "Lobbies");
		NativeFieldInfoPtr_TotalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQueryResult>.NativeClassPtr, "TotalCount");
		NativeFieldInfoPtr_CurrentPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQueryResult>.NativeClassPtr, "CurrentPage");
		NativeFieldInfoPtr_TotalPages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQueryResult>.NativeClassPtr, "TotalPages");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQueryResult>.NativeClassPtr, 100675033);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 201549, RefRangeEnd = 201551, XrefRangeStart = 201541, XrefRangeEnd = 201549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LobbyQueryResult()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyQueryResult>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LobbyQueryResult(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
