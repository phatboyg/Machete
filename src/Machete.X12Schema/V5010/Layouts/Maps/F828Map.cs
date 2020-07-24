namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class F828Map :
        X12LayoutMap<F828, X12Entity>
    {
        public F828Map()
        {
            Id = "F828";
            Name = "828 Debit Authorization";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}