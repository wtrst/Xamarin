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
        UIKit.UISlider adjustTipPercentage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField billAmountTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton calculateTipButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tipAmountLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tipPercentageTextField { get; set; }

        [Action ("aaa:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void aaa (UIKit.UITextField sender);

        [Action ("adjustPer:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void adjustPer (UIKit.UISlider sender);

        [Action ("bbb:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void bbb (UIKit.UITextField sender);

        [Action ("calculateTip:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void calculateTip (UIKit.UIButton sender);

        [Action ("changedPer:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void changedPer (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (adjustTipPercentage != null) {
                adjustTipPercentage.Dispose ();
                adjustTipPercentage = null;
            }

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

            if (tipPercentageTextField != null) {
                tipPercentageTextField.Dispose ();
                tipPercentageTextField = null;
            }
        }
    }
}