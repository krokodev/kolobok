// Robotango (c) 2015 Krokodev
// Robotango.Core
// Communicative.cs

using System;
using Robotango.Core.Elements.Communicative;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.Internal.Agency;

namespace Robotango.Core.Internal.Abilities
{
    internal class Communicative : AgentAbility< Thinking >, ICommunicative
    {
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
                Result = ComputeAnswerResult( question ),
            };
        }

        #endregion


        #region Component

        protected override void MakeDependences()
        {
            _thinking = MakeDependenceIfAvailable< IThinking >();
        }

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


        #region Fields

        private IThinking _thinking;

        #endregion
    }
}