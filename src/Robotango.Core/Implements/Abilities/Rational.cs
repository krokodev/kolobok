// Robotango (c) 2015 Krokodev
// Robotango.Core
// Rational.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Implements.Agency;
using Robotango.Core.System;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Implements.Abilities
{
    public class Rational : IRational
    {
        #region IRational

        void IRational.Think()
        {
            _presentImage.Clear();
            _beliefs.ForEach( belief => belief.Invoke( _presentImage ) );
        }

        void IRational.Believes( Action< IReality > belief )
        {
            _beliefs.Add( belief );
        }

        IReality IRational.Imaginary
        {
            get { return _presentImage; }
        }

        #endregion


        #region IComponent

        void IComponent.Init( IComposite composite )
        {
            _composite = composite;
            _presentImage = new Reality( ( IAgent ) _composite, Settings.Reality.Names.Imaginary );
        }

        IComponent IComponent.Clone()
        {
            return new Rational {
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
            wr.Line( "<{0}>", typeof( Rational ).Name );
            wr.Append( _presentImage.Dump( wr.Level + 1 ) );
            return wr.ToString();
        }

        #endregion


        #region Fields

        private List< Action< IReality > > _beliefs = new List< Action< IReality > >();
        private IReality _presentImage;
        private IComposite _composite;

        #endregion
    }
}