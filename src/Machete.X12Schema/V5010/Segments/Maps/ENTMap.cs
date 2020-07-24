namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ENTMap :
        X12SegmentMap<ENT, X12Entity>
    {
        public ENTMap()
        {
            Id = "ENT";
            Name = "Entity";
            
            Value(x => x.AssignedNumber, 1, x => x.MinLength(1).MaxLength(6));
            Value(x => x.EntityIdentifierCode1, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.IdentificationCodeQualifier1, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdentificationCode1, 4, x => x.MinLength(2).MaxLength(80));
            Value(x => x.EntityIdentifierCode2, 5, x => x.MinLength(2).MaxLength(3));
            Value(x => x.IdentificationCodeQualifier2, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdentificationCode2, 7, x => x.MinLength(2).MaxLength(80));
            Value(x => x.ReferenceIdentificationQualifier, 8, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 9, x => x.MinLength(2).MaxLength(30));
        }
    }
}