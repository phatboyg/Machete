namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BCAMap :
        X12SegmentMap<BCA, X12Entity>
    {
        public BCAMap()
        {
            Id = "BCA";
            Name = "Beginning Segment for Purchase Order Change Acknowledgement";
            
            Value(x => x.TransactionSetPurposeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.AcknowledgementType, 2, x => x.FixedLength(2));
            Value(x => x.PurchaseOrderNumber, 3, x => x.MinLength(1).MaxLength(22).IsRequired());
            Value(x => x.ReleaseNumber, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ChangeOrderSequenceNumber, 5, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Date1, 6, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.RequestReferenceNumber, 7, x => x.MinLength(1).MaxLength(45));
            Value(x => x.ContractNumber, 8, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ReferenceIdentification, 9, x => x.MinLength(1).MaxLength(50));
            Value(x => x.Date2, 10, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date3, 11, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date4, 12, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.PurchaseOrderTypeCode, 13, x => x.FixedLength(2));
            Value(x => x.SecurityLevelCode, 14, x => x.FixedLength(2));
            Value(x => x.TransactionTypeCode, 15, x => x.FixedLength(2));
        }
    }
}