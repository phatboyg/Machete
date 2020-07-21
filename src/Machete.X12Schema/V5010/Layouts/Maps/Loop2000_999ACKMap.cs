namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000_999ACKMap :
        X12LayoutMap<Loop2000_999ACK, X12Entity>
    {
        public Loop2000_999ACKMap()
        {
            Id = "Loop_2000_999_ACK";
            Name = "Transaction Set Response Header";
            
            Segment(x => x.TransactionSetResponseHeader, 0);
            Layout(x => x.Loop2100, 1);
            Segment(x => x.TransactionSetResponseTrailer, 2);
        }
    }
}