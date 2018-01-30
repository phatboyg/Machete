namespace Machete.X12Schema.V5010
{
    using System;
    using X12;

    
    public interface CR6 :
        X12Segment
    {
        Value<string> Prognosis { get; }

        Value<DateTime> ServiceFromDate { get; }

        Value<string> QualifierCertPeriod { get; }

        // TODO qualifier 3
        Value<DateTimePeriod> CertificationPeriod { get; }

        Value<DateTime> DiagnosisDate { get; }

        Value<string> SkilledNursingFacilityIndicator { get; }

        Value<string> MedicareCoveredIndicator { get; }

        Value<string> CertificationType { get; }

        Value<DateTime> SurgeryDate { get; }

        Value<string> SurgicalProcedureQualifier { get; }

        // TODO qualifier 10
        Value<string> SurgicalProcedureCode { get; }

        Value<DateTime> PhysOrderDate { get; }

        Value<DateTime> LastVisitDate { get; }

        Value<DateTime> PhysContactDate { get; }

        Value<string> AdmissionPeriodQualifier { get; }

        // TODO qualifier 15
        Value<DateTimePeriod> AdmissionPeriod { get; }

        Value<string> TypeOfFacility { get; }

        Value<DateTime> SecondaryDiagnosisDate1 { get; }

        Value<DateTime> SecondaryDiagnosisDate2 { get; }

        Value<DateTime> SecondaryDiagnosisDate3 { get; }

        Value<DateTime> SecondaryDiagnosisDate4 { get; }
    }
}