// Robotango (c) 2015 Krokodev
// Robotango.Core
// Lib.Activities.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Abilities;
using Robotango.Core.Elements.Reality;
using Robotango.Core.Elements.Virtual;

namespace Robotango.Core.Common
{
    public static partial class Lib
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
    }
}