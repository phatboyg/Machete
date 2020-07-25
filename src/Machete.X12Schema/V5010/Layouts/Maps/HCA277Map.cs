namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HCA277Map :
        X12LayoutMap<HCA277, X12Entity>
    {
        public HCA277Map()
        {
            Id = "277";
            Name = "Healthcare Claim Acknowledgement";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}