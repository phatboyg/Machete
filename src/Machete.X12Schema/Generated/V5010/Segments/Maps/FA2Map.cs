namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class FA2Map :
        X12SegmentMap<FA2, X12Entity>
    {
        public FA2Map()
        {
            Id = "FA2";
            Name = "Accounting Data";
            
            Value(x => x.BreakdownStructureDetailCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.FinancialInformationCode, 2, x => x.MinLength(1).MaxLength(80).IsRequired());
        }
    }
}