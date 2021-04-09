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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ResultField { get; set; }

		[Action ("AddBtn:")]
		partial void AddBtn (Foundation.NSObject sender);

		[Action ("LoadBtn:")]
		partial void LoadBtn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ResultField != null) {
				ResultField.Dispose ();
				ResultField = null;
			}
		}
	}
}
