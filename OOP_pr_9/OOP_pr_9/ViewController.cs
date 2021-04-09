using System;

using AppKit;
using Foundation;

namespace OOP_pr_9
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

        partial void CalcBtn(NSObject sender)
        {
            double x1min = double.Parse(X1minField.StringValue);
            double x1max = double.Parse(X1maxField.StringValue);
            double dx1 = double.Parse(dx1Field.StringValue);
            double x2min = double.Parse(X2minField.StringValue);
            double x2max = double.Parse(X2maxField.StringValue);
            double dx2 = double.Parse(dx2Field.StringValue);


            Table = new NSTableView();
            Table.Delegate = new NSTableViewDelegate();
            Table.Frame = new CoreGraphics.CGRect(20, 20, 450, 450);
            this.Table.AddSubview(Table);



            
        }
    }
}
