// Robotango (c) 2015 Krokodev
// Robotango.Core
// Location.cs

using Robotango.Common.Domain.Types;

namespace Robotango.Core.Elements.Virtual.Imp
{
    public class Location : ILocation
    {
        #region ILocation

        public ILocation ILocation
        {
            get { return this; }
        }

        string ILocation.Name { get; set; }

        #endregion


        #region Ctor

        public Location( string name = null )
        {
            ILocation.Name = name;
        }

        #endregion


        #region Overrides

        public override string ToString()
        {
            return ILocation.Name;
        }

        #endregion
    }
}