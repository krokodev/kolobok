// Robotango (c) 2015 Krokodev
// Robotango.Core
// IRespondent.cs

using Robotango.Core.Types.Elements.Communicative;

namespace Robotango.Core.Types.Abilities
{
    public interface IRespondent
    {
        IAnswer< T > Reply<T>( IQuestion< T > question );
    }
}