// Robotango (c) 2015 Krokodev
// Robotango.Core
// Reflective.cs

using Robotango.Common.Domain.Types.Compositions;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Internal.Agency;

namespace Robotango.Core.Internal.Abilities
{
    internal class Reflective : Ability, IReflective {
        #region Overrides

        protected override IComponent Clone()
        {
            return new Reflective();
        }

        #endregion
    }
}