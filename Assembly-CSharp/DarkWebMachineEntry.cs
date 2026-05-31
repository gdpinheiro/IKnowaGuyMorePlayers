using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class DarkWebMachineEntry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_machine;

	private static readonly System.IntPtr NativeFieldInfoPtr_cryptoPrice;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe MachineSO machine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MachineSO>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machine)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)machineSO));
		}
	}

	public unsafe float cryptoPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cryptoPrice);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cryptoPrice)) = num;
		}
	}

	static DarkWebMachineEntry()
	{
		Il2CppClassPointerStore<DarkWebMachineEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DarkWebMachineEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkWebMachineEntry>.NativeClassPtr);
		NativeFieldInfoPtr_machine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebMachineEntry>.NativeClassPtr, "machine");
		NativeFieldInfoPtr_cryptoPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkWebMachineEntry>.NativeClassPtr, "cryptoPrice");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkWebMachineEntry>.NativeClassPtr, 100671341);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DarkWebMachineEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkWebMachineEntry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DarkWebMachineEntry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
