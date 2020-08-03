namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0330_945Map :
        X12LayoutMap<Loop0330_945, X12Entity>
    {
        public Loop0330_945Map()
        {
            Id = "Loop0330_945";
            Name = "Loop 0330";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}