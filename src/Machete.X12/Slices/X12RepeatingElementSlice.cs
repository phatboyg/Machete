namespace Machete.X12.Slices
{
    public class X12RepeatingElementSlice :
        X12Slice<X12ElementSlice>
    {
        public X12RepeatingElementSlice(X12ParserSettings settings, ParseText text, TextSpan span)
            : base(settings, text, span, settings.RepetitionParser)
        {
        }

        protected override X12ElementSlice CreateSlice(ParseText text, TextSpan span)
        {
            return new X12ElementSlice(Settings, text, span);
        }
    }
}