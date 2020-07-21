namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100B_277Map :
        X12LayoutMap<Loop2100B_277, X12Entity>
    {
        public Loop2100B_277Map()
        {
            Id = "Loop_2100B_277";
            Name = "Information Receiver Name";
            
            Segment(x => x.InformationReceiver, 0);
        }
    }
}