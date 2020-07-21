namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1000B_837IMap :
        X12LayoutMap<Loop1000B_837I, X12Entity>
    {
        public Loop1000B_837IMap()
        {
            Id = "Loop_1000B_837I";
            Name = "Receiver Name";
            
            Segment(x => x.Receiver, 0, x => x.IsRequired());
        }
    }
}