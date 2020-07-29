namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN9_1_855Map :
        X12LayoutMap<LoopN9_1_855, X12Entity>
    {
        public LoopN9_1_855Map()
        {
            Id = "Loop_N9_1_855";
            Name = "Loop N9";
            
            Segment(x => x.ExtendedReferenceInformation, 0);
            Segment(x => x.DateOrTimeReference, 1);
            Segment(x => x.Text, 2);
            Segment(x => x.Paperwork, 3);
            Segment(x => x.ElectronicFormatIdentification, 4);
        }
    }
}