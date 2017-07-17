namespace Machete.HL7.Configuration.SchemaConfiguration.Configurators
{
    using Machete.SchemaConfiguration.Configurators;
    using TypeSelectors;


    public class HL7SchemaConfigurator<TEntity> :
        SchemaConfigurator<TEntity>,
        IHL7SchemaConfigurator<TEntity>
        where TEntity : HL7Entity
    {
        public HL7SchemaConfigurator()
            : base(new TrieEntitySelectorFactory(0))
        {
        }
    }
}