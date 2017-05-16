namespace Machete.TemplateConfiguration
{
    using System;
    using System.Collections.Generic;
    using Configuration;
    using StructureConfiguration;


    public interface ILayoutSpecification<TSchema> :
        ISpecification
        where TSchema : Entity
    {
        Type TemplateType { get; }

        IEnumerable<Type> GetReferencedLayoutTypes();

        void Apply(IStructureBuilder<TSchema> builder);
    }
}