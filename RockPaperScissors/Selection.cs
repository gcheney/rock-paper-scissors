using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Selection : Form
    {
        private string selection;

        public Selection()
        {
            InitializeComponent();
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string fileName = Path.Combine(dir, @"img\rock-paper-scissors-logo.jpg");
            backgroundImage.Image = Image.FromFile(fileName);
            backgroundImage.Visible = true;
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            selection = btnRock.Text; 
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            selection = btnPaper.Text;
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            selection = btnScissors.Text;
        }

        public string getSelection
        {
            get
            {
                return selection;
            }
        }
    }
}
