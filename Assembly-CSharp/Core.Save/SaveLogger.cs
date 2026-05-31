using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace Core.Save;

public static class SaveLogger : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LOG_DIRECTORY_NAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOG_FILE_PREFIX;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_LOG_FILES;

	private static readonly System.IntPtr NativeFieldInfoPtr_writerLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_writer;

	private static readonly System.IntPtr NativeFieldInfoPtr_logFilePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_initializationFailed;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LogFilePath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Info_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Warning_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Error_Public_Static_Void_String_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Section_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Private_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureInitialized_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureInitializedLocked_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanOldLogs_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Timestamp_Private_Static_String_0;

	public unsafe static string LOG_DIRECTORY_NAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOG_DIRECTORY_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOG_DIRECTORY_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LOG_FILE_PREFIX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOG_FILE_PREFIX, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOG_FILE_PREFIX, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int MAX_LOG_FILES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_LOG_FILES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_LOG_FILES, (void*)(&num));
		}
	}

	public unsafe static Il2CppSystem.Object writerLock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_writerLock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_writerLock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe static StreamWriter writer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_writer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_writer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streamWriter));
		}
	}

	public unsafe static string logFilePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_logFilePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_logFilePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool initialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initialized, (void*)(&flag));
		}
	}

	public unsafe static bool initializationFailed
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initializationFailed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initializationFailed, (void*)(&flag));
		}
	}

	public unsafe static string LogFilePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216656, XrefRangeEnd = 216660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LogFilePath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static SaveLogger()
	{
		Il2CppClassPointerStore<SaveLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Core.Save", "SaveLogger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr);
		NativeFieldInfoPtr_LOG_DIRECTORY_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, "LOG_DIRECTORY_NAME");
		NativeFieldInfoPtr_LOG_FILE_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, "LOG_FILE_PREFIX");
		NativeFieldInfoPtr_MAX_LOG_FILES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, "MAX_LOG_FILES");
		NativeFieldInfoPtr_writerLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, "writerLock");
		NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, "writer");
		NativeFieldInfoPtr_logFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, "logFilePath");
		NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, "initialized");
		NativeFieldInfoPtr_initializationFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, "initializationFailed");
		NativeMethodInfoPtr_get_LogFilePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676074);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676075);
		NativeMethodInfoPtr_Info_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676076);
		NativeMethodInfoPtr_Warning_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676077);
		NativeMethodInfoPtr_Error_Public_Static_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676078);
		NativeMethodInfoPtr_Section_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676079);
		NativeMethodInfoPtr_Shutdown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676080);
		NativeMethodInfoPtr_Write_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676081);
		NativeMethodInfoPtr_EnsureInitialized_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676082);
		NativeMethodInfoPtr_EnsureInitializedLocked_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676083);
		NativeMethodInfoPtr_CleanOldLogs_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676084);
		NativeMethodInfoPtr_Timestamp_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLogger>.NativeClassPtr, 100676085);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216660, XrefRangeEnd = 216664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216664, XrefRangeEnd = 216670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Info(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Info_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 216676, RefRangeEnd = 216688, XrefRangeStart = 216670, XrefRangeEnd = 216676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Warning(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Warning_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 216714, RefRangeEnd = 216726, XrefRangeStart = 216688, XrefRangeEnd = 216714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Error(string message, Il2CppSystem.Exception ex = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Error_Public_Static_Void_String_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216732, RefRangeEnd = 216734, XrefRangeStart = 216726, XrefRangeEnd = 216732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Section(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Section_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 216763, RefRangeEnd = 216764, XrefRangeStart = 216734, XrefRangeEnd = 216763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Shutdown()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shutdown_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 216832, RefRangeEnd = 216847, XrefRangeStart = 216764, XrefRangeEnd = 216832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Write(string level, string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(level);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Private_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216858, RefRangeEnd = 216860, XrefRangeStart = 216847, XrefRangeEnd = 216858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnsureInitialized()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureInitialized_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216965, RefRangeEnd = 216967, XrefRangeStart = 216860, XrefRangeEnd = 216965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool EnsureInitializedLocked()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureInitializedLocked_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 216989, RefRangeEnd = 216990, XrefRangeStart = 216967, XrefRangeEnd = 216989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanOldLogs(string dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanOldLogs_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216997, RefRangeEnd = 216999, XrefRangeStart = 216990, XrefRangeEnd = 216997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Timestamp()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Timestamp_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public SaveLogger(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
