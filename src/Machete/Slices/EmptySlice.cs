namespace Machete.Slices
{
    public class EmptySlice :
        TextSlice
    {
        public ParseText Text => ParseText.Empty;

        public TextSpan SourceSpan => TextSpan.Empty;
        public ParseText SourceText => ParseText.Empty;

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