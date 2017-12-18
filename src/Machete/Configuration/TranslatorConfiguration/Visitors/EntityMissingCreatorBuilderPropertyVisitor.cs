namespace Machete.TranslatorConfiguration.Visitors
{
    using System.Reflection;


    public class EntityMissingCreatorBuilderPropertyVisitor<TResult, TSchema> : 
        MissingCreatorBuilderPropertyVisitor<TResult, TSchema>
        where TResult : TSchema
        where TSchema : Entity
    {
        readonly ITranslateBuilderPropertyReflector<EntityMissingCreatorBuilderPropertyVisitor<TResult, TSchema>, TSchema> _reflector;

        public EntityMissingCreatorBuilderPropertyVisitor(IEntityCreatorBuilder<TResult, TSchema> builder)
            : base(builder)
        {
            _reflector = new EntityTranslateBuilderPropertyReflector<EntityMissingCreatorBuilderPropertyVisitor<TResult, TSchema>, TSchema>();
        }

        public override void Property(PropertyInfo property)
        {
            _reflector.Property(this, property);
        }
    }
}