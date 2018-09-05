// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// VH (Component) - Visiting Hours
    /// </summary>
    public interface VH :
        HL7V26Component
    {
        /// <summary>
        /// VH-1  Start Day Range
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> StartDayRange { get; }

        /// <summary>
        /// VH-2  End Day Range
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> EndDayRange { get; }

        /// <summary>
        /// VH-3  Start Hour Range
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> StartHourRange { get; }

        /// <summary>
        /// VH-4  End Hour Range
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> EndHourRange { get; }
    }
}