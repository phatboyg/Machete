namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2200D_277Map :
        X12LayoutMap<Loop2200D_277, X12Entity>
    {
        public Loop2200D_277Map()
        {
            Id = "Loop_2200D_277";
            Name = "Payer Claim Control Number";
            
            Segment(x => x.PayerClaimControlNumber, 0);
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
            Layout(x => x.Loop2210D, 8);
            Layout(x => x.Loop2220D, 9);
        }
    }
}