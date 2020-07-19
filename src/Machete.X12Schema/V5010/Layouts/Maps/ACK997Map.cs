namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ACK997Map :
        X12LayoutMap<ACK997, X12Entity>
    {
        public ACK997Map()
        {
            Id = "997";
            Name = "Functional Acknowledgement";
            
            Segment(x => x.InterchangeControlHeader, 0, x => x.IsRequired());
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}