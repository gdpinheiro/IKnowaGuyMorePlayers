using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace FIMSpace.FProceduralAnimation;

public class RAF_ReconstructionMode : RagdollAnimatorFeatureBase
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static RAF_ReconstructionMode()
	{
		Il2CppClassPointerStore<RAF_ReconstructionMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RAF_ReconstructionMode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RAF_ReconstructionMode>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RAF_ReconstructionMode>.NativeClassPtr, 100677677);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RAF_ReconstructionMode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RAF_ReconstructionMode>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RAF_ReconstructionMode(IntPtr pointer)
		: base(pointer)
	{
	}
}
