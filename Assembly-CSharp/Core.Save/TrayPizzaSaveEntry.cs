using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Core.Save;

[System.Serializable]
public class TrayPizzaSaveEntry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_trayId;

	private static readonly System.IntPtr NativeFieldInfoPtr_pizzaState;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int trayId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trayId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trayId)) = num;
		}
	}

	public unsafe PizzaSaveEntry pizzaState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PizzaSaveEntry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pizzaState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pizzaSaveEntry));
		}
	}

	static TrayPizzaSaveEntry()
	{
		Il2CppClassPointerStore<TrayPizzaSaveEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "TrayPizzaSaveEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrayPizzaSaveEntry>.NativeClassPtr);
		NativeFieldInfoPtr_trayId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayPizzaSaveEntry>.NativeClassPtr, "trayId");
		NativeFieldInfoPtr_pizzaState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayPizzaSaveEntry>.NativeClassPtr, "pizzaState");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayPizzaSaveEntry>.NativeClassPtr, 100676018);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TrayPizzaSaveEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrayPizzaSaveEntry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TrayPizzaSaveEntry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
