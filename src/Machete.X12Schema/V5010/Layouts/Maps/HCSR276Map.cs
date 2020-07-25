namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HCSR276Map :
        X12LayoutMap<HCSR276, X12Entity>
    {
        public HCSR276Map()
        {
            Id = "276";
            Name = "Healthcare Claim Status Request";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}