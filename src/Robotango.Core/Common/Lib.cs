// Robotango (c) 2015 Krokodev
// Robotango.Core
// Lib.cs

using Robotango.Common.Types.Types;
using Robotango.Core.Abilities.Desirous;
using Robotango.Core.Abilities.Desirous.Imp;
using Robotango.Core.Abilities.Thinking.Processes;
using Robotango.Core.Abilities.Thinking.Processes.Imp;
using Robotango.Core.Abilities.Virtual;
using Robotango.Core.System;
using Robotango.Core.System.Imp;

namespace Robotango.Core.Common
{
    public static class Lib
    {
        public static class Activities
        {
            public static readonly IActivity Movement = new Activity< ILocation >(
                name : "MoveTo",
                action : ( agent, location ) => {
                    agent
                        .As< IVirtual >()
                        .GetAttribute< IPosition >()
                        .Location = location;
                } );
        }

        public static class Desires
        {
            public static readonly IDesireModel< ILocation > Location = new DesireModel< ILocation >(
                name : "InLocation",
                predicate : ( reality, agent, location ) =>
                    reality.GetAgent( agent ).As< IVirtual >().GetAttribute< IPosition >().Location == location
                );

            public static readonly IDesireModel< INothing > Nothing = new DesireModel< INothing >(
                name : "Nothing",
                predicate : ( reality, agent, nothing ) => true
                );

            public static readonly IDesireModel< INothing > Existing = new DesireModel< INothing >(
                name : "Existing",
                predicate : ( reality, agent, nothing ) => reality.Contains( agent )
                );
        }

        public static class Thinking
        {
            public static class Processes
            {
                public static class Shemas
                {
                    public static readonly IThinkingProcessSchema Imaginaton = new ThinkingProcessSchema(
                        name : "Imaginaton",
                        inputRealitySelector : process => (( IImaginationProcess ) process).InnerReality
                        );

                    public static readonly IThinkingProcessSchema Rational = new ThinkingProcessSchema(
                        name : "Rational",
                        inputRealitySelector : process => null
                        );
                }
            }
        }
    }
}