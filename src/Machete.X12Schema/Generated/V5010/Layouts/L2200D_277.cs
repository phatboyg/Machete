namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2200D_277 :
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
        
        Layout<L2210D_277> ClaimSupplementalInformation { get; }
        
        LayoutList<L2220D_277> ServiceLineInformation { get; }
    }
}