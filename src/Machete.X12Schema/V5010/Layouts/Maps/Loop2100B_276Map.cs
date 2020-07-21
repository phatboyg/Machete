namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100B_276Map :
        X12LayoutMap<Loop2100B_276, X12Entity>
    {
        public Loop2100B_276Map()
        {
            Id = "Loop_2100B_276";
            Name = "Information Receiver Name";
            
            Segment(x => x.InformationReceiver, 0);
        }
    }
}