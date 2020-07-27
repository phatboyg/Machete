namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopQTY_860Map :
        X12LayoutMap<LoopQTY_860, X12Entity>
    {
        public LoopQTY_860Map()
        {
            Id = "Loop_QTY_860";
            Name = "Loop QTY";
            
            Segment(x => x.Quantity, 0);
            Segment(x => x.ServiceCharacteristicIdentification, 1);
        }
    }
}