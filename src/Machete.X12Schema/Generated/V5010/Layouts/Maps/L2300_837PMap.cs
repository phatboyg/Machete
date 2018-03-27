namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2300_837PMap :
        X12LayoutMap<L2300_837P, X12Entity>
    {
        public L2300_837PMap()
        {
            Id = "2300";
            Name = "Claim Information";
            
            Segment(x => x.ClaimInformation, 0, x => x.IsRequired());
            Segment(x => x.OnsetOfCurrentIllnessDate, 1);
            Segment(x => x.InitialTreatmentDate, 2);
            Segment(x => x.LastSeenDate, 3);
            Segment(x => x.AcuteManifestationDate, 4);
            Segment(x => x.AccidentDate, 5);
            Segment(x => x.LastMensrualPeriod, 6);
            Segment(x => x.LastXRayDate, 7);
            Segment(x => x.HearingVisionPrescriptionDate, 8);
            Segment(x => x.DisabilityDates, 9);
            Segment(x => x.LastWorkedDate, 10);
            Segment(x => x.AuthorizedReturnToWork, 11);
            Segment(x => x.AdmissionDate, 12);
            Segment(x => x.DischargeDate, 13);
            Segment(x => x.AssumedRelinquishedCareDates, 14);
            Segment(x => x.PropertyAndCasaultyDateOfFirstContact, 15);
            Segment(x => x.RepricerReceivedDate, 16);
            Segment(x => x.ClaimSupplementalInfo, 17);
            Segment(x => x.ContractInfo, 18);
            Segment(x => x.PatientAmountPaid, 19);
            Segment(x => x.ServiceAuthorizationExceptionCode, 20);
            Segment(x => x.MandatoryMedicareCrossoverIndicator, 21);
            Segment(x => x.MammographyCertificationNumber, 22);
            Segment(x => x.ReferralNumber, 23);
            Segment(x => x.PriorAuthorization, 24);
            Segment(x => x.PayerClaimControlNumber, 25);
            Segment(x => x.CLIANumber, 26);
            Segment(x => x.RepricedClaimNumber, 27);
            Segment(x => x.AdjustedRepricedClaimNumber, 28);
            Segment(x => x.InvestigationalDeviceExemptionNumber, 29);
            Segment(x => x.ClaimIdentifierForTransmissionIntermediaries, 30);
            Segment(x => x.MedicalRecordNumber, 31);
            Segment(x => x.DemonstrationProjectIdentifier, 32);
            Segment(x => x.CarePlanOversight, 33);
            Segment(x => x.FileInfo, 34);
            Segment(x => x.ClaimNote, 35);
            Segment(x => x.AmbulanceTransportInfo, 36);
            Segment(x => x.SpinalManipulationServiceInfo, 37);
            Segment(x => x.AmbulanceCertification, 38);
            Segment(x => x.PatientConditionInfo, 39);
            Segment(x => x.HomeboundIndicator, 40);
            Segment(x => x.EPSDTReferral, 41);
            Segment(x => x.HealthCareDiagnosisCode, 42);
            Segment(x => x.AnesthesiaRelatedProcedure, 43);
            Segment(x => x.ConditionInfo, 44);
            Segment(x => x.ClaimPricingOrRepricingInfo, 45);
            Layout(x => x.ReferringProvider, 46);
            Layout(x => x.RenderingProvider, 47);
            Layout(x => x.SerivceFacilityLocation, 48);
            Layout(x => x.SupervisingProvider, 49);
            Layout(x => x.AmbulancePickUpLocation, 50);
            Layout(x => x.AmbulanceDropOffLocation, 51);
            Layout(x => x.OtherSubscriberInfo, 52);
            Layout(x => x.ServiceLineNumber, 53);
        }
    }
}