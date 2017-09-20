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

        public HL7ParseResult(ISchema<TSchema> schema, HL7ParserSettings settings, TextCursor cursor)
            : base(settings, cursor.InputText, cursor.CurrentSpan, new LineParser())
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
        public StreamText RemainingText => _cursor.InputText;
        public TextSpan RemainingSpan => _cursor.NextSpan;
    }
}