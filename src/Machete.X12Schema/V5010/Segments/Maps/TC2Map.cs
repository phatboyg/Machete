namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class TC2Map :
        X12SegmentMap<TC2, X12Entity>
    {
        public TC2Map()
        {
            Id = "TC2";
            Name = "Commodity";
            
            Value(x => x.CommodityCodeQualifier, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.CommodityCode, 2, x => x.MinLength(1).MaxLength(30).IsRequired());
        }
    }
}