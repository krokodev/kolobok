// Robotango (c) 2015 Krokodev
// Robotango.Core
// IActive.cs

using Robotango.Core.Agency;
using Robotango.Core.Elements.Active;
using Robotango.Core.Elements.Virtual;

namespace Robotango.Core.Abilities
{
    public interface IActive : IAbility
    {
        IOperation CreateOperation<T>( IActivity activity, IAgent operand, T arg );
        void AddOperation( IOperation operation );
        void AddActivity( IActivity activity );
        bool ContainsOperation<T>( IActivity activity, IAgent operand, T arg );
    }
}