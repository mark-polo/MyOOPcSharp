using System;

using AppKit;
using Foundation;

namespace OOP_pr_8
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void CalcButton(NSObject sender)
        {
            int x1 = int.Parse(InputFieldForX1Var.StringValue.ToString());
            int x2 = int.Parse(InputFieldForX2Var.StringValue.ToString());

            double part_one = Math.Cos(2 * x2) + (x1 / x2);

            double part_two = 16 * x2 * x1;

            double y = Math.Sqrt(part_one / part_two);

            OutputFieldForCalc.StringValue = y.ToString();
        }

        partial void ClearButton(NSObject sender)
        {
            OutputFieldForCalc.StringValue = "";
        }
    }
}
