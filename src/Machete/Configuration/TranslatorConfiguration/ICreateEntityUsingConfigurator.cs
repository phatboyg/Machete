namespace Machete.TranslatorConfiguration
{
    using System;


    /// <summary>
    /// Configure entity creation, as part of a translation
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public interface ICreateEntityUsingConfigurator<out TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        /// <summary>
        /// Specify the translate to use for the entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Using<T>()
            where T : IEntityCreatorSpecification<TEntity, TSchema>, new();

        /// <summary>
        /// Specify a translate inline without having to define a separate class
        /// </summary>
        /// <param name="configure"></param>
        void By(Action<IEntityCreatorConfigurator<TEntity, TSchema>> configure);
    }
}