namespace Machete.X12Schema.V5010.Layouts
{
    using X12;
    using X12.Schema.Segments;


    public interface L2000A_837I :
        X12Layout
    {
        Segment<HL> BillingProviderHeirarchicalLevel { get; }
        
        Segment<PRV> BillingProviderSpecialtyInformation { get; }
        
        Segment<CUR> ForeignCurrencyInformation { get; }
        
        Layout<L2010AA_837I> BillingProvider { get; }
        
        Layout<L2010AB_837I> PayToAddress { get; }
        
        Layout<L2010AC_837I> PayToPlan { get; }
    }
}