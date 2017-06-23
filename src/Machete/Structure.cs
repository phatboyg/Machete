namespace Machete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public static class Structure
    {
        public static readonly IStructureFactorySelector Factory = new UnusedStructureFactorySelector();


        class UnusedStructureFactorySelector :
            IStructureFactorySelector
        {
        }
    }


    public class Structure<TSchema> :
        IStructure<TSchema>
        where TSchema : Entity
    {
        readonly IDictionary<Type, ILayoutParserFactory> _layouts;

        public Structure(IEnumerable<ILayoutParserFactory> layouts)
        {
            _layouts = layouts.ToDictionary(x => x.LayoutType);
        }

        public bool TryGetLayout<T>(out ILayoutParserFactory<T, TSchema> result)
            where T : Layout
        {
            ILayoutParserFactory layoutParserFactory;
            if (_layouts.TryGetValue(typeof(T), out layoutParserFactory))
            {
                result = layoutParserFactory as ILayoutParserFactory<T, TSchema>;
                return result != null;
            }

            result = null;
            return false;
        }
    }
}