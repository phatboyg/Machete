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
        readonly IDictionary<Type, ILayout<TSchema>> _layouts;

        public Structure(IEnumerable<ILayout<TSchema>> layouts)
        {
            _layouts = layouts.ToDictionary(x => x.LayoutType);
        }

        public bool TryGetLayout<T>(out ILayout<T, TSchema> result)
            where T : Layout
        {
            ILayout<TSchema> layout;
            if (_layouts.TryGetValue(typeof(T), out layout))
            {
                result = layout as ILayout<T, TSchema>;
                return result != null;
            }

            result = null;
            return false;
        }
    }
}