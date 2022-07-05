using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Caculator
{
    /// <summary>
    /// The Sqrt button class
    /// </summary>
    public class Sqrt : IButton
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static Sqrt()
        {
            Content = "√";
        }

        /// <summary>
        /// The method makes the switch to sqrt mood
        /// </summary>
        public void Execute()
        {
            GlobalVariables.UpdateWindow(Content);
        }

        /// <summary>
        /// The method calculates the sqrt of a number
        /// </summary>
        /// <param name="operand">The operand that is to be sqrted</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Calculate(double operand) => Math.Sqrt(operand);
    }
}
