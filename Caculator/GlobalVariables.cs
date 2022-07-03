using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    /// <summary>
    /// The class of global variable
    /// </summary>
    public static class GlobalVariables
    {
        /// <summary>
        /// The List of operands
        /// </summary>
        public static List<double> ListOperand { get; set; }

        /// <summary>
        /// The list constains single operators
        /// </summary>
        public static List<ISingleOperation> SingleOperator { get; set; }

        /// <summary>
        /// The list contains high order double operators
        /// </summary>
        public static List<IDoubleOperation> HighOperator { get; set; }

        /// <summary>
        /// The list contains low order double operators
        /// </summary>
        public static List<IDoubleOperation> LowOperator { get; set; }

        /// <summary>
        /// The value behinds the last operator
        /// </summary>
        public static string CurrentValue { get; set; }

        /// <summary>
        /// The variable is set dynamically to record the position of the last operator
        /// </summary>
        public static int NextNumberStart { get; set; }

        /// <summary>
        /// The current equation
        /// </summary>
        public static string CurrentEquation { get; set; }

        /// <summary>
        /// The answer of the equation
        /// </summary>
        public static string Result { get; set; }

        /// <summary>
        /// The constructor initialize each properties
        /// </summary>
        static GlobalVariables()
        {
            ListOperand = new List<double>();
            SingleOperator = new List<ISingleOperation>();
            HighOperator = new List<IDoubleOperation>();
            LowOperator = new List<IDoubleOperation>();
            CurrentValue = "";
            CurrentEquation = "";
        }

        /// <summary>
        /// The method resets background variables
        /// </summary>
        public static void Reset()
        {
            ListOperand.Clear();
            SingleOperator.Clear();
            HighOperator.Clear();
            LowOperator.Clear();
            CurrentValue = "";
            NextNumberStart = 0;
        }
    }
}
