namespace Machete.Slices
{
    public class MissingSlice :
        TextSlice
    {
        public ParseText Text
        {
            get { throw new SliceMissingException(); }
        }

        public TextSpan SourceSpan
        {
            get { throw new SliceMissingException(); }
        }

        public ParseText SourceText
        {
            get { throw new SliceMissingException(); }
        }

        public bool TryGetSlice(int index, out TextSlice slice)
        {
            throw new SliceMissingException();
        }
    }
}