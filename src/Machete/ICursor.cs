namespace Machete
{
    public interface ICursor
    {
        /// <summary>
        /// True if the cursor is currently at a valid input position
        /// </summary>
        bool HasCurrent { get; }

        /// <summary>
        /// True if the cursor may be able to advance to another input position
        /// </summary>
        bool HasNext { get; }
    }
}