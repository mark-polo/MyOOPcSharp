// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Calculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField Result { get; set; }

		[Action ("CalcBtn:")]
		partial void CalcBtn (Foundation.NSObject sender);

		[Action ("ClearBtn:")]
		partial void ClearBtn (Foundation.NSObject sender);

		[Action ("DivBtn:")]
		partial void DivBtn (Foundation.NSObject sender);

		[Action ("EightBtn:")]
		partial void EightBtn (Foundation.NSObject sender);

		[Action ("FiveBtn:")]
		partial void FiveBtn (Foundation.NSObject sender);

		[Action ("FourBtn:")]
		partial void FourBtn (Foundation.NSObject sender);

		[Action ("MinusBtn:")]
		partial void MinusBtn (Foundation.NSObject sender);

		[Action ("MultBtn:")]
		partial void MultBtn (Foundation.NSObject sender);

		[Action ("NineBtn:")]
		partial void NineBtn (Foundation.NSObject sender);

		[Action ("OneBtn:")]
		partial void OneBtn (Foundation.NSObject sender);

		[Action ("PlusBtn:")]
		partial void PlusBtn (Foundation.NSObject sender);

		[Action ("SevenBtn:")]
		partial void SevenBtn (Foundation.NSObject sender);

		[Action ("SixBtn:")]
		partial void SixBtn (Foundation.NSObject sender);

		[Action ("ThirdBtn:")]
		partial void ThirdBtn (Foundation.NSObject sender);

		[Action ("TwoBtn:")]
		partial void TwoBtn (Foundation.NSObject sender);

		[Action ("ZeroBtn:")]
		partial void ZeroBtn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (Result != null) {
				Result.Dispose ();
				Result = null;
			}
		}
	}
}
