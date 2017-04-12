namespace Machete
{
    /// <summary>
    /// A text slice, includes the SourceText, the TextSpan, and the Text itself (which should only be used
    /// if needed directly for consumption).
    /// </summary>
    public interface TextSlice
    {
        /// <summary>
        /// The sliced text, which is cached for performance
        /// </summary>
        ParseText Text { get; }

        /// <summary>
        /// The span, relative to the SourceText, which can be used to check length, and to
        /// avoid creating intermediate strings
        /// </summary>
        TextSpan SourceSpan { get; }

        /// <summary>
        /// The source text for this slice, of which the <see cref="SourceSpan"/> is the portion
        /// contained in the slice.
        /// </summary>
        ParseText SourceText { get; }

        /// <summary>
        /// Try to get a slice of text, offset from the index specified
        /// </summary>
        /// <param name="index">The slice index</param>
        /// <param name="slice">The slice, if present, otherwise empty</param>
        /// <returns>True if the slice exists, otherwise false</returns>
        bool TryGetSlice(int index, out TextSlice slice);
    }
}