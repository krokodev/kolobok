namespace Kolobok.Core.Types
{
    public interface IOwner
    {
        void Has( IProperty property );
        T Get<T>();
    }
}