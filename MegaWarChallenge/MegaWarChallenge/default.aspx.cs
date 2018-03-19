using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaWarChallenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void warButton_Click(object sender, EventArgs e)
        {
            Game game = new Game("Bill", "Ted");
            resultLabel.Text = game.Play();
        }
    }
}