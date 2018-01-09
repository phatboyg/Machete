namespace Machete.Cursors
{
    using System;
    using System.Threading.Tasks;
    using Texts;


    /// <summary>
    /// A cursor over ParseText, which is being read from a stream.
    /// </summary>
    public struct StreamTextCursor :
        TextCursor
    {
        readonly TextSpan _nextSpan;
        readonly ITextParser _parser;
        readonly StreamText _text;
        readonly TextSpan _valueSpan;

        Task<TextCursor> _next;
        bool _nextComputed;

        ParseText _value;
        bool _valueComputed;

        public StreamTextCursor(StreamText text, TextSpan valueSpan, TextSpan nextSpan, ITextParser parser)
        {
            _text = text;
            _valueSpan = valueSpan;
            _nextSpan = nextSpan;
            _parser = parser;
            
            _next = null;
            _nextComputed = false;
            _value = null;
            _valueComputed = false;
        }

        bool ICursor.HasCurrent => true;

        ParseText TextCursor.Current
        {
            get
            {
                if (_valueComputed)
                    return _value;

                _value = _text.GetSubText(_valueSpan);
                _valueComputed = true;

                return _value;
            }
        }

        TextSpan TextCursor.CurrentSpan => _valueSpan;

        bool ICursor.HasNext => _text.HasNext;

        public StreamText InputText => _text;
        public TextSpan NextSpan => _nextSpan;

        public Task<TextCursor> Next()
        {
            if (!_text.HasNext)
                throw new InvalidOperationException("The cursor is at the end, there is no next.");

            if (_nextComputed)
                return _next;

            _next = ParseText(_text, _nextSpan, _parser);
            _nextComputed = true;

            return _next;
        }

        public static Task<TextCursor> ParseText(ParseText text, TextSpan span, ITextParser parser)
        {
            var result = parser.Parse(text, span);
            
            return result.HasResult
                ? Task.FromResult<TextCursor>(new StreamTextCursor(new StreamText(text, null), result.Result, result.Next, parser))
                : Task.FromResult<TextCursor>(new EmptyTextCursor(new StreamText(text, null), span));
        }

        public static async Task<TextCursor> ParseText(StreamText text, TextSpan span, ITextParser parser)
        {
            var result = parser.Parse(text, span);
            if (NeedsMoreInput(text, span, result))
            {
                var streamText = await text.GetNext(span).ConfigureAwait(false);
                var textSpan = new TextSpan(0, streamText.Length);

                result = parser.Parse(streamText, textSpan);
                while (NeedsMoreInput(streamText, textSpan, result))
                {
                    streamText = await streamText.Reader.Next(streamText).ConfigureAwait(false);
                    textSpan = new TextSpan(0, streamText.Length);

                    result = parser.Parse(streamText, textSpan);
                }

                if (result.HasResult)
                    return new StreamTextCursor(streamText, result.Result, result.Next, parser);
            }

            if (result.HasResult)
                return new StreamTextCursor(text, result.Result, result.Next, parser);

            return new EmptyTextCursor(text, span);
        }

        static bool NeedsMoreInput(StreamText text, TextSpan span, Result<TextSpan, TextSpan> result)
        {
            return (!result.HasResult || result.Next.Length == 0) && span.End == text.Length && text.HasNext;
        }
    }
}