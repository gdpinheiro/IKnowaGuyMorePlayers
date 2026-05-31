using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class RestaurantSlot : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_waypoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_occupyingCustomer;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Occupy_Public_Void_CustomerNPC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NPCWaypoint waypoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waypoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NPCWaypoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waypoint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nPCWaypoint));
		}
	}

	public unsafe CustomerNPC occupyingCustomer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupyingCustomer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomerNPC>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupyingCustomer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customerNPC));
		}
	}

	public unsafe bool isOccupied
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 111563, RefRangeEnd = 111566, XrefRangeStart = 111559, XrefRangeEnd = 111563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static RestaurantSlot()
	{
		Il2CppClassPointerStore<RestaurantSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RestaurantSlot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestaurantSlot>.NativeClassPtr);
		NativeFieldInfoPtr_waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestaurantSlot>.NativeClassPtr, "waypoint");
		NativeFieldInfoPtr_occupyingCustomer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestaurantSlot>.NativeClassPtr, "occupyingCustomer");
		NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestaurantSlot>.NativeClassPtr, 100669936);
		NativeMethodInfoPtr_Occupy_Public_Void_CustomerNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestaurantSlot>.NativeClassPtr, 100669937);
		NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestaurantSlot>.NativeClassPtr, 100669938);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestaurantSlot>.NativeClassPtr, 100669939);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 111573, RefRangeEnd = 111575, XrefRangeStart = 111566, XrefRangeEnd = 111573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Occupy(CustomerNPC customer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Occupy_Public_Void_CustomerNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 111582, RefRangeEnd = 111588, XrefRangeStart = 111575, XrefRangeEnd = 111582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RestaurantSlot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestaurantSlot>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RestaurantSlot(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
