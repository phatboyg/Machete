namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 999 Acknowledgement for Healthcare Insurance
    /// </summary>
    public interface ACK999 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T999> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}