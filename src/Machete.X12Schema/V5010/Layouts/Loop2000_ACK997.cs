namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000_ACK997 :
        X12Layout
    {
        Segment<AK2> TransactionSetResponseHeader { get; }
        
        LayoutList<Loop2100_ACK997> Loop2100 { get; }
        
        Segment<AK5> TransactionSetResponseTrailer { get; }
    }
}