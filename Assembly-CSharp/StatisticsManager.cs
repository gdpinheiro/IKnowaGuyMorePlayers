using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class StatisticsManager : MonoBehaviour
{
	[System.Serializable]
	public class StatisticsData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_unlockedAchievements;

		private static readonly System.IntPtr NativeFieldInfoPtr_stats;

		private static readonly System.IntPtr NativeFieldInfoPtr_floatStats;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe HashSet<string> unlockedAchievements
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedAchievements);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedAchievements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
			}
		}

		public unsafe Dictionary<string, int> stats
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stats);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe Dictionary<string, float> floatStats
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floatStats);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floatStats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		static StatisticsData()
		{
			Il2CppClassPointerStore<StatisticsData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "StatisticsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatisticsData>.NativeClassPtr);
			NativeFieldInfoPtr_unlockedAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsData>.NativeClassPtr, "unlockedAchievements");
			NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsData>.NativeClassPtr, "stats");
			NativeFieldInfoPtr_floatStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsData>.NativeClassPtr, "floatStats");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsData>.NativeClassPtr, 100664441);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 42516, RefRangeEnd = 42520, XrefRangeStart = 42494, XrefRangeEnd = 42516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatisticsData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatisticsData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public StatisticsData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_THINGS_GOT_SERIOUS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_YOU_MADE_IT_THROUGH;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_JUST_HERE_FOR_THE_PIZZA;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_WHATS_YOUR_FAVORITE_TOPPING;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_LIKE_A_FERRIS_WHEEL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_GET_YOUR_HANDS_DIRTY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_TO_THE_MOON;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_STAY_COOL_STAY_FOCUSED;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_YOURE_LOCKED_IN;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_A_SUCKER_PUNCH;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_ENJOY_YOUR_BREAK;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_PAY_ATTENTION_TO_DETAILS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_ARE_YOU_A_FASHION_VICTIM;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_SHOW_ME_THE_MONEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_ALWAYS_PAYS_HIS_DEBTS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_IVE_DONE_MY_PART;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACH_GOING_DOWN_THE_RABBIT_HOLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_STAT_PIZZAS_SERVED;

	private static readonly System.IntPtr NativeFieldInfoPtr_STAT_SHADY_QUESTS_COMPLETED;

	private static readonly System.IntPtr NativeFieldInfoPtr_STAT_TOTAL_EARNINGS;

	private static readonly System.IntPtr NativeFieldInfoPtr_STATISTICS_FILE;

	private static readonly System.IntPtr NativeFieldInfoPtr_FILE_VERSION;

	private static readonly System.IntPtr NativeFieldInfoPtr_data;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnAchievementUnlocked;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_StatisticsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_StatisticsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnAchievementUnlocked_Public_add_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnAchievementUnlocked_Public_rem_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAchievementUnlocked_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAchievement_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAllAchievements_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStat_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementStat_Public_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStat_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatStat_Public_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementFloatStat_Public_Single_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloatStat_Public_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlushStats_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FilePath_Private_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static StatisticsManager _Instance_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatisticsManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statisticsManager));
		}
	}

	public unsafe static string ACH_THINGS_GOT_SERIOUS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_THINGS_GOT_SERIOUS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_THINGS_GOT_SERIOUS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_YOU_MADE_IT_THROUGH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_YOU_MADE_IT_THROUGH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_YOU_MADE_IT_THROUGH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_JUST_HERE_FOR_THE_PIZZA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_JUST_HERE_FOR_THE_PIZZA, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_JUST_HERE_FOR_THE_PIZZA, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_WHATS_YOUR_FAVORITE_TOPPING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_WHATS_YOUR_FAVORITE_TOPPING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_WHATS_YOUR_FAVORITE_TOPPING, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_LIKE_A_FERRIS_WHEEL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_LIKE_A_FERRIS_WHEEL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_LIKE_A_FERRIS_WHEEL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_GET_YOUR_HANDS_DIRTY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_GET_YOUR_HANDS_DIRTY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_GET_YOUR_HANDS_DIRTY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_TO_THE_MOON
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_TO_THE_MOON, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_TO_THE_MOON, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_STAY_COOL_STAY_FOCUSED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_STAY_COOL_STAY_FOCUSED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_STAY_COOL_STAY_FOCUSED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_YOURE_LOCKED_IN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_YOURE_LOCKED_IN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_YOURE_LOCKED_IN, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_A_SUCKER_PUNCH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_A_SUCKER_PUNCH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_A_SUCKER_PUNCH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_ENJOY_YOUR_BREAK
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_ENJOY_YOUR_BREAK, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_ENJOY_YOUR_BREAK, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_PAY_ATTENTION_TO_DETAILS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_PAY_ATTENTION_TO_DETAILS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_PAY_ATTENTION_TO_DETAILS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_ARE_YOU_A_FASHION_VICTIM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_ARE_YOU_A_FASHION_VICTIM, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_ARE_YOU_A_FASHION_VICTIM, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_SHOW_ME_THE_MONEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_SHOW_ME_THE_MONEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_SHOW_ME_THE_MONEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_ALWAYS_PAYS_HIS_DEBTS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_ALWAYS_PAYS_HIS_DEBTS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_ALWAYS_PAYS_HIS_DEBTS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_IVE_DONE_MY_PART
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_IVE_DONE_MY_PART, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_IVE_DONE_MY_PART, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACH_GOING_DOWN_THE_RABBIT_HOLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACH_GOING_DOWN_THE_RABBIT_HOLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACH_GOING_DOWN_THE_RABBIT_HOLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STAT_PIZZAS_SERVED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STAT_PIZZAS_SERVED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STAT_PIZZAS_SERVED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STAT_SHADY_QUESTS_COMPLETED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STAT_SHADY_QUESTS_COMPLETED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STAT_SHADY_QUESTS_COMPLETED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STAT_TOTAL_EARNINGS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STAT_TOTAL_EARNINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STAT_TOTAL_EARNINGS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STATISTICS_FILE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STATISTICS_FILE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STATISTICS_FILE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int FILE_VERSION
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FILE_VERSION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FILE_VERSION, (void*)(&num));
		}
	}

	public unsafe StatisticsData data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatisticsData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statisticsData));
		}
	}

	public unsafe bool isDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDirty)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action<string> OnAchievementUnlocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnAchievementUnlocked);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnAchievementUnlocked)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe static StatisticsManager Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42520, XrefRangeEnd = 42522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_StatisticsManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatisticsManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42522, XrefRangeEnd = 42526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_StatisticsManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe string FilePath
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 42735, RefRangeEnd = 42738, XrefRangeStart = 42725, XrefRangeEnd = 42735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FilePath_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static StatisticsManager()
	{
		Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatisticsManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr);
		NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "<Instance>k__BackingField");
		NativeFieldInfoPtr_ACH_THINGS_GOT_SERIOUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_THINGS_GOT_SERIOUS");
		NativeFieldInfoPtr_ACH_YOU_MADE_IT_THROUGH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_YOU_MADE_IT_THROUGH");
		NativeFieldInfoPtr_ACH_JUST_HERE_FOR_THE_PIZZA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_JUST_HERE_FOR_THE_PIZZA");
		NativeFieldInfoPtr_ACH_WHATS_YOUR_FAVORITE_TOPPING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_WHATS_YOUR_FAVORITE_TOPPING");
		NativeFieldInfoPtr_ACH_LIKE_A_FERRIS_WHEEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_LIKE_A_FERRIS_WHEEL");
		NativeFieldInfoPtr_ACH_GET_YOUR_HANDS_DIRTY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_GET_YOUR_HANDS_DIRTY");
		NativeFieldInfoPtr_ACH_TO_THE_MOON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_TO_THE_MOON");
		NativeFieldInfoPtr_ACH_STAY_COOL_STAY_FOCUSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_STAY_COOL_STAY_FOCUSED");
		NativeFieldInfoPtr_ACH_YOURE_LOCKED_IN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_YOURE_LOCKED_IN");
		NativeFieldInfoPtr_ACH_A_SUCKER_PUNCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_A_SUCKER_PUNCH");
		NativeFieldInfoPtr_ACH_ENJOY_YOUR_BREAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_ENJOY_YOUR_BREAK");
		NativeFieldInfoPtr_ACH_PAY_ATTENTION_TO_DETAILS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_PAY_ATTENTION_TO_DETAILS");
		NativeFieldInfoPtr_ACH_ARE_YOU_A_FASHION_VICTIM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_ARE_YOU_A_FASHION_VICTIM");
		NativeFieldInfoPtr_ACH_SHOW_ME_THE_MONEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_SHOW_ME_THE_MONEY");
		NativeFieldInfoPtr_ACH_ALWAYS_PAYS_HIS_DEBTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_ALWAYS_PAYS_HIS_DEBTS");
		NativeFieldInfoPtr_ACH_IVE_DONE_MY_PART = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_IVE_DONE_MY_PART");
		NativeFieldInfoPtr_ACH_GOING_DOWN_THE_RABBIT_HOLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "ACH_GOING_DOWN_THE_RABBIT_HOLE");
		NativeFieldInfoPtr_STAT_PIZZAS_SERVED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "STAT_PIZZAS_SERVED");
		NativeFieldInfoPtr_STAT_SHADY_QUESTS_COMPLETED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "STAT_SHADY_QUESTS_COMPLETED");
		NativeFieldInfoPtr_STAT_TOTAL_EARNINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "STAT_TOTAL_EARNINGS");
		NativeFieldInfoPtr_STATISTICS_FILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "STATISTICS_FILE");
		NativeFieldInfoPtr_FILE_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "FILE_VERSION");
		NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "data");
		NativeFieldInfoPtr_isDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "isDirty");
		NativeFieldInfoPtr_OnAchievementUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "OnAchievementUnlocked");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_StatisticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664419);
		NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_StatisticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664420);
		NativeMethodInfoPtr_add_OnAchievementUnlocked_Public_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664421);
		NativeMethodInfoPtr_remove_OnAchievementUnlocked_Public_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664422);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664423);
		NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664424);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664425);
		NativeMethodInfoPtr_UnlockAchievement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664426);
		NativeMethodInfoPtr_IsAchievementUnlocked_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664427);
		NativeMethodInfoPtr_ClearAchievement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664428);
		NativeMethodInfoPtr_ClearAllAchievements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664429);
		NativeMethodInfoPtr_SetStat_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664430);
		NativeMethodInfoPtr_IncrementStat_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664431);
		NativeMethodInfoPtr_GetStat_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664432);
		NativeMethodInfoPtr_SetFloatStat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664433);
		NativeMethodInfoPtr_IncrementFloatStat_Public_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664434);
		NativeMethodInfoPtr_GetFloatStat_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664435);
		NativeMethodInfoPtr_FlushStats_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664436);
		NativeMethodInfoPtr_get_FilePath_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664437);
		NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664438);
		NativeMethodInfoPtr_Load_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664439);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100664440);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42526, XrefRangeEnd = 42531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnAchievementUnlocked(Il2CppSystem.Action<string> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnAchievementUnlocked_Public_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42531, XrefRangeEnd = 42536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnAchievementUnlocked(Il2CppSystem.Action<string> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnAchievementUnlocked_Public_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42536, XrefRangeEnd = 42560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42560, XrefRangeEnd = 42561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42561, XrefRangeEnd = 42568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 42607, RefRangeEnd = 42624, XrefRangeStart = 42568, XrefRangeEnd = 42607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockAchievement(string achievementKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockAchievement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42624, XrefRangeEnd = 42628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAchievementUnlocked(string achievementKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAchievementUnlocked_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42628, XrefRangeEnd = 42649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAchievement(string achievementKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAchievement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42649, XrefRangeEnd = 42681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAllAchievements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAllAchievements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42681, XrefRangeEnd = 42684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStat(string statKey, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(statKey);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStat_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 42698, RefRangeEnd = 42701, XrefRangeStart = 42684, XrefRangeEnd = 42698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IncrementStat(string statKey, int amount = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(statKey);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncrementStat_Public_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42701, XrefRangeEnd = 42704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetStat(string statKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(statKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStat_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42704, XrefRangeEnd = 42707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloatStat(string statKey, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(statKey);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatStat_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42721, RefRangeEnd = 42722, XrefRangeStart = 42707, XrefRangeEnd = 42721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float IncrementFloatStat(string statKey, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(statKey);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncrementFloatStat_Public_Single_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42722, XrefRangeEnd = 42725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFloatStat(string statKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(statKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloatStat_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FlushStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlushStats_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 42784, RefRangeEnd = 42790, XrefRangeStart = 42738, XrefRangeEnd = 42784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42844, RefRangeEnd = 42845, XrefRangeStart = 42790, XrefRangeEnd = 42844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(158)]
	[CachedScanResults(RefRangeStart = 42846, RefRangeEnd = 43004, XrefRangeStart = 42845, XrefRangeEnd = 42846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StatisticsManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StatisticsManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
