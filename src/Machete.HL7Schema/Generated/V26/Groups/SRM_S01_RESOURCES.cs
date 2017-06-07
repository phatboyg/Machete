// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SRM_S01_RESOURCES (Group) - 
    /// </summary>
    public interface SRM_S01_RESOURCES :
        HL7V26Layout
    {
        /// <summary>
        /// RGS
        /// </summary>
        Segment<RGS> RGS { get; }

        /// <summary>
        /// SERVICE
        /// </summary>
        LayoutList<SRM_S01_SERVICE> Service { get; }

        /// <summary>
        /// GENERAL_RESOURCE
        /// </summary>
        LayoutList<SRM_S01_GENERAL_RESOURCE> GeneralResource { get; }

        /// <summary>
        /// LOCATION_RESOURCE
        /// </summary>
        LayoutList<SRM_S01_LOCATION_RESOURCE> LocationResource { get; }

        /// <summary>
        /// PERSONNEL_RESOURCE
        /// </summary>
        LayoutList<SRM_S01_PERSONNEL_RESOURCE> PersonnelResource { get; }
    }
}