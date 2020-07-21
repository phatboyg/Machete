namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000_999ACK :
        X12Layout
    {
        Segment<AK2> TransactionSetResponseHeader { get; }
        
        LayoutList<Loop2100_999ACK> Loop2100 { get; }
        
        Segment<IK5> TransactionSetResponseTrailer { get; }
    }
}