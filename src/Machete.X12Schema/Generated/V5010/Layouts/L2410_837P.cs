namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2410_837P :
        X12Layout
    {
        Segment<LIN> DrugIdentification { get; }
        
        Segment<CTP> DrugQuantity { get; }
        
        Segment<REF> PrescriptionOrCompoundDrugAssociationNumber { get; }
    }
}