using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            
            string name = "Alex Wong";
            string newName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                newName += name[i];
                resultLabel.Text = newName;
            }
            
            // xelA gnoW

            // 2.  Reverse this sequence:
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke
            
            string names = "Luke,Leia,Han,Chewbacca";           
            string[] newNames = names.Split(',');
            resultLabel.Text = String.Format ("{0},{1},{2},{3}",newNames[3], newNames[2], newNames[1], newNames[0]);


           

            // 3. Use the sequence to create ascii art:
            //*****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***
            
            string luke = "luke";
            string leia = "leia";
            string han = "han";
            string Chewbacca = "Chewbacca";

            string result = luke.PadLeft(9, '*').PadRight(14, '*') + "<br />" + leia.PadLeft(9, '*').PadRight(14, '*') + "<br />"
                          + han.PadLeft(8, '*').PadRight(14, '*') + "<br />" + Chewbacca.PadLeft(11, '*').PadRight(14, '*');
            resultLabel.Text = result;

            


            // 4. Solve this puzzle:
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

             string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
             resultLabel.Text = puzzle.Remove(10, 9).ToLower().Replace("z", "t").Replace("now", "Now");

        }

    }
}