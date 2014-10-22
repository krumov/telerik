namespace ComputerParts
{
    /// <summary>
    /// Has methods for drawing with the video card of the computer and for saving and loading data to tha ram module
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// Displays a message with the video card
        /// </summary>
        /// <param name="message">the message to be displayed</param>
        void DrawWithVideoCard(string message);

        /// <summary>
        /// Saves data to the ram of the computer
        /// </summary>
        /// <param name="data">The data to be saved</param>
        void SaveToRam(int data);

        /// <summary>
        /// Loads data from the ram of the computer
        /// </summary>
        /// <returns>the data that was saved in the ram</returns>
        int LoadFromRam();
    }
}
