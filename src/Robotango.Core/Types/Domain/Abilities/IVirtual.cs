// Robotango (c) 2015 Krokodev
// Robotango.Core
// IVirtual.cs

using Robotango.Core.Types.Attributes;
using Robotango.Core.Types.Domain.Agency;

namespace Robotango.Core.Types.Domain.Abilities
{
    public interface IVirtual : IAbility
    {
        void Add( IAttribute attribute );
        T Add<T>() where T : IAttribute, new();
        T GetFirst<T>();
    }
}