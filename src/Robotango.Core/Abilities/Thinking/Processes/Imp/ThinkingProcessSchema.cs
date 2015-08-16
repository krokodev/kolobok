// Robotango (c) 2015 Krokodev
// Robotango.Core
// ThinkingProcessSchema.cs

using System;
using System.Runtime.InteropServices;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Processes.Imp
{
    internal class ThinkingProcessSchema : IThinkingProcessSchema {
        private string _name;

        public ThinkingProcessSchema( string name )
        {
            _name = name;
        }

        public Func< IThinkingProcess, IReality > InputRealitySelector { get; private set; }
    }
}