namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ADVMap :
        X12SegmentMap<ADV, X12Entity>
    {
        public ADVMap()
        {
            Id = "ADV";
            Name = "Advertising Demographic Information";
            
            Value(x => x.AgencyQualifierCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ServiceCharacteristicsQualifier1, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.RangeMinimum, 3, x => x.MinLength(1).MaxLength(20));
            Value(x => x.RangeMaximum, 4, x => x.MinLength(1).MaxLength(20));
            Value(x => x.Category, 5, x => x.MinLength(1).MaxLength(6));
            Value(x => x.ServiceCharacteristicsQualifier2, 6, x => x.FixedLength(2));
            Value(x => x.MeasurementValue, 7, x => x.MinLength(1).MaxLength(20));
        }
    }
}