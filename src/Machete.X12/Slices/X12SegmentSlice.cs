namespace Machete.X12.Slices
{
    public class X12SegmentSlice :
        X12Slice<X12ElementSlice>
    {
        public X12SegmentSlice(X12ParserSettings settings, ParseText text, TextSpan span)
            : base(settings, text, span, settings.ElementParser)
        {
        }

        protected override X12ElementSlice CreateSlice(ParseText text, TextSpan span)
        {
            return new X12ElementSlice(Settings, text, span);
        }
    }
}