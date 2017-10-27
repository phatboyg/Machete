namespace Machete.SchemaConfiguration.Builders
{
    using System.Collections.Generic;
    using Formatters;


    public delegate IEntityFormatter<TEntity> EntityFormatterFactory<TEntity>(IEnumerable<IEntityPropertyFormatter<TEntity>> formatters)
        where TEntity : Entity;
}