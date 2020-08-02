namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0320_940Map :
        X12LayoutMap<Loop0320_940, X12Entity>
    {
        public Loop0320_940Map()
        {
            Id = "Loop_0320_940";
            Name = "Loop 0320";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}