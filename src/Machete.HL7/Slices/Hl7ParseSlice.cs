namespace Machete.HL7.Slices
{
    using Machete.Parsers.TextParsers;
    using Texts;


    public class Hl7ParseSlice<TSchema> :
        HL7Slice<HL7SegmentSlice>,
        ParseResult<TSchema>
        where TSchema : HL7Entity
    {
        readonly TextCursor _cursor;

        public Hl7ParseSlice(ISchema<TSchema> schema, HL7Settings settings, TextCursor cursor)
            : base(settings, cursor.SourceText, cursor.Span, new LineParser())
        {
            Schema = schema;
            _cursor = cursor;
        }

        protected override HL7SegmentSlice CreateSlice(ParseText text, TextSpan span)
        {
            return new HL7SegmentSlice(Settings, text, span);
        }

        public bool TryGetEntity<T>(int index, out T entity)
            where T : TSchema
        {
            TextSlice slice;
            if (TryGetSlice(index, out slice))
            {
                return Schema.TryConvertEntity(slice, out entity);
            }

            entity = default(T);
            return false;
        }

        public ISchema<TSchema> Schema { get; }
        public StreamText RemainingText => _cursor.SourceText;
        public TextSpan RemainingSpan => _cursor.RemainingSpan;
    }
}