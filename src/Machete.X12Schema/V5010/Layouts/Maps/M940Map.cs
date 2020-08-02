namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M940Map :
        X12LayoutMap<M940, X12Entity>
    {
        public M940Map()
        {
            Id = "M940";
            Name = "940 Warehouse Shipping Order";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}