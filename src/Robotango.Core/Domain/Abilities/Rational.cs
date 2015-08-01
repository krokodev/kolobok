// Robotango (c) 2015 Krokodev
// Robotango.Core
// Rational.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Implements.Tools;
using Robotango.Common.Types.Compositions;
using Robotango.Common.Types.Properties;
using Robotango.Core.Domain.Agents;
using Robotango.Core.Domain.System;
using Robotango.Core.Types.Domain.Abilities;
using Robotango.Core.Types.Domain.Agency;

namespace Robotango.Core.Domain.Abilities
{
    public class Rational : IRational
    {
        #region IRational

        void IRational.Think()
        {
            _presentImage.Clear();
            _beliefs.ForEach( belief => belief.Invoke( _presentImage ) );
        }

        public void Believes( Action< IReality > belief )
        {
            _beliefs.Add( belief );
        }

        public IReality Imaginary
        {
            get { return _presentImage; }
        }

        #endregion


        #region IComponent

        void IComponent.Init( IComposite composite )
        {
            _composite = composite;
            _presentImage = new Reality( ( IAgent ) _composite, Settings.Worlds.Names.Imaginary );
        }

        IComponent IComponent.Clone()
        {
            return new Rational {
                _beliefs = _beliefs.ToList(),
                _presentImage = _presentImage.Clone()
            };
        }

        #endregion


        #region IAspect

        void IVerifiable.Verify()
        {
            _presentImage.Verify();
        }

        #endregion


        #region Fields

        private List< Action< IReality > > _beliefs = new List< Action< IReality > >();
        private IReality _presentImage;
        private IComposite _composite;

        #endregion


        #region IResearchable

        string IResearchable.GetDump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "<{0}>", typeof( Rational ).Name );
            wr.Append( _presentImage.GetDump( wr.Level + 1 ) );
            return wr.ToString();
        }

        #endregion
    }
}