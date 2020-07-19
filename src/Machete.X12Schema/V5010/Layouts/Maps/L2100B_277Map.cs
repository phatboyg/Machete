namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100B_277Map :
        X12LayoutMap<L2100B_277, X12Entity>
    {
        public L2100B_277Map()
        {
            Id = "2100B";
            Name = "Information Receiver Name";
            
            Segment(x => x.InformationReceiverName, 0, x => x.IsRequired());
        }
    }
}