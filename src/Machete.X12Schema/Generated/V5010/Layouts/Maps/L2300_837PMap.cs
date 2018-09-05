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
            Segment(x => x.OnsetOfCurrentIllnessDate, 1,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("431")));
            Segment(x => x.InitialTreatmentDate, 2,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("454")));
            Segment(x => x.LastSeenDate, 3,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("304")));
            Segment(x => x.AcuteManifestationDate, 4,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("453")));
            Segment(x => x.AccidentDate, 5,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("439")));
            Segment(x => x.LastMensrualPeriod, 6,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("484")));
            Segment(x => x.LastXRayDate, 7,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("455")));
            Segment(x => x.HearingVisionPrescriptionDate, 8,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("471")));
            Segment(x => x.DisabilityDates, 9,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("314") ||
                                                               p.DateTimeQualifier.IsEqualTo("360") ||
                                                               p.DateTimeQualifier.IsEqualTo("361")));
            Segment(x => x.LastWorkedDate, 10,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("297")));
            Segment(x => x.AuthorizedReturnToWork, 11,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("296")));
            Segment(x => x.AdmissionDate, 12,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("435")));
            Segment(x => x.DischargeDate, 13,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("096")));
            Segment(x => x.AssumedRelinquishedCareDates, 14,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("090")));
            Segment(x => x.PropertyAndCasualtyDateOfFirstContact, 15,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("444")));
            Segment(x => x.RepricerReceivedDate, 16,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("050")));
            Segment(x => x.ClaimSupplementalInfo, 17);
            Segment(x => x.ContractInfo, 18);
            Segment(x => x.PatientAmountPaid, 19);
            Segment(x => x.ServiceAuthorizationExceptionCode, 20,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("4N")));
            Segment(x => x.MandatoryMedicareCrossoverIndicator, 21,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("F5")));
            Segment(x => x.MammographyCertificationNumber, 22,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("EW")));
            Segment(x => x.ReferralNumber, 23,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9F")));
            Segment(x => x.PriorAuthorization, 24,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G1")));
            Segment(x => x.PayerClaimControlNumber, 25,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("F8")));
            Segment(x => x.CLIANumber, 26,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("X4")));
            Segment(x => x.RepricedClaimNumber, 27,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9A")));
            Segment(x => x.AdjustedRepricedClaimNumber, 28,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9C")));
            Segment(x => x.InvestigationalDeviceExemptionNumber, 29,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("LX")));
            Segment(x => x.ClaimIdentifierForTransmissionIntermediaries, 30,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("D9")));
            Segment(x => x.MedicalRecordNumber, 31,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("EA")));
            Segment(x => x.DemonstrationProjectIdentifier, 32,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("P4")));
            Segment(x => x.CarePlanOversight, 33,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("1J")));
            Segment(x => x.FileInfo, 34);
            Segment(x => x.ClaimNote, 35);
            Segment(x => x.AmbulanceTransportInfo, 36);
            Segment(x => x.SpinalManipulationServiceInfo, 37);
            Segment(x => x.AmbulanceCertification, 38,
                x => x.Condition = parser => parser.Where(p => p.CodeCategory.IsEqualTo("07")));
            Segment(x => x.PatientConditionInfo, 39,
                x => x.Condition = parser => parser.Where(p => p.CodeCategory.IsEqualTo("E1") ||
                                                               p.CodeCategory.IsEqualTo("E2") ||
                                                               p.CodeCategory.IsEqualTo("E3")));
            Segment(x => x.HomeboundIndicator, 40,
                x => x.Condition = parser => parser.Where(p => p.CodeCategory.IsEqualTo("75")));
            Segment(x => x.EPSDTReferral, 41,
                x => x.Condition = parser => parser.Where(p => p.CodeCategory.IsEqualTo("ZZ")));
            Segment(x => x.HealthCareDiagnosisCode, 42,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("ABK") ||
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BK")));
            Segment(x => x.AnesthesiaRelatedProcedure, 43,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BP")));
            Segment(x => x.ConditionInfo, 44,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BG")));
            Segment(x => x.ClaimPricingOrRepricingInfo, 45);
            Layout(x => x.ReferringProvider, 46);
            Layout(x => x.RenderingProvider, 47);
            Layout(x => x.ServiceFacilityLocation, 48);
            Layout(x => x.SupervisingProvider, 49);
            Layout(x => x.AmbulancePickUpLocation, 50);
            Layout(x => x.AmbulanceDropOffLocation, 51);
            Layout(x => x.OtherSubscriberInfo, 52);
            Layout(x => x.ServiceLineNumber, 53);
        }
    }
}