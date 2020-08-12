namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class L10Map :
        X12SegmentMap<L10, X12Entity>
    {
        public L10Map()
        {
            Id = "L10";
            Name = "Weight Information";
            
            Value(x => x.Weight, 1, x => x.MinLength(1).MaxLength(10).IsRequired());
            Value(x => x.WeightQualifier, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.WeightUnitCode, 3, x => x.FixedLength(1));
        }
    }
}