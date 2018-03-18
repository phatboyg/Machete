namespace Machete.X12Schema.V5010.Layouts.Maps
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
            Segment(x => x.AccidentDate, 1);
            Segment(x => x.AppliancePlacementDate, 2);
            Segment(x => x.ServiceDate, 3);
            Segment(x => x.RepricerReceivedDate, 4);
            Segment(x => x.OrthodonticTotalMonthsOfTretment, 5);
            Segment(x => x.ToothStatus, 6);
            Segment(x => x.ClaimSupplementalInformation, 7);
            Segment(x => x.ContractInformation, 8);
            Segment(x => x.PatientAmountPaid, 9);
            Segment(x => x.PredeterminationIdentification, 10);
            Segment(x => x.ServiceAuthorizationExceptionCode, 11);
            Segment(x => x.PayerClaimControlNumber, 12);
            Segment(x => x.ReferralNumber, 13);
            Segment(x => x.PriorAuthorization, 14);
            Segment(x => x.RepricedClaimNumber, 15);
            Segment(x => x.AdjustedRepricedClaimNumber, 16);
            Segment(x => x.ClaimIdentifierForTransmissionIntermediaries, 17);
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