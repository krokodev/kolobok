// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Rational.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Kolobok.Core.Common;
using Kolobok.Core.Types;

namespace Kolobok.Core.Implementations
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

        void IAspect.Verify()
        {
            _presentImage.Verify();
        }

        #endregion


        #region Fields

        private List< Action< IWorld > > _beliefs = new List< Action< IWorld > >();
        private IWorld _presentImage;
        private IComposition _composition;

        #endregion
    }
}