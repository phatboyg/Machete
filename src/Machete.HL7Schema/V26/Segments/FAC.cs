// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// FAC (Segment) - Facility
    /// </summary>
    public interface FAC :
        HL7V26Segment
    {
        /// <summary>
        /// FAC-1: Facility ID-FAC
        /// </summary>
        Value<EI> FacilityId { get; }

        /// <summary>
        /// FAC-2: Facility Type
        /// </summary>
        Value<string> FacilityType { get; }

        /// <summary>
        /// FAC-3: Facility Address
        /// </summary>
        ValueList<XAD> FacilityAddress { get; }

        /// <summary>
        /// FAC-4: Facility Telecommunication
        /// </summary>
        Value<XTN> FacilityTelecommunication { get; }

        /// <summary>
        /// FAC-5: Contact Person
        /// </summary>
        ValueList<XCN> ContactPerson { get; }

        /// <summary>
        /// FAC-6: Contact Title
        /// </summary>
        ValueList<string> ContactTitle { get; }

        /// <summary>
        /// FAC-7: Contact Address
        /// </summary>
        ValueList<XAD> ContactAddress { get; }

        /// <summary>
        /// FAC-8: Contact Telecommunication
        /// </summary>
        ValueList<XTN> ContactTelecommunication { get; }

        /// <summary>
        /// FAC-9: Signature Authority
        /// </summary>
        ValueList<XCN> SignatureAuthority { get; }

        /// <summary>
        /// FAC-10: Signature Authority Title
        /// </summary>
        Value<string> SignatureAuthorityTitle { get; }

        /// <summary>
        /// FAC-11: Signature Authority Address
        /// </summary>
        ValueList<XAD> SignatureAuthorityAddress { get; }

        /// <summary>
        /// FAC-12: Signature Authority Telecommunication
        /// </summary>
        Value<XTN> SignatureAuthorityTelecommunication { get; }
    }
}