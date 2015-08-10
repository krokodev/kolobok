// Robotango (c) 2015 Krokodev
// Robotango.Core
// Active.cs

using System;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Core.Interfaces.Abilities;

namespace Robotango.Core.Internal.Abilities
{
    internal class Active : IActive
    {
        public IComponent Clone()
        {
            throw new NotImplementedException();
        }

        public void InitReferences( IComposite composition )
        {
            throw new NotImplementedException();
        }
    }
}