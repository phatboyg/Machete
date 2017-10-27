namespace Machete
{
    /// <summary>
    /// The base, non-generic, cursor interface
    /// </summary>
    public interface ICursor
    {
        /// <summary>
        /// True if the current cursor position is valid, otherwise false.
        /// </summary>
        bool HasCurrent { get; }

        /// <summary>
        /// True if the next cursor can be returned, otherwise false.
        /// </summary>
        bool HasNext { get; }
    }
}