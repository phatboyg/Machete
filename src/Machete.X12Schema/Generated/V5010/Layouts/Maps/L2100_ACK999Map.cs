namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100_ACK999Map :
        X12LayoutMap<L2100_ACK999, X12Entity>
    {
        public L2100_ACK999Map()
        {
            Id = "2100";
            Name = "Error Identification";
            
            Segment(x => x.ErrorIdentification, 0);
            Segment(x => x.SegmentContext, 1);
            Segment(x => x.BusinessUnitIdentifier, 2);
            Layout(x => x.ImplementationDataElementNote, 3);
        }
    }
}