namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2200D_277ACKMap :
        X12LayoutMap<L2200D_277ACK, X12Entity>
    {
        public L2200D_277ACKMap()
        {
            Id = "2200D";
            Name = "Claim Status Tracking Number";
            
            Segment(x => x.TrackingNumber, 0, x => x.IsRequired());
            Segment(x => x.StatusInformation, 1, x => x.IsRequired());
            Segment(x => x.PayerClaimControlNumber, 2);
            Segment(x => x.ClaimIdentifierNumberForClearinghouseAndOtherTransmissionIternmediaries, 3);
            Segment(x => x.InstitutionalBillTypeIdentification, 4);
            Segment(x => x.ClaimLevelServiceDate, 5);
            Layout(x => x.ServiceLineInformation, 6, x => x.IsRequired());
        }
    }
}