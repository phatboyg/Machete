namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class LDTMap :
        X12SegmentMap<LDT, X12Entity>
    {
        public LDTMap()
        {
            Id = "LDT";
            Name = "Lead Time";
            
            Value(x => x.LeadTimeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Quantity, 2, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.UnitOfTimePeriodOrInterval, 3, x => x.FixedLength(2).IsRequired());
            Value(x => x.Date, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}