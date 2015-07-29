namespace Kolobok.Core.Types
{
    public interface IComposition
    {
        void Has( IComposition part );
        T Get<T>();
    }
}