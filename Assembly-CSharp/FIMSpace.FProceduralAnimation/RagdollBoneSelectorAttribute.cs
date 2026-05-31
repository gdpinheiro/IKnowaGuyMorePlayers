using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace FIMSpace.FProceduralAnimation;

public class RagdollBoneSelectorAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr_ragdollProperty;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	public unsafe string ragdollProperty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollProperty);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollProperty)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static RagdollBoneSelectorAttribute()
	{
		Il2CppClassPointerStore<RagdollBoneSelectorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FIMSpace.FProceduralAnimation", "RagdollBoneSelectorAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollBoneSelectorAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_ragdollProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneSelectorAttribute>.NativeClassPtr, "ragdollProperty");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneSelectorAttribute>.NativeClassPtr, 100676759);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225836, XrefRangeEnd = 225842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollBoneSelectorAttribute(string ragdollAnimatorVariableName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollBoneSelectorAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ragdollAnimatorVariableName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RagdollBoneSelectorAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
