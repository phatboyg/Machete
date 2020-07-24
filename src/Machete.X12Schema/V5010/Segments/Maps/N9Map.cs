namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class N9Map :
        X12SegmentMap<N9, X12Entity>
    {
        public N9Map()
        {
            Id = "N9";
            Name = "Extended Reference Information";
            
            Value(x => x.ReferenceIdentificationQualifier, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification, 2, x => x.MinLength(1).MaxLength(50));
            Value(x => x.Description, 3, x => x.MinLength(1).MaxLength(45));
            Value(x => x.Date, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time, 5, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Entity(x => x.ReferenceIdentifier, 6);
        }
    }
}