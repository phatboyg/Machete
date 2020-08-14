namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class X2Map :
        X12SegmentMap<X2, X12Entity>
    {
        public X2Map()
        {
            Id = "X2";
            Name = "Import License";
            
            Value(x => x.ImportLicenseNumber1, 1, x => x.MinLength(6).MaxLength(30).IsRequired());
            Value(x => x.Date1, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date2, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ImportLicenseNumber2, 1, x => x.MinLength(6).MaxLength(30));
            Value(x => x.Date3, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date4, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}