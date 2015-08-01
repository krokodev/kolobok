// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Hat.cs

using Robotango.Core.Types.Attributes;
using Robotango.Core.Types.Domain.Abilities;

namespace Robotango.Tests.Stuff
{
    public class Hat : IAttribute, IHat
    {
        #region IHat

        public IHat IHat
        {
            get { return this; }
        }

        Colors IColored.Color { get; set; }

        #endregion


        #region IProperty

        IAttribute IAttribute.Clone()
        {
            var hat = new Hat();
            hat.IHat.Color = IHat.Color;
            return hat;
        }

        IVirtual IAttribute.Virtual { get; set; }
    }

    #endregion
}