// Robotango (c) 2015 Krokodev
// Robotango.Core
// IRespondent.cs

using Robotango.Core.Elements.Communicative;

namespace Robotango.Core.Abilities
{
    public interface IRespondent
    {
        IAnswer< T > Reply<T>( IQuestion< T > question );
    }
}