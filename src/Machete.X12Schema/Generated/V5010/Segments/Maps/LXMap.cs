namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class LXMap :
        X12SegmentMap<LX, X12Entity>
    {
        public LXMap()
        {
            Id = "LX";
            Name = "Assigned Number";
            
            Value(x => x.NumberAssigned, 1, x => x.MinLength(1).MaxLength(6).IsRequired());
        }
    }
}