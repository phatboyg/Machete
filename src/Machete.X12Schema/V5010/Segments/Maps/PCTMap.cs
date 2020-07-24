namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PCTMap :
        X12SegmentMap<PCT, X12Entity>
    {
        public PCTMap()
        {
            Id = "PCT";
            Name = "Percent Amounts";
            
            Value(x => x.PercentQualifier, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Percent, 2, x => x.MinLength(1).MaxLength(10));
        }
    }
}