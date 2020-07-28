namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SC860Map :
        X12LayoutMap<SC860, X12Entity>
    {
        public SC860Map()
        {
            Id = "SC860";
            Name = "Purchase Order Change Request - Buyer Initiated";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}