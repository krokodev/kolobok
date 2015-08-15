// Robotango (c) 2015 Krokodev
// Robotango.Core
// World.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Abilities;
using Robotango.Core.System;

namespace Robotango.Core.Agency.Imp
{
    internal class World : IWorld
    {
        #region IWorld

        private IWorld IWorld
        {
            get { return this; }
        }

        IReality IWorld.IReality
        {
            get { return _thinking.InnerReality; }
        }

        public IThinking IThinking
        {
            get { return _thinking; }
        }

        void IWorld.Proceed()
        {
            _agent.Proceed( null );
        }

        IAgent IWorld.GetAgent( IAgent agent )
        {
            return _thinking.InnerReality.GetAgent( agent );
        }

        string IWorld.Name
        {
            get { return _agent.Name; }
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "{0} <{1}>", IWorld.Name, typeof( World ).Name );
            wr.Append( _agent.Dump( wr.Level + 1 ) );
            return wr.ToString();
        }

        #endregion


        #region Ctor

        public World( IFactory factory, string name )
        {
            _agent = factory.CreateAgent< IThinking >( name ?? Settings.Worlds.Names.Default );
            _thinking = _agent.As< IThinking >();
        }

        #endregion


        #region Data

        private readonly IAgent _agent;
        private readonly IThinking _thinking;

        #endregion
    }
}