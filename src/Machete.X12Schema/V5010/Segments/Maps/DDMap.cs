namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class DDMap :
        X12SegmentMap<DD, X12Entity>
    {
        public DDMap()
        {
            Id = "DD";
            Name = "Demand Detail";
            
            Value(x => x.IndustryCode1, 1, x => x.MinLength(1).MaxLength(30));
            Value(x => x.CodeListQualifierCode1, 2, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ReferenceIdentificationQualifier, 3, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.IndustryCode2, 5, x => x.MinLength(1).MaxLength(30));
            Value(x => x.CodeListQualifierCode2, 6, x => x.MinLength(1).MaxLength(3));
            Value(x => x.Quantity, 7, x => x.MinLength(1).MaxLength(15));
            Value(x => x.YesNoConditionOrResponseCode, 8, x => x.FixedLength(1));
            Value(x => x.IndustryCode3, 9, x => x.MinLength(1).MaxLength(30));
            Value(x => x.CodeListQualifierCode3, 10, x => x.MinLength(1).MaxLength(3));
        }
    }
}