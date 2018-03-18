namespace Machete.X12.Slices
{
    public class X12ElementSlice :
        X12Slice<X12SubElementSlice>,
        ListTextSlice
    {
        TextSlice _listSlice;

        public X12ElementSlice(X12ParserSettings settings, ParseText text, TextSpan span)
            : base(settings, text, span, settings.SubElementParser)
        {
        }

        protected override X12SubElementSlice CreateSlice(ParseText text, TextSpan span)
        {
            return new X12SubElementSlice(text, span);
        }

        public bool TryGetListSlice(out TextSlice slice)
        {
            slice = _listSlice ?? (_listSlice = new X12RepeatingElementSlice(Settings, SourceText, SourceSpan));
            return true;
        }
    }
}