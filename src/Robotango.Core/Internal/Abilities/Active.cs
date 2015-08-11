// Robotango (c) 2015 Krokodev
// Robotango.Core
// Active.cs

using System;
using System.Collections.Generic;
using MoreLinq;
using Robotango.Common.Domain.Implements.Compositions;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Elements.Active;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Internal.Abilities
{
    internal class Active : Component< Active >, IActive
    {
        #region Fields

        private readonly IList<IOperation> _operations = new List< IOperation >();
        private IAgent _agent;

        #endregion


        #region IActive

        IOperation IActive.CreateOperation<T>( Action< IAgent, T > action, IAgent operand, T arg )
        {
            return new Operation< T >( action, operand, arg );
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line( level, "<{0}>", typeof( Active ).Name );
        }

        #endregion


        #region

        public void Proceed()
        {
            OperateInOuterReality();
        }

        #endregion


        #region Component

        protected override void InitAsComponent( IComposite holder )
        {
            _agent = ( IAgent ) holder;
        }

        #endregion


        #region Routines

        private void OperateInOuterReality()
        {
            _operations.ForEach( op=>op.Execute( _agent.OuterReality ) );
        }

        #endregion

    }
}