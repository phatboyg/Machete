namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M862Map :
        X12LayoutMap<M862, X12Entity>
    {
        public M862Map()
        {
            Id = "M862";
            Name = "862 Shipping Schedule";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}