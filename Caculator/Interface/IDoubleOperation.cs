using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    /// <summary>
    /// The interface regulates the property and method that all operation buttons should implement
    /// </summary>
    public interface IDoubleOperation : IOperatorContent
    {
        /// <summary>
        /// The method calculates partial result of the answer
        /// </summary>
        /// <param name="first">The first operand</param>
        /// <param name="second">The second operand</param>
        /// <returns>The partial result</returns>
        double Calculate(double first, double second);
    }
}
