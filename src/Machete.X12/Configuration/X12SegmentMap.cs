namespace Machete.X12.Configuration
{
    using Formatters;
    using Machete.SchemaConfiguration;
    using TypeSelectors;


    public class X12SegmentMap<TSegment, TSchema> :
        X12EntityMap<TSegment, TSchema>
        where TSegment : TSchema, X12Segment
        where TSchema : X12Entity
    {
        protected X12SegmentMap()
        {
            Value(x => x.SegmentId, 0, x =>
            {
                x.Required = true;
                x.MaxLength = 10;
            });

            IEntityConfigurator<TSegment, TSchema> entityConfigurator = this;

            entityConfigurator.FormatterFactory = formatters => new X12SegmentFormatter<TSegment, TSchema>(formatters);
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