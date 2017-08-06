namespace Machete.HL7.Configuration.SchemaConfiguration.Configurators
{
    using Machete.SchemaConfiguration.Builders;
    using Machete.SchemaConfiguration.Configurators;
    using Translators;
    using TypeSelectors;


    public class HL7SchemaConfigurator<TSchema> :
        SchemaConfigurator<TSchema>,
        IHL7SchemaConfigurator<TSchema>
        where TSchema : HL7Entity
    {
        public HL7SchemaConfigurator()
            : base(new TrieEntitySelectorFactory(0))
        {
        }

        protected override SchemaBuilder<TSchema> CreateSchemaBuilder()
        {
            var builder = base.CreateSchemaBuilder();

            builder.SetTranslateFactoryProvider(new Hl7EntityTranslateFactoryProvider<TSchema>());

            return builder;
        }
    }
}