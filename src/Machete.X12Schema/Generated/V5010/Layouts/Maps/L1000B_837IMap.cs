namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L1000B_837IMap :
        X12LayoutMap<L1000B_837I, X12Entity>
    {
        public L1000B_837IMap()
        {
            Id = "1000B";
            Name = "Receiver Name";
            
            Segment(x => x.Receiver, 0, x => x.IsRequired());
        }
    }
}