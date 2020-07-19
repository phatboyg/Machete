namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000_ACK997 :
        X12Layout
    {
        Segment<AK2> TransactionSetResponseHeader { get; }
        
        LayoutList<L2100_ACK997> ErrorIdentification { get; }
        
        Segment<AK5> TransactionSetResponseTrailer { get; }
    }
}