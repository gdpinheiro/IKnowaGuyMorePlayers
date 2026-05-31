using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Netcode;

[StructLayout(LayoutKind.Explicit)]
public struct NetworkCartEntry
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<NetworkCartEntry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_contrabandIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_listingIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_quantity;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkCartEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public int contrabandIndex;

	[FieldOffset(4)]
	public int listingIndex;

	[FieldOffset(8)]
	public int quantity;

	static NetworkCartEntry()
	{
		Il2CppClassPointerStore<NetworkCartEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NetworkCartEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkCartEntry>.NativeClassPtr);
		NativeFieldInfoPtr_contrabandIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkCartEntry>.NativeClassPtr, "contrabandIndex");
		NativeFieldInfoPtr_listingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkCartEntry>.NativeClassPtr, "listingIndex");
		NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkCartEntry>.NativeClassPtr, "quantity");
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCartEntry>.NativeClassPtr, 100673029);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkCartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCartEntry>.NativeClassPtr, 100673030);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCartEntry>.NativeClassPtr, 100673031);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 97987, RefRangeEnd = 97992, XrefRangeStart = 97987, XrefRangeEnd = 97992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(NetworkCartEntry other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkCartEntry_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158840, XrefRangeEnd = 158846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkCartEntry>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
