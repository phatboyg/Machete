namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HealthcareClaimStatusMap :
        X12ComponentMap<HealthcareClaimStatus, X12Entity>
    {
        public HealthcareClaimStatusMap()
        {
            Value(x => x.HealthcareClaimStatusCategoryCode1, 0, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.HealthcareClaimStatusCategoryCode2, 1, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.EntityIdentifierCode, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.CodeListQualifierCode, 3, x => x.MinLength(1).MaxLength(3));
        }
    }
}