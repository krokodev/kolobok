// Robotango (c) 2015 Krokodev
// Robotango.Core
// IVirtual.cs

using Robotango.Core.Types.Attributes;

namespace Robotango.Core.Types.Agency.Abilities
{
    public interface IVirtual : IAbility, IAttributeHolder
    {
        void Add( IAttribute attribute );
        T Add<T>() where T : IAttribute, new();
        T GetFirst<T>();
    }
}