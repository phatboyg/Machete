namespace Machete.Slices
{
    public class RangeTextSlice :
        TextSlice
    {
        readonly TextSlice _slice;
        readonly int _offset;

        public RangeTextSlice(TextSlice slice, int offset)
        {
            _slice = slice;
            _offset = offset;
        }

        public ParseText Text => throw new System.NotImplementedException();

        public TextSpan SourceSpan => throw new System.NotImplementedException();
        public ParseText SourceText => throw new System.NotImplementedException();

        public bool TryGetSlice(int index, out TextSlice slice)
        {
            return _slice.TryGetSlice(_offset + index, out slice);
        }
    }
}