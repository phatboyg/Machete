namespace Machete.Entities
{
    using System;


    public interface IEntityPropertyConverter<in TEntity>
        where TEntity : Entity
    {
        /// <summary>
        /// Convert the <see cref="TextSlice"/> to the entity property.
        /// </summary>
        /// <param name="entity">The entity instance</param>
        /// <param name="slice">The text fragment</param>
        void Convert(TEntity entity, TextSlice slice);

        void Convert(TEntity entity, ReadOnlySpan<char> span);
    }
}