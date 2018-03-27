namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2220D_277ACKMap :
        X12LayoutMap<L2220D_277ACK, X12Entity>
    {
        public L2220D_277ACKMap()
        {
            Id = "2220D";
            Name = "Service Line Information";
            
            Segment(x => x.Information, 0);
            Segment(x => x.LevelStatusInformation, 1, x => x.IsRequired());
            Segment(x => x.ItemIdentification, 2, x => x.IsRequired());
            Segment(x => x.PharmacyPrescriptionNumber, 3);
            Segment(x => x.InstitutionalBillTypeIdentification, 4);
            Segment(x => x.Date, 5);
        }
    }
}