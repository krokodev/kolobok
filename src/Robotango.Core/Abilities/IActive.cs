// Robotango (c) 2015 Krokodev
// Robotango.Core
// IActive.cs

using System.Collections.Generic;
using Robotango.Core.Agency;
using Robotango.Core.Elements.Reality;

namespace Robotango.Core.Abilities
{
    public interface IActive : IAbility
    {
        void AddActivity( IActivity activity );
        bool ContainsIntention<T>( IActivity activity, IAgent operand, T arg );
        void AddIntention<T>( IActivity activity, IAgent operand, T arg );
        IList< IActivity > Activities { get; }
    }
}