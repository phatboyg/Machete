namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2200E_276 :
        X12Layout
    {
        Segment<TRN> PayerClaimControlNumber { get; }
        
        Segment<REF> PayerControlNumber { get; }
        
        Segment<REF> InstitutionalTypeOfBill { get; }
        
        Segment<REF> ApplicationOrLocationSystemIdentifier { get; }
        
        Segment<REF> GroupNumber { get; }
        
        Segment<REF> PatientControlNumber { get; }
        
        Segment<REF> PharmacyPrescriptionNumber { get; }
        
        Segment<REF> ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries { get; }
        
        Segment<AMT> ClaimSubmittedCharges { get; }
        
        Segment<DTP> ClaimServiceDate { get; }
        
        LayoutList<Loop2210E_276> Loop2210E { get; }
    }
}