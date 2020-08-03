namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop211_944Map :
        X12LayoutMap<Loop211_944, X12Entity>
    {
        public Loop211_944Map()
        {
            Id = "Loop_211_944";
            Name = "Loop 210";

            Segment(x => x.ItemDetailException, 0);
            Segment(x => x.AdministrativeCommunicationsContact, 1);
        }
    }
}