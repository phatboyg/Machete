namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2400_837P :
        X12Layout
    {
        Segment<LX> ServiceLineNumber { get; }
        
        Segment<SV1> ProfessionalService { get; }
        
        Segment<SV5> DurableMedicalEquipmentService { get; }
        
        SegmentList<PWK> LineSupplementalInformation { get; }
        
        Segment<PWK> DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator { get; }
        
        SegmentList<CR1> AmbulanceTransportInformation { get; }
        
        Segment<CR3> DurableMedicalEquipmentCertification { get; }
        
        SegmentList<CRC> AmbulanceCertifications { get; }
        
        Segment<CRC> HospiceEmployeeIndicator { get; }
        
        Segment<CRC> ConditionIndicatorDurableMedicalEquipment { get; }
        
        Segment<DTP> ServiceDate { get; }
        
        Segment<DTP> PrescriptionDate { get; }
        
        Segment<DTP> CertificationRevisionDate { get; }
        
        Segment<DTP> BeginTherapyDate { get; }
        
        Segment<DTP> LastCertificationDate { get; }
        
        Segment<DTP> LastSeenDate { get; }
        
        Segment<DTP> TestDate { get; }
        
        Segment<DTP> ShippedDate { get; }
        
        Segment<DTP> LastXRayDate { get; }
        
        Segment<DTP> InitialTreatmentDate { get; }
        
        Segment<QTY> AmbulancePatientCount { get; }
        
        Segment<QTY> ObstetricAnesthesiaAdditionalUnits { get; }
        
        SegmentList<MEA> TestResult { get; }
        
        Segment<CN1> ContractInformation { get; }
        
        Segment<REF> RepricedLineItemReferenceNumber { get; }
        
        Segment<REF> AdjustedRepricedLineItemReferenceNumber { get; }
        
        SegmentList<REF> PriorAuthorization { get; }
        
        Segment<REF> LineItemControlNumber { get; }
        
        Segment<REF> MammographyCertificationNumber { get; }
        
        Segment<REF> CLIANumber { get; }
        
        Segment<REF> ReferringCLIAFacilityIdentification { get; }
        
        Segment<REF> ImmunizationBatchNumber { get; }
        
        SegmentList<REF> ReferralNumber { get; }
        
        Segment<AMT> SalesTaxAmount { get; }
        
        Segment<AMT> PostageClaimedAmount { get; }
        
        SegmentList<K3> FileInformation { get; }
        
        Segment<NTE> LineNote { get; }
        
        Segment<NTE> ThirdPartyOrganizationNotes { get; }
        
        Segment<PS1> PurchasedServiceInformation { get; }
        
        Segment<HCP> LinePricingInformation { get; }
        
        Layout<Loop2410_837P> Loop2410 { get; }
        
        Layout<Loop2420A_837P> Loop2420A { get; }
        
        Layout<Loop2420B_837P> Loop2420B { get; }
        
        Layout<Loop2420C_837P> Loop2420C { get; }
        
        Layout<Loop2420D_837P> Loop2420D { get; }
        
        Layout<Loop2420E_837P> Loop2420E { get; }
        
        LayoutList<Loop2420F_837P> Loop2420F { get; }
        
        Layout<Loop2420G_837P> Loop2420G { get; }
        
        Layout<Loop2420H_837P> Loop2420H { get; }
        
        LayoutList<Loop2430_837P> Loop2430 { get; }
        
        LayoutList<Loop2440_837P> Loop2440 { get; }
    }
}