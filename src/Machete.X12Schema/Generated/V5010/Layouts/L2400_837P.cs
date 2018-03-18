namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2400_837P :
        X12Layout
    {
        Segment<LX> ServiceLineNumber { get; }
        
        Segment<SV1> ProfessionalService { get; }
        
        Segment<SV5> DurableMedicalEquipmentService { get; }
        
        SegmentList<PWK> LineSupplementalInformation { get; }
        
        Segment<PWK> DurableMedicalEquipmentCertificateOfMedicalNecessityIndicator { get; }
        
        SegmentList<CR1> AmbulanceTransportInformation { get; }
        
        Segment<CR3> DurableMedicalEqumentCertification { get; }
        
        Segment<CRC> AmbulanceCertification { get; }
        
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
        
        Segment<REF> MammographyCerficationNumber { get; }
        
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
        
        Layout<L2410_837P> DrugIdentification { get; }
        
        Layout<L2420A_837P> RenderingProvider { get; }
        
        Layout<L2420B_837P> PurchasedServiceProvider { get; }
        
        Layout<L2420C_837P> SerivceFacilityLocation { get; }
        
        Layout<L2420D_837P> SupervisingProvider { get; }
        
        Layout<L2420E_837P> OrderingProvider { get; }
        
        LayoutList<L2420F_837P> ReferringProvider { get; }
        
        Layout<L2420G_837P> AmbulancePickUpLocation { get; }
        
        Layout<L2420H_837P> AmbulanceDropOffLocation { get; }
        
        LayoutList<L2430_837P> LineAdjudicationInformation { get; }
        
        LayoutList<L2440_837P> FormIdentificationCode { get; }
    }
}