namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2210E_276Map :
        X12LayoutMap<L2210E_276, X12Entity>
    {
        public L2210E_276Map()
        {
            Id = "2210E";
            Name = "Service Line Information";
            
            Segment(x => x.Information, 0);
            Segment(x => x.ItemIdentification, 1);
            Segment(x => x.Date, 2, x => x.IsRequired());
        }
    }
}