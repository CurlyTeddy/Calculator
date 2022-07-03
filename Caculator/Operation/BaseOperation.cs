using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    /// <summary>
    /// The base class of operators
    /// </summary>
    public class BaseOperation
    {
        /// <summary>
        /// The method prepares for calculating result
        /// </summary>
        /// <param name="content">The argument is the symbol of the operation</param>
        public static void SymbolWorks(string content)
        {
            GlobalVariables.ListOperand.Add(double.Parse(GlobalVariables.CurrentValue));
            GlobalVariables.CurrentValue = "";
            GlobalVariables.CurrentEquation += content;
            GlobalVariables.NextNumberStart = GlobalVariables.CurrentEquation.Length;
        }
    }
}
