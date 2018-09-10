// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TipCalculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField billAmountTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton calculateTipButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tipAmountLabel { get; set; }

        [Action ("calculateTip:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void calculateTip (UIKit.UIButton sender);

        [Action ("CalculateTipButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CalculateTipButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (billAmountTextField != null) {
                billAmountTextField.Dispose ();
                billAmountTextField = null;
            }

            if (calculateTipButton != null) {
                calculateTipButton.Dispose ();
                calculateTipButton = null;
            }

            if (tipAmountLabel != null) {
                tipAmountLabel.Dispose ();
                tipAmountLabel = null;
            }
        }
    }
}