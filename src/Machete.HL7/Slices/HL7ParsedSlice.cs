namespace Machete.HL7.Slices
{
    using Machete.Parsers;
    using Machete.Parsers.TextParsers;
    using Texts;


    public class HL7ParsedSlice<TSchema> :
        HL7Slice<HL7SegmentSlice>,
        ParsedResult<TSchema>
        where TSchema : HL7Entity
    {
        readonly ISchema<TSchema> _schema;
        readonly TextCursor _cursor;

        public HL7ParsedSlice(ISchema<TSchema> schema, HL7Settings settings, TextCursor cursor)
            : base(settings, cursor.SourceText, cursor.Span, new LineParser())
        {
            _schema = schema;
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
                return _schema.TryMapEntity(slice, out entity);
            }

            entity = default(T);
            return false;
        }

        public StreamText RemainingText => _cursor.SourceText;
        public TextSpan RemainingSpan => _cursor.RemainingSpan;
    }
}