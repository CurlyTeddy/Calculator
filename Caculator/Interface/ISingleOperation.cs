using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    /// <summary>
    /// The interface regulates the method that a single operation should implement
    /// </summary>
    public interface ISingleOperation : IOperatorContent
    {
        /// <summary>
        /// The method calculates partial result of the answer
        /// </summary>
        /// <param name="operand">The single operand</param>
        /// <returns>The single operation result</returns>
        double Calculate(double operand);
    }
}
