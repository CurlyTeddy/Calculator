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
    }
}
