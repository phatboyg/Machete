namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class F829Map :
        X12LayoutMap<F829, X12Entity>
    {
        public F829Map()
        {
            Id = "F828";
            Name = "828 Debit Authorization";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}