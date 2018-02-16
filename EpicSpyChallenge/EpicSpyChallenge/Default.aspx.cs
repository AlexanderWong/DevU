using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicSpyChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                endPreviousCalendar.SelectedDate = DateTime.Now.Date;
                startNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                projectedEndOfNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void codenameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void assignmentnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void endPreviousCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void startNewCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void projectedEndOfNewCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void assignButton_Click(object sender, EventArgs e)
        {

            double daysOff = double.Parse(startNewCalendar.SelectedDate.Subtract(endPreviousCalendar.SelectedDate).TotalDays.ToString());
            double workDays = double.Parse(projectedEndOfNewCalendar.SelectedDate.Subtract(startNewCalendar.SelectedDate).TotalDays.ToString());
            if (daysOff < 14)
            {
                startNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                resultLabel.Text = "Error: Please allow the agent to rest for 14 days.";
            }

            if (14 <= daysOff && workDays <= 21 )
            {
              
                double totalMoney = workDays * 500;
                resultLabel.Text = "The assignment of Agent " + codenameTextBox.Text + " to " + assignmentnameTextBox.Text + " is authorized with a budget of $" + totalMoney + ".";
            }

             if (14 <= daysOff && 21 < workDays)
            {
                double totalMoney = ((workDays * 500) + 1000);
                resultLabel.Text = "The assignment of Agent " + codenameTextBox.Text + " to " + assignmentnameTextBox.Text + " is authorized with a budget of $" + totalMoney + ".";
            }
        }
    }
}