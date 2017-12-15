namespace Machete.HL7
{
    using Formatters;
    using Machete.SchemaConfiguration;
    using TypeSelectors;


    public class HL7SegmentMap<TSegment, TSchema> :
        HL7EntityMap<TSegment, TSchema>
        where TSegment : TSchema, HL7Segment
        where TSchema : HL7Entity
    {
        protected HL7SegmentMap()
        {
            Value(x => x.SegmentId, 0, x =>
            {
                x.Required = true;
                x.MaxLength = 10;
            });

            IEntityConfigurator<TSegment, TSchema> entityConfigurator = this;

            entityConfigurator.FormatterFactory = formatters => new HL7SegmentFormatter<TSegment, TSchema>(formatters);
        }

        protected string Id
        {
            set
            {
                EntitySelector = new TrieValueEntitySelector(0, value);

                Init(x => x.SegmentId, value);
            }
        }
    }
}