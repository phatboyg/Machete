namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class RYLMap :
        X12SegmentMap<RYL, X12Entity>
    {
        public RYLMap()
        {
            Id = "RYL";
            Name = "Royalty Payment";
            
            Value(x => x.AssignedNumber, 1, x => x.MinLength(1).MaxLength(6));
            Value(x => x.NameLastOrOrganizationName, 2, x => x.MinLength(1).MaxLength(35));
            Value(x => x.IdentificationCodeQualifier, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdentificationCode, 4, x => x.MinLength(2).MaxLength(80));
        }
    }
}