// Robotango (c) 2015 Krokodev
// Robotango.Common
// IComponent.cs

using System.Collections.Generic;

namespace Robotango.Common.Domain.Types.Compositions
{
    public interface IComponent
    {
        IComponent Clone();
        void InitReferences( IComposite composition );
        IList< IComponent > Dependences { get; }
        IComposite Holder { get; }
    }
}