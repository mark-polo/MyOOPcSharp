// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace OOP_pr_8_2
{
	[Register ("WindowController")]
	partial class WindowController
	{
		[Outlet]
		AppKit.NSTextField ChannelField { get; set; }

		[Outlet]
		AppKit.NSTextField CostField { get; set; }

		[Outlet]
		AppKit.NSTextField CountryField { get; set; }

		[Outlet]
		AppKit.NSTextField DiagonalField { get; set; }

		[Outlet]
		AppKit.NSTextField ModelField { get; set; }

		[Outlet]
		AppKit.NSTextField ScreenField { get; set; }

		[Action ("AddBtn:")]
		partial void AddBtn (Foundation.NSObject sender);

		[Action ("NetflixBtn:")]
		partial void NetflixBtn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ChannelField != null) {
				ChannelField.Dispose ();
				ChannelField = null;
			}

			if (CostField != null) {
				CostField.Dispose ();
				CostField = null;
			}

			if (CountryField != null) {
				CountryField.Dispose ();
				CountryField = null;
			}

			if (DiagonalField != null) {
				DiagonalField.Dispose ();
				DiagonalField = null;
			}

			if (ModelField != null) {
				ModelField.Dispose ();
				ModelField = null;
			}

			if (ScreenField != null) {
				ScreenField.Dispose ();
				ScreenField = null;
			}
		}
	}
}
