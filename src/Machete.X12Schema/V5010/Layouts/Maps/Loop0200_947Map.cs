namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0200_947Map :
        X12LayoutMap<Loop0200_947, X12Entity>
    {
        public Loop0200_947Map()
        {
            Id = "Loop_0200_947";
            Name = "Loop 0200";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}