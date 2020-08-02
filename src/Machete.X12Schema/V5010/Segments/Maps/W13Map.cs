namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W13Map :
        X12SegmentMap<W13, X12Entity>
    {
        public W13Map()
        {
            Id = "W13";
            Name = "Item Detail Exception";
            
            Value(x => x.Quantity, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.UnitOrBasisOfMeasurementCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReceivingConditionCode, 3, x => x.FixedLength(2).IsRequired());
            Value(x => x.WarehouseLotNumber, 4, x => x.MinLength(1).MaxLength(12));
            Value(x => x.DamageReasonCode, 5, x => x.FixedLength(2));
        }
    }
}