using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public static class QuestParamsParser : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_ParsedQuestParams_String_String_0;

	static QuestParamsParser()
	{
		Il2CppClassPointerStore<QuestParamsParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "QuestParamsParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestParamsParser>.NativeClassPtr);
		NativeMethodInfoPtr_Parse_Public_Static_ParsedQuestParams_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestParamsParser>.NativeClassPtr, 100663446);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23091, RefRangeEnd = 23092, XrefRangeStart = 23029, XrefRangeEnd = 23091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ParsedQuestParams Parse(string questType, string questParams)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(questType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(questParams);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_ParsedQuestParams_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ParsedQuestParams>(intPtr) : null;
	}

	public QuestParamsParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
