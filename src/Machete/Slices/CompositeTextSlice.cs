namespace Machete.Slices
{
    using System;
    using Texts;


    public class CompositeTextSlice :
        TextSlice
    {
        readonly TextSlice[] _slices;
        ParseText _text;
        bool _textComputed;

        public CompositeTextSlice(params TextSlice[] slices)
        {
            _slices = slices;
        }

        ParseText GetText()
        {
            ParseText[] texts = new ParseText[_slices.Length];
            for (int i = 0; i < _slices.Length; i++)
            {
                texts[i] = _slices[i].Text;
            }

            _text = new CompositeText(texts);
            _textComputed = true;

            return _text;
        }

        public ParseText Text => _textComputed ? _text : GetText();
        public TextSpan SourceSpan => _textComputed ? new TextSpan(0, _text.Length) : new TextSpan(0, GetText().Length);
        public ParseText SourceText => _textComputed ? _text : GetText();

        public bool TryGetSlice(int index, out TextSlice slice)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), "must be >= 0");

            if (index < _slices.Length)
            {
                slice = _slices[index];
                return true;
            }

            slice = Slice.Missing;
            return false;
        }
    }
}