// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Rational.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Kolobok.Core.Types;

namespace Kolobok.Core.Items
{
    public class Rational : IRational, IComponent
    {
        #region IRational

        void IRational.Think()
        {
            _beliefs.ForEach( b => b( _present ) );
        }

        public void Believes( Action< IWorld > belief )
        {
            _beliefs.Add( belief );
        }

        public IWorld Present
        {
            get { return _present; }
        }

        #endregion


        #region IComponent

        IComponent IComponent.Clone()
        {
            return new Rational {
                _beliefs = _beliefs.ToList(),
                _present = _present.Clone()
            };
        }

        #endregion


        #region Fields

        private List< Action< IWorld > > _beliefs = new List< Action< IWorld > >();
        private IWorld _present = new World();

        #endregion
    }
}