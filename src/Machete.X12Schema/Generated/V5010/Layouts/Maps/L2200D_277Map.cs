namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2200D_277Map :
        X12LayoutMap<L2200D_277, X12Entity>
    {
        public L2200D_277Map()
        {
            Id = "2200D";
            Name = "Payer Claim Control Number";
            
            Segment(x => x.PayerClaimControlNumber, 0, x => x.IsRequired());
            Segment(x => x.ClaimLevelStatusInformation, 1);
            Segment(x => x.PatientControlNumber, 2, x => x.IsRequired());
            Segment(x => x.InstitutionalTypeOfBill, 3);
            Segment(x => x.MedicalRecordIdentificationNumber, 4);
            Segment(x => x.ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries, 5);
            Segment(x => x.ClaimServiceDate, 6);
            Segment(x => x.ResponseDueDate, 7);
            Layout(x => x.ClaimSupplementalInformation, 8);
            Layout(x => x.ServiceLineInformation, 9, x => x.IsRequired());
        }
    }
}