namespace Machete.Slices
{
    public class StringSlice :
        TextSlice
    {
        public StringSlice(ParseText text)
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
                slice = default(TextSlice);
                return false;
            }

            slice = this;
            return true;
        }
    }
}