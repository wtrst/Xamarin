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
            if(string.IsNullOrEmpty(tipPercentageTextField.Text) || Convert.ToInt16(tipPercentageTextField.Text) == 0){
                tipAmount = double.Parse(billAmountTextField.Text) * 0.15;
            }else{
                double per = Convert.ToDouble(tipPercentageTextField.Text) / 100;
                tipAmount = double.Parse(billAmountTextField.Text) * per;
            }

            tipAmountLabel.Text = "Tip amount: $" + tipAmount.ToString();
        }

        partial void adjustPer(UISlider sender)
        {
            tipPercentageTextField.Text = Convert.ToInt16(adjustTipPercentage.Value).ToString();

            double tipAmount;
            if (!string.IsNullOrEmpty(billAmountTextField.Text))
            {
                double per = Convert.ToDouble(tipPercentageTextField.Text) / 100;
                tipAmount = double.Parse(billAmountTextField.Text) * per;

                tipAmountLabel.Text = "Tip amount: $" + tipAmount.ToString();
            }
        }

        partial void changedPer(UITextField sender)
        {
            double tipAmount;

            if(!string.IsNullOrEmpty(billAmountTextField.Text)){
                double per = Convert.ToDouble(tipPercentageTextField.Text) / 100;
                tipAmount = double.Parse(billAmountTextField.Text) * per;

                tipAmountLabel.Text = "Tip amount: $" + tipAmount.ToString();
            }

        }
    }
}
