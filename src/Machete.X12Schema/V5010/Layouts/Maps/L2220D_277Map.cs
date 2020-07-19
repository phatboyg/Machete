namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2220D_277Map :
        X12LayoutMap<L2220D_277, X12Entity>
    {
        public L2220D_277Map()
        {
            Id = "2220D";
            Name = "Service Line Information";
            
            Segment(x => x.Information, 0);
            Segment(x => x.StatusInformation, 1, x => x.IsRequired());
            Segment(x => x.ItemIdentification, 2,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("FJ")));
            Segment(x => x.PharmacyPrescriptionNumber, 3,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("XZ")));
            Segment(x => x.Date, 4, x => x.IsRequired());
        }
    }
}