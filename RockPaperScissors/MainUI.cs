using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace RockPaperScissors
{
    public partial class MainUI : Form
    {
        private string userChoice;
        private string comChoice;
        private int userWins = 0;
        private int comWins = 0;
        private int draws = 0;

        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private string PlayGame(string user, string com)
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
                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                string userImgFile 
                    = Path.Combine(dir, @"img\" + user.ToLower() + ".jpg");
                string comImgFile 
                    = Path.Combine(dir, @"img\" + com.ToLower() + ".jpg");

                userBox.Image = Image.FromFile(userImgFile);
                comBox.Image = Image.FromFile(comImgFile);
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

        private void InitializeGame()
        {
            userWins = 0;
            comWins = 0;
            draws = 0;
            lblUser.Text = userWins.ToString();
            lblCom.Text = comWins.ToString();
            lblDraw.Text = draws.ToString();

            try
            {
                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                string fileName = Path.Combine(dir, @"img\rpstriangle.jpg");
                userBox.Image = Image.FromFile(fileName);
                comBox.Image = Image.FromFile(fileName);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Selection makeSelection = new Selection();
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
                    case 1:
                        comChoice = "Rock";
                        break;
                    case 2:
                        comChoice = "Paper";
                        break;
                    case 3:
                        comChoice = "Rock";
                        break;
                    default:
                        comChoice = "Invalid choice";
                        break;
                }

                string result = PlayGame(userChoice, comChoice);
                Replay replay = new Replay(result);
                replay.StartPosition = FormStartPosition.Manual;
                replay.Location = new Point(800, 175);
                replay.ShowDialog(this);

                if (replay.DialogResult == DialogResult.OK)
                {
                    btnPlay.PerformClick();
                }
                else
                {
                    replay.Close();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Are you sure you want to start over? " 
                    + "All current progress will be lost",
                     "Reset?", MessageBoxButtons.YesNoCancel,
                     MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                InitializeGame();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit the game?",
                     "Exit Game?", MessageBoxButtons.YesNoCancel,
                     MessageBoxIcon.Stop);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
