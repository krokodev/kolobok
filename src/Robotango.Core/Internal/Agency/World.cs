// Robotango (c) 2015 Krokodev
// Robotango.Core
// World.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.System;

namespace Robotango.Core.Internal.Agency
{
    internal class World : IWorld
    {
        #region IWorld

        IReality IWorld.IReality
        {
            get { return _thinking.InnerReality; }
        }

        public IThinking IThinking
        {
            get { return _thinking; }
        }

        IAgent IWorld.IAgent
        {
            get { return _agent; }
        }

        public void Proceed()
        {
            _agent.Proceed();
        }

        IAgent IWorld.GetAgent( IAgent agent )
        {
            return _thinking.InnerReality.GetAgent( agent );
        }

        #endregion


        #region INamed

        private INamed INamed
        {
            get { return this; }
        }

        string INamed.Name
        {
            get { return _agent.Name; }
            set { _agent.Name = value; }
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "{0} <{1}>", INamed.Name, typeof( World ).Name );
            wr.Append( _agent.Dump( wr.Level + 1 ) );
            return wr.ToString();
        }

        #endregion


        #region Ctor

        public World( IFactory factory, string name )
        {
            _agent = factory.CreateAgent< IThinking >( name ?? Settings.Worlds.Names.Default );
            _thinking = _agent.As< IThinking >();
            ;
        }

        #endregion


        #region Fields

        private readonly IAgent _agent;
        private readonly IThinking _thinking;

        #endregion
    }
}