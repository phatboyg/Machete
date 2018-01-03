namespace Machete.HL7.Tests.TestSchema
{
    public class JCCComponentMap :
        HL7ComponentMap<JCCComponent, HL7Component>
    {
        public JCCComponentMap()
        {
            Value(x => x.JobCode, 0);
            Value(x => x.JobClass, 1);
        }
    }
}