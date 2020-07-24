namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ADXMap :
        X12SegmentMap<ADX, X12Entity>
    {
        public ADXMap()
        {
            Id = "ADX";
            Name = "Adjustment";
            
            Value(x => x.MonetaryAmount, 1, x => x.MinLength(1).MaxLength(18));
            Value(x => x.AdjustmentReasonCode, 2, x => x.FixedLength(2));
            Value(x => x.ReferenceIdentificationQualifier, 3, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 4, x => x.MinLength(2).MaxLength(30));
        }
    }
}