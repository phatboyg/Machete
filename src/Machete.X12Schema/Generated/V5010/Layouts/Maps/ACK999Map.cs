namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ACK999Map :
        X12LayoutMap<ACK999, X12Entity>
    {
        public ACK999Map()
        {
            Id = "999";
            Name = "Acknowledgement";
            
            Segment(x => x.InterchangeControlHeader, 0, x => x.IsRequired());
            Segment(x => x.FunctionalGroupHeader, 1, x => x.IsRequired());
            Segment(x => x.TransactionSetHeader, 2);
            Segment(x => x.FunctionalGroupResponseHeader, 3);
            Layout(x => x.TransactionSetResponseHeader, 4);
            Segment(x => x.FunctionalGroupResponseTrailer, 5, x => x.IsRequired());
            Segment(x => x.TransactionSetTrailer, 6, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 7);
            Segment(x => x.InterchangeControlTrailer, 8);
        }
    }
}