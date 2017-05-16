// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SIU_S12_RESOURCES (Group) - 
    /// </summary>
    public interface SIU_S12_RESOURCES :
        HL7Layout
    {
        /// <summary>
        /// RGS
        /// </summary>
        Segment<RGS> RGS { get; }

        /// <summary>
        /// SERVICE
        /// </summary>
        LayoutList<SIU_S12_SERVICE> Service { get; }

        /// <summary>
        /// GENERAL_RESOURCE
        /// </summary>
        LayoutList<SIU_S12_GENERAL_RESOURCE> GeneralResource { get; }

        /// <summary>
        /// LOCATION_RESOURCE
        /// </summary>
        LayoutList<SIU_S12_LOCATION_RESOURCE> LocationResource { get; }

        /// <summary>
        /// PERSONNEL_RESOURCE
        /// </summary>
        LayoutList<SIU_S12_PERSONNEL_RESOURCE> PersonnelResource { get; }
    }
}