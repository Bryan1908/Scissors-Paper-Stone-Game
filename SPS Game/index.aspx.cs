using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SPS_Game
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_Restart.Visible = false;
        }

        protected void btn_Scs_Click(object sender, EventArgs e)
        {
            randomizer();
            determineResult("Scissors");
            btn_Paper.Enabled = false;
            btn_Scs.Enabled = false;
            btn_Stone.Enabled = false;
            btn_Restart.Visible = true;
        }

        protected void btn_Paper_Click(object sender, EventArgs e)
        {
            randomizer();
            determineResult("Paper");
            btn_Paper.Enabled = false;
            btn_Scs.Enabled = false;
            btn_Stone.Enabled = false;
            btn_Restart.Visible = true;
        }

        protected void btn_Stone_Click(object sender, EventArgs e)
        {
            randomizer();
            determineResult("Stone");
            btn_Paper.Enabled = false;
            btn_Scs.Enabled = false;
            btn_Stone.Enabled = false;
            btn_Restart.Visible = true;
        }

        private void randomizer()
        {
            Random random = new Random();
            string[] list = new string[3] { "Scissors", "Paper", "Stone" };
            int index = random.Next(0, list.Length);
            lbl_ComputerPick.Text = list[index].ToString().Trim();
        }

        private void determineResult(string userChoice)
        {
            string compPick = lbl_ComputerPick.Text.Trim();

            if (string.Equals(userChoice, "Scissors"))
            {
                if (string.Equals(compPick, "Scissors"))
                {
                    lbl_Result.Text = "Tie. User picked: " + userChoice + " and the Computer picked: " + compPick;
                }
                else if (string.Equals(compPick, "Paper"))
                {
                    lbl_Result.Text = "You won. User picked: " + userChoice + " and the Computer picked: " + compPick;
                }
                else if (string.Equals(compPick, "Stone"))
                {
                    lbl_Result.Text = "You lost. User picked: " + userChoice + " and the Computer picked: " + compPick;
                }
            }
            else if (string.Equals(userChoice, "Paper"))
            {
                if (string.Equals(compPick, "Scissors"))
                {
                    lbl_Result.Text = "You lost. User picked: " + userChoice + " and the Computer picked: " + compPick;
                }
                else if (string.Equals(compPick, "Paper"))
                {
                    lbl_Result.Text = "Tie. User picked: " + userChoice + " and the Computer picked: " + compPick;
                }
                else if (string.Equals(compPick, "Stone"))
                {
                    lbl_Result.Text = "You won. User picked: " + userChoice + " and the Computer picked: " + compPick;
                }
            }

            else if (string.Equals(userChoice, "Stone"))
            {
                if (string.Equals(compPick, "Scissors"))
                {
                    lbl_Result.Text = "You won. User picked: " + userChoice + " and the Computer picked: " + compPick;
                }
                else if (string.Equals(compPick, "Paper"))
                {
                    lbl_Result.Text = "You lost. User picked: " + userChoice + " and the Computer picked: " + compPick;
                }
                else if (string.Equals(compPick, "Stone"))
                {
                    lbl_Result.Text = "Tie. User picked: " + userChoice + " and the Computer picked: " + compPick;
                }
            }

        }

        protected void btn_Restart_Click(object sender, EventArgs e)
        {
            lbl_ComputerPick.Text = "";
            lbl_Result.Text = "";
            btn_Paper.Enabled = true;
            btn_Scs.Enabled = true;
            btn_Stone.Enabled = true;
            btn_Restart.Visible = false;
        }
    }
}