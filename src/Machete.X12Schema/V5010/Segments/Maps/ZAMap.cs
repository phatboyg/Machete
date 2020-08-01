namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class ZAMap :
        X12SegmentMap<ZA, X12Entity>
    {
        public ZAMap()
        {
            Id = "ZA";
            Name = "Product Activity Reporting";
            
            Value(x => x.ActivityCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Quantity, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.UnitOrBasisForMeasurementCode, 3, x => x.FixedLength(2));
            Value(x => x.DateOrTimeQualifier, 4, x => x.FixedLength(3));
            Value(x => x.Date, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ReferenceIdentificationQualifier, 6, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 7, x => x.MinLength(1).MaxLength(50));
            Value(x => x.YesNoConditionOrResponseCode, 8, x => x.FixedLength(1));
        }
    }
}