namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M860Map :
        X12LayoutMap<M860, X12Entity>
    {
        public M860Map()
        {
            Id = "M860";
            Name = "860 Purchase Order Change Request - Buyer Initiated";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}