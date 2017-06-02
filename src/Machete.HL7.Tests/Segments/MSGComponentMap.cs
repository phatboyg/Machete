namespace Machete.HL7.Tests.Segments
{
    public class MSGComponentMap :
        HL7ComponentMap<MSG, HL7Component>
    {
        public MSGComponentMap()
        {
            Value(x => x.MessageCode, 0, x => x.Required = true);
            Value(x => x.TriggerEvent, 1, x => x.Required = true);
            Value(x => x.MessageStructure, 2);
        }
    }
}