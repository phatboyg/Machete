namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2300_837IMap :
        X12LayoutMap<Loop2300_837I, X12Entity>
    {
        public Loop2300_837IMap()
        {
            Id = "Loop_2300_837I";
            Name = "Claim Information";
            
            Segment(x => x.ClaimInformation, 0);
            Segment(x => x.DischargeHour, 1,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("096")));
            Segment(x => x.StatementDates, 2,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("434")));
            Segment(x => x.AdmissionDateOrHour, 3,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("435")));
            Segment(x => x.RepricerReceivedDate, 4,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("050")));
            Segment(x => x.InstitutionalClaimCode, 5);
            Segment(x => x.ClaimSupplementalInformation, 6);
            Segment(x => x.ContractInformation, 7);
            Segment(x => x.PatientEstimatedAmountPaid, 8);
            Segment(x => x.ServiceAuthorizationExceptionCode, 9,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("4N")));
            Segment(x => x.ReferralNumber, 10,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9F")));
            Segment(x => x.PriorAuthorization, 11,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G1")));
            Segment(x => x.PayerClaimControlNumber, 12,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("F8")));
            Segment(x => x.RepricedClaimNumber, 13,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9A")));
            Segment(x => x.AdjustedRepricedClaimNumber, 14,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("9C")));
            Segment(x => x.InvestigationalDeviceExemptionNumber, 15,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("LX")));
            Segment(x => x.ClaimIdentifierForTransmissionIntermediaries, 16,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("D9")));
            Segment(x => x.AutoAccidentState, 17,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
            Segment(x => x.MedicalRecordNumber, 18,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("EA")));
            Segment(x => x.DemonstrationProjectIdentifier, 19,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("P4")));
            Segment(x => x.PeerReviewOrganizationApprovalNumber, 20,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G4")));
            Segment(x => x.FileInformation, 21);
            Segment(x => x.ClaimNote, 22);
            Segment(x => x.BillingNote, 23);
            Segment(x => x.EPSDTReferral, 24);
            Segment(x => x.PrincipalDiagnosis, 25,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("ABK") ||
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BK")));
            Segment(x => x.AdmittingDiagnosis, 26,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("ABJ") ||
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BJ")));
            Segment(x => x.PatientReasonForVisit, 27,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("APR") ||
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("PR")));
            Segment(x => x.ExternalCauseOfInjury, 28,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("ABN") ||
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BN")));
            Segment(x => x.DiagnosisRelatedGroupInformation, 29,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("DR")));
            Segment(x => x.OtherDiagnosisInformation, 30,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("ABF") ||
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BF")));
            Segment(x => x.PrincipalProcedureInformation, 31,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BBR") ||
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BR") ||
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("CAH")));
            Segment(x => x.OtherProcedureInformation, 32,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BBQ") ||
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BQ")));
            Segment(x => x.OccurenceSpanInformation, 33,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BI")));
            Segment(x => x.OccurenceInformation, 34,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BH")));
            Segment(x => x.ValueInformation, 35,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BE")));
            Segment(x => x.ConditionInformation, 36,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("BG")));
            Segment(x => x.TreatmentCodeInformation, 37,
                x => x.Condition = parser => parser.Where(p =>
                    p.HealthCareCodeInformation1.Select(s => s.DiagnosisTypeCode).IsEqualTo("TC")));
            Segment(x => x.ClaimPricingOrRepricingInformation, 38);
            Layout(x => x.Loop2310A, 39);
            Layout(x => x.Loop2310B, 40);
            Layout(x => x.Loop2310C, 41);
            Layout(x => x.Loop2310D, 42);
            Layout(x => x.Loop2310E, 43);
            Layout(x => x.Loop2310F, 44);
            Layout(x => x.Loop2320, 45);
            Layout(x => x.Loop2400, 46);
        }
    }
}