// Robotango (c) 2015 Krokodev
// Robotango.Core
// Location.cs

using Robotango.Common.Domain.Types.Properties;

namespace Robotango.Core.Implements.Elements.Virtual
{
    public class Location : ILocation
    {
        #region ILocation

        public ILocation ILocation
        {
            get { return this; }
        }

        #endregion


        #region INamed

        string INamed.Name { get; set; }

        #endregion


        #region Ctor

        public Location( string name = null )
        {
            ILocation.Name = name;
        }

        #endregion


        public override string ToString()
        {
            return ( ( INamed ) this ).Name;
        }
    }
}