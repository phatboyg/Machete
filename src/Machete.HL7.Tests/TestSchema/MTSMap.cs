namespace Machete.HL7.Tests.TestSchema
{
    public class MTSMap :
        HL7SegmentMap<MTS, HL7Entity>
    {
        public MTSMap()
        {
            Id = "MTS";
            
            Value(x => x.Field1, 1, x => x.IsRequired());
        }
    }
}