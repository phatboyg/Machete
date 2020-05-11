namespace Machete.SchemaConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Builders;
    using Configuration;
    using Layouts;


    public class LayoutSpecification<TLayout, TSchema> :
        ILayoutSpecification<TSchema>
        where TSchema : Entity
        where TLayout : Layout
    {
        readonly IDictionary<string, ILayoutPropertySpecification<TLayout, TSchema>> _specifications;

        public LayoutSpecification()
        {
            _specifications = new Dictionary<string, ILayoutPropertySpecification<TLayout, TSchema>>();
        }

        public void Add(string propertyName, ILayoutPropertySpecification<TLayout, TSchema> specification)
        {
            _specifications[propertyName] = specification;
        }

        public Type LayoutType => typeof(TLayout);
        public string Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Type> GetReferencedLayoutTypes()
        {
            return _specifications.Values.SelectMany(x => x.GetReferencedLayoutTypes());
        }

        public void Apply(ISchemaLayoutBuilder<TSchema> builder)
        {
            BuildFormatter(builder);

            BuildLayout(builder);
        }

        void BuildLayout(ISchemaLayoutBuilder<TSchema> builder)
        {
            ILayoutParserFactory<TLayout, TSchema> CreateLayout()
            {
                var layoutBuilder = new DynamicLayoutBuilder<TLayout, TSchema>(builder);

                foreach (var specification in _specifications.Values)
                {
                    specification.Apply(layoutBuilder);
                }

                ILayoutParserFactory<TLayout, TSchema> layout = layoutBuilder.Build();

                return layout;
            }

            builder.Add(new UnbuiltLayoutParserFactory<TLayout, TSchema>(CreateLayout));
        }

        void BuildFormatter(ISchemaLayoutBuilder<TSchema> builder)
        {
            ILayoutFactory<TLayout> Factory()
            {
                try
                {
                    var formatterBuilder = new DynamicEntityFormatterBuilder<TEntity, TSchema>(builder);

                    if (FormatterFactory != null)
                        formatterBuilder.Factory = FormatterFactory;

                    foreach (var specification in _specifications)
                        specification.Apply(formatterBuilder);

                    return formatterBuilder.Build();
                }
                catch (Exception exception)
                {
                    throw new SchemaConfigurationException($"Failed to build entity formatter: {TypeCache<TEntity>.ShortName}", exception);
                }
            }

            builder.Add(new UnbuiltEntityFormatter<TEntity>(Factory));
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.Values.SelectMany(x => x.Validate());
        }
    }
}