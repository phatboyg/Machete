namespace Machete.HL7.Tests.TestSchema
{
    public class PIDSegmentMap :
        HL7SegmentMap<PIDSegment, HL7Entity>
    {
        public PIDSegmentMap()
        {
            Id = "PID";

            Name = "Patient Identification";

            Value(x => x.SetId, 1);
            Entity(x => x.PatientId, 2);
            Entity(x => x.PatientIdentifierList, 3, x => x.IsRequired());
        }
    }
}