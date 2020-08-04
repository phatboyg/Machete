namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M945Map :
        X12LayoutMap<M945, X12Entity>
    {
        public M945Map()
        {
            Id = "M945";
            Name = "945 Warehouse Shipping Advice";

            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}