namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HC837IMap :
        X12LayoutMap<HC837I, X12Entity>
    {
        public HC837IMap()
        {
            Id = "837I";
            Name = "Healthcare Claim";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}