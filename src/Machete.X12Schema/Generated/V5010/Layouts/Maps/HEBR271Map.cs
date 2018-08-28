namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HEBR271Map :
        X12LayoutMap<HEBR271, X12Entity>
    {
        public HEBR271Map()
        {
            Id = "271";
            Name = "Healthcare Eligibility Benefit Response";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}