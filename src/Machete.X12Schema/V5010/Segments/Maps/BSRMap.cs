namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BSRMap :
        X12SegmentMap<BSR, X12Entity>
    {
        public BSRMap()
        {
            Id = "BSR";
            Name = "Beginning Segment for Order Status Report";
            
            Value(x => x.StatusReportCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.OrderOrItemCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ReferenceIdentification1, 3, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.Date1, 4, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ProductOrDateCode, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationCode, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Time1, 7, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.ReferenceIdentification2, 8, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.Date2, 9, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time2, 10, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.TransactionSetPurposeCode, 11, x => x.FixedLength(2));
            Value(x => x.ActionCode, 12, x => x.MinLength(1).MaxLength(2));
        }
    }
}