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
public struct NetworkIngredientData
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<NetworkIngredientData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_ingredientType;

	private static readonly System.IntPtr NativeFieldInfoPtr_visualIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IngredientType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkIngredientData_0;

	[FieldOffset(0)]
	public IngredientType ingredientType;

	[FieldOffset(4)]
	public int visualIndex;

	static NetworkIngredientData()
	{
		Il2CppClassPointerStore<NetworkIngredientData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NetworkIngredientData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkIngredientData>.NativeClassPtr);
		NativeFieldInfoPtr_ingredientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkIngredientData>.NativeClassPtr, "ingredientType");
		NativeFieldInfoPtr_visualIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkIngredientData>.NativeClassPtr, "visualIndex");
		NativeMethodInfoPtr__ctor_Public_Void_IngredientType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIngredientData>.NativeClassPtr, 100670945);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIngredientData>.NativeClassPtr, 100670946);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkIngredientData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIngredientData>.NativeClassPtr, 100670947);
	}

	[CallerCount(111)]
	[CachedScanResults(RefRangeStart = 126304, RefRangeEnd = 126415, XrefRangeStart = 126304, XrefRangeEnd = 126304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NetworkIngredientData(IngredientType type, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IngredientType_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126418, RefRangeEnd = 126419, XrefRangeStart = 126415, XrefRangeEnd = 126418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126419, RefRangeEnd = 126420, XrefRangeStart = 126419, XrefRangeEnd = 126419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(NetworkIngredientData other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NetworkIngredientData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkIngredientData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
