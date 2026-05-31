using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public static class MachineDefinitions : Il2CppSystem.Object
{
	public sealed class MachineData : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_nameKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_descriptionKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_price;

		private static readonly System.IntPtr NativeFieldInfoPtr_deliveryTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxQuantity;

		public unsafe MachineType type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
				return *(MachineType*)num;
			}
			set
			{
				*(MachineType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = machineType;
			}
		}

		public unsafe string nameKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameKey);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameKey)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string descriptionKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptionKey);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptionKey)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float price
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price)) = num;
			}
		}

		public unsafe float deliveryTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveryTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deliveryTime)) = num;
			}
		}

		public unsafe int maxQuantity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxQuantity);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxQuantity)) = num;
			}
		}

		static MachineData()
		{
			Il2CppClassPointerStore<MachineData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MachineDefinitions>.NativeClassPtr, "MachineData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MachineData>.NativeClassPtr);
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineData>.NativeClassPtr, "type");
			NativeFieldInfoPtr_nameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineData>.NativeClassPtr, "nameKey");
			NativeFieldInfoPtr_descriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineData>.NativeClassPtr, "descriptionKey");
			NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineData>.NativeClassPtr, "price");
			NativeFieldInfoPtr_deliveryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineData>.NativeClassPtr, "deliveryTime");
			NativeFieldInfoPtr_maxQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineData>.NativeClassPtr, "maxQuantity");
		}

		public MachineData(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public MachineData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MachineData>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_AllMachines;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationFallbacks;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMachineData_Public_Static_Nullable_1_MachineData_MachineType_0;

	public unsafe static Il2CppReferenceArray<MachineData> AllMachines
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AllMachines, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MachineData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AllMachines, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Dictionary<string, string> LocalizationFallbacks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LocalizationFallbacks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LocalizationFallbacks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static MachineDefinitions()
	{
		Il2CppClassPointerStore<MachineDefinitions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MachineDefinitions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MachineDefinitions>.NativeClassPtr);
		NativeFieldInfoPtr_AllMachines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineDefinitions>.NativeClassPtr, "AllMachines");
		NativeFieldInfoPtr_LocalizationFallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineDefinitions>.NativeClassPtr, "LocalizationFallbacks");
		NativeMethodInfoPtr_GetLocalizedName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineDefinitions>.NativeClassPtr, 100667129);
		NativeMethodInfoPtr_GetMachineData_Public_Static_Nullable_1_MachineData_MachineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineDefinitions>.NativeClassPtr, 100667130);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78718, XrefRangeEnd = 78740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocalizedName(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78740, XrefRangeEnd = 78748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Nullable<MachineData> GetMachineData(MachineType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMachineData_Public_Static_Nullable_1_MachineData_MachineType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<MachineData>(pointer);
	}

	public MachineDefinitions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
