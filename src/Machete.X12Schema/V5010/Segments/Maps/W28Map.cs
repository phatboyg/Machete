namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W28Map :
        X12SegmentMap<W28, X12Entity>
    {
        public W28Map()
        {
            Id = "W28";
            Name = "Consolidation Information";
            
            Value(x => x.ConsolidationCode, 1, x => x.FixedLength(1));
            Value(x => x.Weight, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.WeightUnitCode, 4, x => x.FixedLength(1));
            Value(x => x.TotalStopOffs, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.LocationQualifier, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.BillOfLadingOrWaybillNumber, 8, x => x.MinLength(1).MaxLength(25));
        }
    }
}