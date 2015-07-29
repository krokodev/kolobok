// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Rational.cs

using System;
using Kolobok.Core.Types;

namespace Kolobok.Core.Items
{
    public class Rational : IRational, IComponent
    {
        #region IRational

        void IRational.Think() {}
        public void Believes( Action< IWorld > belief )
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}