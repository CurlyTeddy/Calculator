namespace Caculator
{
    /// <summary>
    /// The class of clear entry button
    /// </summary>
    public class EquationWipe : IButton
    {
        /// <summary>
        /// The method represents clear entry button's function
        /// </summary>
        public void Execute()
        {
            GlobalVariables.CurrentEquation = "";
            GlobalVariables.PreorderEquation = "";
            GlobalVariables.PostorderEquation = "";
            GlobalVariables.Reset();
        }
    }
}
