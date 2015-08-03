// Robotango (c) 2015 Krokodev
// Robotango.Core
// World.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.System;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Implements.Agency
{
    public class World : IWorld
    {
        #region IWorld

        IReality IWorld.Reality
        {
            get { return _thinking.Imaginary; }
        }

        IThinking IWorld.Thinking
        {
            get { return _thinking; }
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