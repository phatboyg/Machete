namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M947Map :
        X12LayoutMap<M947, X12Entity>
    {
        public M947Map()
        {
            Id = "M947";
            Name = "947 Warehouse Inventory Adjustment Advice";

            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}