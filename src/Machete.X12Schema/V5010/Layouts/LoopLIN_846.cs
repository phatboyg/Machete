namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLIN_846 : 
        X12Layout
    {
        Segment<LIN> ItemIdentification { get; }
        
        Segment<PID> ItemDescription { get; }
        
        Segment<MEA> Measurements { get; }
        
        Segment<PKG> MarkingPackagingLoading { get; }
        
        Segment<DTM> DateOrTimeReference { get;  }
        
        Segment<CTP> PricingInformation { get;  }
        
        Segment<CUR> Currency { get;  }
        
        Segment<SAC> ServiceAllowanceOrChargeInformation { get; }
        
        Segment<REF> ReferenceInformation { get; }
        
        Segment<PER> AdministrativeCommunicationsContact { get; }
        
        Segment<SDQ> DestinationQuantity { get; }
        
        Segment<MAN> MarksAndNumbersInformation { get; }
        
        Segment<UIT> UnitDetail { get; }
        
        Segment<CS> ContractSummary { get; }
        
        Segment<DD> DemandDetail { get; }
        
        Segment<G53> MaintenanceType { get;  }
        
        Segment<PCT> PercentAmounts { get;  }
        
        Segment<LDT> LeadTime { get; }
        
        LayoutList<LoopLM_846> LoopLM { get; }
        
        LayoutList<LoopSLN_846> LoopSLN { get; }
        
        LayoutList<LoopQTY_846> LoopQty { get;  }
        
        LayoutList<LoopN1_846> LoopN1 { get;  }
    }
}