namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0320_947Map :
        X12LayoutMap<Loop0320_947, X12Entity>
    {
        public Loop0320_947Map()
        {
            Id = "Loop0320_947";
            Name = "Loop 0320";

            Segment(x => x.PartyIdentification, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.PartyLocation, 2);
            Segment(x => x.GeographicLocation, 3);
            Segment(x => x.Contact, 4);
        }
    }
}