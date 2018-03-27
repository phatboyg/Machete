namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CR6Map :
        X12SegmentMap<CR6, X12Entity>
    {
        public CR6Map()
        {
            Id = "CR6";
            Name = "Home Health Care Certification";
            
            Value(x => x.Prognosis, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.ServiceFromDate, 2, x => x.LongDate().IsRequired());
            Value(x => x.QualifierCertPeriod, 3, x => x.MinLength(2).MaxLength(3));
            // TODO qualifier 3
            Value(x => x.CertificationPeriod, 4);
            Value(x => x.DiagnosisDate, 5, x => x.LongDate().IsRequired());
            Value(x => x.SkilledNursingFacilityIndicator, 6, x => x.FixedLength(1).IsRequired());
            Value(x => x.MedicareCoveredIndicator, 7, x => x.FixedLength(1).IsRequired());
            Value(x => x.CertificationType, 8, x => x.FixedLength(1).IsRequired());
            Value(x => x.SurgeryDate, 9, x => x.LongDate());
            Value(x => x.SurgicalProcedureQualifier, 10, x => x.MinLength(1).MaxLength(2));
            // TODO qualifier 10
            Value(x => x.SurgicalProcedureCode, 11, x => x.MinLength(1).MaxLength(15));
            Value(x => x.PhysOrderDate, 12, x => x.LongDate());
            Value(x => x.LastVisitDate, 13, x => x.LongDate());
            Value(x => x.PhysContactDate, 14, x => x.LongDate());
            Value(x => x.AdmissionPeriodQualifier, 15, x => x.MinLength(2).MaxLength(3));
            // TODO qualifier 15
            Value(x => x.AdmissionPeriod, 16);
            Value(x => x.TypeOfFacility, 17, x => x.FixedLength(1).IsRequired());
            Value(x => x.SecondaryDiagnosisDate1, 18, x => x.LongDate());
            Value(x => x.SecondaryDiagnosisDate2, 19, x => x.LongDate());
            Value(x => x.SecondaryDiagnosisDate3, 20, x => x.LongDate());
            Value(x => x.SecondaryDiagnosisDate4, 21, x => x.LongDate());
        }
    }
}