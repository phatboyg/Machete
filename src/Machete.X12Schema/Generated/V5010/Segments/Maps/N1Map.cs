namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class N1Map :
        X12SegmentMap<N1, X12Entity>
    {
        public N1Map()
        {
            Id = "N1";
            Name = "Name";
            
            Value(x => x.EntityIdCode, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.EntityName, 2, x => x.MinLength(1).MaxLength(60));
            Value(x => x.IdCodeQualifier, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdCode, 4, x => x.MinLength(2).MaxLength(80));
        }
    }
}