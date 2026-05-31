using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class QuestDialogueOption : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_playerText;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcAnswer;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionLines;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string playerText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string npcAnswer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcAnswer);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcAnswer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> missionLines
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionLines);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionLines)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static QuestDialogueOption()
	{
		Il2CppClassPointerStore<QuestDialogueOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "QuestDialogueOption");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestDialogueOption>.NativeClassPtr);
		NativeFieldInfoPtr_playerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestDialogueOption>.NativeClassPtr, "playerText");
		NativeFieldInfoPtr_npcAnswer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestDialogueOption>.NativeClassPtr, "npcAnswer");
		NativeFieldInfoPtr_missionLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestDialogueOption>.NativeClassPtr, "missionLines");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestDialogueOption>.NativeClassPtr, 100663435);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 22958, RefRangeEnd = 22962, XrefRangeStart = 22950, XrefRangeEnd = 22958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe QuestDialogueOption()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestDialogueOption>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public QuestDialogueOption(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
