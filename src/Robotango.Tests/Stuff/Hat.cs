// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Hat.cs

using Robotango.Common.Types.Enums;
using Robotango.Common.Types.Types;
using Robotango.Core.Abilities.Virtual;
using Robotango.Core.Abilities.Virtual.Imp;

namespace Robotango.Tests.Stuff
{
    public class Hat : Attribute< Hat >, IHat
    {
        #region IHat

        public IHat IHat {
            get { return this; }
        }

        Colors IColored.Color { get; set; }

        #endregion


        #region Attribute

        protected override string GetDumpContent()
        {
            return string.Format( "Color:{0}", IHat.Color );
        }

        protected override IAttribute Clone()
        {
            var hat = new Hat();
            hat.IHat.Color = IHat.Color;
            return hat;
        }

        #endregion
    }
}