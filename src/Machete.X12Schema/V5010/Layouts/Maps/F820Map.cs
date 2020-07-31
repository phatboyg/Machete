namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class F820Map :
        X12LayoutMap<F820, X12Entity>
    {
        public F820Map()
        {
            Id = "F820";
            Name = "820 Payment Order/Remittance Advice";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}