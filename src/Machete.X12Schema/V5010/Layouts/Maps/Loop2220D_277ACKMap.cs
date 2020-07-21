namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2220D_277ACKMap :
        X12LayoutMap<Loop2220D_277ACK, X12Entity>
    {
        public Loop2220D_277ACKMap()
        {
            Id = "Loop_2220D_277_ACK";
            Name = "Service Line Information";
            
            Segment(x => x.Information, 0);
            Segment(x => x.LevelStatusInformation, 1);
            Segment(x => x.ItemIdentification, 2,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("FJ")));
            Segment(x => x.PharmacyPrescriptionNumber, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("XZ")));
            Segment(x => x.Date, 5);
        }
    }
}