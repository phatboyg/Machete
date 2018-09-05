namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2300_837DMap :
        X12LayoutMap<L2300_837D, X12Entity>
    {
        public L2300_837DMap()
        {
            Id = "2300";
            Name = "Claim Information";
            
            Segment(x => x.ClaimInformation, 0, x => x.IsRequired());
            Segment(x => x.AccidentDate, 1,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("439")));
            Segment(x => x.AppliancePlacementDate, 2,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("452")));
            Segment(x => x.ServiceDate, 3,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("472")));
            Segment(x => x.RepricerReceivedDate, 4,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("050")));
            Segment(x => x.OrthodonticTotalMonthsOfTretment, 5);
            Segment(x => x.ToothStatus, 6);
            Segment(x => x.ClaimSupplementalInformation, 7);
            Segment(x => x.ContractInformation, 8);
            Segment(x => x.PatientAmountPaid, 9);
            Segment(x => x.PredeterminationIdentification, 10,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G3")));
            Segment(x => x.ServiceAuthorizationExceptionCode, 11,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("4N")));
            Segment(x => x.PayerClaimControlNumber, 12,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("F8")));
            Segment(x => x.ReferralNumber, 13,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9F")));
            Segment(x => x.PriorAuthorization, 14,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G1")));
            Segment(x => x.RepricedClaimNumber, 15,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9A")));
            Segment(x => x.AdjustedRepricedClaimNumber, 16,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9C")));
            Segment(x => x.ClaimIdentifierForTransmissionIntermediaries, 17,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("D9")));
            Segment(x => x.FileInformation, 18);
            Segment(x => x.ClaimNote, 19);
            Segment(x => x.HealthcareDiagnosisCode, 20);
            Segment(x => x.ClaimPricingOrRepricingInformation, 21);
            Layout(x => x.ReferringProvider, 22);
            Layout(x => x.RenderingProvider, 23);
            Layout(x => x.ServiceFacilityLocation, 24);
            Layout(x => x.AssistantSurgeon, 25);
            Layout(x => x.SupervisingProvider, 26);
            Layout(x => x.OtherSubscriberInformation, 27);
            Layout(x => x.ServiceLineNumber, 28);
        }
    }
}