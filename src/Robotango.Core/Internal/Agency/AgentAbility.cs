// Robotango (c) 2015 Krokodev
// Robotango.Core
// Ability.cs

using Robotango.Common.Domain.Implements.Compositions;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Internal.Agency
{
    public abstract class AgentAbility<T> : Component< T >
        where T : IComponent, new()
    {
        #region Protected

        protected IAgent Agent
        {
            get { return ( IAgent ) IComponent.Composition; }
        }

        protected TA GetAbility<TA>() where TA : IAbility
        {
            return IComponent.Composition.GetComponent< TA >();
        }

        #endregion
    }
}