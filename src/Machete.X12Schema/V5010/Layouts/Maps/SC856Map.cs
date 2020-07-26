namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SC856Map :
        X12LayoutMap<SC856, X12Entity>
    {
        public SC856Map()
        {
            Id = "SC856";
            Name = "Ship Notice/Manifest";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}