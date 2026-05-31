using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Core.Save;

[System.Serializable]
public class OpenWorldQuestManagerSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_npcProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintingPlaced;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintingPosX;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintingPosY;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintingPosZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintingRotX;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintingRotY;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintingRotZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintingRotW;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<NPCQuestProgress> npcProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcProgress);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NPCQuestProgress>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcProgress)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool paintingPlaced
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingPlaced);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingPlaced)) = flag;
		}
	}

	public unsafe float paintingPosX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingPosX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingPosX)) = num;
		}
	}

	public unsafe float paintingPosY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingPosY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingPosY)) = num;
		}
	}

	public unsafe float paintingPosZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingPosZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingPosZ)) = num;
		}
	}

	public unsafe float paintingRotX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingRotX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingRotX)) = num;
		}
	}

	public unsafe float paintingRotY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingRotY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingRotY)) = num;
		}
	}

	public unsafe float paintingRotZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingRotZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingRotZ)) = num;
		}
	}

	public unsafe float paintingRotW
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingRotW);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintingRotW)) = num;
		}
	}

	static OpenWorldQuestManagerSaveData()
	{
		Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "OpenWorldQuestManagerSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_npcProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr, "npcProgress");
		NativeFieldInfoPtr_paintingPlaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr, "paintingPlaced");
		NativeFieldInfoPtr_paintingPosX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr, "paintingPosX");
		NativeFieldInfoPtr_paintingPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr, "paintingPosY");
		NativeFieldInfoPtr_paintingPosZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr, "paintingPosZ");
		NativeFieldInfoPtr_paintingRotX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr, "paintingRotX");
		NativeFieldInfoPtr_paintingRotY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr, "paintingRotY");
		NativeFieldInfoPtr_paintingRotZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr, "paintingRotZ");
		NativeFieldInfoPtr_paintingRotW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr, "paintingRotW");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr, 100676007);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215305, RefRangeEnd = 215306, XrefRangeStart = 215297, XrefRangeEnd = 215305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OpenWorldQuestManagerSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenWorldQuestManagerSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OpenWorldQuestManagerSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
