using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaCasinoChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                string[] lever = new string[] { imageGenerator(), imageGenerator(), imageGenerator() };
                showImages(lever);
                ViewState.Add("PlayersMoney", 100);
                displayPlayersMoney();
            }
    
        }    

        protected void betTextBox_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        protected void pullLeverButton_Click(object sender, EventArgs e)
        {          
            int bet = 0;
            if (!int.TryParse(betTextBox.Text, out bet)) return;
            int winnings = pullLever(bet);
            changePlayerMoney(bet, winnings);
            winningPull(bet, winnings);
            displayPlayersMoney();
        }

        private void changePlayerMoney(int bet, int winnings)
        {
            int playersMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            playersMoney -= bet;
            playersMoney += winnings;
            ViewState["PlayersMoney"] = playersMoney;
        }

       private void winningPull(int bet, int winnings)
        {
            if (winnings > 0)
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}", bet, winnings);
            else
                resultLabel.Text = String.Format("Sorry you lost {0:C}, try again!", bet);
        }

        private int pullLever(int bet)
        {
            string[] lever = new string[] { imageGenerator(), imageGenerator(), imageGenerator()};
            showImages(lever);

            int multiplier = evaluateLever(lever);
            return bet * multiplier;
        }

        private int evaluateLever(string[] lever)
        {
            if (barResult(lever)) return 0;
            if (sevenResult(lever)) return 100;   
            int multiplier = 0;
            if (cherry(lever, out multiplier)) return multiplier;
            return 0;
        }

        private bool cherry(string[] lever, out int multiplier)
        {
            multiplier = cherryMultiplier(lever);
            if (multiplier > 0) return true;
            return false;
                     
        }

        private void showImages(string[] lever)
        {
            Image1.ImageUrl = lever[0] + ".png";
            Image2.ImageUrl = lever[1] + ".png";
            Image3.ImageUrl = lever[2] + ".png";
        }

        private string imageGenerator()
        {
            string[] images = new string[] { "Strawberry", "Bar", "Lemon", "Bell", "Clover", "Cherry", "Diamond", "Orange", "Seven", "HorseShoe", "Plum", "Watermelon" };
            return images[random.Next(11)];
        }

        private void displayPlayersMoney()
        {
            moneyLabel.Text = String.Format("Your Money: {0:C}", ViewState["PlayersMoney"]);
        }


        /*================================================= SPIN RESULTS ====================================================*/
        private bool barResult(string[] lever)
        {
            if (lever[0] == "Bar" || lever[1] == "Bar" || lever[2] == "Bar") return true;
            else return false;
        }

        private bool sevenResult(string[] lever)
        {
            if (lever[0] == "Seven" && lever[1] == "Seven" && lever[2] == "Seven") return true;
            else return false;
        }

        /*============================================= END SPIN RESULTS ====================================================*/

        /*================================================ MULTIPLIER =======================================================*/
        private int cherryMultiplier(string[] lever)
        {
            int cherryCount = totalCherryCount(lever);
            if (cherryCount == 1) return 2;
            if (cherryCount == 2) return 3;
            if (cherryCount == 3) return 4;
            return 0;
        }

        private int totalCherryCount(string[] lever)
        {
            int cherryCount = 0;
            if (lever[0] == "Cherry") cherryCount++;
            if (lever[1] == "Cherry") cherryCount++;
            if (lever[2] == "Cherry") cherryCount++;
            return cherryCount;
        }
      

        /*============================================== END MULTIPLIER ===================================================*/

    }
}