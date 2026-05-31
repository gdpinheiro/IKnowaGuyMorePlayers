using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace NOT_Lonely;

public class ACC_CableJoint : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_autoUpdateRotation;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool autoUpdateRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoUpdateRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoUpdateRotation)) = flag;
		}
	}

	static ACC_CableJoint()
	{
		Il2CppClassPointerStore<ACC_CableJoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NOT_Lonely", "ACC_CableJoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACC_CableJoint>.NativeClassPtr);
		NativeFieldInfoPtr_autoUpdateRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACC_CableJoint>.NativeClassPtr, "autoUpdateRotation");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACC_CableJoint>.NativeClassPtr, 100676406);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ACC_CableJoint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACC_CableJoint>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ACC_CableJoint(IntPtr pointer)
		: base(pointer)
	{
	}
}
