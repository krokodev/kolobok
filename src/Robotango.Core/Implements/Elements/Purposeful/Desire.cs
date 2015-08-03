// Robotango (c) 2015 Krokodev
// Robotango.Core
// Desire.cs

using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Purposful;

namespace Robotango.Core.Implements.Elements.Purposeful
{
    internal class Desire : IDesire
    {
        public IReality Context { get; private set; }
        public bool IsSatisfied { get; private set; }
    }
}