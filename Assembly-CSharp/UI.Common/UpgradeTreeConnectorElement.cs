using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI.Common;

public class UpgradeTreeConnectorElement : VisualElement
{
	public enum SegmentStatus
	{
		Locked,
		AvailableNext,
		OwnedChain
	}

	public enum SegmentKind
	{
		HorizontalStraight,
		VerticalStraight,
		DiagonalBezier
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct Segment
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_startX;

		private static readonly System.IntPtr NativeFieldInfoPtr_startY;

		private static readonly System.IntPtr NativeFieldInfoPtr_endX;

		private static readonly System.IntPtr NativeFieldInfoPtr_endY;

		private static readonly System.IntPtr NativeFieldInfoPtr_kind;

		private static readonly System.IntPtr NativeFieldInfoPtr_status;

		[FieldOffset(0)]
		public float startX;

		[FieldOffset(4)]
		public float startY;

		[FieldOffset(8)]
		public float endX;

		[FieldOffset(12)]
		public float endY;

		[FieldOffset(16)]
		public SegmentKind kind;

		[FieldOffset(20)]
		public SegmentStatus status;

		static Segment()
		{
			Il2CppClassPointerStore<Segment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr, "Segment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Segment>.NativeClassPtr);
			NativeFieldInfoPtr_startX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment>.NativeClassPtr, "startX");
			NativeFieldInfoPtr_startY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment>.NativeClassPtr, "startY");
			NativeFieldInfoPtr_endX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment>.NativeClassPtr, "endX");
			NativeFieldInfoPtr_endY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment>.NativeClassPtr, "endY");
			NativeFieldInfoPtr_kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment>.NativeClassPtr, "kind");
			NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment>.NativeClassPtr, "status");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Segment>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_segments;

	private static readonly System.IntPtr NativeFieldInfoPtr_ColorOwnedChain;

	private static readonly System.IntPtr NativeFieldInfoPtr_ColorAvailable;

	private static readonly System.IntPtr NativeFieldInfoPtr_ColorLocked;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSegments_Public_Void_List_1_Segment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGenerateVisualContent_Private_Void_MeshGenerationContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawDashedLine_Private_Static_Void_Painter2D_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawDashedBezier_Private_Static_Void_Painter2D_Single_Single_Single_Single_Single_Single_Single_Single_0;

	public unsafe List<Segment> segments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_segments);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Segment>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_segments)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Color ColorOwnedChain
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ColorOwnedChain, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ColorOwnedChain, (void*)(&color));
		}
	}

	public unsafe static Color ColorAvailable
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ColorAvailable, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ColorAvailable, (void*)(&color));
		}
	}

	public unsafe static Color ColorLocked
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ColorLocked, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ColorLocked, (void*)(&color));
		}
	}

	static UpgradeTreeConnectorElement()
	{
		Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UI.Common", "UpgradeTreeConnectorElement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr);
		NativeFieldInfoPtr_segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr, "segments");
		NativeFieldInfoPtr_ColorOwnedChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr, "ColorOwnedChain");
		NativeFieldInfoPtr_ColorAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr, "ColorAvailable");
		NativeFieldInfoPtr_ColorLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr, "ColorLocked");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr, 100674876);
		NativeMethodInfoPtr_SetSegments_Public_Void_List_1_Segment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr, 100674877);
		NativeMethodInfoPtr_OnGenerateVisualContent_Private_Void_MeshGenerationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr, 100674878);
		NativeMethodInfoPtr_DrawDashedLine_Private_Static_Void_Painter2D_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr, 100674879);
		NativeMethodInfoPtr_DrawDashedBezier_Private_Static_Void_Painter2D_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr, 100674880);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 198561, RefRangeEnd = 198562, XrefRangeStart = 198483, XrefRangeEnd = 198561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UpgradeTreeConnectorElement()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeTreeConnectorElement>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 198574, RefRangeEnd = 198575, XrefRangeStart = 198562, XrefRangeEnd = 198574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSegments(List<Segment> newSegments)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newSegments);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSegments_Public_Void_List_1_Segment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198575, XrefRangeEnd = 198636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGenerateVisualContent(MeshGenerationContext mgc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mgc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGenerateVisualContent_Private_Void_MeshGenerationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 198642, RefRangeEnd = 198644, XrefRangeStart = 198636, XrefRangeEnd = 198642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawDashedLine(Painter2D painter, float x1, float y1, float x2, float y2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)painter);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x2;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawDashedLine_Private_Static_Void_Painter2D_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 198655, RefRangeEnd = 198656, XrefRangeStart = 198644, XrefRangeEnd = 198655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawDashedBezier(Painter2D painter, float x1, float y1, float cx1, float cy1, float cx2, float cy2, float x2, float y2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)painter);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cx1;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &cy1;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &cx2;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &cy2;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &x2;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &y2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawDashedBezier_Private_Static_Void_Painter2D_Single_Single_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UpgradeTreeConnectorElement(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
