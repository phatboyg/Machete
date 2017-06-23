namespace Machete.StructureConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Configuration;
    using Layouts.LayoutProperties;


    /// <summary>
    /// Matches a layout in a layout
    /// </summary>
    /// <typeparam name="TLayout"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class LayoutLayoutPropertySpecification<TLayout, TSchema, T> :
        ILayoutPropertySpecification<TLayout, TSchema>,
        ILayoutConfigurator<T>
        where TLayout : Layout
        where TSchema : Entity
        where T : Layout
    {
        readonly PropertyInfo _property;

        public LayoutLayoutPropertySpecification(PropertyInfo property, int position)
        {
            _property = property;
            Position = position;
        }

        public IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public int Position { get; }

        public IEnumerable<Type> GetReferencedLayoutTypes()
        {
            yield return typeof(T);
        }

        public IEnumerable<Type> GetReferencedEntityTypes()
        {
            yield break;
        }

        public void Apply(ILayoutBuilder<TLayout, TSchema> builder)
        {
            ILayoutParserFactory<T, TSchema> layout = builder.GetLayout<T>();

            var property = new LayoutLayoutProperty<TLayout, TSchema, T>(builder.ImplementationType, _property, layout, Required);

            builder.Add(property);
        }

        public bool Required { private get; set; }
    }
}