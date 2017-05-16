namespace Machete.StructureConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Configuration;
    using TemplateConfiguration;


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
        public string Name { get; set; }

        public void Add(string propertyName, ILayoutPropertySpecification<TLayout, TSchema> specification)
        {
            _specifications[propertyName] = specification;
        }

        public Type TemplateType => typeof(TLayout);

        public IEnumerable<Type> GetReferencedLayoutTypes()
        {
            return _specifications.Values.SelectMany(x => x.GetReferencedLayoutTypes());
        }

        public void Apply(IStructureBuilder<TSchema> builder)
        {
            var entityMapBuilder = new DynamicLayoutBuilder<TLayout, TSchema>(builder);

            foreach (var specification in _specifications.Values)
            {
                specification.Apply(entityMapBuilder);
            }

            var map = entityMapBuilder.Build();

            builder.Add(map);
        }

        public IEnumerable<ValidateResult> Validate()
        {
            return _specifications.Values.SelectMany(x => x.Validate());
        }
    }
}