namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class HSDMap :
        X12SegmentMap<HSD, X12Entity>
    {
        public HSDMap()
        {
            Id = "HSD";
            Name = "Health Care Services Delivery";
            
            Value(x => x.QuantityQualifier, 1, x => x.FixedLength(2));
            // TODO qualifier 1
            Value(x => x.Quantity, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.UnitBasisforMeasurementCode, 3, x => x.FixedLength(2));
            Value(x => x.SampleSelectionModulus, 4, x => x.MinLength(1).MaxLength(6));
            Value(x => x.TimePeriodQualifier, 5, x => x.MinLength(1).MaxLength(2));
            // TODO qualifier 5
            Value(x => x.Periods, 6, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ShipDeliveryCalendarPatternCode, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ShipDeliveryPatternTimeCode, 8, x => x.FixedLength(1));
        }
    }
}