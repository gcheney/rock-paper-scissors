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
    public partial class frmReplay : Form
    {
        public frmReplay(string matchResult)
        {
            InitializeComponent();
            lblResult.Text = matchResult;
        }
    }
}
