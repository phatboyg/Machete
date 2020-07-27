namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class IN2Map :
        X12SegmentMap<IN2, X12Entity>
    {
        public IN2Map()
        {
            Id = "IN2";
            Name = "Individual Name Structure Components";
            
            Value(x => x.NameComponentQualifier, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Name1, 2, x => x.MinLength(1).MaxLength(60));
            Value(x => x.Name2, 3, x => x.MinLength(1).MaxLength(60));
        }
    }
}