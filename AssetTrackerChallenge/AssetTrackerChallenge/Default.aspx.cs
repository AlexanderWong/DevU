using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssetTrackerChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] rigged = new double[0];
                ViewState.Add("Rigged", rigged);

                double[] subterfuge = new double[0];
                ViewState.Add("Subterfuge", subterfuge);

                string[] assets = new string[0];
                ViewState.Add("Assets", assets);
            }
        }

        protected void assetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void riggedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void subterfugeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double[] rigged = (double[])ViewState["Rigged"];
            Array.Resize(ref rigged, rigged.Length + 1);
            int newRiggedItem = rigged.GetUpperBound(0);
            rigged[newRiggedItem] = double.Parse(riggedTextBox.Text);
            ViewState["Rigged"] = rigged;

            double[] subterfuge = (double[])ViewState["Subterfuge"];
            Array.Resize(ref subterfuge, subterfuge.Length + 1);
            int newSubterfugeItem = subterfuge.GetUpperBound(0);
            subterfuge[newSubterfugeItem] = double.Parse(subterfugeTextBox.Text);
            ViewState["Subterfuge"] = subterfuge;

            string[] assets = (string[])ViewState["Assets"];
            Array.Resize(ref assets, assets.Length + 1);
            int newAssetsItem = assets.GetUpperBound(0);
            assets[newAssetsItem] = assetsTextBox.Text;
            ViewState["Assets"] = assets;

            resultLabel.Text = String.Format("Total number of elections rigged: {0}<br />Average acts of subterfuge per asset: {1:N2}<br />(Last asset added: {2})", rigged.Sum(), subterfuge.Average(), assets[newAssetsItem]);

            assetsTextBox.Text = "";
            riggedTextBox.Text = "";
            subterfugeTextBox.Text = "";


        }
    }
}