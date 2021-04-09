// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace OOP_lab_3
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField Output { get; set; }

		[Action ("ClickBtn:")]
		partial void ClickBtn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (Output != null) {
				Output.Dispose ();
				Output = null;
			}
		}
	}
}
