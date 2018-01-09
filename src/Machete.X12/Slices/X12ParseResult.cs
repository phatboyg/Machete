namespace Machete.X12.Slices
{
    using Texts;
    using X12;


    public class X12ParseResult<TSchema> :
        X12Slice<X12SegmentSlice>,
        ParseResult<TSchema>
        where TSchema : X12Entity
    {
        readonly TextCursor _cursor;

        public X12ParseResult(ISchema<TSchema> schema, IEntityParser<TSchema> parser, X12ParserSettings settings, TextCursor cursor)
            : base(settings, cursor.InputText, cursor.CurrentSpan, settings.SegmentParser)
        {
            Schema = schema;
            Parser = parser;
            _cursor = cursor;
        }

        protected override X12SegmentSlice CreateSlice(ParseText text, TextSpan span)
        {
            return new X12SegmentSlice(Settings, text, span);
        }

        public bool TryGetEntity<T>(int index, out T entity)
            where T : TSchema
        {
            if (TryGetSlice(index, out var slice))
                return Schema.TryConvertEntity(slice, out entity);

            entity = default;
            return false;
        }

        public bool HasResult => true;
        public ISchema<TSchema> Schema { get; }
        public IEntityParser<TSchema> Parser { get; }
        public StreamText RemainingText => _cursor.InputText;
        public TextSpan RemainingSpan => _cursor.NextSpan;
    }
}