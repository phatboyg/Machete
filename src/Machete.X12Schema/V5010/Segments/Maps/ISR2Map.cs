namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class ISR2Map :
        X12SegmentMap<ISR2, X12Entity>
    {
        public ISR2Map()
        {
            Id = "ISR";
            Name = "Item Status Report";
            
            Value(x => x.ShipmentOrOrderStatusCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Date, 2, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.StatusReasonCode, 4, x => x.FixedLength(3));
        }
    }
}