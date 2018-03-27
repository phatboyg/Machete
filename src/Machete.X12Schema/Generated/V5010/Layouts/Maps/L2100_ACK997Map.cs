namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100_ACK997Map :
        X12LayoutMap<L2100_ACK997, X12Entity>
    {
        public L2100_ACK997Map()
        {
            Id = "2100";
            Name = "Error Identification";
            
            Segment(x => x.ErrorIdentification, 0);
            Segment(x => x.DateElementNote, 1);
        }
    }
}