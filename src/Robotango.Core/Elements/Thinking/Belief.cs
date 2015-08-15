// Robotango (c) 2015 Krokodev
// Robotango.Core
// Belief.cs

using System;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Thinking
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