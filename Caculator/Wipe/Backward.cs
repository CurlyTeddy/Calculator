using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    /// <summary>
    /// The backspace class
    /// </summary>
    public class Backward : IButton
    {
        /// <summary>
        /// The method deletes one digit of current value
        /// </summary>
        public void Execute()
        {
            try
            {
                GlobalVariables.CurrentValue = GlobalVariables.CurrentValue.Remove(GlobalVariables.CurrentValue.Length - 1);
                GlobalVariables.CurrentEquation = GlobalVariables.CurrentEquation.Remove(GlobalVariables.CurrentEquation.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("後退鍵僅能修改當前數字。");
            }
        }
    }
}
