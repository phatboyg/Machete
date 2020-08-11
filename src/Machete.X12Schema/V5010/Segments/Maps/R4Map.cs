namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class R4Map :
        X12SegmentMap<R4, X12Entity>
    {
        public R4Map()
        {
            Id = "V1";
            Name = "Vessel Identification";
            
            Value(x => x.PortOrTerminalFunctionCode, 1, x => x.FixedLength(1));
            Value(x => x.LocationQualifier, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.PortName, 4, x => x.MinLength(2).MaxLength(24));
            Value(x => x.CountryCode, 5, x => x.MinLength(2).MaxLength(3));
            Value(x => x.TerminalName, 6, x => x.MinLength(2).MaxLength(30));
            Value(x => x.PierNumber, 7, x => x.MinLength(1).MaxLength(4));
            Value(x => x.StateOrProvinceCode, 8, x => x.FixedLength(2));
        }
    }
}