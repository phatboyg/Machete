namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1000B_837DMap :
        X12LayoutMap<Loop1000B_837D, X12Entity>
    {
        public Loop1000B_837DMap()
        {
            Id = "Loop_1000B_837D";
            Name = "Receiver Name";
            
            Segment(x => x.Receiver, 0);
        }
    }
}