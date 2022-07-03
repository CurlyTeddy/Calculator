using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    /// <summary>
    /// The Sqrt button class
    /// </summary>
    public class Sqrt : IButton, ISingleOperation
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public string Content { get; private set; }

        /// <summary>
        /// The variable records the position of the operand
        /// </summary>
        public int Position { get; private set; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        /// <param name="buttonText">The argument passes the symbol of the button</param>
        public Sqrt(string buttonText)
        {
            Content = buttonText;
        }

        /// <summary>
        /// The constructor sets the Poition
        /// </summary>
        /// <param name="position">The argument is the position of the operand</param>
        public Sqrt(int position)
        {
            Position = position;
        }

        /// <summary>
        /// The method calculates the sqrt of a number
        /// </summary>
        /// <param name="operand">The operand that is to be sqrted</param>
        /// <returns></returns>
        public double Calculate(double operand) => Math.Sqrt(operand);

        /// <summary>
        /// The method makes the switch to sqrt mood
        /// </summary>
        public void Execute()
        {
            GlobalVariables.CurrentEquation += Content;
            ++GlobalVariables.NextNumberStart;
            GlobalVariables.SingleOperator.Add(new Sqrt(GlobalVariables.ListOperand.Count));
        }
    }
}
