namespace Machete.Cursors
{
    using System.Threading.Tasks;
    using Texts;


    public class StreamTextSubCursor :
        TextCursor
    {
        readonly TextCursor _cursor;
        readonly TextSpan _span;
        readonly int _count;

        public StreamTextSubCursor(TextCursor cursor, TextSpan span, int count)
        {
            _cursor = cursor;
            _span = span;
            _count = count;
        }

        public bool HasValue => true;

        public bool HasNext => _cursor.HasNext;

        public ParseText Text => _cursor.Text;

        public TextSpan Span => _span;

        public async Task<TextCursor> Next()
        {
            var next = await _cursor.Next().ConfigureAwait(false);

            return new StreamTextSubCursor(next, TextSpan.FromBounds(_span.Start, next.Span.End), _count);
        }

        public StreamText SourceText => _cursor.SourceText;

        public TextSpan RemainingSpan => _cursor.RemainingSpan;

        public TextCursor Skip(int count)
        {
            return _cursor.Skip(count + _count);
        }
    }
}