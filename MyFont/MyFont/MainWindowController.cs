using System;

using Foundation;
using AppKit;

namespace MyFont
{
	public partial class MainWindowController : NSWindowController
	{
		public MainWindowController (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
		}

		public MainWindowController () : base ("MainWindow")
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
			lblWelcome.Font = NSFont.FromFontName ("SanFranciscoText-BoldItalic",12.0f);
		}

		public new MainWindow Window {
			get { return (MainWindow)base.Window; }
		}
	}
}
