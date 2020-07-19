namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2210D_277Map :
        X12LayoutMap<L2210D_277, X12Entity>
    {
        public L2210D_277Map()
        {
            Id = "2210D";
            Name = "Claim Supplemental Information";
            
            Segment(x => x.ClaimSupplementalInformation, 0);
            Segment(x => x.ContactInformation, 1, x => x.IsRequired());
            Segment(x => x.Address, 2);
            Segment(x => x.GeographicInformation, 3);
        }
    }
}