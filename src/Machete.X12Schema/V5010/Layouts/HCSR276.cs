namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 276 Healthcare Claim Status Request
    /// </summary>
    public interface HCSR276 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T276> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}