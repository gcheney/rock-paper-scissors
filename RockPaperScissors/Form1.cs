using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        private string userChoice;
        private string comChoice;
        private int userWins = 0;
        private int comWins = 0;
        private int draws = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUser.Text = userWins.ToString();
            lblCom.Text = comWins.ToString();
            lblDraw.Text = draws.ToString();

            try
            {
                userBox.Image = Image.FromFile("../Pics/rpstriangle.jpg");
                comBox.Image = Image.FromFile("../Pics/rpstriangle.jpg");
                userBox.Visible = true;
                comBox.Visible = true;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmDialog makeSelection = new frmDialog();
            makeSelection.StartPosition = FormStartPosition.Manual;
            makeSelection.Location = new Point(800, 100);
            makeSelection.ShowDialog(this);
            if (makeSelection.DialogResult == DialogResult.OK)
            {
                userChoice = makeSelection.getSelection;
                Random random = new Random();
                int randomNumber = random.Next(1, 4);
                switch (randomNumber)
                {
                    case 1: comChoice = "Rock";
                        break;
                    case 2: comChoice = "Paper";
                        break;
                    case 3: comChoice = "Rock";
                        break;
                    default: comChoice = "Invalid choice";
                        break;
                }

                string result = playGame(userChoice, comChoice);
                frmReplay replay = new frmReplay(result);
                replay.StartPosition = FormStartPosition.Manual;
                replay.Location = new Point(800, 175);
                replay.ShowDialog(this);
                if (replay.DialogResult == DialogResult.OK)
                    btnPlay.PerformClick();
                else
                    replay.Close();
            }
        }

        private string playGame(string user, string com)
        {
            string outcome = "";

            if (com.Equals("Rock"))
            {
                if (user.Equals("Rock"))
                {
                    outcome = "You got a draw!";
                    draws++;
                }
                else if (user.Equals("Paper"))
                {
                    outcome = "Congrats! You won!";
                    userWins++;
                }
                else if (userChoice.Equals("Scissors"))
                {
                    outcome = "Sorry, You lost!";
                    comWins++;
                }
            }
            else if (com.Equals("Paper"))
            {
                if (user.Equals("Rock"))
                {
                    outcome = "Sorry, You lost!";
                    comWins++;
                }
                else if (user.Equals("Paper"))
                {
                    outcome = "You got a draw!";
                    draws++;
                }
                if (user.Equals("Scissors"))
                {
                    outcome = "Congrats! You won!";
                    userWins++;
                }
            }
            else if (com.Equals("Scissors"))
            {
                if (user.Equals("Rock"))
                {
                    outcome = "Congrats! You won!";
                    userWins++;
                }
                else if (user.Equals("Paper"))
                {
                    outcome = "Sorry, You lost!";
                    comWins++;
                }
                if (user.Equals("Scissors"))
                {
                    outcome = "You got a draw!";
                    draws++;
                }
            }

            try
            {
                userBox.Image = Image.FromFile("../Pics/" + user + ".jpg");
                comBox.Image = Image.FromFile("../Pics/" + com + ".jpg");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            lblUser.Text = userWins.ToString();
            lblCom.Text = comWins.ToString();
            lblDraw.Text = draws.ToString();

            return outcome;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
             userWins = 0;
             comWins = 0;
             draws = 0;
             lblUser.Text = userWins.ToString();
             lblCom.Text = comWins.ToString();
             lblDraw.Text = draws.ToString();

             try
             {
                 userBox.Image = Image.FromFile("../Pics/rpstriangle.jpg");
                 comBox.Image = Image.FromFile("../Pics/rpstriangle.jpg");
             }
             catch (FileNotFoundException ex)
             {
                 MessageBox.Show(ex.Message, "File Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
