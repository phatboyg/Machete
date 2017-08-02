namespace Machete.TranslateConfiguration.Visitors
{
    using System.Reflection;


    public class EntityMissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema> : 
        MissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly ITranslateBuilderPropertyReflector<ITranslateBuilderPropertyVisitor<TSchema>, TSchema> _reflector;

        public EntityMissingTranslateBuilderPropertyVisitor(ITranslateBuilder<TResult, TInput, TSchema> builder)
            : base(builder)
        {
            _reflector = new EntityTranslateBuilderPropertyReflector<ITranslateBuilderPropertyVisitor<TSchema>, TResult, TInput, TSchema>();
        }

        public override void Property(PropertyInfo property)
        {
            _reflector.Property(this, property);
        }
    }
}