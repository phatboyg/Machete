namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2200D_277 :
        X12Layout
    {
        Segment<TRN> PayerClaimControlNumber { get; }
        
        Segment<STC> ClaimLevelStatusInformation { get; }
        
        Segment<REF> PatientControlNumber { get; }
        
        Segment<REF> InstitutionalTypeOfBill { get; }
        
        Segment<REF> MedicalRecordIdentificationNumber { get; }
        
        Segment<REF> ClaimIdentificationNumber { get; }
        
        Segment<DTP> ClaimServiceDate { get; }
        
        Segment<DTP> ResponseDueDate { get; }
        
        Layout<Loop2210D_277> Loop2210D { get; }
        
        LayoutList<Loop2220D_277> Loop2220D { get; }
    }
}