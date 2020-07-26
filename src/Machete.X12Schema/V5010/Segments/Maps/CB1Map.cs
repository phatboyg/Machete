namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class CB1Map :
        X12SegmentMap<CB1, X12Entity>
    {
        public CB1Map()
        {
            Id = "CB1";
            Name = "Contract and Cost Accounting Standards Data";
            
            Value(x => x.AcquisitionDataCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.FinancingTypeCode, 2, x => x.FixedLength(1));
        }
    }
}