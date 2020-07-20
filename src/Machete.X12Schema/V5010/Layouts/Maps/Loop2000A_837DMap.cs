namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000A_837DMap :
        X12LayoutMap<Loop2000A_837D, X12Entity>
    {
        public Loop2000A_837DMap()
        {
            Id = "2000A";
            Name = "Billing Provider Hierarchical Level";
            
            Segment(x => x.HierarchicalLevel, 0, x => x.IsRequired());
            Segment(x => x.SpecialtyInformation, 1);
            Segment(x => x.ForeignCurrencyInformation, 2);
            Layout(x => x.Loop2010AA, 3);
            Layout(x => x.Loop2010AB, 4);
            Layout(x => x.Loop2010AC, 5);
        }
    }
}