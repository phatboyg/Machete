namespace Machete.X12.Slices
{
    public class X12ElementSlice :
        X12Slice<X12SubElementSlice>
    {
        public X12ElementSlice(X12ParserSettings settings, ParseText text, TextSpan span)
            : base(settings, text, span, settings.SubElementParser)
        {
        }

        protected override X12SubElementSlice CreateSlice(ParseText text, TextSpan span)
        {
            return new X12SubElementSlice(text, span);
        }
    }
}