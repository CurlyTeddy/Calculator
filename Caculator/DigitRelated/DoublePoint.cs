using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    /// <summary>
    /// The dot button class
    /// </summary>
    public class DoublePoint : IButton
    {
        /// <summary>
        /// The content of the button
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        /// <param name="buttonText">The argument passes the symbol of the button</param>
        public DoublePoint(string buttonText)
        {
            Content = buttonText;
        }

        /// <summary>
        /// The method adds a dot to current value and displayed equation
        /// </summary>
        public void Execute()
        {
            GlobalVariables.CurrentEquation += Content;
            GlobalVariables.CurrentValue += Content;
        }
    }
}
