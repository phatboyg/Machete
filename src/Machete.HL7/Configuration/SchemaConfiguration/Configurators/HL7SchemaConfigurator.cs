namespace Machete.HL7.Configuration.SchemaConfiguration.Configurators
{
    using Machete.SchemaConfiguration.Configurators;
    using TypeSelectors;


    public class HL7SchemaConfigurator :
        SchemaConfigurator<HL7Entity>,
        IHL7SchemaConfigurator
    {
        public HL7SchemaConfigurator()
            : base(new TrieEntityTypeSelectorFactory(0))
        {
        }
    }
}