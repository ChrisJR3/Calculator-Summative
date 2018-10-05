using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Summative
{
    public partial class happpinessLabel : Form
    {
        public happpinessLabel()
        {
            InitializeComponent();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            //You  have to make it say "Party On Dude!" at the end
            try
            {

            }

            catch

            {
                letterLabel.Text = "You can only enter numbers."; 
            }
        }
    }
}
