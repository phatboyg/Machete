namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2200D_276Map :
        X12LayoutMap<L2200D_276, X12Entity>
    {
        public L2200D_276Map()
        {
            Id = "2200D";
            Name = "Claim Status Tracking Number";
            
            Segment(x => x.PayerClaimControlNumber, 0, x => x.IsRequired());
            Segment(x => x.PayerControlNumber, 1);
            Segment(x => x.InstitutionalTypeOfBill, 2);
            Segment(x => x.ApplicationOrLocationSystemIdentifier, 3);
            Segment(x => x.GroupNumber, 4);
            Segment(x => x.PatientControlNumber, 5);
            Segment(x => x.PharmacyPrescriptionNumber, 6);
            Segment(x => x.ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries, 7);
            Segment(x => x.ClaimSubmittedCharges, 8);
            Segment(x => x.ClaimServiceDate, 9);
            Layout(x => x.ServiceLineInformation, 10);
        }
    }
}