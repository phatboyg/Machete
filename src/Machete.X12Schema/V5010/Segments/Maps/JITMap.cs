namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class JITMap :
        X12SegmentMap<JIT, X12Entity>
    {
        public JITMap()
        {
            Id = "JIT";
            Name = "Just-In-Time Schedule";
            
            Value(x => x.Quantity, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.Time, 2, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
        }
    }
}