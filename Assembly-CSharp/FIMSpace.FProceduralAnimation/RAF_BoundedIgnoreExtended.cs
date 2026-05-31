using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace FIMSpace.FProceduralAnimation;

public class RAF_BoundedIgnoreExtended : RagdollAnimatorFeatureBase
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static RAF_BoundedIgnoreExtended()
	{
		Il2CppClassPointerStore<RAF_BoundedIgnoreExtended>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RAF_BoundedIgnoreExtended");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RAF_BoundedIgnoreExtended>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_BoundedIgnoreExtended>.NativeClassPtr, 100677548);
	}

	[CallerCount(42)]
	[CachedScanResults(RefRangeStart = 43568, RefRangeEnd = 43610, XrefRangeStart = 43568, XrefRangeEnd = 43610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RAF_BoundedIgnoreExtended()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RAF_BoundedIgnoreExtended>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RAF_BoundedIgnoreExtended(IntPtr pointer)
		: base(pointer)
	{
	}
}
