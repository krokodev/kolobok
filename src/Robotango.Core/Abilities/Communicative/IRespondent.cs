// Robotango (c) 2015 Krokodev
// Robotango.Core
// IRespondent.cs

namespace Robotango.Core.Abilities.Communicative
{
    public interface IRespondent
    {
        IAnswer< T > Reply<T>( IQuestion< T > question );
    }
}