namespace Machete.HL7
{
    public abstract class HL7SegmentCreation<TSegment, TSchema> :
        HL7EntityCreation<TSegment, TSchema>
        where TSchema : HL7Entity
        where TSegment : TSchema, HL7Segment
    {
    }
}