namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Schema.Segments;


    public class HLMap :
        X12SegmentMap<HL, X12Entity>
    {
        public HLMap()
        {
            Id = "HL";
            Name = "Hierarchical Loop";

            Value(x => x.IdNumber, 1, x => x.IsRequired().MaxLength(12));
            Value(x => x.ParentIdNumber, 2, x => x.MaxLength(12));
            Value(x => x.LevelCode, 3, x => x.IsRequired().MaxLength(2));
            Value(x => x.ChildCode, 4);
        }
    }
}