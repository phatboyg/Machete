namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ETDMap :
        X12SegmentMap<ETD, X12Entity>
    {
        public ETDMap()
        {
            Id = "ETD";
            Name = "Excess Transportation Detail";
            
            Value(x => x.ExcessTransportationReasonCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ExcessTransportationResponsibilityCode, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.ReferenceIdentificationQualifier, 3, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ReturnableContainerFreightPaymentResponsibilityCode, 5, x => x.MinLength(1).MaxLength(2));
        }
    }
}