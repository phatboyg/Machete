namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HCPA835Map :
        X12LayoutMap<HCPA835, X12Entity>
    {
        public HCPA835Map()
        {
            Id = "835";
            Name = "Healthcare Claim Payment/Advice";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}