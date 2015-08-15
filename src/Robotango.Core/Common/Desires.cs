// Robotango (c) 2015 Krokodev
// Robotango.Core
// Desires.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Abilities;
using Robotango.Core.Elements.Desirous;
using Robotango.Core.Elements.Virtual;

namespace Robotango.Core.Common
{
    public static class Desires
    {
        public static class Virtual
        {
            public static readonly IDesireModel< ILocation > Location = new DesireModel< ILocation >(
                "InLocation",
                ( reality, agent, location ) =>
                    reality.GetAgent( agent ).As< IVirtual >().GetAttribute< IPosition >().Location == location
                );
        }

        public static class Empty
        {
            public static readonly IDesireModel< INothing > Nothing = new DesireModel< INothing >(
                "Nothing",
                ( reality, agent, nothing ) => true
                );
        }
        public static class Reality
        {
            public static readonly IDesireModel< INothing > Existing = new DesireModel< INothing >(
                "Existing",
                ( reality, agent, nothing ) => reality.Contains( agent )
                );
        }
    }
}