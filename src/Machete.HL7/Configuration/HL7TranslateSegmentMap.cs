namespace Machete.HL7
{
    public abstract class HL7TranslateSegmentMap<TResult, TInput, TSchema> :
        HL7TranslateEntityMap<TResult, TInput, TSchema>
        where TSchema : HL7Entity
        where TInput : TSchema, HL7Segment
        where TResult : TSchema, HL7Segment
    {
        protected HL7TranslateSegmentMap()
        {
            Exclude(x => x.SegmentId);
        }
    }
}