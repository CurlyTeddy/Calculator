namespace Caculator
{
    /// <summary>
    /// The clear button class
    /// </summary>
    public class AllWipe : IButton
    {
        /// <summary>
        /// The method clears the screen and background variables
        /// </summary>
        public void Execute()
        {
            GlobalVariables.CurrentEquation = "";
            GlobalVariables.PreorderEquation = "";
            GlobalVariables.PostorderEquation = "";
            GlobalVariables.Result = "";
            GlobalVariables.Reset();
        }
    }
}
