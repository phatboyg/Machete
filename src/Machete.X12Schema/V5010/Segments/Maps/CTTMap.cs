namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class CTTMap :
        X12SegmentMap<CTT, X12Entity>
    {
        public CTTMap()
        {
            Id = "CTT";
            Name = "Transaction Totals";
            
            Value(x => x.NumberOfLineItems, 1, x => x.MinLength(1).MaxLength(6).IsRequired());
            Value(x => x.HashTotal, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.Weight, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode1, 4, x => x.FixedLength(2));
            Value(x => x.Volume, 5, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode2, 6, x => x.FixedLength(2));
            Value(x => x.Description, 7, x => x.MinLength(1).MaxLength(80));
        }
    }
}