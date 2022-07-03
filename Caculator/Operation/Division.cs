using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    /// <summary>
    /// The divide button class
    /// </summary>
    public class Division : BaseOperation, IButton, IDoubleOperation
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public string Content { get; private set; }

        /// <summary>
        /// The property records the position of the second operand
        /// </summary>
        public int Position { get; private set; }

        /// <summary>
        /// The constructor sets the Poition
        /// </summary>
        /// <param name="position">The argument passes the symbol of the button</param>
        public Division(int position)
        {
            Position = position;
        }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        /// <param name="buttonText">The argument passes the symbol of the button</param>
        public Division(string buttonText)
        {
            Content = buttonText;
        }

        /// <summary>
        /// The method does the work that meets the prerequisite
        /// </summary>
        public void Execute()
        {
            SymbolWorks(Content);
            GlobalVariables.HighOperator.Add(new Division(GlobalVariables.ListOperand.Count));
        }

        /// <summary>
        /// The method calculates partial result of the answer
        /// </summary>
        /// <param name="first">The first operand</param>
        /// <param name="second">The second operand</param>
        /// <returns>The partial result</returns>
        public double Calculate(double first, double second) => first / second;
    }
}
