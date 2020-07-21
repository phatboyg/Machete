namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000B_276Map :
        X12LayoutMap<Loop2000B_276, X12Entity>
    {
        public Loop2000B_276Map()
        {
            Id = "Loop_2000B_276";
            Name = "Information Receiver Detail";
            
            Segment(x => x.InformationReceiverLevel, 0);
            Layout(x => x.Loop2100B, 1);
        }
    }
}