using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public sealed class ReputationNotification : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Message;

	private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;

	public unsafe string Message
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Message);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Message)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float Amount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Amount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Amount)) = num;
		}
	}

	static ReputationNotification()
	{
		Il2CppClassPointerStore<ReputationNotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ReputationNotification");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReputationNotification>.NativeClassPtr);
		NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReputationNotification>.NativeClassPtr, "Message");
		NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReputationNotification>.NativeClassPtr, "Amount");
		NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReputationNotification>.NativeClassPtr, 100663621);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 25289, RefRangeEnd = 25291, XrefRangeStart = 25288, XrefRangeEnd = 25289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReputationNotification(string message, float amount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReputationNotification>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ReputationNotification(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ReputationNotification()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReputationNotification>.NativeClassPtr))
	{
	}
}
