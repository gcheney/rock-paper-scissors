using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Selection : Form
    {
        private string selection;

        public Selection()
        {
            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();
            string imagePath = "RockPaperScissors.Resources.rock-paper-scissors-logo.jpg";
            Stream stream = assembly.GetManifestResourceStream(imagePath);
            Bitmap logoImage = new Bitmap(stream);

            backgroundImage.Image = logoImage;
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
