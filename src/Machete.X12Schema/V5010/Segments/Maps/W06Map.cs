namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class W06Map :
        X12SegmentMap<W06, X12Entity>
    {
        public W06Map()
        {
            Id = "W06";
            Name = "Warehouse Shipment Identification";
            
            Value(x => x.ReportingCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.DepositorOrderNumber, 2, x => x.MinLength(1).MaxLength(22));
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ShipmentIdentificationNumber, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.AgentShipmentIdNumber, 5, x => x.MinLength(1).MaxLength(12));
            Value(x => x.PurchaseOrderNumber, 6, x => x.MinLength(1).MaxLength(22));
            Value(x => x.MasterReferenceNumber, 7, x => x.MinLength(1).MaxLength(22));
            Value(x => x.LinkSequenceNumber, 8, x => x.FixedLength(6));
            Value(x => x.SpecialHandlingCode, 9, x => x.FixedLength(2));
            Value(x => x.ShippingDateChangeReasonCode, 10, x => x.MinLength(2).MaxLength(3));
            Value(x => x.TransactionTypeCode, 11, x => x.FixedLength(2));
            Value(x => x.ActionCode, 12, x => x.FixedLength(2));
        }
    }
}