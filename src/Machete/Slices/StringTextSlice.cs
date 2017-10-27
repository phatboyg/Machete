namespace Machete.Slices
{
    public class StringTextSlice :
        TextSlice
    {
        public StringTextSlice(ParseText text)
        {
            Text = text;
        }

        public ParseText Text { get; }

        public TextSpan SourceSpan => new TextSpan(0, Text.Length);
        public ParseText SourceText => Text;

        public bool TryGetSlice(int index, out TextSlice slice)
        {
            if (index != 0)
            {
                slice = Slice.Missing;
                return false;
            }

            slice = this;
            return true;
        }
    }
}