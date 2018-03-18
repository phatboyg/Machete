namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class DN2Map :
        X12SegmentMap<DN2, X12Entity>
    {
        public DN2Map()
        {
            Id = "DN2";
            Name = "Tooth Status";
            
            Value(x => x.ToothNumber, 1, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.ToothStatusCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.Quantity, 3, x => x.MinLength(1).MaxLength(15));
            Value(x => x.DateTimePeriodFormatQualifier, 4, x => x.MinLength(2).MaxLength(3));
            Value(x => x.DateTimePeriod, 5, x => x.MinLength(1).MaxLength(35));
            Value(x => x.CodeListQualifierCode, 6, x => x.MinLength(1).MaxLength(3).IsRequired());
        }
    }
}