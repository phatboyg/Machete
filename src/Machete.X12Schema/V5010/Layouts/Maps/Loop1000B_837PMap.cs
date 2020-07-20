namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1000B_837PMap :
        X12LayoutMap<Loop1000B_837P, X12Entity>
    {
        public Loop1000B_837PMap()
        {
            Id = "1000B";
            Name = "Receiver Name";
            
            Segment(x => x.Receiver, 0, x => x.IsRequired());
        }
    }
}