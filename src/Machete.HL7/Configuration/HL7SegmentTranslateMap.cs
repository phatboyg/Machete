namespace Machete.HL7
{
    public abstract class HL7SegmentTranslateMap<TResult, TInput, TSchema> :
        HL7EntityTranslateMap<TResult, TInput, TSchema>
        where TSchema : HL7Entity
        where TInput : TSchema, HL7Segment
        where TResult : TSchema, HL7Segment
    {
        protected HL7SegmentTranslateMap()
        {
            Exclude(x => x.SegmentId);
        }
    }
}