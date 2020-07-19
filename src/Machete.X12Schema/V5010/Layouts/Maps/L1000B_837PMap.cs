namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L1000B_837PMap :
        X12LayoutMap<L1000B_837P, X12Entity>
    {
        public L1000B_837PMap()
        {
            Id = "1000B";
            Name = "Receiver Name";
            
            Segment(x => x.Name, 0, x => x.IsRequired());
        }
    }
}