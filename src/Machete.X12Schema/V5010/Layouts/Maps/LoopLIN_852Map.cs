namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLIN_852Map :
        X12LayoutMap<LoopLIN_852, X12Entity>
    {
        public LoopLIN_852Map()
        {
            Id = "Loop_LIN_852";
            Name = "Loop LIN";  
            
            Segment(x => x.ItemIdentification, 0);
            Segment(x => x.PricingInformation, 1);
            Segment(x => x.ServiceAllowanceOrChargeInformation, 2);
            Segment(x => x.ItemPhysicalDetails, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.MonetaryAmountInformation, 5);
            Segment(x => x.PalletTypeAndLoadCharacteristics, 6);
            Segment(x => x.QuantityInformation, 7);
            Layout(x => x.LoopZA, 8);
        }
    }
}