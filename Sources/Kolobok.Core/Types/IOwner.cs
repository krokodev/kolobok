namespace Kolobok.Core.Types
{
    public interface IOwner
    {
        void Set( IProperty property );
        T Get<T>();
    }
}