using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public static class MeshCombiner : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CombineAllMeshes_Public_Static_GameObject_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSliceableCombinedMesh_Public_Static_GameObject_GameObject_Material_0;

	static MeshCombiner()
	{
		Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MeshCombiner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr);
		NativeMethodInfoPtr_CombineAllMeshes_Public_Static_GameObject_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100670941);
		NativeMethodInfoPtr_CreateSliceableCombinedMesh_Public_Static_GameObject_GameObject_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100670942);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126276, RefRangeEnd = 126277, XrefRangeStart = 125884, XrefRangeEnd = 126276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CombineAllMeshes(GameObject source, string combinedObjectName = "CombinedMesh")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(combinedObjectName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineAllMeshes_Public_Static_GameObject_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126277, XrefRangeEnd = 126303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateSliceableCombinedMesh(GameObject source, Material sliceMaterial = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sliceMaterial);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSliceableCombinedMesh_Public_Static_GameObject_GameObject_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	public MeshCombiner(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
