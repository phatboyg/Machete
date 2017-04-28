namespace Machete
{
    using System.Threading.Tasks;
    using Texts;


    public interface TextCursor :
        ICursor
    {
        /// <summary>
        /// The text of the parsed value
        /// </summary>
        ParseText Text { get; }

        /// <summary>
        /// The span matched by the parser
        /// </summary>
        TextSpan Span { get; }

        /// <summary>
        /// Returns the cursor for the next value
        /// </summary>
        /// <returns></returns>
        Task<TextCursor> Next();

        /// <summary>
        /// The text which sourced the cursor
        /// </summary>
        StreamText SourceText { get; }

        /// <summary>
        /// The remaining text span after the text owned by this cursor
        /// </summary>
        TextSpan RemainingSpan { get; }

        /// <summary>
        /// Create a new text cursor which skips the first <paramref name="count"/> characters
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        TextCursor Skip(int count);
    }
}