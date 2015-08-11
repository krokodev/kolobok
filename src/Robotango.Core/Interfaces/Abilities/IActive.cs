// Robotango (c) 2015 Krokodev
// Robotango.Core
// IActive.cs

using Robotango.Core.Elements.Active;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Interfaces.Abilities
{
    public interface IActive : IAbility
    {
        IOperation CreateOperation<T>( IActivity activity, IAgent operand, T arg );
        void AddOperation( IOperation operation );
        void AddActivity<T>( IActivity activity );
    }
}