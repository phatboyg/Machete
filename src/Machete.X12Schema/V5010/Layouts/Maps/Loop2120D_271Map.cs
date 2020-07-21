namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2120D_271Map :
        X12LayoutMap<Loop2120D_271, X12Entity>
    {
        public Loop2120D_271Map()
        {
            Id = "Loop_2120D_271";
            Name = "Dependent Benefit Related Entity Name";
            
            Segment(x => x.Dependent, 0);
            Segment(x => x.AdditionalIdentification, 1);
            Segment(x => x.Address, 2);
            Segment(x => x.GeographicInformation, 3);
            Segment(x => x.ContactInformation, 4);
            Segment(x => x.ProviderInformation, 5);
        }
    }
}