namespace Machete.Cursors
{
    public class ParsedCursor<TSchema> :
        Cursor<TSchema>
        where TSchema : Entity
    {
        readonly Parsed<TSchema> _parsed;
        readonly int _index;

        bool _nextComputed;
        Cursor<TSchema> _next;

        public ParsedCursor(Parsed<TSchema> parsed)
        {
            _parsed = parsed;
            _index = -1;
        }

        ParsedCursor(Parsed<TSchema> parsed, int index, TSchema entity)
        {
            _parsed = parsed;
            _index = index;
            Value = entity;
            HasValue = true;
        }

        public bool HasValue { get; }
        public TSchema Value { get; }

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

        public Cursor<TSchema> Next()
        {
            if (_nextComputed)
                return _next ?? Cursor.Empty<TSchema>();

            return GetNext() ?? Cursor.Empty<TSchema>();
        }

        Cursor<TSchema> GetNext()
        {
            int nextIndex = _index + 1;

            TSchema entity;
            if (_parsed.TryGetEntity(nextIndex, out entity))
            {
                _next = new ParsedCursor<TSchema>(_parsed, nextIndex, entity);
            }

            _nextComputed = true;

            return _next;
        }
    }
}