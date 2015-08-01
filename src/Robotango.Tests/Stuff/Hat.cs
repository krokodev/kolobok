﻿// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Hat.cs

using Robotango.Core.Types;
using Robotango.Core.Types.Attributes;
using Robotango.Core.Types.Common;
using Robotango.Core.Types.Skills;

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

        IEntity IAttribute.Entity { get; set; }
    }

    #endregion
}