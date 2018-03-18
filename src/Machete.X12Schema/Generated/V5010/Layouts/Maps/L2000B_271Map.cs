namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000B_271Map :
        X12LayoutMap<L2000B_271, X12Entity>
    {
        public L2000B_271Map()
        {
            Id = "2000B";
            Name = "Information Receiver Level";
            
            Segment(x => x.InformationReceiverLevel, 0);
            Layout(x => x.InformationReceiver, 1);
        }
    }
}