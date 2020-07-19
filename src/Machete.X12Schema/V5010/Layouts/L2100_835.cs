namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2100_835 :
        X12Layout
    {
        Segment<CLP> ClaimPaymentInformation { get; }
        
        SegmentList<CAS> ClaimAdjustment { get; }
        
        Segment<NM1> PatientName { get; }
        
        Segment<NM1> InsuredName { get; }
        
        Segment<NM1> CorrectedPatientOrInsuredName { get; }
        
        Segment<NM1> ServiceProviderName { get; }
        
        Segment<NM1> CrossoverCarrierName { get; }
        
        Segment<NM1> CorrectedPriorityPayerName { get; }
        
        Segment<NM1> OtherSubscriberName { get; }
        
        Segment<MIA> InpatientAdjudicationInformation { get; }
        
        Segment<MOA> OutpatientAdjudicationInformation { get; }
        
        SegmentList<REF> OtherClaimRelatedIdentification { get; }
        
        SegmentList<REF> RenderingProviderIdentification { get; }
        
        SegmentList<DTM> StatementFromOrToDate { get; }
        
        Segment<DTM> CoverageExpirationDate { get; }
        
        Segment<DTM> ClaimReceivedDate { get; }
        
        SegmentList<PER> ClaimContactInformation { get; }
        
        SegmentList<AMT> ClaimSupplementalInformation { get; }
        
        SegmentList<QTY> ClaimSupplementalInformationQuantity { get; }
        
        LayoutList<L2110_835> ServicePaymentInformation { get; }
    }
}