namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000B_270Map :
        X12LayoutMap<L2000B_270, X12Entity>
    {
        public L2000B_270Map()
        {
            Id = "2000B";
            Name = "Information Receiver Detail";
            
            Segment(x => x.InformationReceiverLevel, 0, x => x.IsRequired());
            Layout(x => x.InformationReceiver, 1);
        }
    }
}