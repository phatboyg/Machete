namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BIAMap :
        X12SegmentMap<BIA, X12Entity>
    {
        public BIAMap()
        {
            Id = "BIA";
            Name = "Beginning Segment for Inventory Inquiry/Advice";
            
            Value(x => x.TransactionSetPurposeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReportTypeCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReferenceIdentification, 3, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.Date, 4, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time, 5, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.ActionCode, 6, x => x.MinLength(1).MaxLength(2));
        }
    }
}