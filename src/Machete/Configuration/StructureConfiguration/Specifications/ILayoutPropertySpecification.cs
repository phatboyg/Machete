namespace Machete.StructureConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using Configuration;


    public interface ILayoutPropertySpecification<in TLayout, TSchema> :
        ISpecification
        where TSchema : Entity
        where TLayout : Layout
    {
        /// <summary>
        /// Returns the template types referenced by this property
        /// </summary>
        /// <returns></returns>
        IEnumerable<Type> GetReferencedLayoutTypes();

        /// <summary>
        /// Apply the specification to the builder
        /// </summary>
        /// <param name="builder"></param>
        void Apply(ILayoutBuilder<TLayout, TSchema> builder);
    }
}