namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SC850Map :
        X12LayoutMap<SC850, X12Entity>
    {
        public SC850Map()
        {
            Id = "SC850";
            Name = "Purchase Order";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}