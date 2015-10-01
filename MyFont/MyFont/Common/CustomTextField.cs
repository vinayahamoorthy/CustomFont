using AppKit;
using Foundation;

namespace MyFont
{
	[Register("CustomTextField")]
	public class CustomTextField : NSTextField
	{
		[Export("initWithCoder:")]
		public CustomTextField (NSCoder coder) : base(coder)
		{
		}

		public CustomTextField()
		{
		}

		[Connect("fontName")]
		public NSString FontName
		{
			get { return (NSString)GetNativeField("fontName"); }
			set { SetNativeField("fontName", value); }
		}

		public override void DrawRect(CoreGraphics.CGRect dirtyRect)
		{
			if (FontName != null)
			{
				Font = NSFont.FromFontName(FontName.ToString(), Font.PointSize);
			}
			base.DrawRect(dirtyRect);
		}
	}
}
