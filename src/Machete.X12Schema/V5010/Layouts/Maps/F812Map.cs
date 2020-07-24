namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class F812Map :
        X12LayoutMap<F812, X12Entity>
    {
        public F812Map()
        {
            Id = "F812";
            Name = "812 Credit/Debit Adjustment";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}