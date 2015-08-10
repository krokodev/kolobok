// Robotango (c) 2015 Krokodev
// Robotango.Core
// Active.cs

using System;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Elements.Active;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Internal.Abilities
{
    internal class Active : IActive, IResearchable
    {
        #region IComponent

        IComponent IComponent.Clone()
        {
            return new Active();
        }

        #endregion


        #region IComponent

        void IComponent.InitReferences( IComposite composition )
        {
            _agent = ( IAgent ) composition;
        }

        public IOperation CreateOperation<T>( Action< IAgent, T > action, IAgent operand, T arg )
        {
            return new Operation< T >( _agent, action, operand, arg );
        }

        #endregion


        #region Fields

        private IAgent _agent;

        #endregion


                #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line( level,"<{0}>", typeof( Active ).Name );
        }

        #endregion

    }
}