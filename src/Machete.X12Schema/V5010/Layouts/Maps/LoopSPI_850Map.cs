namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSPI_850Map :
        X12LayoutMap<LoopSPI_850, X12Entity>
    {
        public LoopSPI_850Map()
        {
            Id = "Loop_SPI_850";
            Name = "Loop SPI";
            
            Segment(x => x.SpecificationIdentifier, 0);
            Segment(x => x.ReferenceInformation, 1);
            Segment(x => x.DateOrTimeReference, 2);
            Segment(x => x.Text, 3);
            Layout(x => x.LoopN1, 4);
            Layout(x => x.LoopCB1, 5);
        }
    }
}