namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LH6Map :
        X12SegmentMap<LH6, X12Entity>
    {
        public LH6Map()
        {
            Id = "LH6";
            Name = "Hazardous Certification";
            
            Value(x => x.Name, 1, x => x.MinLength(4).MaxLength(60));
            Value(x => x.HazardousCertificationCode, 2, x => x.FixedLength(1));
            Value(x => x.HazardousCertificationDeclaration1, 3, x => x.MinLength(1).MaxLength(25));
            Value(x => x.HazardousCertificationDeclaration2, 4, x => x.MinLength(1).MaxLength(25));
        }
    }
}