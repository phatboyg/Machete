namespace Machete.Slices
{
    public abstract class SubTextSlice :
        TextSlice
    {
        readonly ParseText _sourceText;
        readonly TextSpan _sourceSpan;

        bool _textComputed;
        ParseText _text;

        protected SubTextSlice(ParseText text, TextSpan span)
        {
            _sourceText = text;
            _sourceSpan = span;
        }

        public ParseText Text
        {
            get
            {
                if (_textComputed)
                    return _text;

                _text = _sourceText.GetSubText(_sourceSpan);
                _textComputed = true;

                return _text;
            }
        }

        TextSpan TextSlice.SourceSpan => _sourceSpan;
        ParseText TextSlice.SourceText => _sourceText;

        public bool TryGetSlice(int index, out TextSlice slice)
        {
            slice = Slice.Missing;
            return false;
        }
    }
}