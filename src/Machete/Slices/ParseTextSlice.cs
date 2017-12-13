namespace Machete.Slices
{
    public class ParseTextSlice :
        TextSlice
    {
        public ParseTextSlice(ParseText text, TextSpan span)
        {
            SourceText = text;
            SourceSpan = span;

            Text = text.GetSubText(span);
        }

        public ParseText Text { get; }
        public TextSpan SourceSpan { get; }
        public ParseText SourceText { get; }

        public bool TryGetSlice(int index, out TextSlice slice)
        {
            slice = Slice.Missing;
            return false;
        }
    }
}