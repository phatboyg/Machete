namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class Y6Map :
        X12SegmentMap<Y6, X12Entity>
    {
        public Y6Map()
        {
            Id = "Y6";
            Name = "Authentication";
            
            Value(x => x.AuthorityIdentifierCode, 1, x => x.FixedLength(2));
            Value(x => x.Authority, 2, x => x.MinLength(1).MaxLength(20).IsRequired());
            Value(x => x.AuthorityDate, 3, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}