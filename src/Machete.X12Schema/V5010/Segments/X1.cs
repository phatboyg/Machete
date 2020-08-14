namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface X1 :
        X12Segment
    {
        Value<string> CodeForLicensingCertificationRegistrationOrAccreditationAgency { get; }
        
        Value<string> ExportLicenseNumber { get; }
        
        Value<string> ExportLicenseStatusCode { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> ExportLicenseSymbolCode { get; }
        
        Value<string> ExportLicenseControlCode { get; }
        
        Value<string> CountryCode { get; }
        
        Value<string> ScheduleBCode { get; }
        
        Value<string> InternationalOrDomesticCode { get; }
        
        Value<int> LadingQuantity { get; }
        
        Value<decimal> LadingValue { get; }
        
        Value<string> ExportFilingKeyCode { get; }

        Value<string> UnitOrBasisOfMeasurement { get; }

        Value<decimal> UnitPrice { get; }
        
        Value<string> UnitedStatesGovernmentLicenseType { get; }
        
        Value<string> IdentificationCode { get; }
        
        Value<string> LocationIdentifier { get; }
    }
}