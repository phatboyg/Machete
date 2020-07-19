namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2100B_271 :
        X12Layout
    {
        Segment<NM1> InformationReceiver { get; }
        
        SegmentList<REF> AdditionalIdentification { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<AAA> RequestValidation { get; }
        
        SegmentList<PRV> ProviderInformation { get; }
    }
}