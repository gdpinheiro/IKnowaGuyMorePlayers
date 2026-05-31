using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Network;

[System.Serializable]
public class VivoxParticipantInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerId;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisplayName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChannelName;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsMuted;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSelf;

	private static readonly System.IntPtr NativeFieldInfoPtr_AudioEnergy;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string PlayerId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string DisplayName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisplayName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisplayName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ChannelName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChannelName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChannelName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool IsMuted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMuted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMuted)) = flag;
		}
	}

	public unsafe bool IsSelf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSelf);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSelf)) = flag;
		}
	}

	public unsafe float AudioEnergy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioEnergy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioEnergy)) = num;
		}
	}

	static VivoxParticipantInfo()
	{
		Il2CppClassPointerStore<VivoxParticipantInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Network", "VivoxParticipantInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxParticipantInfo>.NativeClassPtr);
		NativeFieldInfoPtr_PlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxParticipantInfo>.NativeClassPtr, "PlayerId");
		NativeFieldInfoPtr_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxParticipantInfo>.NativeClassPtr, "DisplayName");
		NativeFieldInfoPtr_ChannelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxParticipantInfo>.NativeClassPtr, "ChannelName");
		NativeFieldInfoPtr_IsMuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxParticipantInfo>.NativeClassPtr, "IsMuted");
		NativeFieldInfoPtr_IsSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxParticipantInfo>.NativeClassPtr, "IsSelf");
		NativeFieldInfoPtr_AudioEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxParticipantInfo>.NativeClassPtr, "AudioEnergy");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxParticipantInfo>.NativeClassPtr, 100675581);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VivoxParticipantInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxParticipantInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public VivoxParticipantInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
