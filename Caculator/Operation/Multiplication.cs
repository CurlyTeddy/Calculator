using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Caculator
{
    /// <summary>
    /// The multiply button class
    /// </summary>
    public class Multiplication : BaseOperation, IButton
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the button's symbol
        /// </summary>
        static Multiplication()
        {
            Content = "×";
        }

        /// <summary>
        /// The method does the work that meets the prerequisite
        /// </summary>
        public void Execute()
        {
            SymbolWorks(Content);
        }

        /// <summary>
        /// The method calculates partial result of the answer
        /// </summary>
        /// <param name="first">The first operand</param>
        /// <param name="second">The second operand</param>
        /// <returns>The partial result</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Calculate(double first, double second) => first * second;
    }
}
