// Robotango (c) 2015 Krokodev
// Robotango.Core
// Thinking.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Elements.Thinking;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.Internal.Agency;
using Robotango.Core.System;

namespace Robotango.Core.Internal.Abilities
{
    internal class Thinking : IThinking
    {
        #region IThinking

        private IThinking IThinking
        {
            get { return this; }
        }

        IReality IThinking.Imagination
        {
            get { return _presentImage; }
        }

        void IThinking.Think()
        {
            _beliefs.ForEach( belief => belief.Essence.Invoke( _presentImage ) );
        }

        void IThinking.AddBelief( IBelief belief )
        {
            _beliefs.Add( belief );
        }

        void IThinking.AddBelief( Action< IReality > realityAction )
        {
            IThinking.AddBelief( new Belief( realityAction ) );
        }

        bool IThinking.HasBelief( IBelief belief )
        {
            return _beliefs.Contains( belief );
        }

        #endregion


        #region IComponent

        void IComponent.InitReferences( IComposite composite )
        {
            _composite = composite;
            _presentImage = new Reality( ( IAgent ) _composite, Settings.Agents.Thinking.InnerReality.Name );
        }

        IComponent IComponent.Clone()
        {
            return new Thinking {
                _beliefs = _beliefs.ToList(),
                _presentImage = _presentImage.Clone()
            };
        }

        #endregion


        #region IVerifiable

        void IVerifiable.Verify()
        {
            _presentImage.Verify();
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "<{0}>", typeof( Thinking ).Name );
            wr.Append( _presentImage.Dump( wr.Level + 1 ) );
            return wr.ToString();
        }

        #endregion


        #region Fields

        private List< IBelief > _beliefs = new List< IBelief >();
        private IReality _presentImage;
        private IComposite _composite;

        #endregion
    }
}