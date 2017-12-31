namespace Machete.Formatters
{
    using System;


    public class UnbuiltEntityFormatter<TEntity> :
        IEntityFormatter<TEntity>
        where TEntity : Entity
    {
        Lazy<IEntityFormatter<TEntity>> _formatter;

        public UnbuiltEntityFormatter(Func<IEntityFormatter<TEntity>> formatterFactory)
        {
            _formatter = new Lazy<IEntityFormatter<TEntity>>(formatterFactory);
        }

        public void Format(FormatContext context, TEntity entity)
        {
            _formatter.Value.Format(context, entity);
        }

        public Type EntityType => typeof(TEntity);

        public void Format<T>(FormatContext context, T entity)
            where T : Entity
        {
            _formatter.Value.Format(context, entity);
        }
    }
}