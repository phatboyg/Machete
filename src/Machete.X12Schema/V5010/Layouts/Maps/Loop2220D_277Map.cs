namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2220D_277Map :
        X12LayoutMap<Loop2220D_277, X12Entity>
    {
        public Loop2220D_277Map()
        {
            Id = "Loop_2220D_277";
            Name = "Service Line Information";
            
            Segment(x => x.ServiceLineInformation, 0);
            Segment(x => x.StatusInformation, 1);
            Segment(x => x.ItemIdentification, 2,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("FJ")));
            Segment(x => x.PharmacyPrescriptionNumber, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("XZ")));
            Segment(x => x.Date, 4);
        }
    }
}