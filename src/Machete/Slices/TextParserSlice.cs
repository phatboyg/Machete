namespace Machete.Slices
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;


    public abstract class TextParserSlice<TSlice> :
        TextSlice
        where TSlice : TextSlice
    {
        readonly ParseText _sourceText;
        readonly TextSpan _sourceSpan;
        readonly TextParser _parser;
        readonly IList<TSlice> _slices;

        TextSpan _parseSpan;

        bool _textComputed;
        ParseText _text;

        protected TextParserSlice(ParseText text, TextSpan span, TextParser parser)
        {
            _sourceText = text;
            _sourceSpan = span;
            _parser = parser;

            _parseSpan = span;

            _slices = new List<TSlice>();
        }

        protected abstract TSlice CreateSlice(ParseText text, TextSpan span);

        bool TryParseUntil(int index, out TSlice result)
        {
            while (_parseSpan.Length > 0 && index >= _slices.Count)
            {
                Result<TextSpan, TextSpan> parseResult = _parser.Parse(_sourceText, _parseSpan);
                if (parseResult.HasValue == false)
                    break;

                AddSlice(parseResult.Value);

                _parseSpan = parseResult.Next;

                // if the remaining text is empty, and the end of the result is not the start of the next span,
                // there was a separate or something in between and therefore, we have an empty value next so add it.
                if (_parseSpan.IsEmpty && _parseSpan.Start > parseResult.Value.End)
                {
                    AddSlice(_parseSpan);
                }
            }

            if (index < _slices.Count)
            {
                result = _slices[index];
                return true;
            }

            result = default(TSlice);
            return false;
        }

        void AddSlice(TextSpan span)
        {
            var slice = CreateSlice(_sourceText, span);

            _slices.Add(slice);
        }

        public ParseText Text
        {
            get
            {
                if (_textComputed)
                    return _text;

                _text = _sourceText.GetSubText(_sourceSpan);
                _textComputed = true;

                if (Trace.Listeners.Count > 0)
                    Trace.WriteLine($"Computed Text: {_sourceSpan} {_text}");

                return _text;
            }
        }

        public ParseText SourceText => _sourceText;
        public TextSpan SourceSpan => _sourceSpan;

        public bool TryGetSlice(int index, out TextSlice slice)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), "Must be >= 0");

            if (index < _slices.Count)
            {
                slice = _slices[index];
                return true;
            }

            TSlice getSlice;
            if (TryParseUntil(index, out getSlice))
            {
                slice = getSlice;
                return true;
            }

            slice = Slice.Missing;
            return false;
        }
    }
}