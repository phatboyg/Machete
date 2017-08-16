namespace Machete
{
    public interface IImplementedType
    {
        void ImplementsType<T>(bool direct)
            where T : class;
    }
}