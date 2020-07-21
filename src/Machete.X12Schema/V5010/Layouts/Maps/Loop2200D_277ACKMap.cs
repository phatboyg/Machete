namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2200D_277ACKMap :
        X12LayoutMap<Loop2200D_277ACK, X12Entity>
    {
        public Loop2200D_277ACKMap()
        {
            Id = "Loop_2200D_277_ACK";
            Name = "Claim Status Tracking Number";
            
            Segment(x => x.TrackingNumber, 0);
            Segment(x => x.StatusInformation, 1);
            Segment(x => x.PayerClaimControlNumber, 2,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("1K")));
            Segment(x => x.ClaimIdNumberForClearinghouseAndOtherTransmissionIntermediaries, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("D9")));
            Segment(x => x.InstitutionalBillTypeIdentification, 4,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("BLT")));
            Segment(x => x.ClaimLevelServiceDate, 5);
            Layout(x => x.Loop2220D, 6);
        }
    }
}