namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopQTY_850Map :
        X12LayoutMap<LoopQTY_850, X12Entity>
    {
        public LoopQTY_850Map()
        {
            Id = "Loop_QTY_850";
            Name = "Loop QTY";
            
            Segment(x => x.QuantityInformation, 0);
            Segment(x => x.ServiceCharacteristicIdentification, 1);
        }
    }
}