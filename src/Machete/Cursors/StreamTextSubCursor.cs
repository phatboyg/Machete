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

        public bool HasCurrent => true;

        public bool HasNext => _cursor.HasNext;

        public ParseText Current => _cursor.Current;

        public TextSpan CurrentSpan => _span;

        public async Task<TextCursor> Next()
        {
            var next = await _cursor.Next().ConfigureAwait(false);

            return new StreamTextSubCursor(next, TextSpan.FromBounds(_span.Start, next.CurrentSpan.End), _count);
        }

        public StreamText InputText => _cursor.InputText;

        public TextSpan NextSpan => _cursor.NextSpan;
    }
}