namespace Machete.Cursors
{
    using System.Threading.Tasks;
    using Texts;


    public struct StreamTextSubCursor :
        TextCursor
    {
        readonly TextCursor _cursor;
        readonly int _count;

        public StreamTextSubCursor(TextCursor cursor, TextSpan span, int count)
        {
            _cursor = cursor;
            CurrentSpan = span;
            _count = count;
        }

        public bool HasCurrent => true;

        public bool HasNext => _cursor.HasNext;

        public ParseText Current => _cursor.Current;

        public TextSpan CurrentSpan { get; }

        public async Task<TextCursor> Next()
        {
            var next = await _cursor.Next().ConfigureAwait(false);

            return new StreamTextSubCursor(next, TextSpan.FromBounds(CurrentSpan.Start, next.CurrentSpan.End), _count);
        }

        public StreamText InputText => _cursor.InputText;

        public TextSpan NextSpan => _cursor.NextSpan;
    }
}