namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M855Map :
        X12LayoutMap<M855, X12Entity>
    {
        public M855Map()
        {
            Id = "M855";
            Name = "855 Purchase Order Acknowledgement";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}