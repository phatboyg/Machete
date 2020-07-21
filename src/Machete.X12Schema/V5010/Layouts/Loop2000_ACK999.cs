namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000_ACK999 :
        X12Layout
    {
        Segment<AK2> TransactionSetResponseHeader { get; }
        
        LayoutList<Loop2100_ACK999> Loop2100 { get; }
        
        Segment<IK5> TransactionSetResponseTrailer { get; }
    }
}