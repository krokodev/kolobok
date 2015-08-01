// Robotango (c) 2015 Krokodev
// Robotango.Core
// Rational.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Robotango.Core.Common;
using Robotango.Core.Types;
using Robotango.Core.Utils;

namespace Robotango.Core.Implementations
{
    public class Rational : IRational, IComponent
    {
        #region IRational

        void IRational.Think()
        {
            _presentImage.Clear();
            _beliefs.ForEach( belief => belief.Invoke( _presentImage ) );
        }

        public void Believes( Action< IWorld > belief )
        {
            _beliefs.Add( belief );
        }

        public IWorld Imaginary
        {
            get { return _presentImage; }
        }

        #endregion


        #region IComponent

        void IComponent.Init( IComposition composition )
        {
            _composition = composition;
            _presentImage = new World( ( IAgent ) _composition, Constants.Worlds.Names.Imaginary );
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

        void ISkill.Verify()
        {
            _presentImage.Verify();
        }

        #endregion


        #region Fields

        private List< Action< IWorld > > _beliefs = new List< Action< IWorld > >();
        private IWorld _presentImage;
        private IComposition _composition;

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