namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M861Map :
        X12LayoutMap<M861, X12Entity>
    {
        public M861Map()
        {
            Id = "M861";
            Name = "861 Receiving Advice/Acceptance Certificate";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}