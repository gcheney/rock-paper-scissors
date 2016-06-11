using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class frmDialog : Form
    {
        private string selection;

        public frmDialog()
        {
            InitializeComponent();
            selectionPicture.Image = Image.FromFile("../Pics/rock-paper-scissors-logo.jpg");
            selectionPicture.Visible = true;
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
