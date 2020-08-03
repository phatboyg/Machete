namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M944Map :
        X12LayoutMap<M944, X12Entity>
    {
        public M944Map()
        {
            Id = "M944";
            Name = "944 Warehouse Stock Transfer Receipt Advice";

            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}