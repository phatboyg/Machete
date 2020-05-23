﻿namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000B_837I :
        X12Layout
    {
        Segment<HL> SubscriberHierarchicalLevel { get; }
        
        Segment<SBR> SubscriberInformation { get; }
        
        Layout<L2010BA_837I> Subscriber { get; }
        
        Layout<L2010BB_837I> Payer { get; }
    }
}