namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class CD812Map :
        X12LayoutMap<CD812, X12Entity>
    {
        public CD812Map()
        {
            Id = "CD812";
            Name = "812 Credit/Debit Adjustment";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}