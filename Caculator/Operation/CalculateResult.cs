using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    /// <summary>
    /// The class of equal button
    /// </summary>
    public class CalculateResult : IButton
    {
        /// <summary>
        /// The symbol of the button
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// The constructor sets the button's symbol
        /// </summary>
        /// <param name="buttonText">The argument passes the button's symbol</param>
        public CalculateResult(string buttonText)
        {
            Content = buttonText;
        }

        /// <summary>
        /// The function of the button
        /// </summary>
        public void Execute()
        {
            // The last operand needs to be added to the list
            GlobalVariables.ListOperand.Add(double.Parse(GlobalVariables.CurrentValue));

            foreach (ISingleOperation operation in GlobalVariables.SingleOperator)
            {
                GlobalVariables.ListOperand[operation.Position] = operation.Calculate(GlobalVariables.ListOperand[operation.Position]);
            }

            foreach (IDoubleOperation operation in GlobalVariables.HighOperator)
            {
                double first = GlobalVariables.ListOperand[operation.Position - 1];
                double second = GlobalVariables.ListOperand[operation.Position];
                GlobalVariables.ListOperand[operation.Position] = operation.Calculate(first, second);
                GlobalVariables.ListOperand[operation.Position - 1] = double.PositiveInfinity;
            }

            foreach (IDoubleOperation operation in GlobalVariables.HighOperator)
            {
                GlobalVariables.ListOperand.Remove(double.PositiveInfinity);
            }

            // Calculate the answer of the equation
            double total = GlobalVariables.ListOperand[0];
            for (int i = 0; i < GlobalVariables.LowOperator.Count; ++i)
            {
                total = GlobalVariables.LowOperator[i].Calculate(total, GlobalVariables.ListOperand[i + 1]);
            }
            GlobalVariables.Result = total.ToString();

            GlobalVariables.Reset();
        }
    }
}
