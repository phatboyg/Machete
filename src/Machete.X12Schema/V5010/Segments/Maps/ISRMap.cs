namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class ISRMap :
        X12SegmentMap<ISR, X12Entity>
    {
        public ISRMap()
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