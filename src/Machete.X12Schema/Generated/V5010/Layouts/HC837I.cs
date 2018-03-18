namespace Machete.X12Schema.V5010.Layouts
{
    using X12;
    using X12.Schema.Segments;


    public interface HC837I :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BHT> BeginningOfHeirarchicalTransaction { get; }
        
        LayoutList<L1000A_837I> Submitter { get; }
        
        LayoutList<L1000B_837I> Receiver { get; }
        
        LayoutList<L2000A_837I> BillingProviderDetail { get; }
        
        LayoutList<L2000B_837I> SubscriberDetail { get; }
        
        LayoutList<L2000C_837I> PatientDetail { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}