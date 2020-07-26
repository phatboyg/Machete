namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class SCHMap :
        X12SegmentMap<SCH, X12Entity>
    {
        public SCHMap()
        {
            Id = "SCH";
            Name = "Line Item Schedule";
            
            Value(x => x.Quantity, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.UnitOrBasisForMeasurementCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.EntityIdentifierCode, 3, x => x.MinLength(2).MaxLength(3));
            Value(x => x.Name, 4, x => x.MinLength(1).MaxLength(60));
            Value(x => x.DateOrTimeQualifier1, 5, x => x.FixedLength(3).IsRequired());
            Value(x => x.Date1, 6, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time1, 7, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.DateOrTimeQualifier2, 8, x => x.FixedLength(3));
            Value(x => x.Date2, 9, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time2, 10, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.RequestReferenceNumber, 11, x => x.MinLength(1).MaxLength(45));
            Value(x => x.AssignedIdentification, 12, x => x.MinLength(1).MaxLength(20));
        }
    }
}