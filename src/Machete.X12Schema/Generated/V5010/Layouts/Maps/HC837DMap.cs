namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HC837DMap :
        X12LayoutMap<HC837D, X12Entity>
    {
        public HC837DMap()
        {
            Id = "837I";
            Name = "Healthcare Claim";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transactions, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}