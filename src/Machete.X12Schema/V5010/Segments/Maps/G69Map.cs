namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G69Map :
        X12SegmentMap<G69, X12Entity>
    {
        public G69Map()
        {
            Id = "G69";
            Name = "Line Item Detail - Description";
            
            Value(x => x.FreeformDescription, 1, x => x.MinLength(1).MaxLength(45));
        }
    }
}