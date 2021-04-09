// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace OOP_pr_8
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField InputFieldForX1Var { get; set; }

		[Outlet]
		AppKit.NSTextField InputFieldForX2Var { get; set; }

		[Outlet]
		AppKit.NSTextField OutputFieldForCalc { get; set; }

		[Action ("CalcButton:")]
		partial void CalcButton (Foundation.NSObject sender);

		[Action ("ClearButton:")]
		partial void ClearButton (Foundation.NSObject sender);

		[Action ("ExitButton:")]
		partial void ExitButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (InputFieldForX1Var != null) {
				InputFieldForX1Var.Dispose ();
				InputFieldForX1Var = null;
			}

			if (InputFieldForX2Var != null) {
				InputFieldForX2Var.Dispose ();
				InputFieldForX2Var = null;
			}

			if (OutputFieldForCalc != null) {
				OutputFieldForCalc.Dispose ();
				OutputFieldForCalc = null;
			}
		}
	}
}
