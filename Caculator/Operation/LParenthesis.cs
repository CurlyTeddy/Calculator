using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    /// <summary>
    /// The left parenthesis class
    /// </summary>
    public class LParenthesis : IButton
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public static string Content { get; }

        /// <summary>
        /// The constuctor sets the number on the button
        /// </summary>
        static LParenthesis()
        {
            Content = "(";
        }

        /// <summary>
        /// 
        /// </summary>
        public void Execute()
        {
            GlobalVariables.UpdateWindow(Content);
        }
    }
}
