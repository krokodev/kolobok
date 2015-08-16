// Robotango (c) 2015 Krokodev
// Robotango.Core
// Thinking.cs

using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using Robotango.Common.Types.Compositions;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Abilities.Thinking.Beliefs;
using Robotango.Core.Abilities.Thinking.Processes;
using Robotango.Core.Common;
using Robotango.Core.System;
using Robotango.Core.System.Imp;

namespace Robotango.Core.Abilities.Thinking
{
    internal class ThinkingAbility : Ability, IThinking
    {
        #region Data

        private List< IBelief > _beliefs = new List< IBelief >();
        private IReality _innerReality = new Reality( Settings.Agents.Thinking.InnerReality.Name );
        private readonly List< IThinkingProcess> _processes = new List< IThinkingProcess >();

        #endregion


        #region Routines
        private void DumpProcesses( OutlineWriter wr )
        {
            if( !_processes.Any() ) {
                return;
            }
            wr.Line( "Processes" );
            _processes.ForEach( p => wr.Append( p.Dump( wr.Level + 1 ) ) );
        }


        #endregion


        #region Overrides

        protected override IComponent Clone()
        {
            return new ThinkingAbility {
                _beliefs = _beliefs.ToList(),
                _innerReality = _innerReality.Clone()
            };
        }


        protected override void DumpAbilityContent( OutlineWriter wr )
        {
            DumpProcesses( wr );
            wr.Append( _innerReality.Dump( wr.Level ) );
        }

        protected override void Proceed( IReality reality )
        {
            _beliefs.ForEach( belief => belief.Essence.Invoke( _innerReality ) );

            _innerReality.Agents.ForEach( agent => agent.Proceed( _innerReality ) );

            _innerReality.Proceed();

            //MakeDecision();
            //UpdateInnerReality();
        }

        #endregion


        #region IThinking

        private IThinking IThinking
        {
            get { return this; }
        }

        IReality IThinking.InnerReality
        {
            get { return _innerReality; }
        }

        void IThinking.ImplementBeliefs()
        {
            _beliefs.ForEach( belief => belief.Essence.Invoke( _innerReality ) );
        }

        void IThinking.AddBelief( IBelief belief )
        {
            _beliefs.Add( belief );
        }

        void IThinking.AddBelief( Action< IReality > realityAction )
        {
            IThinking.AddBelief( new Belief( realityAction ) );
        }

        bool IThinking.HasBelief( IBelief belief )
        {
            return _beliefs.Contains( belief );
        }

        void IThinking.AddProcess( IThinkingProcess process )
        {
            _processes.Add( process );
        }

        public T GetProcess<T>() where T : IThinkingProcess
        {
            return _processes.OfType< T >().FirstOrDefault();
        }

        #endregion
    }
}