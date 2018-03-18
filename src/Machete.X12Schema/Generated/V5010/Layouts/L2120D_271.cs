namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2120D_271 :
        X12Layout
    {
        Segment<NM1> Dependent { get; }
        
        SegmentList<REF> AdditionalIdentification { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        Segment<PER> ContactInformation { get; }
        
        Segment<PRV> ProviderInformation { get; }
    }
}