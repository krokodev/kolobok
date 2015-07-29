// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// World.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Kolobok.Core.Types;

namespace Kolobok.Core.Items
{
    internal class World : IWorld, IComponent
    {
        #region IWorld

        private IWorld IWorld
        {
            get { return this; }
        }

        IAgent IWorld.GetAgent( Guid id  )
        {
            return _agents.First( a => a.Id == id );
        }

        void IWorld.Contains( params IAgent[] agents )
        {
            _agents.AddRange( agents );
        }

        IWorld IWorld.Clone()
        {
            return new World {
                _agents = _agents.Select( a => a.Clone() ).ToList()
            };
        }

        #endregion


        #region IComponent

        private IComponent IComponent
        {
            get { return this; }
        }

        IComponent IComponent.Clone()
        {
            return IWorld.Clone() as IComponent;
        }

        #endregion


        #region Fields

        private List< IAgent > _agents = new List< IAgent >();

        #endregion
    }
}