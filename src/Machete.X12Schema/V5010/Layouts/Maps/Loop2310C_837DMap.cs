namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2310C_837DMap :
        X12LayoutMap<Loop2310C_837D, X12Entity>
    {
        public Loop2310C_837DMap()
        {
            Id = "2310C";
            Name = "Service Facility Location Name";
            
            Segment(x => x.ServiceFacilityLocation, 0);
            Segment(x => x.Address, 1, x => x.IsRequired());
            Segment(x => x.GeographicInformation, 2, x => x.IsRequired());
            Segment(x => x.SecondaryIdentification, 3);
        }
    }
}