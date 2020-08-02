namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0331_940Map :
        X12LayoutMap<Loop0331_940, X12Entity>
    {
        public Loop0331_940Map()
        {
            Id = "Loop_0331_940";
            Name = "Loop 0331";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}