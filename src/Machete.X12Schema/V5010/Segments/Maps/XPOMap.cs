namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class XPOMap :
        X12SegmentMap<XPO, X12Entity>
    {
        public XPOMap()
        {
            Id = "XPO";
            Name = "Preassigned Purchase Order Numbers";
            
            Value(x => x.PurchaseOrderNumber1, 1, x => x.MinLength(1).MaxLength(22).IsRequired());
            Value(x => x.PurchaseOrderNumber2, 2, x => x.MinLength(1).MaxLength(22));
            Value(x => x.IdentificationCodeQualifier, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdentificationCode, 4, x => x.MinLength(2).MaxLength(80));
        }
    }
}