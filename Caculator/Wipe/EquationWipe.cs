using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    /// <summary>
    /// The class of clear entry button
    /// </summary>
    public class EquationWipe : IButton
    {
        /// <summary>
        /// The method represents clear entry button's function
        /// </summary>
        public void Execute()
        {
            GlobalVariables.CurrentEquation = "";
            GlobalVariables.Reset();
        }
    }
}
