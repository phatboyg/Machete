namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopQTY_855Map :
        X12LayoutMap<LoopQTY_855, X12Entity>
    {
        public LoopQTY_855Map()
        {
            Id = "Loop_QTY_855";
            Name = "Loop QTY";
            
            Segment(x => x.Quantity, 0);
            Segment(x => x.ServiceCharacteristicIdentification, 1);
        }
    }
}