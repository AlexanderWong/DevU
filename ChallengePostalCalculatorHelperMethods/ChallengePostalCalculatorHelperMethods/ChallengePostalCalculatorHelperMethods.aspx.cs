using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class ChallengePostalCalculatorHelperMethods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            performShipping();
        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            performShipping();
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            performShipping();
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performShipping();
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performShipping();
        }

        protected void nextdayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performShipping();
        }

        private void performShipping()
        {
            if (!valuesExist()) return;

            int volume = 0;
            if (!tryVolume(out volume)) return;

            double multiplier = getMultiplier();

            double cost = volume * multiplier;

            resultLabel.Text = String.Format("Your item will cost {0:C} to ship.", cost);          
        }

        private bool valuesExist()
        {
            if (!groundRadioButton.Checked && !airRadioButton.Checked && !nextdayRadioButton.Checked) return false;

            if (widthTextBox.Text.Trim().Length == 0 || heightTextBox.Text.Trim().Length == 0) return false;

            return true;
        }

        private bool tryVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;

            int height = 0;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;

            int length = 0;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

            volume = width * height * length;
            return true;
        }

        private double getMultiplier()
        {
            if (groundRadioButton.Checked) return .15;
            else if (airRadioButton.Checked) return .25;
            else if (nextdayRadioButton.Checked) return .45;
            else return 0;
        }
    }
}