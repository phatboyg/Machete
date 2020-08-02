namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class BNXMap :
        X12SegmentMap<BNX, X12Entity>
    {
        public BNXMap()
        {
            Id = "BNX";
            Name = "Rail Shipment Information";
            
            Value(x => x.ShipmentWeightCode, 1, x => x.FixedLength(1));
            Value(x => x.ReferencedPatternIdentifier, 2, x => x.MinLength(1).MaxLength(13));
            Value(x => x.BillingCode, 3, x => x.FixedLength(1));
            Value(x => x.RepetitivePatternNumber, 4, x => x.FixedLength(5));
        }
    }
}