namespace Machete.Translators
{
    using System.Threading.Tasks;


    public delegate Task<bool> TranslateEntityFilter<T, TSchema>(TranslateContext<T, TSchema> context)
        where TSchema : Entity
        where T : TSchema;
}