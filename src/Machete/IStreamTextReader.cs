namespace Machete
{
    using System.Threading.Tasks;
    using Texts;


    /// <summary>
    /// Used to incrementally read the stream into parsable text
    /// </summary>
    public interface IStreamTextReader
    {
        /// <summary>
        /// Return the next span, including the <paramref name="left"/> span.
        /// </summary>
        /// <param name="left"></param>
        /// <returns></returns>
        Task<StreamText> Next(ParseText left);
    }
}