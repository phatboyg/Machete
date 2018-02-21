namespace Machete.SchemaConfiguration
{
    using System;
    using System.Collections.Generic;
    using Configuration;


    public interface ILayoutSpecification<TSchema> :
        ISpecification
        where TSchema : Entity
    {
        Type LayoutType { get; }
        
        string Id { get; }
        
        string Name { get; }

        IEnumerable<Type> GetReferencedLayoutTypes();

        void Apply(ISchemaLayoutBuilder<TSchema> builder);
    }
}