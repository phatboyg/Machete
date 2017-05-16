namespace Machete.StructureConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using Internals.Extensions;
    using StructureConfiguration;


    public class StructureBuilder<TSchema> :
        IStructureBuilder<TSchema>
        where TSchema : Entity
    {
        readonly ISchema<TSchema> _schema;
        readonly IDictionary<Type, ILayout<TSchema>> _layouts;

        public StructureBuilder(ISchema<TSchema> schema)
        {
            _schema = schema;

            _layouts = new Dictionary<Type, ILayout<TSchema>>();
        }

        Type IStructureBuilder<TSchema>.GetImplementationType<T>()
        {
            return _schema.GetImplementationType<T>();
        }

        public ILayout<T, TSchema> GetLayout<T>()
            where T : Layout
        {
            ILayout<TSchema> result;
            if (_layouts.TryGetValue(typeof(T), out result))
            {
                return result as ILayout<T, TSchema>;
            }

            throw new MacheteStructureException($"The layout {TypeCache<T>.ShortName} was not found.");
        }

        public void Add<T>(ILayout<T, TSchema> map)
            where T : Layout
        {
            _layouts.Add(typeof(T), map);
        }

        public IStructure<TSchema> Build()
        {
            return new Structure<TSchema>(_layouts.Values);
        }
    }
}