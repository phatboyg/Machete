namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 837 Healthcare Claim Professional
    /// </summary>
    public interface HC837P :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T837P> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}