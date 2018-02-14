using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void firstValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void secondValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void additionButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(firstValueTextBox.Text);
            int second = int.Parse(secondValueTextBox.Text);

            int result = first + second;
            resultLabel.Text = result.ToString();
        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(firstValueTextBox.Text);
            int second = int.Parse(secondValueTextBox.Text);

            int result = first - second;
            resultLabel.Text = result.ToString();
        }

        protected void multiplicationButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(firstValueTextBox.Text);
            int second = int.Parse(secondValueTextBox.Text);

            int result = first * second;
            resultLabel.Text = result.ToString();
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstValueTextBox.Text);
            double second = double.Parse(secondValueTextBox.Text);

            double result = first / second;
            resultLabel.Text = result.ToString();
        }
    }
}