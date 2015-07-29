namespace Kolobok.Tests
{
    public interface IComposition
    {
        void Add( IComposition part );
        T Has<T>();
    }
}