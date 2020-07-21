namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop1000B_835 :
        X12Layout
    {
        Segment<N1> PayeeIdentification { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> AdditionalIdentification { get; }
        
        Segment<RDM> RemittanceDeliveryMethod { get; }
    }
}