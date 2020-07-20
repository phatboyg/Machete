namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2440_837PMap :
        X12LayoutMap<Loop2440_837P, X12Entity>
    {
        public Loop2440_837PMap()
        {
            Id = "Loop_2440_837P";
            Name = "Form Identification Code";
            
            Segment(x => x.FormIdentificationCode, 0);
            Segment(x => x.SupportingDocumentation, 1);
        }
    }
}