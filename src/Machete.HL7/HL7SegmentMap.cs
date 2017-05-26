namespace Machete.HL7
{
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

            Set(x => x.IsEmpty, IsSegmentEmpty);

            Set(x => x.Fields, EmptyFields);
        }

        protected string Id
        {
            set { EntityTypeSelector = new TrieValueEntityTypeSelector(0, value); }
        }

        static bool IsSegmentEmpty(TextSlice slice)
        {
            TextSlice nextSlice;
            return !slice.TryGetSlice(1, out nextSlice);
        }

        static ValueArray<string> EmptyFields(TextSlice slice)
        {
            return ValueArray.Empty<string>();
        }
    }
}