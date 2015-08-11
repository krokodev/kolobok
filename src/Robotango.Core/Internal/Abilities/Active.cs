// Robotango (c) 2015 Krokodev
// Robotango.Core
// Active.cs

using System;
using System.Collections.Generic;
using MoreLinq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Elements.Active;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.Internal.Agency;

// Here: Active

namespace Robotango.Core.Internal.Abilities
{
    internal class Active : Ability, IActive
    {
        #region Data

        private readonly IList< IOperation > _operations = new List< IOperation >();

        #endregion


        #region Overrides

        protected override IComponent Clone()
        {
            return new Active();
        }

        #endregion


        #region IActive

        IOperation IActive.CreateOperation<T>( Action< IAgent, T > action, IAgent operand, T arg )
        {
            return new Operation< T >( action, operand, arg );
        }

        public void AddOperation( IOperation operation )
        {
            _operations.Add( operation );
        }

        #endregion



        #region IProceedable

        void IProceedable< IReality >.Proceed( IReality reality )
        {
            // Code: Active.Proceed

            _operations.ForEach( op => op.Execute( reality ) );
            _operations.Clear();
        }

        #endregion
    }
}