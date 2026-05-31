using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct StampRequirement
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stampType;

	private static readonly System.IntPtr NativeFieldInfoPtr_suggestedPlacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_strictPlacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_placementTolerance;

	[FieldOffset(0)]
	public StampType stampType;

	[FieldOffset(4)]
	public Rect suggestedPlacement;

	[FieldOffset(20)]
	[MarshalAs(UnmanagedType.U1)]
	public bool strictPlacement;

	[FieldOffset(24)]
	public float placementTolerance;

	static StampRequirement()
	{
		Il2CppClassPointerStore<StampRequirement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StampRequirement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StampRequirement>.NativeClassPtr);
		NativeFieldInfoPtr_stampType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StampRequirement>.NativeClassPtr, "stampType");
		NativeFieldInfoPtr_suggestedPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StampRequirement>.NativeClassPtr, "suggestedPlacement");
		NativeFieldInfoPtr_strictPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StampRequirement>.NativeClassPtr, "strictPlacement");
		NativeFieldInfoPtr_placementTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StampRequirement>.NativeClassPtr, "placementTolerance");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StampRequirement>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
