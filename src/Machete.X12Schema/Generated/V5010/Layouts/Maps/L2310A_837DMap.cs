namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310A_837DMap :
        X12LayoutMap<L2310A_837D, X12Entity>
    {
        public L2310A_837DMap()
        {
            Id = "2310A";
            Name = "Referring Provider Name";
            
            Segment(x => x.Provider, 0);
            Segment(x => x.SpecialtyInformation, 1, x => x.IsRequired());
            Segment(x => x.SecondaryIdentification, 2);
        }
    }
}