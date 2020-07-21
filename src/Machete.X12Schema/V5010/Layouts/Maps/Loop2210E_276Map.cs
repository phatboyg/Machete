namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2210E_276Map :
        X12LayoutMap<Loop2210E_276, X12Entity>
    {
        public Loop2210E_276Map()
        {
            Id = "Loop_2210E_276";
            Name = "Service Line Information";
            
            Segment(x => x.Information, 0);
            Segment(x => x.ItemIdentification, 1);
            Segment(x => x.Date, 2);
        }
    }
}