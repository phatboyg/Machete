namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class R2Map :
        X12SegmentMap<R2, X12Entity>
    {
        public R2Map()
        {
            Id = "R2";
            Name = "Route Information";
            
            Value(x => x.StandardCarrierAlphaCode, 1, x => x.MinLength(2).MaxLength(4).IsRequired());
            Value(x => x.RoutingSequenceCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.CityName, 3, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StandardPointLocationCode, 4, x => x.MinLength(6).MaxLength(9));
            Value(x => x.IntermodalServiceCode, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.TransportationMethodOrTypeCode, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IntermediateSwitchCarrier1, 7, x => x.MinLength(2).MaxLength(4));
            Value(x => x.IntermediateSwitchCarrier2, 8, x => x.MinLength(2).MaxLength(4));
            Value(x => x.InvoiceNumber, 9, x => x.MinLength(1).MaxLength(22));
            Value(x => x.Date, 10, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.FreeformDescription, 11, x => x.MinLength(1).MaxLength(45));
            Value(x => x.TypeOfServiceCode, 12, x => x.FixedLength(2));
            Value(x => x.RouteDescription, 13, x => x.MinLength(1).MaxLength(35));
        }
    }
}