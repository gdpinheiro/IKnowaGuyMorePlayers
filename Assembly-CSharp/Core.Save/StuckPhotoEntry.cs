using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Core.Save;

[System.Serializable]
public class StuckPhotoEntry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_localPosX;

	private static readonly System.IntPtr NativeFieldInfoPtr_localPosY;

	private static readonly System.IntPtr NativeFieldInfoPtr_localPosZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_localRotX;

	private static readonly System.IntPtr NativeFieldInfoPtr_localRotY;

	private static readonly System.IntPtr NativeFieldInfoPtr_localRotZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_localRotW;

	private static readonly System.IntPtr NativeFieldInfoPtr_photoFileName;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float localPosX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPosX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPosX)) = num;
		}
	}

	public unsafe float localPosY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPosY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPosY)) = num;
		}
	}

	public unsafe float localPosZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPosZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPosZ)) = num;
		}
	}

	public unsafe float localRotX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRotX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRotX)) = num;
		}
	}

	public unsafe float localRotY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRotY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRotY)) = num;
		}
	}

	public unsafe float localRotZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRotZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRotZ)) = num;
		}
	}

	public unsafe float localRotW
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRotW);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRotW)) = num;
		}
	}

	public unsafe string photoFileName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_photoFileName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_photoFileName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static StuckPhotoEntry()
	{
		Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "StuckPhotoEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr);
		NativeFieldInfoPtr_localPosX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr, "localPosX");
		NativeFieldInfoPtr_localPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr, "localPosY");
		NativeFieldInfoPtr_localPosZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr, "localPosZ");
		NativeFieldInfoPtr_localRotX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr, "localRotX");
		NativeFieldInfoPtr_localRotY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr, "localRotY");
		NativeFieldInfoPtr_localRotZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr, "localRotZ");
		NativeFieldInfoPtr_localRotW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr, "localRotW");
		NativeFieldInfoPtr_photoFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr, "photoFileName");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr, 100676017);
	}

	[CallerCount(2493)]
	[CachedScanResults(RefRangeStart = 17367, RefRangeEnd = 19860, XrefRangeStart = 17367, XrefRangeEnd = 19860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StuckPhotoEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StuckPhotoEntry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StuckPhotoEntry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
