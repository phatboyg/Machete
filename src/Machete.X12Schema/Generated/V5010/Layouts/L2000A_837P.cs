﻿namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000A_837P :
        X12Layout
    {
        Segment<HL> BillingProviderHierarchicalLevel { get; }
        
        Segment<PRV> BillingProviderSpecialtyInformation { get; }
        
        Segment<CUR> ForeignCurrencyInformation { get; }
        
        Layout<L2010AA_837P> BillingProviderName { get; }
        
        Layout<L2010AB_837P> PayToAddressName { get; }
        
        Layout<L2010AC_837P> PayToPlanName { get; }
    }
}