using System;

using UIKit;

namespace TipCalculator
{
    public partial class ViewController : UIViewController
    {
        
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void calculateTipButton_Click()
        {
            
        }

        partial void calculateTip(UIButton sender)
        {
            double tipAmount;

            tipAmount = double.Parse(billAmountTextField.Text) * 0.15;
            tipAmountLabel.Text = tipAmount.ToString();
        }
    }
}
