namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M846Map :
        X12LayoutMap<M846, X12Entity>
    {
        public M846Map()
        {
            Id = "M846";
            Name = "846 Inventory Inquiry/Advice";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}