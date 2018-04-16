namespace Machete.Slices
{
    public class MissingSlice :
        TextSlice
    {
        public ParseText Text => throw new SliceMissingException();

        public TextSpan SourceSpan => throw new SliceMissingException();
        public ParseText SourceText => throw new SliceMissingException();

        public bool TryGetSlice(int index, out TextSlice slice)
        {
            slice = Slice.Missing;
            return false;
        }
    }
}