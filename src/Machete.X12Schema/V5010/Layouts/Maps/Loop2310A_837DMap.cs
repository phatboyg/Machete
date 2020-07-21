namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2310A_837DMap :
        X12LayoutMap<Loop2310A_837D, X12Entity>
    {
        public Loop2310A_837DMap()
        {
            Id = "Loop_2310A_837D";
            Name = "Referring Provider Name";
            
            Segment(x => x.ReferringProvider, 0);
            Segment(x => x.SpecialtyInformation, 1);
            Segment(x => x.SecondaryIdentification, 2);
        }
    }
}