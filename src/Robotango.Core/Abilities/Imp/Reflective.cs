// Robotango (c) 2015 Krokodev
// Robotango.Core
// Reflective.cs

using Robotango.Common.Types.Compositions;
using Robotango.Core.Agency.Imp;

namespace Robotango.Core.Abilities.Imp
{
    internal class Reflective : Ability, IReflective
    {
        #region Overrides

        protected override IComponent Clone()
        {
            return new Reflective();
        }

        #endregion
    }
}