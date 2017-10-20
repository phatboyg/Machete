namespace Machete
{
    using System.IO;
    using System.Threading.Tasks;
    using Formatters;


    public interface IFormatter<TSchema>
        where TSchema : Entity
    {
        Task<FormatResult<TSchema>> FormatAsync(Stream output, EntityResult<TSchema> input);
    }
}