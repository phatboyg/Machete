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
            Segment(x => x.PatientControlNumber, 2,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("EJ")));
            Segment(x => x.InstitutionalTypeOfBill, 3,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("BLT")));
            Segment(x => x.MedicalRecordIdentificationNumber, 4,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("EA")));
            Segment(x => x.ClaimIdentificationNumber, 5,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("D9")));
            Segment(x => x.ClaimServiceDate, 6,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("472")));
            Segment(x => x.ResponseDueDate, 7,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("106")));
            Layout(x => x.ClaimSupplementalInformation, 8);
            Layout(x => x.ServiceLineInformation, 9);
        }
    }
}