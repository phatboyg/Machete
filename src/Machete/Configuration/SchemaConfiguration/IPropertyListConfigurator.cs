namespace Machete.SchemaConfiguration
{
    public interface IPropertyListConfigurator :
        IPropertyConfigurator
    {
        /// <summary>
        /// Sets the slice provider to return the entire <see cref="TextSlice"/>
        /// </summary>
        void SetParent();

        /// <summary>
        /// Sets the slice provider to return the range of text slices starting at <see cref="IPropertyConfigurator.Position"/>
        /// </summary>
        void SetRange();

        /// <summary>
        /// Sets the slice provider to return the slice as a list, if possible
        /// </summary>
        void SetList();

        /// <summary>
        /// Sets the slice provider to return a single text slice at position
        /// </summary>
        void SetSingle();
    }


    public interface IPropertyListConfigurator<T> :
        IPropertyConfigurator<T>,
        IPropertyListConfigurator
    {
    }
}