namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BSIMap :
        X12SegmentMap<BSI, X12Entity>
    {
        public BSIMap()
        {
            Id = "BSI";
            Name = "Beginning Segment for Order Status Inquiry";
            
            Value(x => x.ReferenceIdentification, 1, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.Date, 2, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.OrderOrItemCode, 3, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ProductOrDateCode, 4, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationCode, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Time, 6, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.TransactionSetPurposeCode, 7, x => x.FixedLength(2));
            Value(x => x.TransactionTypeCode, 8, x => x.FixedLength(2));
            Value(x => x.ActionCode, 9, x => x.MinLength(1).MaxLength(2));
        }
    }
}