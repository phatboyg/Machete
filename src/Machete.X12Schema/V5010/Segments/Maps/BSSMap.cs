namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BSSMap :
        X12SegmentMap<BSS, X12Entity>
    {
        public BSSMap()
        {
            Id = "BSS";
            Name = "Beginning Segment for Shipping Schedule/Production Sequence";
            
            Value(x => x.TransactionSetPurposeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReferenceIdentification1, 2, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.Date1, 3, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ScheduleTypeQualifier1, 4, x => x.FixedLength(2).IsRequired());
            Value(x => x.Date2, 5, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date3, 6, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ReleaseNumber, 7, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ReferenceIdentification2, 8, x => x.MinLength(1).MaxLength(50));
            Value(x => x.ContractNumber, 9, x => x.MinLength(1).MaxLength(30));
            Value(x => x.PurchaseOrderNumber, 10, x => x.MinLength(1).MaxLength(22));
            Value(x => x.ScheduleTypeQualifier2, 11, x => x.FixedLength(2));
        }
    }
}