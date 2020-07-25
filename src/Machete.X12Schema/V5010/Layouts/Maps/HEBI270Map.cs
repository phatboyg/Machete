namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HEBI270Map :
        X12LayoutMap<HEBI270, X12Entity>
    {
        public HEBI270Map()
        {
            Id = "270";
            Name = "Healthcare Eligibility Benefit Inquiry";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}