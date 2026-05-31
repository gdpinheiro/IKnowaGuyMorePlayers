using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Netcode;
using UnityEngine;

public static class NetworkSpawnHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnServer_Public_Static_NetworkObject_GameObject_Vector3_Quaternion_Nullable_1_UInt64_Action_1_NetworkObject_Action_1_NetworkObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnAsPlayer_Public_Static_NetworkObject_GameObject_UInt64_Vector3_Quaternion_Action_1_NetworkObject_String_0;

	static NetworkSpawnHelper()
	{
		Il2CppClassPointerStore<NetworkSpawnHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NetworkSpawnHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkSpawnHelper>.NativeClassPtr);
		NativeMethodInfoPtr_SpawnServer_Public_Static_NetworkObject_GameObject_Vector3_Quaternion_Nullable_1_UInt64_Action_1_NetworkObject_Action_1_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSpawnHelper>.NativeClassPtr, 100672444);
		NativeMethodInfoPtr_SpawnAsPlayer_Public_Static_NetworkObject_GameObject_UInt64_Vector3_Quaternion_Action_1_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSpawnHelper>.NativeClassPtr, 100672445);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 148201, RefRangeEnd = 148220, XrefRangeStart = 148113, XrefRangeEnd = 148201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NetworkObject SpawnServer(GameObject prefab, Vector3 position, Quaternion rotation, Il2CppSystem.Nullable<ulong> ownerClientId = null, Il2CppSystem.Action<NetworkObject> preSpawnInit = null, Il2CppSystem.Action<NetworkObject> postSpawnInit = null, string debugContext = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ownerClientId));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preSpawnInit);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)postSpawnInit);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(debugContext);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnServer_Public_Static_NetworkObject_GameObject_Vector3_Quaternion_Nullable_1_UInt64_Action_1_NetworkObject_Action_1_NetworkObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 148296, RefRangeEnd = 148299, XrefRangeStart = 148220, XrefRangeEnd = 148296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NetworkObject SpawnAsPlayer(GameObject prefab, ulong clientId, Vector3 position, Quaternion rotation, Il2CppSystem.Action<NetworkObject> preSpawnInit = null, string debugContext = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clientId;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preSpawnInit);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(debugContext);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnAsPlayer_Public_Static_NetworkObject_GameObject_UInt64_Vector3_Quaternion_Action_1_NetworkObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr) : null;
	}

	public NetworkSpawnHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
