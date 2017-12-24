namespace Machete.HL7.Tests.TestSchema
{
    public class NTESegmentMap :
        HL7SegmentMap<NTESegment, HL7Entity>
    {
        public NTESegmentMap()
        {
            Id = "NTE";

            Name = "Notes and Comments";

            Value(x => x.SetId, 1);
            Value(x => x.SourceOfComment, 2);
//            Value(x => x.Comment, 3);
        }
    }
}