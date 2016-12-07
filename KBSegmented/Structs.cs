using System;
using ObjCRuntime;

namespace KBSegmented
{
	
	public enum KBSegmentedControlSelectionStyle : int
	{
		TextWidthStripe,
		FullWidthStripe,
		Box,
		Arrow
	}

	
	public enum KBSegmentedControlSelectionIndicatorLocation : int
	{
		Up,
		Down,
		None
	}

	
	public enum KBSegmentedControlSegmentWidthStyle : int
	{
		Fixed,
		Dynamic
	}

	
	public enum KBSegmentedControlBorderType : int
	{
		None = 0,
		Top = (1 << 0),
		Left = (1 << 1),
		Bottom = (1 << 2),
		Right = (1 << 3)
	}
	 
	public enum KBSegmentedControlType : int
	{
		Text,
		Images,
		TextImages
	}
}
