namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0310_947Map :
        X12LayoutMap<Loop0310_947, X12Entity>
    {
        public Loop0310_947Map()
        {
            Id = "Loop_0310_947";
            Name = "Loop 0310";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}