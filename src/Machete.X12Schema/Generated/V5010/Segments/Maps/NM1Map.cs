namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class NM1Map :
        X12SegmentMap<NM1, X12Entity>
    {
        public NM1Map()
        {
            Id = "NM1";
            Name = "Individual Or Organizational Name";
            
            Value(x => x.EntityIdCode, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.EntityTypeQualifier, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.LastNameOrOrganizationName, 3, x => x.MinLength(1).MaxLength(35));
            Value(x => x.FirstName, 4, x => x.MinLength(1).MaxLength(25));
            Value(x => x.MiddleName, 5, x => x.MinLength(1).MaxLength(25));
            Value(x => x.NameSuffix, 6, x => x.MinLength(1).MaxLength(10));
            Value(x => x.IdCodeQualifier, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdCode, 8, x => x.MinLength(2).MaxLength(80));
        }
    }
}