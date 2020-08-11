namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LMMap :
        X12SegmentMap<LM, X12Entity>
    {
        public LMMap()
        {
            Id = "LM";
            Name = "Code Source Information";
            
            Value(x => x.AgencyQualifierCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.SourceSubQualifier, 2, x => x.MinLength(1).MaxLength(15));
        }
    }
}