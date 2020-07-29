namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PO850Map :
        X12LayoutMap<PO850, X12Entity>
    {
        public PO850Map()
        {
            Id = "PO850";
            Name = "850 Purchase Order";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}