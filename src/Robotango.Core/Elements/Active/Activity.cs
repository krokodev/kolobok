// Robotango (c) 2015 Krokodev
// Robotango.Core
// Activity.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Active
{
    public class Activity<T> : IActivity
    {
        #region Data

        private Action< IAgent, T > _action;
        private readonly string _name;

        #endregion


        #region Ctor

        public Activity( Action< IAgent, T > action, string name )
        {
            _action = action;
            _name = name;
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line(
                level,
                "{0} ( {1} ) <{2}>",
                IActivity.Name,
                typeof(T).Name,
                typeof( Operation< T > ).Name
                );
        }

        #endregion


        #region IActivity

        IActivity IActivity { get { return this; } }
        string IActivity.Name { get { return _name; }}

        #endregion
    }
}