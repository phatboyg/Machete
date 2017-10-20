namespace Machete.X12.Configuration.SchemaConfiguration.Configurators
{
    using Machete.SchemaConfiguration.Builders;
    using Machete.SchemaConfiguration.Configurators;
    using Schema;
    using Translators;
    using TypeSelectors;


    public class X12SchemaConfigurator<TSchema> :
        SchemaConfigurator<TSchema>,
        IX12SchemaConfigurator<TSchema>
        where TSchema : X12Entity
    {
        public X12SchemaConfigurator()
            : base(new TrieEntitySelectorFactory(0))
        {
            AddFromNamespaceContaining<Common>();
        }

        protected override SchemaBuilder<TSchema> CreateSchemaBuilder()
        {
            var builder = base.CreateSchemaBuilder();

            builder.SetTranslateFactoryProvider(new X12EntityTranslateFactoryProvider<TSchema>());

            return builder;
        }
    }
}