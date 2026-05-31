using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace NOT_Lonely;

public class ACC_Utilities : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr_GetTex_Public_Static_Texture_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ACC_Utilities()
	{
		Il2CppClassPointerStore<ACC_Utilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NOT_Lonely", "ACC_Utilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACC_Utilities>.NativeClassPtr);
		NativeMethodInfoPtr_GetTex_Public_Static_Texture_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Utilities>.NativeClassPtr, 100676463);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_Utilities>.NativeClassPtr, 100676464);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 222353, RefRangeEnd = 222354, XrefRangeStart = 222299, XrefRangeEnd = 222353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture GetTex(Material material)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTex_Public_Static_Texture_Material_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
	}

	[CallerCount(158)]
	[CachedScanResults(RefRangeStart = 42846, RefRangeEnd = 43004, XrefRangeStart = 42846, XrefRangeEnd = 43004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ACC_Utilities()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACC_Utilities>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ACC_Utilities(IntPtr pointer)
		: base(pointer)
	{
	}
}
