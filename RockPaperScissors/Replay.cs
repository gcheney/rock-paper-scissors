using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Replay : Form
    {
        public Replay(string matchResult)
        {
            InitializeComponent();
            lblResult.Text = matchResult;
        }
    }
}
