namespace Machete
{
    using System.Threading.Tasks;
    using Texts;


    public interface TextCursor :
        ICursor
    {
        /// <summary>
        /// The current parse text for this cursor
        /// </summary>
        ParseText Current { get; }

        /// <summary>
        /// The text which sourced the cursor
        /// </summary>
        StreamText InputText { get; }

        /// <summary>
        /// The span of the current position
        /// </summary>
        TextSpan CurrentSpan { get; }

        /// <summary>
        /// The remaining text span after the text owned by this cursor
        /// </summary>
        TextSpan NextSpan { get; }

        /// <summary>
        /// Returns the cursor for the next input position
        /// </summary>
        /// <returns></returns>
        Task<TextCursor> Next();
    }
}