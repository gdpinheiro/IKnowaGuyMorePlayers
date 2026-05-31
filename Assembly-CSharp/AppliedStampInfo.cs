using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct AppliedStampInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stampType;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_appliedTime;

	[FieldOffset(0)]
	public StampType stampType;

	[FieldOffset(4)]
	public Vector2 position;

	[FieldOffset(12)]
	public float rotation;

	[FieldOffset(16)]
	public float appliedTime;

	static AppliedStampInfo()
	{
		Il2CppClassPointerStore<AppliedStampInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AppliedStampInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppliedStampInfo>.NativeClassPtr);
		NativeFieldInfoPtr_stampType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppliedStampInfo>.NativeClassPtr, "stampType");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppliedStampInfo>.NativeClassPtr, "position");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppliedStampInfo>.NativeClassPtr, "rotation");
		NativeFieldInfoPtr_appliedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppliedStampInfo>.NativeClassPtr, "appliedTime");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AppliedStampInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
