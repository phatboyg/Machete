namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BIGMap :
        X12SegmentMap<BIG, X12Entity>
    {
        public BIGMap()
        {
            Id = "BIG";
            Name = "Beginning Segment for Invoice";
            
            Value(x => x.Date1, 1, x =>
            {
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.InvoiceNumber1, 2, x => x.MinLength(1).MaxLength(22).IsRequired());
            Value(x => x.Date2, 3, x => x.Converter = X12ValueConverters.VariableDate);
            Value(x => x.PurchaseOrderNumber, 4, x => x.MinLength(1).MaxLength(22));
            Value(x => x.ReleaseNumber, 5, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ChangeOrderSequenceNumber, 6, x => x.MinLength(1).MaxLength(8));
            Value(x => x.TransactionTypeCode, 7, x => x.FixedLength(2));
            Value(x => x.TransactionSetPurposeCode, 8, x => x.FixedLength(2));
            Value(x => x.ActionCode, 9, x => x.MinLength(1).MaxLength(2));
            Value(x => x.InvoiceNumber2, 10, x => x.MinLength(1).MaxLength(22));
            Value(x => x.HierarchicalStructureCode, 11, x => x.FixedLength(4));
        }
    }
}