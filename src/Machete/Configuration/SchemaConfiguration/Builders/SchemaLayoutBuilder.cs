namespace Machete.SchemaConfiguration.Builders
{
    using System;
    using Translators;


    public class SchemaLayoutBuilder<TSchema> :
        ISchemaLayoutBuilder<TSchema>
        where TSchema : Entity
    {
        readonly ISchemaLayoutBuilder<TSchema> _schemaBuilder;

        public SchemaLayoutBuilder(ISchemaLayoutBuilder<TSchema> schemaBuilder)
        {
            _schemaBuilder = schemaBuilder ?? throw new ArgumentNullException(nameof(schemaBuilder));
        }

        public ILayoutParserFactory<T, TSchema> GetLayout<T>()
            where T : Layout
        {
            return _schemaBuilder.GetLayout<T>();
        }

        public void Add<T>(ILayoutParserFactory<T, TSchema> factory)
            where T : Layout
        {
            _schemaBuilder.Add(factory);
        }

        public void SetTranslateFactoryProvider(IEntityTranslatorFactoryProvider<TSchema> entityTranslateFactoryProvider)
        {
            _schemaBuilder.SetTranslateFactoryProvider(entityTranslateFactoryProvider);
        }
    }
}