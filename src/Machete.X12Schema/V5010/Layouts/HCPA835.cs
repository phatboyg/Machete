namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 835 Healthcare Claim Payment/Advice
    /// </summary>
    public interface HCPA835 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T835> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}