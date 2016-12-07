# KBSegmented

Custom Segmented Control

This is a binding project based on https://github.com/HeshamMegid/HMSegmentedControl.

###Usage 

```
var segmentedControl = new KBSegmentedControl();
segmentedControl.Type = KBSegmentedControlType.Text;
segmentedControl.TitleFormatter = HandleHMTitleFormatterBlock;
segmentedControl.SelectionIndicatorColor = UIColor.Red;
segmentedControl.InitWithSectionTitles(new NSObject[] { new NSString("Trending"), new NSString("News"), new NSString("Library") });
segmentedControl.Frame = new CGRect(50, 60, this.View.Frame.Width - 100, 40);
segmentedControl.AutoresizingMask = UIViewAutoresizing.FlexibleRightMargin | UIViewAutoresizing.FlexibleWidth;
segmentedControl.AddTarget(SegmentedControlChangedValue, UIControlEvent.ValueChanged);
this.View.AddSubview(segmentedControl);
```

###For Changing Text Styles

```
NSAttributedString HandleHMTitleFormatterBlock(KBSegmentedControl arg0, string arg1, nuint arg2, bool arg3)
{
	var myText = new NSAttributedString(arg1,
	   new UIStringAttributes() {
		   ForegroundColor = UIColor.Blue,
		   Font = UIFont.SystemFontOfSize(14f)
	   });
	return myText;
}
```

###For Getting the Selected Index

```
private void SegmentedControlChangedValue(object sender, EventArgs e)
{
	var s = sender as KBSegmentedControl;
	Console.WriteLine(s.SelectedSegmentIndex);
}
```

###Segmented Control with Images

```
segmentedControl.InitWithSectionImages(new NSObject[] { UIImage.FromBundle("1"), UIImage.FromBundle("2"), UIImage.FromBundle("3") },
												   new NSObject[] { UIImage.FromBundle("S_1"), UIImage.FromBundle("S_2"), UIImage.FromBundle("S_3")
```

###Ouput

![](https://github.com/guntidheerajkumar/KBSegmented/blob/master/SegmentedOutput.gif)
