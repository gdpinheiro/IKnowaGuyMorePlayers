using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class IStampable : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_CanReceiveStamp_Public_Abstract_Virtual_New_Boolean_StampType_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyStampAtPosition_Public_Abstract_Virtual_New_Boolean_StampType_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStampableBounds_Public_Abstract_Virtual_New_Rect_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasStamp_Public_Abstract_Virtual_New_Boolean_StampType_0;

	static IStampable()
	{
		Il2CppClassPointerStore<IStampable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "IStampable");
		NativeMethodInfoPtr_CanReceiveStamp_Public_Abstract_Virtual_New_Boolean_StampType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStampable>.NativeClassPtr, 100671692);
		NativeMethodInfoPtr_ApplyStampAtPosition_Public_Abstract_Virtual_New_Boolean_StampType_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStampable>.NativeClassPtr, 100671693);
		NativeMethodInfoPtr_GetStampableBounds_Public_Abstract_Virtual_New_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStampable>.NativeClassPtr, 100671694);
		NativeMethodInfoPtr_HasStamp_Public_Abstract_Virtual_New_Boolean_StampType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStampable>.NativeClassPtr, 100671695);
	}

	[CallerCount(0)]
	public unsafe virtual bool CanReceiveStamp(StampType stampType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&stampType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CanReceiveStamp_Public_Abstract_Virtual_New_Boolean_StampType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool ApplyStampAtPosition(StampType stampType, Vector2 localPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&stampType);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &localPosition;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ApplyStampAtPosition_Public_Abstract_Virtual_New_Boolean_StampType_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Rect GetStampableBounds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStampableBounds_Public_Abstract_Virtual_New_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool HasStamp(StampType stampType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&stampType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HasStamp_Public_Abstract_Virtual_New_Boolean_StampType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IStampable(IntPtr pointer)
		: base(pointer)
	{
	}
}
