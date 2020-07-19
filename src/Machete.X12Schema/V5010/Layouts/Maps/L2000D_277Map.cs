namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000D_277Map :
        X12LayoutMap<L2000D_277, X12Entity>
    {
        public L2000D_277Map()
        {
            Id = "2000D";
            Name = "Patient Level";
            
            Segment(x => x.ServiceProviderLevel, 0,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("PT")));
            Layout(x => x.ServiceProviderName, 1);
            Layout(x => x.PayerClaimControlNumber, 2);
         }
    }
}