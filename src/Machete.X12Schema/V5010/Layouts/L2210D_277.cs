namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2210D_277 :
        X12Layout
    {
        Segment<PWK> ClaimSupplementalInformation { get; }
        
        Segment<PER> ContactInformation { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
    }
}