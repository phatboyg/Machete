﻿namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 837D Transaction
    /// </summary>
    public interface T837D :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BHT> BeginningOfHierarchicalTransaction { get; }
        
        LayoutList<L1000A_837D> Submitter { get; }
        
        LayoutList<L1000B_837D> Receiver { get; }
        
        LayoutList<L2000A_837D> BillingProviderDetail { get; }
        
        LayoutList<L2000B_837D> SubscriberDetail { get; }
        
        LayoutList<L2000C_837D> PatientDetail { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}