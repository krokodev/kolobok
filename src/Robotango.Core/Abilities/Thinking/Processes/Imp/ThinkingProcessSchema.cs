// Robotango (c) 2015 Krokodev
// Robotango.Core
// ThinkingProcessSchema.cs

using System;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Processes.Imp
{
    internal class ThinkingProcessSchema : IThinkingProcessSchema
    {
        #region Data

        private readonly string _name;
        private readonly Func< IThinkingProcess, IReality > _inputRealitySelector;

        #endregion


        #region Ctor

        public ThinkingProcessSchema( string name, Func< IThinkingProcess, IReality > inputRealitySelector )
        {
            _name = name;
            _inputRealitySelector = inputRealitySelector;
        }

        #endregion


        #region IThinkingProcessSchema

        Func< IThinkingProcess, IReality > IThinkingProcessSchema.InputRealitySelector
        {
            get { return _inputRealitySelector; }
        }

        string IThinkingProcessSchema.Name
        {
            get { return _name; }
        }

        #endregion
    }
}