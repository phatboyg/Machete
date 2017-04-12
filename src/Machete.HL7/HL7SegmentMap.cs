namespace Machete.HL7
{
    using TypeSelectors;


    public class HL7SegmentMap<TSegment, TSegmentSchema> :
        HL7EntityMap<TSegment>
        where TSegment : TSegmentSchema
        where TSegmentSchema : HL7Segment
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