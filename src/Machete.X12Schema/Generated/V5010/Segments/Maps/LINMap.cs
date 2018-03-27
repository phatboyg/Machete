namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class LINMap :
        X12SegmentMap<LIN, X12Entity>
    {
        public LINMap()
        {
            Id = "LIN";
            Name = "Drug Information";
            
            Value(x => x.Qualifier, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.NationalDrugCode, 3, x => x.MinLength(1).MaxLength(48).IsRequired());
        }
    }
}