namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class L11Map :
        X12SegmentMap<L11, X12Entity>
    {
        public L11Map()
        {
            Id = "L11";
            Name = "Beginning Segment for Booking or Pickup/Delivery";
            
            Value(x => x.ReferenceIdentification, 1, x => x.MinLength(1).MaxLength(50));
            Value(x => x.ReferenceIdentificationQualifier, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.Description, 3, x => x.MinLength(1).MaxLength(80));
            Value(x => x.Date, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.YesNoConditionOrResponseCode, 5, x => x.FixedLength(1));
        }
    }
}