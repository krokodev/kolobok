// Robotango (c) 2015 Krokodev
// Robotango.Core
// ThinkingSchema.cs

using System;
using Robotango.Core.Abilities.Thinking.Processes;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Thinking.Schemas
{
    internal class ThinkingSchema : IThinkingSchema
    {
        #region Data

        private readonly string _name;
        private readonly Func< IThinkingProcess, IReality > _inputRealitySelector;
        private readonly Func< IThinkingProcess, IReality > _outputRealitySelector;
        private readonly Action< IThinkingProcess > _proceed;

        #endregion


        #region Ctor

        public ThinkingSchema(
            string name,
            Func< IThinkingProcess, IReality > inputRealitySelector,
            Func< IThinkingProcess, IReality > outputRealitySelector,
            Action< IThinkingProcess > proceed
            )
        {
            _name = name;
            _inputRealitySelector = inputRealitySelector;
            _outputRealitySelector = outputRealitySelector;
            _proceed = proceed;
        }

        #endregion


        #region IThinkingSchema

        Func< IThinkingProcess, IReality > IThinkingSchema.InputRealitySelector {
            get { return _inputRealitySelector; }
        }

        Func< IThinkingProcess, IReality > IThinkingSchema.OutputRealitySelector {
            get { return _outputRealitySelector; }
        }

        Action< IThinkingProcess > IThinkingSchema.Proceed {
            get { return _proceed; }
        }

        string IThinkingSchema.Name {
            get { return _name; }
        }

        #endregion
    }
}