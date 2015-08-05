// Robotango (c) 2015 Krokodev
// Robotango.Core
// Reflective.cs

using Robotango.Common.Domain.Types.Compositions;
using Robotango.Core.Interfaces.Abilities;

namespace Robotango.Core.Internal.Abilities
{
    internal class Reflective : IReflective
    {
        #region IComponent

        void IComponent.InitReferences( IComposite composite ) {}

        IComponent IComponent.Clone()
        {
            return new Reflective();
        }

        #endregion
    }
}