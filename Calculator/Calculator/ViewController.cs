using System;

using AppKit;
using Foundation;

namespace Calculator
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

        int count = 0;



        partial void OneBtn(NSObject sender)
        {
            Result.StringValue = Result.StringValue + 1;
        }
        partial void TwoBtn (NSObject sender)
        {
            Result.StringValue = Result.StringValue + 2;
        }
        partial void ThirdBtn (NSObject sender)
        {
            Result.StringValue = Result.StringValue + 3;
        }
        partial void FourBtn (NSObject sender)
        {
            Result.StringValue = Result.StringValue + 4;
        }
        partial void FiveBtn(NSObject sender)
        {
            Result.StringValue = Result.StringValue + 5;
        }
        partial void SixBtn(NSObject sender)
        {
            Result.StringValue = Result.StringValue + 6;
        }
        partial void SevenBtn(NSObject sender)
        {
            Result.StringValue = Result.StringValue + 7;
        }
        partial void EightBtn(NSObject sender)
        {
            Result.StringValue = Result.StringValue + 8;
        }
        partial void NineBtn(NSObject sender)
        {
            Result.StringValue = Result.StringValue + 9;
        }
        partial void ZeroBtn(NSObject sender)
        {
            Result.StringValue = Result.StringValue + 0;
        }
        partial void PlusBtn (NSObject sender)
        {
            count = 1;

            Result.StringValue = Result.StringValue + '+';

        }
        partial void MinusBtn(NSObject sender)
        {
            count = 2;
            Result.StringValue = Result.StringValue + '-';
        }
        partial void MultBtn(NSObject sender)
        {
            count = 3;

            Result.StringValue = Result.StringValue + '*';
        }
        partial void DivBtn(NSObject sender)
        {
            count = 4;
            Result.StringValue = Result.StringValue + '/';
        }

        partial void ClearBtn(NSObject sender)
        {
            Result.StringValue = "";
            Console.WriteLine(count);
        }

        partial void CalcBtn(NSObject sender)
        {
            int a = int.Parse(Result.StringValue);
           switch(count)
            {
                case 1:
                    int plus = a + int.Parse(Result.StringValue);
                    Result.StringValue = plus.ToString();
                    break;
                case 2:
                    int minus = a - int.Parse(Result.StringValue);
                    Result.StringValue = minus.ToString();
                    break;
                case 3:
                    int mult = a * int.Parse(Result.StringValue);
                    Result.StringValue = mult.ToString();
                    break;
                case 4:
                    int div = a / int.Parse(Result.StringValue);
                    Result.StringValue = div.ToString();
                    break;
            }
        }
    }
}
