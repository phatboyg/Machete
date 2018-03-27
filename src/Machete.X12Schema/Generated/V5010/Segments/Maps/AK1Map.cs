namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AK1Map :
        X12SegmentMap<AK1, X12Entity>
    {
        public AK1Map()
        {
            Id = "AK1";
            Name = "Functional Group Response Header";

            Value(x => x.FunctionalIdCode, 1, x => x.MaxLength(2).IsRequired());
            Value(x => x.GroupCtrlNumber, 2, x => x.MaxLength(9).IsRequired());
            Value(x => x.VerReleaseIdCode, 3, x => x.MaxLength(12).IsRequired());
        }
    }
}