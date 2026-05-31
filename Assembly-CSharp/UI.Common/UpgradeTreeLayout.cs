using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UI.Common;

public static class UpgradeTreeLayout : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_NodeWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_NodeHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_CellWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_CellHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_PadX;

	private static readonly System.IntPtr NativeFieldInfoPtr_PadY;

	public unsafe static float NodeWidth
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NodeWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NodeWidth, (void*)(&num));
		}
	}

	public unsafe static float NodeHeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NodeHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NodeHeight, (void*)(&num));
		}
	}

	public unsafe static float CellWidth
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CellWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CellWidth, (void*)(&num));
		}
	}

	public unsafe static float CellHeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CellHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CellHeight, (void*)(&num));
		}
	}

	public unsafe static float PadX
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PadX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PadX, (void*)(&num));
		}
	}

	public unsafe static float PadY
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PadY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PadY, (void*)(&num));
		}
	}

	static UpgradeTreeLayout()
	{
		Il2CppClassPointerStore<UpgradeTreeLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UI.Common", "UpgradeTreeLayout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeTreeLayout>.NativeClassPtr);
		NativeFieldInfoPtr_NodeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeTreeLayout>.NativeClassPtr, "NodeWidth");
		NativeFieldInfoPtr_NodeHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeTreeLayout>.NativeClassPtr, "NodeHeight");
		NativeFieldInfoPtr_CellWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeTreeLayout>.NativeClassPtr, "CellWidth");
		NativeFieldInfoPtr_CellHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeTreeLayout>.NativeClassPtr, "CellHeight");
		NativeFieldInfoPtr_PadX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeTreeLayout>.NativeClassPtr, "PadX");
		NativeFieldInfoPtr_PadY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeTreeLayout>.NativeClassPtr, "PadY");
	}

	public UpgradeTreeLayout(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
