using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.Universal;

namespace VolFx;

public class VolFx_SetUrpAsset : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__urp;

	private static readonly IntPtr NativeFieldInfoPtr__onStart;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe UniversalRenderPipelineAsset _urp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__urp);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderPipelineAsset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__urp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)universalRenderPipelineAsset));
		}
	}

	public unsafe UnityEvent _onStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onStart);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onStart)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	static VolFx_SetUrpAsset()
	{
		Il2CppClassPointerStore<VolFx_SetUrpAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VolFx", "VolFx_SetUrpAsset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolFx_SetUrpAsset>.NativeClassPtr);
		NativeFieldInfoPtr__urp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolFx_SetUrpAsset>.NativeClassPtr, "_urp");
		NativeFieldInfoPtr__onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolFx_SetUrpAsset>.NativeClassPtr, "_onStart");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolFx_SetUrpAsset>.NativeClassPtr, 100674298);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolFx_SetUrpAsset>.NativeClassPtr, 100674299);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187598, XrefRangeEnd = 187613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(158)]
	[CachedScanResults(RefRangeStart = 42846, RefRangeEnd = 43004, XrefRangeStart = 42846, XrefRangeEnd = 43004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VolFx_SetUrpAsset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolFx_SetUrpAsset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public VolFx_SetUrpAsset(IntPtr pointer)
		: base(pointer)
	{
	}
}
