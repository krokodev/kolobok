// Robotango (c) 2015 Krokodev
// Robotango.Core
// IDeciding.cs

using Robotango.Core.Agency;

namespace Robotango.Core.Abilities
{
    public interface IDeciding : IAbility {
        void MakeDecision( IReality reality );
    }
}