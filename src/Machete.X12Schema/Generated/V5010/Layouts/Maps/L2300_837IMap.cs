namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2300_837IMap :
        X12LayoutMap<L2300_837I, X12Entity>
    {
        public L2300_837IMap()
        {
            Id = "2300";
            Name = "Claim Information";
            
            Segment(x => x.ClaimInformation, 0, x => x.IsRequired());
            Segment(x => x.DischargeHour, 1);
            Segment(x => x.StatementDates, 2);
            Segment(x => x.AdmissionDateOrHour, 3);
            Segment(x => x.RepricerReceivedDate, 4);
            Segment(x => x.InstitutionalClaimCode, 5);
            Segment(x => x.ClaimSupplementalInformation, 6);
            Segment(x => x.ContractInformation, 7);
            Segment(x => x.PatientEstimatedAmountPaid, 8);
            Segment(x => x.ServiceAuthorizationExceptionCode, 9);
            Segment(x => x.ReferralNumber, 10);
            Segment(x => x.PriorAuthorization, 11);
            Segment(x => x.PayerClaimControlNumber, 12);
            Segment(x => x.RepricedClaimNumber, 13);
            Segment(x => x.AdjustedRepricedClaimNumber, 14);
            Segment(x => x.InvestigationalDeviceExemptionNumber, 15);
            Segment(x => x.ClaimIdentifierForTransmissionIntermediaries, 16);
            Segment(x => x.AutoAccidentState, 17);
            Segment(x => x.MedicalRecordNumber, 18);
            Segment(x => x.DemonstrationProjectIdentifier, 19);
            Segment(x => x.PeerReviewOrganizationApprovalNumber, 20);
            Segment(x => x.FileInformation, 21);
            Segment(x => x.ClaimNote, 22);
            Segment(x => x.BillingNote, 23);
            Segment(x => x.EPSDTReferral, 24);
            Segment(x => x.PrincipalDiagnosis, 25);
            Segment(x => x.AdmittingDiagnosis, 26);
            Segment(x => x.PatientReasonForVisit, 27);
            Segment(x => x.ExternalCauseOfInjury, 28);
            Segment(x => x.DiagnosisRelatedGroupInformation, 29);
            Segment(x => x.OtherDiagnosisInformation, 30);
            Segment(x => x.PrincipalProcedureInformation, 31);
            Segment(x => x.OtherProcedureInformation, 32);
            Segment(x => x.OccurenceSpanInformation, 33);
            Segment(x => x.OccurenceInformation, 34);
            Segment(x => x.ValueInformation, 35);
            Segment(x => x.ConditionInformation, 36);
            Segment(x => x.TreamentCodeInformation, 37);
            Segment(x => x.ClaimPricingOrRepricingInformation, 38);
            Layout(x => x.AttendingProvider, 39);
            Layout(x => x.OperatingPhysician, 40);
            Layout(x => x.OtherOperatingPhysician, 41);
            Layout(x => x.RenderingProvider, 42);
            Layout(x => x.ServiceFacilityLocation, 43);
            Layout(x => x.ReferringProvider, 44);
            Layout(x => x.OtherSubscriberInformation, 45);
            Layout(x => x.ServiceLineNumber, 46);
        }
    }
}