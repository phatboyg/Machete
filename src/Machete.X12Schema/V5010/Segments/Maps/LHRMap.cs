namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class LHRMap :
        X12SegmentMap<LHR, X12Entity>
    {
        public LHRMap()
        {
            Id = "LHR";
            Name = "Hazardous Material Identifying Reference Numbers";
            
            Value(x => x.ReferenceIdentificationQualifier, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification, 2, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}