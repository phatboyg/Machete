namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HISN277Map :
        X12LayoutMap<HISN277, X12Entity>
    {
        public HISN277Map()
        {
            Id = "277";
            Name = "Healthcare Claim Request for Additional Information";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}