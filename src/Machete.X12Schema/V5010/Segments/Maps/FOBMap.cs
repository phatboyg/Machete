namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class FOBMap :
        X12SegmentMap<FOB, X12Entity>
    {
        public FOBMap()
        {
            Id = "FOB";
            Name = "Free On Board Related Instructions";
            
            Value(x => x.ShipmentMethodOfPayment, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.LocationQualifier1, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Description1, 3, x => x.MinLength(1).MaxLength(80));
            Value(x => x.TransportationTermsQualifierCode, 4, x => x.FixedLength(2));
            Value(x => x.TransportationTermsCode, 5, x => x.FixedLength(3));
            Value(x => x.LocationQualifier2, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Description2, 7, x => x.MinLength(1).MaxLength(80));
            Value(x => x.RiskOfLossCode, 8, x => x.FixedLength(2));
            Value(x => x.Description3, 9, x => x.MinLength(1).MaxLength(80));
        }
    }
}