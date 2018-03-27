namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2330A_837P :
        X12Layout
    {
        Segment<NM1> Subscriber { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInfo { get; }
        
        Segment<REF> SecondaryIdentification { get; }
    }
}