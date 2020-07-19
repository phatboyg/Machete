namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000_ACK997Map :
        X12LayoutMap<L2000_ACK997, X12Entity>
    {
        public L2000_ACK997Map()
        {
            Id = "2000";
            Name = "Transaction Set Response Header";
            
            Segment(x => x.TransactionSetResponseHeader, 0);
            Layout(x => x.ErrorIdentification, 1);
            Segment(x => x.TransactionSetResponseTrailer, 2, x => x.IsRequired());
        }
    }
}