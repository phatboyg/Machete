namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HC837PMap :
        X12LayoutMap<HC837P, X12Entity>
    {
        public HC837PMap()
        {
            Id = "837P";
            Name = "Healthcare Claim";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}