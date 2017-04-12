namespace Machete
{
    public interface ICursor
    {
        /// <summary>
        /// True if the cursor has a value
        /// </summary>
        bool HasValue { get; }

        /// <summary>
        /// True if the cursor may be able to advance to another value
        /// </summary>
        bool HasNext { get; }
    }
}