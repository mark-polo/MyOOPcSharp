// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace OOP_pr_9
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTableColumn Column { get; set; }

		[Outlet]
		AppKit.NSTextField dx1Field { get; set; }

		[Outlet]
		AppKit.NSTextField dx2Field { get; set; }

		[Outlet]
		AppKit.NSTableColumn Rows { get; set; }

		[Outlet]
		AppKit.NSTableView Table { get; set; }

		[Outlet]
		AppKit.NSTextField X1maxField { get; set; }

		[Outlet]
		AppKit.NSTextField X1minField { get; set; }

		[Outlet]
		AppKit.NSTextField X2maxField { get; set; }

		[Outlet]
		AppKit.NSTextField X2minField { get; set; }

		[Action ("CalcBtn:")]
		partial void CalcBtn (Foundation.NSObject sender);

		[Action ("ClearBtn:")]
		partial void ClearBtn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (X1minField != null) {
				X1minField.Dispose ();
				X1minField = null;
			}

			if (X1maxField != null) {
				X1maxField.Dispose ();
				X1maxField = null;
			}

			if (dx1Field != null) {
				dx1Field.Dispose ();
				dx1Field = null;
			}

			if (X2minField != null) {
				X2minField.Dispose ();
				X2minField = null;
			}

			if (X2maxField != null) {
				X2maxField.Dispose ();
				X2maxField = null;
			}

			if (dx2Field != null) {
				dx2Field.Dispose ();
				dx2Field = null;
			}

			if (Table != null) {
				Table.Dispose ();
				Table = null;
			}

			if (Column != null) {
				Column.Dispose ();
				Column = null;
			}

			if (Rows != null) {
				Rows.Dispose ();
				Rows = null;
			}
		}
	}
}
