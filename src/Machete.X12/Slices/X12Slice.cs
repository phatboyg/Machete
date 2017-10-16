namespace Machete.X12.Slices
{
    using Machete.Slices;


    public abstract class X12Slice<TFragment> :
        TextParserSlice<TFragment>,
        IX12Slice
        where TFragment : IX12Slice
    {
        protected X12ParserSettings Settings { get; }

        protected X12Slice(X12ParserSettings settings, ParseText text, TextSpan span, TextParser parser)
            : base(text, span, parser)
        {
            Settings = settings;
        }
    }
}