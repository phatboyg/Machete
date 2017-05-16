// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RPA_I08 (MessageMap) - 
    /// </summary>
    public class RPA_I08Map :
        HL7LayoutMap<RPA_I08>
    {
        public RPA_I08Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Segment(x => x.RF1, 4);
            Layout(x => x.Authorization, 5);
            Layout(x => x.Provider, 6, x => x.Required = true);
            Segment(x => x.PID, 7, x => x.Required = true);
            Segment(x => x.NK1, 8);
            Segment(x => x.GT1, 9);
            Layout(x => x.Insurance, 10);
            Segment(x => x.ACC, 11);
            Segment(x => x.DG1, 12);
            Segment(x => x.DRG, 13);
            Segment(x => x.AL1, 14);
            Layout(x => x.Procedure, 15, x => x.Required = true);
            Layout(x => x.Observation, 16);
            Layout(x => x.Visit, 17);
            Segment(x => x.NTE, 18);
        }
    }
}