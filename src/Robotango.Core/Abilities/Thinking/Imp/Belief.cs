// Robotango (c) 2015 Krokodev
// Robotango.Core
// Belief.cs

using System;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Imp
{
    public class Belief : IBelief
    {
        Action< IReality > IBelief.Essence
        {
            get { return _essence; }
        }

        public Belief( Action< IReality > essence )
        {
            _essence = essence;
        }

        private readonly Action< IReality > _essence;
    }
}