using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Netcode;

[StructLayout(LayoutKind.Explicit)]
public struct NetworkQuestEntry
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_questId;

	private static readonly System.IntPtr NativeFieldInfoPtr_category;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressType;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_descriptionKey;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkQuestEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public int questId;

	[FieldOffset(4)]
	public int category;

	[FieldOffset(8)]
	public int progressType;

	[FieldOffset(12)]
	public int currentProgress;

	[FieldOffset(16)]
	public int targetProgress;

	[FieldOffset(20)]
	public int status;

	[FieldOffset(24)]
	public FixedString64Bytes descriptionKey;

	static NetworkQuestEntry()
	{
		Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NetworkQuestEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr);
		NativeFieldInfoPtr_questId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr, "questId");
		NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr, "category");
		NativeFieldInfoPtr_progressType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr, "progressType");
		NativeFieldInfoPtr_currentProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr, "currentProgress");
		NativeFieldInfoPtr_targetProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr, "targetProgress");
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr, "status");
		NativeFieldInfoPtr_descriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr, "descriptionKey");
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr, 100664872);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkQuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr, 100664873);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr, 100664874);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50500, RefRangeEnd = 50501, XrefRangeStart = 50492, XrefRangeEnd = 50500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50501, XrefRangeEnd = 50502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(NetworkQuestEntry other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkQuestEntry_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50502, XrefRangeEnd = 50508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkQuestEntry>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
