namespace Machete.Cursors
{
    public class StringCursor :
        BasePayload,
        Cursor<char>
    {
        readonly string _text;
        readonly int _index;

        bool _nextComputed;
        Cursor<char> _next;

        public StringCursor(string text)
        {
            _text = text;
            _index = -1;
        }

        StringCursor(string text, int index)
        {
            _text = text;
            _index = index;
            HasValue = true;
        }

        public bool HasValue { get; }
        public char Value => _text[_index];

        public bool HasNext
        {
            get
            {
                if (_nextComputed)
                    return _next != null;

                GetNext();

                return _next != null;
            }
        }

        public Cursor<char> Next()
        {
            if (_nextComputed)
                return _next ?? Cursor.Empty<char>();

            return GetNext() ?? Cursor.Empty<char>();
        }

        Cursor<char> GetNext()
        {
            int nextIndex = _index + 1;

            if (nextIndex < _text.Length)
            {
                _next = new StringCursor(_text, nextIndex);
            }

            _nextComputed = true;

            return _next;
        }
    }
}