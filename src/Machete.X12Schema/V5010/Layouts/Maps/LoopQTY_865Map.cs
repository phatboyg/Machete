namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopQTY_865Map :
        X12LayoutMap<LoopQTY_865, X12Entity>
    {
        public LoopQTY_865Map()
        {
            Id = "Loop_QTY_865";
            Name = "Loop QTY";
            
            Segment(x => x.Quantity, 0);
            Segment(x => x.ServiceCharacteristicIdentification, 1);
        }
    }
}