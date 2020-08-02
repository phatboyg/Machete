namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W76Map :
        X12SegmentMap<W76, X12Entity>
    {
        public W76Map()
        {
            Id = "W76";
            Name = "Total Shipping Order";
            
            Value(x => x.Quantity, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.Weight, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisOfMeasurementCode1, 3, x => x.FixedLength(2));
            Value(x => x.Volume, 4, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisOfMeasurementCode2, 5, x => x.FixedLength(2));
            Value(x => x.OrderSizingFactor, 6, x => x.MinLength(1).MaxLength(10));
        }
    }
}