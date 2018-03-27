namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000_ACK999 :
        X12Layout
    {
        Segment<AK2> TransactionSetResponseHeader { get; }
        
        LayoutList<L2100_ACK999> ErrorIdentification { get; }
        
        Segment<IK5> TransactionSetResponseTrailer { get; }
    }
}