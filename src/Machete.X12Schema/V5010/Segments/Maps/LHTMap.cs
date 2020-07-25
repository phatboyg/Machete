namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LHTMap :
        X12SegmentMap<LHT, X12Entity>
    {
        public LHTMap()
        {
            Id = "LHT";
            Name = "Transborder Hazardous Requirements";
            
            Value(x => x.HazardousClassification, 1, x => x.MinLength(1).MaxLength(30));
            Value(x => x.HazardousPlacardNotation, 2, x => x.MinLength(14).MaxLength(40));
            Value(x => x.HazardousEndorsement, 3, x => x.MinLength(4).MaxLength(25));
        }
    }
}