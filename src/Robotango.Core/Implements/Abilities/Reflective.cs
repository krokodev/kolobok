// Robotango (c) 2015 Krokodev
// Robotango.Core
// Reflective.cs

using Robotango.Common.Domain.Types.Compositions;
using Robotango.Core.Types.Abilities;

namespace Robotango.Core.Implements.Abilities
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