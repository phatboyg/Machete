namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class REFMap : X12SegmentMap<REF, X12Entity>
    {
        public REFMap()
        {
            Id = "REF";
            Name = "Reference Identification";
            Value(x => x.Qualifier, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.Identifier, 2, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Description, 3, x => x.MinLength(1).MaxLength(80));
        }
    }
}