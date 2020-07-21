namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100A_277ACKMap :
        X12LayoutMap<Loop2100A_277ACK, X12Entity>
    {
        public Loop2100A_277ACKMap()
        {
            Id = "Loop_2100A_277_ACK";
            Name = "Information Source Name";
            
            Segment(x => x.InformationSourceName, 0);
        }
    }
}