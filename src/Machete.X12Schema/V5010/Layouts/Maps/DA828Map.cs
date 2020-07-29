namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class DA828Map :
        X12LayoutMap<DA828, X12Entity>
    {
        public DA828Map()
        {
            Id = "DA828";
            Name = "828 Debit Authorization";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}