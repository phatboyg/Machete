namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class FA1Map :
        X12SegmentMap<FA1, X12Entity>
    {
        public FA1Map()
        {
            Id = "FA2";
            Name = "Type of Financial Accounting Data";
            
            Value(x => x.AgencyQualifierCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ServicePromotionAllowanceOrChargeCode, 2, x => x.FixedLength(4));
            Value(x => x.AllowanceOrChargeIndicator, 3, x => x.FixedLength(1));
        }
    }
}