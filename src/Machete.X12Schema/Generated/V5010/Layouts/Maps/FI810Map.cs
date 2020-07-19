namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class FI810Map :
        X12LayoutMap<FI810, X12Entity>
    {
        public FI810Map()
        {
            Id = "T810";
            Name = "T810";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}