namespace Machete.Cursors
{
    using System;
    using System.Threading.Tasks;
    using Texts;


    /// <summary>
    /// A cursor over ParseText, which is being read from a stream.
    /// </summary>
    public class StreamTextCursor :
        TextCursor
    {
        readonly StreamText _text;
        readonly TextSpan _valueSpan;
        readonly TextSpan _nextSpan;
        readonly TextParser _parser;

        ParseText _value;
        bool _valueComputed;

        Task<TextCursor> _next;
        bool _nextComputed;

        public StreamTextCursor(StreamText text, TextSpan valueSpan, TextSpan nextSpan, TextParser parser)
        {
            _text = text;
            _valueSpan = valueSpan;
            _nextSpan = nextSpan;
            _parser = parser;
        }

        bool ICursor.HasValue => true;

        ParseText TextCursor.Text
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

        TextSpan TextCursor.Span => _valueSpan;

        bool ICursor.HasNext => _text.HasNext;

        public StreamText SourceText => _text;
        public TextSpan RemainingSpan => _nextSpan;

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

        public static async Task<TextCursor> ParseText(StreamText text, TextSpan span, TextParser parser)
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

                if (result.HasValue)
                {
                    return new StreamTextCursor(streamText, result.Value, result.Next, parser);
                }
            }

            if (result.HasValue)
                return new StreamTextCursor(text, result.Value, result.Next, parser);

            return new EmptyTextCursor(text, span);
        }

        static bool NeedsMoreInput(StreamText text, TextSpan span, Result<TextSpan, TextSpan> result)
        {
            return !result.HasValue || result.Next.Length == 0 && span.End == text.Length && text.HasNext;
        }
    }
}