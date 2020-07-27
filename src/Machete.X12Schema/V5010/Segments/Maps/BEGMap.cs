namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BEGMap :
        X12SegmentMap<BEG, X12Entity>
    {
        public BEGMap()
        {
            Id = "BEG";
            Name = "Beginning Segment for Purchase Order";
            
            Value(x => x.TransactionSetPurposeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.PurchaseOrderTypeCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.PurchaseOrderNumber, 3, x => x.MinLength(1).MaxLength(22).IsRequired());
            Value(x => x.ReleaseNumber, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Date, 5, x =>
            {
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ContractNumber, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.AcknowledgementType, 7, x => x.FixedLength(2));
            Value(x => x.InvoiceTypeCode, 8, x => x.FixedLength(3));
            Value(x => x.ContractTypeCode, 9, x => x.FixedLength(2));
            Value(x => x.PurchaseCategory, 10, x => x.FixedLength(2));
            Value(x => x.SecurityLevelCode, 11, x => x.FixedLength(2));
            Value(x => x.TransactionTypeCode, 12, x => x.FixedLength(2));
        }
    }
}