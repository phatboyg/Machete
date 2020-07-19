namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2120C_271 :
        X12Layout
    {
        Segment<NM1> BenefitRelatedEntity { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        Segment<PER> ContactInformation { get; }
        
        Segment<PRV> ProviderInformation { get; }
    }
}