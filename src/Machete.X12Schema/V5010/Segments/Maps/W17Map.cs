namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class W17Map :
        X12SegmentMap<W17, X12Entity>
    {
        public W17Map()
        {
            Id = "W17";
            Name = "Warehouse Receipt Identification";
            
            Value(x => x.ReportingCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.Date, 2, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.WarehouseReceiptNumber, 3, x => x.MinLength(1).MaxLength(12).IsRequired());
            Value(x => x.DepositorOrderNumber, 4, x => x.MinLength(1).MaxLength(22));
            Value(x => x.ShipmentIdentificationNumber, 5, x => x.MinLength(1).MaxLength(30));
            Value(x => x.TimeQualifier, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Time, 7, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.MasterReferenceNumber, 8, x => x.MinLength(1).MaxLength(22));
            Value(x => x.LinkSequenceNumber, 9, x => x.FixedLength(6));
        }
    }
}