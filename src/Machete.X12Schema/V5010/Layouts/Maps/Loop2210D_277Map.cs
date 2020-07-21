namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2210D_277Map :
        X12LayoutMap<Loop2210D_277, X12Entity>
    {
        public Loop2210D_277Map()
        {
            Id = "Loop_2210D_277";
            Name = "Claim Supplemental Information";
            
            Segment(x => x.ClaimSupplementalInformation, 0);
            Segment(x => x.ContactInformation, 1);
            Segment(x => x.Address, 2);
            Segment(x => x.GeographicInformation, 3);
        }
    }
}