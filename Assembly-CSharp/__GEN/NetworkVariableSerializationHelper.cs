using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace __GEN;

public class NetworkVariableSerializationHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSerialization_Internal_Static_Void_0;

	static NetworkVariableSerializationHelper()
	{
		Il2CppClassPointerStore<NetworkVariableSerializationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "__GEN", "NetworkVariableSerializationHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkVariableSerializationHelper>.NativeClassPtr);
		NativeMethodInfoPtr_InitializeSerialization_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkVariableSerializationHelper>.NativeClassPtr, 100678088);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244107, XrefRangeEnd = 244245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeSerialization()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeSerialization_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NetworkVariableSerializationHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
