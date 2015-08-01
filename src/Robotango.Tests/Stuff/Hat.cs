// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Hat.cs

using Robotango.Common.Types.Enums;
using Robotango.Common.Types.Properties;
using Robotango.Core.Types.Attributes;

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

        IAttributeHolder IAttribute.Holder { get; set; }
    }

    #endregion
}