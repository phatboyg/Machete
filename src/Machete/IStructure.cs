namespace Machete
{
    public interface IStructure<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Returns the layout specified, if present.
        /// </summary>
        /// <param name="result"></param>
        /// <typeparam name="T">The layout type</typeparam>
        /// <returns></returns>
        bool TryGetLayout<T>(out ILayoutParserFactory<T, TSchema> result)
            where T : Layout;
    }
}