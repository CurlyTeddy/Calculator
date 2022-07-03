using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    public interface IOperatorContent
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        string Content { get; }

        /// <summary>
        /// The position of the second operand
        /// </summary>
        int Position { get; }
    }
}
