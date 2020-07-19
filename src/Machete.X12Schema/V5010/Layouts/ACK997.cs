namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 997 Functional Acknowledgmenet for Healthcare Insurance
    /// </summary>
    public interface ACK997 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T997> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}