namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BAKMap :
        X12SegmentMap<BAK, X12Entity>
    {
        public BAKMap()
        {
            Id = "BAK";
            Name = "Beginning Segment for Purchase Order Acknowledgment";
            
            Value(x => x.TransactionSetPurposeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.AcknowledgementType, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.PurchaseOrderNumber, 3, x => x.MinLength(1).MaxLength(22).IsRequired());
            Value(x => x.Date1, 4, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ReleaseNumber, 5, x => x.MinLength(1).MaxLength(30));
            Value(x => x.RequestReferenceNumber, 6, x => x.MinLength(1).MaxLength(45));
            Value(x => x.ContractNumber, 7, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ReferenceIdentification, 8, x => x.MinLength(1).MaxLength(50));
            Value(x => x.Date2, 9, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.TransactionTypeCode, 10, x => x.FixedLength(2));
        }
    }
}