// Robotango (c) 2015 Krokodev
// Robotango.Core
// Communicative.cs

using System;
using Robotango.Common.Types.Compositions;
using Robotango.Core.Agency;
using Robotango.Core.Agency.Imp;
using Robotango.Core.Elements.Communicative;
using Robotango.Core.Elements.Communicative.Imp;

namespace Robotango.Core.Abilities.Imp
{
    internal class Communicative : Ability, ICommunicative
    {
        #region Data

        private IThinking _thinking;

        #endregion


        #region Routines

        private IAnswerResult< T > ComputeAnswerResult<T>( IQuestion< T > question )
        {
            var result = new AnswerResult< T >();
            try {
                result.Value = question.Essense.Invoke( GetWorldForAnswer() );
                result.IsVaild = true;
            }
            catch( Exception exception ) {
                result.IsVaild = false;
                result.Exception = exception;
            }

            return result;
        }

        private IReality GetWorldForAnswer()
        {
            return _thinking == null ? null : _thinking.InnerReality;
        }

        #endregion


        #region Overrides

        protected override IComponent Clone()
        {
            return new Communicative();
        }

        protected override void onInitAsComponent()
        {
            _thinking = MakeDependenceIfAvailable< IThinking >();
        }

        #endregion


        #region IQuerist

        IQuestion< T > IQuerist.Ask<T>( Func< IReality, T > theme )
        {
            return new Question< T > {
                Querist = this,
                Essense = theme
            };
        }

        #endregion


        #region IRespondent

        IAnswer< T > IRespondent.Reply<T>( IQuestion< T > question )
        {
            return new Answer< T > {
                Question = question,
                Respondent = this,
                Result = ComputeAnswerResult( question )
            };
        }

        #endregion
    }
}