namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class NM1Map : X12SegmentMap<NM1, X12Entity>
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
            Value(x => x.NameSuffix, 7, x => x.MinLength(1).MaxLength(10));
            Value(x => x.IdCodeQualifier, 8, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdCode, 9, x => x.MinLength(2).MaxLength(80));
        }
    }
}