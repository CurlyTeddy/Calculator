using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            IButton generalButton = (IButton)button.Tag;
            generalButton.Execute();
            Equation.Text = GlobalVariables.CurrentEquation;
            Result.Text = GlobalVariables.Result;
        }
    }
}
