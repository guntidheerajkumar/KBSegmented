using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace KBSegmented
{
	// typedef void (^IndexChangeBlock)(NSInteger);
	delegate void IndexChangeBlock(nint arg0);

	// typedef NSAttributedString * (^HMTitleFormatterBlock)(KBSegmentedControl *, NSString *, NSUInteger, BOOL);
	delegate NSAttributedString HMTitleFormatterBlock(KBSegmentedControl arg0, string arg1, nuint arg2, bool arg3);

	// @interface KBSegmentedControl : UIControl
	[BaseType(typeof(UIControl))]
	interface KBSegmentedControl
	{
		// @property (nonatomic, strong) NSArray * sectionTitles;
		[Export("sectionTitles", ArgumentSemantic.Strong)]
		NSObject[] SectionTitles { get; set; }

		// @property (nonatomic, strong) NSArray * sectionImages;
		[Export("sectionImages", ArgumentSemantic.Strong)]
		NSObject[] SectionImages { get; set; }

		// @property (nonatomic, strong) NSArray * sectionSelectedImages;
		[Export("sectionSelectedImages", ArgumentSemantic.Strong)]
		NSObject[] SectionSelectedImages { get; set; }

		// @property (copy, nonatomic) IndexChangeBlock indexChangeBlock;
		[Export("indexChangeBlock", ArgumentSemantic.Copy)]
		IndexChangeBlock IndexChangeBlock { get; set; }

		// @property (copy, nonatomic) HMTitleFormatterBlock titleFormatter;
		[Export("titleFormatter", ArgumentSemantic.Copy)]
		HMTitleFormatterBlock TitleFormatter { get; set; }

		// @property (nonatomic, strong) NSDictionary * titleTextAttributes __attribute__((annotate("ui_appearance_selector")));
		[Export("titleTextAttributes", ArgumentSemantic.Strong)]
		NSDictionary TitleTextAttributes { get; set; }

		// @property (nonatomic, strong) NSDictionary * selectedTitleTextAttributes __attribute__((annotate("ui_appearance_selector")));
		[Export("selectedTitleTextAttributes", ArgumentSemantic.Strong)]
		NSDictionary SelectedTitleTextAttributes { get; set; }

		// @property (nonatomic, strong) UIColor * backgroundColor __attribute__((annotate("ui_appearance_selector")));
		[Export("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * selectionIndicatorColor __attribute__((annotate("ui_appearance_selector")));
		[Export("selectionIndicatorColor", ArgumentSemantic.Strong)]
		UIColor SelectionIndicatorColor { get; set; }

		// @property (nonatomic, strong) UIColor * selectionIndicatorBoxColor __attribute__((annotate("ui_appearance_selector")));
		[Export("selectionIndicatorBoxColor", ArgumentSemantic.Strong)]
		UIColor SelectionIndicatorBoxColor { get; set; }

		// @property (nonatomic, strong) UIColor * verticalDividerColor __attribute__((annotate("ui_appearance_selector")));
		[Export("verticalDividerColor", ArgumentSemantic.Strong)]
		UIColor VerticalDividerColor { get; set; }

		// @property (nonatomic) CGFloat selectionIndicatorBoxOpacity;
		[Export("selectionIndicatorBoxOpacity")]
		nfloat SelectionIndicatorBoxOpacity { get; set; }

		// @property (assign, nonatomic) CGFloat verticalDividerWidth;
		[Export("verticalDividerWidth")]
		nfloat VerticalDividerWidth { get; set; }

		// @property (assign, nonatomic) KBSegmentedControlType type;
		[Export("type", ArgumentSemantic.Assign)]
		KBSegmentedControlType Type { get; set; }

		// @property (assign, nonatomic) KBSegmentedControlSelectionStyle selectionStyle;
		[Export("selectionStyle", ArgumentSemantic.Assign)]
		KBSegmentedControlSelectionStyle SelectionStyle { get; set; }

		// @property (assign, nonatomic) KBSegmentedControlSegmentWidthStyle segmentWidthStyle;
		[Export("segmentWidthStyle", ArgumentSemantic.Assign)]
		KBSegmentedControlSegmentWidthStyle SegmentWidthStyle { get; set; }

		// @property (assign, nonatomic) KBSegmentedControlSelectionIndicatorLocation selectionIndicatorLocation;
		[Export("selectionIndicatorLocation", ArgumentSemantic.Assign)]
		KBSegmentedControlSelectionIndicatorLocation SelectionIndicatorLocation { get; set; }

		// @property (assign, nonatomic) KBSegmentedControlBorderType borderType;
		[Export("borderType", ArgumentSemantic.Assign)]
		KBSegmentedControlBorderType BorderType { get; set; }

		// @property (nonatomic, strong) UIColor * borderColor;
		[Export("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (assign, nonatomic) CGFloat borderWidth;
		[Export("borderWidth")]
		nfloat BorderWidth { get; set; }

		// @property (getter = isUserDraggable, nonatomic) BOOL userDraggable;
		[Export("userDraggable")]
		bool UserDraggable { [Bind("isUserDraggable")] get; set; }

		// @property (getter = isTouchEnabled, nonatomic) BOOL touchEnabled;
		[Export("touchEnabled")]
		bool TouchEnabled { [Bind("isTouchEnabled")] get; set; }

		// @property (getter = isVerticalDividerEnabled, nonatomic) BOOL verticalDividerEnabled;
		[Export("verticalDividerEnabled")]
		bool VerticalDividerEnabled { [Bind("isVerticalDividerEnabled")] get; set; }

		// @property (assign, nonatomic) NSInteger selectedSegmentIndex;
		[Export("selectedSegmentIndex")]
		nint SelectedSegmentIndex { get; set; }

		// @property (readwrite, nonatomic) CGFloat selectionIndicatorHeight;
		[Export("selectionIndicatorHeight")]
		nfloat SelectionIndicatorHeight { get; set; }

		// @property (readwrite, nonatomic) UIEdgeInsets selectionIndicatorEdgeInsets;
		[Export("selectionIndicatorEdgeInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets SelectionIndicatorEdgeInsets { get; set; }

		// @property (readwrite, nonatomic) UIEdgeInsets segmentEdgeInset;
		[Export("segmentEdgeInset", ArgumentSemantic.Assign)]
		UIEdgeInsets SegmentEdgeInset { get; set; }

		// @property (readwrite, nonatomic) UIEdgeInsets enlargeEdgeInset;
		[Export("enlargeEdgeInset", ArgumentSemantic.Assign)]
		UIEdgeInsets EnlargeEdgeInset { get; set; }

		// @property (nonatomic) BOOL shouldAnimateUserSelection;
		[Export("shouldAnimateUserSelection")]
		bool ShouldAnimateUserSelection { get; set; }

		// -(id)initWithSectionTitles:(NSArray *)sectiontitles;
		[Export("initWithSectionTitles:")]
		IntPtr InitWithSectionTitles(NSObject[] sectiontitles);

		// -(id)initWithSectionImages:(NSArray *)sectionImages sectionSelectedImages:(NSArray *)sectionSelectedImages;
		[Export("initWithSectionImages:sectionSelectedImages:")]
		IntPtr InitWithSectionImages(NSObject[] sectionImages, NSObject[] sectionSelectedImages);

		// -(instancetype)initWithSectionImages:(NSArray *)sectionImages sectionSelectedImages:(NSArray *)sectionSelectedImages titlesForSections:(NSArray *)sectiontitles;
		[Export("initWithSectionImages:sectionSelectedImages:titlesForSections:")]
		IntPtr InitWithSectionImageswithTitles(NSObject[] sectionImages, NSObject[] sectionSelectedImages, NSObject[] sectiontitles);

		// -(void)setSelectedSegmentIndex:(NSUInteger)index animated:(BOOL)animated;
		[Export("setSelectedSegmentIndex:animated:")]
		void SetSelectedSegmentIndex(nuint index, bool animated);
	}
}
