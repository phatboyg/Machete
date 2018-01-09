namespace Machete.HL7.Slices
{
    using TextParsers;
    using Texts;


    public class HL7ParseResult<TSchema> :
        HL7Slice<HL7SegmentSlice>,
        ParseResult<TSchema>
        where TSchema : HL7Entity
    {
        readonly TextCursor _cursor;

        public HL7ParseResult(ISchema<TSchema> schema, IEntityParser<TSchema> parser, HL7ParserSettings settings, TextCursor cursor)
            : base(settings, cursor.InputText, cursor.CurrentSpan, new LineTextParser())
        {
            Schema = schema;
            Parser = parser;
            _cursor = cursor;
        }

        protected override HL7SegmentSlice CreateSlice(ParseText text, TextSpan span)
        {
            return new HL7SegmentSlice(Settings, text, span);
        }

        public bool TryGetEntity<T>(int index, out T entity)
            where T : TSchema
        {
            if (TryGetSlice(index, out TextSlice slice))
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