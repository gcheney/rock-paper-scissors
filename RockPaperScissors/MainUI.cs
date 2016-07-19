using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace RockPaperScissors
{
    /// <summary>
    /// The Main User Interface class for the game
    /// </summary>
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

        /// <summary>
        /// Runs on load and calls the game initialization method
        /// </summary>
        private void MainUI_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        /// <summary>
        /// Runs the game logic and checks results to determine the winner
        /// </summary>
        /// <param name="user">The users choice</param>
        /// <param name="com">The computer players choice</param>
        /// <returns>The game results string</returns>
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
                Assembly assembly = Assembly.GetExecutingAssembly();
                string directory = "RockPaperScissors.Resources.";

                string userImgPath = directory + user.ToLower() + ".jpg";
                Stream userStream = assembly.GetManifestResourceStream(userImgPath);
                Bitmap userImage = new Bitmap(userStream);

                string comImgPath = directory + com.ToLower() + ".jpg";
                Stream comStream = assembly.GetManifestResourceStream(comImgPath);
                Bitmap comImage = new Bitmap(comStream);

                userBox.Image = userImage;
                comBox.Image = comImage;
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

        /// <summary>
        /// Initializes the game logic and starting images
        /// </summary>
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
                Assembly assembly = Assembly.GetExecutingAssembly();
                string imagePath = "RockPaperScissors.Resources.rpstriangle.jpg";
                Stream stream = assembly.GetManifestResourceStream(imagePath);
                Bitmap startImage = new Bitmap(stream);

                userBox.Image = startImage;
                comBox.Image = startImage;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Starts the game. Prompts the user to make a choice 
        /// and displays the result of that round
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Resets all game stats after confirmation from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
