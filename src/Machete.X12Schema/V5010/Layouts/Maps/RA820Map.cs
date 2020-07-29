namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class RA820Map :
        X12LayoutMap<RA820, X12Entity>
    {
        public RA820Map()
        {
            Id = "RA820";
            Name = "820 Payment Order/Remittance Advice";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}