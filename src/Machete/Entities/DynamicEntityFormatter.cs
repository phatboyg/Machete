using System.Collections.Generic;
using System.Linq;
using Machete.Slices;


namespace Machete.Entities
{
    using System;


    public class DynamicEntityFormatter<TEntity, TSchema> :
        IEntityFormatter<TEntity>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly ITextSliceProvider<TEntity>[] _sliceProviders;

        public DynamicEntityFormatter(IEnumerable<ITextSliceProvider<TEntity>> sliceProviders)
        {
            _sliceProviders = sliceProviders.ToArray();
        }

        public TextSlice FormatEntity(TEntity entity)
        {
            return new EntitySlice<TEntity>(entity, _sliceProviders);
        }

        public Type EntityType => typeof(TEntity);
    }
}