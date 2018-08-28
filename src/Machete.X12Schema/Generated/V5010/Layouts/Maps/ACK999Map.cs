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
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}