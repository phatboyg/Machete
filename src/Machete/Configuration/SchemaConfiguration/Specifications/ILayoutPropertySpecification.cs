﻿namespace Machete.SchemaConfiguration.Specifications
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
        /// Used to order the properties before adding them to the layout, can't assume natural order is perfect.
        /// </summary>
        int Position { get; }

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

        IEnumerable<Type> GetReferencedEntityTypes();
    }
}