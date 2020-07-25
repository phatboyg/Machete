namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 277 Claim Acknowledgement
    /// </summary>
    public interface HCA277 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<CAT277> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}