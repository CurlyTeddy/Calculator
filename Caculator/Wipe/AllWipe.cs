using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    /// <summary>
    /// The clear button class
    /// </summary>
    public class Wipe : IButton
    {
        /// <summary>
        /// The method clears the screen and background variables
        /// </summary>
        public void Execute()
        {
            GlobalVariables.CurrentEquation = "";
            GlobalVariables.Result = "";
            GlobalVariables.Reset();
        }
    }
}
