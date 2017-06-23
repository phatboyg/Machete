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
        readonly IDictionary<Type, ILayoutParserFactory> _layouts;

        public StructureBuilder(ISchema<TSchema> schema)
        {
            _schema = schema;

            _layouts = new Dictionary<Type, ILayoutParserFactory>();
        }

        Type IStructureBuilder<TSchema>.GetImplementationType<T>()
        {
            return _schema.GetImplementationType<T>();
        }

        public ILayoutParserFactory<T, TSchema> GetLayout<T>()
            where T : Layout
        {
            ILayoutParserFactory result;
            if (_layouts.TryGetValue(typeof(T), out result))
            {
                return result as ILayoutParserFactory<T, TSchema>;
            }

            throw new MacheteStructureException($"The layout {TypeCache<T>.ShortName} was not found.");
        }

        public void Add<T>(ILayoutParserFactory<T, TSchema> map)
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