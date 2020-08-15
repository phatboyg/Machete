namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface PI :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }

        Value<string> PrimaryPublicationAuthorityCode { get; }

        Value<string> RegulatoryAgencyCode { get; }
        
        Value<string> TariffAgencyCode { get; }
        
        Value<string> IssuingCarrierIdentifier { get; }
        
        Value<string> ContractSuffix1 { get; }
        
        Value<string> TariffItemNumber { get; }
        
        Value<string> TariffSupplementIdentifier { get; }
        
        Value<string> TariffSectionNumber { get; }
        
        Value<string> ContractSuffix2 { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> AlternationPrecedenceCode1 { get; }
        
        Value<string> AlternationPrecedenceCode2 { get; }
        
        Value<string> ServiceLevelCode { get; }
    }
}