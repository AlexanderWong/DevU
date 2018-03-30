using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rocks
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MineralsEntities db = new MineralsEntities();

            var mineral = db.Minerals;

            string result = "";


            mineralsGridView.DataSource = mineral.ToList();
            mineralsGridView.DataBind();

            result = resultLabel.Text;

            
        }
    }
}