// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CTD (Segment) - Contact Data
    /// </summary>
    public interface CTD :
        HL7V26Segment
    {
        /// <summary>
        /// CTD-1: Contact Role
        /// </summary>
        ValueList<CWE> ContactRole { get; }

        /// <summary>
        /// CTD-2: Contact Name
        /// </summary>
        ValueList<XPN> ContactName { get; }

        /// <summary>
        /// CTD-3: Contact Address
        /// </summary>
        ValueList<XAD> ContactAddress { get; }

        /// <summary>
        /// CTD-4: Contact Location
        /// </summary>
        Value<PL> ContactLocation { get; }

        /// <summary>
        /// CTD-5: Contact Communication Information
        /// </summary>
        ValueList<XTN> ContactCommunicationInformation { get; }

        /// <summary>
        /// CTD-6: Preferred Method of Contact
        /// </summary>
        Value<CWE> PreferredMethodOfContact { get; }

        /// <summary>
        /// CTD-7: Contact Identifiers
        /// </summary>
        ValueList<PLN> ContactIdentifiers { get; }
    }
}