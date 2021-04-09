using System;

using AppKit;
using Foundation;

namespace OOP_pr_8_2
{
    public partial class ViewController : NSViewController
    {
      //  public TV tv;

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

        partial void LoadBtn(NSObject sender)
        {
            //tv = new TV();
            //WindowController w = new WindowController(tv);

            //Console.WriteLine(tv.country);
            //Console.WriteLine("aaaaaaaaaa");

            //ResultField.StringValue += string.Format("{0}, {1}, {2}.\n {3}, {4}, {5}| \r\n", tv.cost, tv.diagonal, tv.model, tv.country, tv.screen_resolution, tv.channel);


            ResultField.StringValue = "aaaaaaa";
        }
    }
}
