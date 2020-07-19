// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CER (SegmentMap) - Certificate Detail
    /// </summary>
    public class CERMap :
        HL7V26SegmentMap<CER>
    {
        public CERMap()
        {
            Id = "CER";

            Name = "Certificate Detail";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Value(x => x.SerialNumber, 2);
            Value(x => x.Version, 3);
            Entity(x => x.GrantingAuthority, 4);
            Entity(x => x.IssuingAuthority, 5);
            Entity(x => x.SignatureOfIssuingAuthority, 6);
            Value(x => x.GrantingCountry, 7);
            Entity(x => x.GrantingStateProvince, 8);
            Entity(x => x.GrantingCountyParish, 9);
            Entity(x => x.CertificateType, 10);
            Entity(x => x.CertificateDomain, 11);
            Value(x => x.SubjectId, 12);
            Value(x => x.SubjectName, 13, x => x.IsRequired());
            Entity(x => x.SubjectDirectoryAttributeExtension, 14);
            Entity(x => x.SubjectPublicKeyInfo, 15);
            Entity(x => x.AuthorityKeyIdentifier, 16);
            Value(x => x.BasicConstraint, 17);
            Entity(x => x.CRLDistributionPoint, 18);
            Value(x => x.JurisdictionCountry, 19);
            Entity(x => x.JurisdictionStateProvince, 20);
            Entity(x => x.JurisdictionCountyParish, 21);
            Entity(x => x.JurisdictionBreadth, 22);
            Value(x => x.GrantingDate, 23, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.IssuingDate, 24, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ActivationDate, 25, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.InactivationDate, 26, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ExpirationDate, 27, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.RenewalDate, 28, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.RevocationDate, 29, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.RevocationReasonCode, 30);
            Entity(x => x.CertificateStatusCode, 31);
        }
    }
}