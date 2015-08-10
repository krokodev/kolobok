// Robotango (c) 2015 Krokodev
// Robotango.Core
// Activities.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Active
{
    public static class Activities
    {
        public static class Virtual
        {
            public static readonly Action< IAgent, ILocation > Move =
                ( agent, location ) => agent.As< IVirtual >().GetAttribute< IPosition >().Location = location;
        }
    }
}