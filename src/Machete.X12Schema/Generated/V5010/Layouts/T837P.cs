﻿namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 837P Transaction
    /// </summary>
    public interface T837P :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BHT> BeginningOfHierarchicalTransaction { get; }
        
        LayoutList<L1000A_837P> Submitter { get; }
        
        LayoutList<L1000B_837P> Receiver { get; }
        
        LayoutList<L2000A_837P> BillingProviderDetail { get; }
        
        LayoutList<L2000B_837P> SubscriberDetail { get; }
        
        LayoutList<L2000C_837P> PatientDetail { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}