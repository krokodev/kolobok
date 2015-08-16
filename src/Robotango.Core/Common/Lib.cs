// Robotango (c) 2015 Krokodev
// Robotango.Core
// Lib.Activities.cs

using Robotango.Common.Types.Types;
using Robotango.Core.Abilities;
using Robotango.Core.Elements.Desirous;
using Robotango.Core.Elements.Desirous.Imp;
using Robotango.Core.Elements.Reality;
using Robotango.Core.Elements.Reality.Imp;
using Robotango.Core.Elements.Virtual;

namespace Robotango.Core.Common
{
    public static class Lib
    {
        public static class Activities
        {
            public static readonly IActivity Movement = new Activity< ILocation >(
                "MoveTo",
                ( agent, location ) => {
                    agent
                        .As< IVirtual >()
                        .GetAttribute< IPosition >()
                        .Location = location;
                } );
        }

        public static class Desires
        {
            public static readonly IDesireModel< ILocation > Location = new DesireModel< ILocation >(
                "InLocation",
                ( reality, agent, location ) =>
                    reality.GetAgent( agent ).As< IVirtual >().GetAttribute< IPosition >().Location == location
                );

            public static readonly IDesireModel< INothing > Nothing = new DesireModel< INothing >(
                "Nothing",
                ( reality, agent, nothing ) => true
                );

            public static readonly IDesireModel< INothing > Existing = new DesireModel< INothing >(
                "Existing",
                ( reality, agent, nothing ) => reality.Contains( agent )
                );
        }
    }
}