namespace Machete.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Extensions;


    public class DynamicEntityFormatter<TEntity, TSchema> :
        IEntityFormatter<TEntity>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly IEntityPropertyFormatter<TEntity>[] _formatters;

        public DynamicEntityFormatter(IEnumerable<IEntityPropertyFormatter<TEntity>> formatters)
        {
            _formatters = formatters.ToArray();
        }

        public void Format(FormatContext context, TEntity entity)
        {
            for (int i = 0; i < _formatters.Length; i++)
            {
                _formatters[i].Format(context.CreateEntityContext(entity));
            }
        }

        public void Format<T>(FormatContext context, T entity)
            where T : Entity
        {
            var obj = (object) entity;
            if (obj is TEntity)
            {
                Format(context, (TEntity) obj);
            }
            else
                throw new ArgumentException($"Argument entity type was {TypeCache.GetShortName(entity.GetType())}, expected {TypeCache<TEntity>.ShortName}");
        }

        public Type EntityType => typeof(TEntity);
    }
}